using Newtonsoft.Json;
using Shef_Kuhar_2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Shef_Kuhar_2.Services
{
    public static class DailyMenuService
    {
        private static string folder = "menus";

        public static void SaveMenu(DailyMenuModel menu)
        {
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, $"menu_{menu.Date:yyyyMMdd}.json");
            string json = JsonConvert.SerializeObject(menu, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static DailyMenuModel LoadMenu(DateTime date)
        {
            string path = Path.Combine(folder, $"menu_{date:yyyyMMdd}.json");
            if (!File.Exists(path))
                return null;

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<DailyMenuModel>(json);
        }
        public static List<InvoiceItem> GenerateInvoice(List<MenuItemModel> menuItems, List<Product> products)
        {
            List<InvoiceItem> invoice = new List<InvoiceItem>();

            foreach (var menuItem in menuItems)
            {
                foreach (var ingredient in menuItem.Recipe.Ingredients)
                {
                    double needed = ingredient.Quantity * menuItem.Persons;

                    var product = products.FirstOrDefault(p => p.Name == ingredient.ProductName);

                    double available = 0;
                    if (product != null && double.TryParse(product.Quantity, out double stockQty))
                    {
                        available = UnitConverter.ConvertToSameUnit(product.Unit, stockQty, ingredient.Unit);
                    }

                    invoice.Add(new InvoiceItem
                    {
                        ProductName = ingredient.ProductName,
                        NeededAmount = (float)needed,
                        AvailableAmount = (float)available,
                        Shortage = (float)(needed - available > 0 ? needed - available : 0),
                        Unit = ingredient.Unit
                    });
                }
            }

            return invoice;
        }
        public static class UnitConverter
        {
            public static double ConvertToSameUnit(string stockUnit, double stockQty, string recipeUnit)
            {
                stockUnit = (stockUnit ?? "г").ToLower();
                recipeUnit = (recipeUnit ?? "г").ToLower();
                if (recipeUnit == "г" && stockUnit == "кг")
                    return stockQty * 1000;
                if (recipeUnit == "кг" && stockUnit == "г")
                    return stockQty / 1000;
                if (recipeUnit == "мл" && stockUnit == "л")
                    return stockQty * 1000;
                if (recipeUnit == "л" && stockUnit == "мл")
                    return stockQty / 1000;

                if (recipeUnit == stockUnit)
                    return stockQty;

                var nonConvertible = new[] { "шт", "банка", "упак.", "пляшка" };
                if (nonConvertible.Contains(recipeUnit) || nonConvertible.Contains(stockUnit))
                    return stockQty;
                return stockQty;
            }
        }

    }
}
