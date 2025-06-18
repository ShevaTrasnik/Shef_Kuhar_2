using Shef_Kuhar_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shef_Kuhar_2.Forms
{
    public partial class AddIngredientDialog : Form
    {
        private List<Product> availableProducts;
        public List<RecipeIngredient> Ingredients { get; private set; } = new List<RecipeIngredient>();
        private RecipeIngredient NewIngredient;
        public AddIngredientDialog(List<Product> products)
        {
            InitializeComponent();
            availableProducts = products;
            comboProducts.DataSource = products;
            comboProducts.DisplayMember = "Name";
        }
        private void AddIngredientDialog_Load(object sender, EventArgs e)
        {

        }

        private void comboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboProducts.SelectedItem is Product selected)
            {
                Dictionary<string, double> unitToGramFactor = new Dictionary<string, double>
            {
                { "г", 1 },
                { "кг", 1000 },
                { "мл", 1 },
                { "л", 1000 },
                { "шт", 150 },
                { "банка", 400 },
                { "пляшка", 1000 },
                { "упак.", 500 }
            };
                double factor = unitToGramFactor.TryGetValue(selected.Unit, out var f) ? f : 1;
                double grams = (double)nudQuantity.Value * factor;
                NewIngredient = new RecipeIngredient
                {
                    ProductName = selected.Name,
                    Quantity = (double)nudQuantity.Value,
                    CaloriesPer100g = selected.Calories
                };
                Ingredients.Add(NewIngredient);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Оберіть продукт.");
            }
        }
    }
}
