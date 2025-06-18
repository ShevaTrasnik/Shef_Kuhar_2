using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Shef_Kuhar_2.Models;

namespace ShefKuhar.Services
{
    public static class ProductService
    {
        private static readonly string FilePath = "products.json";
        private static readonly string HistoryPath = "history.txt";

        public static void SaveProducts(List<Product> products)
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(products));
        }

        public static List<Product> LoadProducts()
        {
            if (!File.Exists(FilePath)) return new List<Product>();
            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        public static void AddHistory(string entry)
        {
            File.AppendAllText(HistoryPath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {entry}\n");
        }

        public static List<string> GetHistory()
        {
            if (!File.Exists(HistoryPath)) return new List<string>();
            return new List<string>(File.ReadAllLines(HistoryPath));
        }
        public static List<Product> GetAllProducts()
        {
            return LoadProducts();
        }
    }
}
