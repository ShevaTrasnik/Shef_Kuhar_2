using Shef_Kuhar_2.Models;
using ShefKuhar.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shef_Kuhar_2.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        private List<Product> products = new List<Product>();
        private void LoadProducts()
        {
            products = ProductService.LoadProducts();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
            if (dataGridView1.Columns["Name"] != null)
                dataGridView1.Columns["Name"].HeaderText = "Назва продукту";
            if (dataGridView1.Columns["Quantity"] != null)
                dataGridView1.Columns["Quantity"].HeaderText = "Кількість";
            if (dataGridView1.Columns["Unit"] != null)
                dataGridView1.Columns["Unit"].HeaderText = "Одиниця виміру";
            if (dataGridView1.Columns["Calories"] != null)
                dataGridView1.Columns["Calories"].HeaderText = "Калорійність (ккал)";
            if (dataGridView1.Columns["Price"] != null)
                dataGridView1.Columns["Price"].HeaderText = "Ціна (грн)";
            if (dataGridView1.Columns["ExpiryDate"] != null)
                dataGridView1.Columns["ExpiryDate"].HeaderText = "Термін придатності";
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearEditFields()
        {
            txtEditName.Text = "";
            numericEditQuantity.Value = 1;
            comboEditUnit.SelectedIndex = -1;
            dateEditExpiry.Value = DateTime.Today;
            numEditCal.Value = 0;
            numericEditPrice.Value = 0;
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            comboUnit.Items.Clear();
            comboUnit.Items.AddRange(new string[]
            {
                "шт",
                "кг",
                "г",
                "л",
                "мл",
                "упак.",
                "банка",
                "пляшка"
            });
            comboEditUnit.Items.Clear();
            comboEditUnit.Items.AddRange(comboUnit.Items.Cast<object>().ToArray());
            comboEditUnit.SelectedIndex = -1;
            comboSort.Items.AddRange(new string[]
            {
                "Назва: А → Я",
                "Назва: Я → А",
                "Термін придатності: спочатку найстаріші",
                "Термін придатності: спочатку найновіші"
            });
            comboSort.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int quantity = (int)numericQuantity.Value;
            string unit = comboUnit.SelectedItem?.ToString();
            DateTime expiryDate = dateExpiry.Value;
            decimal price = numericPrice.Value;
            float calories = (float)numCal.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть назву продукту.");
                return;
            }

            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Оберіть одиницю виміру.");
                return;
            }

            Product newProduct = new Product(
                name,
                quantity.ToString(),
                unit,
                expiryDate,
                calories,
                price
            );

            products.Add(newProduct);
            ProductService.SaveProducts(products);
            ProductService.AddHistory($"Додано продукт: {name}, {quantity} {unit}, придатний до {expiryDate:yyyy-MM-dd}");
            LoadProducts();

            txtName.Clear();
            numericQuantity.Value = 1;
            comboUnit.SelectedIndex = -1;
            dateExpiry.Value = DateTime.Today;
            numCal.Value = 0;
            numericPrice.Value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Виберіть продукт для видалення.");
                return;
            }

            var product = (Product)dataGridView1.CurrentRow.DataBoundItem;
            products.Remove(product);
            ProductService.SaveProducts(products);
            ProductService.AddHistory($"Видалено продукт: {product.Name}");
            LoadProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem is Product selected)
            {
                txtEditName.Text = selected.Name;
                numericEditQuantity.Value = decimal.TryParse(selected.Quantity, out var quantity) ? quantity : numericEditQuantity.Minimum;
                comboEditUnit.SelectedItem = selected.Unit;
                dateEditExpiry.Value = selected.ExpiryDate;
                numericEditPrice.Value = selected.Price;
                numEditCal.Value = (decimal)selected.Calories;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string selected = comboSort.SelectedItem.ToString();

            switch (selected)
            {
                case "Назва: А → Я":
                    products = products.OrderBy(p => p.Name).ToList();
                    break;
                case "Назва: Я → А":
                    products = products.OrderByDescending(p => p.Name).ToList();
                    break;
                case "Термін придатності: спочатку найстаріші":
                    products = products.OrderBy(p => p.ExpiryDate).ToList();
                    break;
                case "Термін придатності: спочатку найновіші":
                    products = products.OrderByDescending(p => p.ExpiryDate).ToList();
                    break;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Оберіть продукт для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            if (string.IsNullOrWhiteSpace(txtEditName.Text))
            {
                MessageBox.Show("Введіть назву продукту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboEditUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть одиницю виміру.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numEditCal.Value <= 0)
            {
                MessageBox.Show("Введіть калорійність більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericEditPrice.Value <= 0)
            {
                MessageBox.Show("Введіть ціну більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = (Product)dataGridView1.CurrentRow.DataBoundItem;

            product.Name = txtEditName.Text.Trim();
            product.Quantity = numericEditQuantity.Value.ToString();
            product.Unit = comboEditUnit.SelectedItem?.ToString() ?? "";
            product.ExpiryDate = dateEditExpiry.Value;
            product.Price = numericEditPrice.Value;
            product.Calories = (float)numEditCal.Value;

            ProductService.SaveProducts(products);
            ProductService.AddHistory($"Оновлено продукт: {product.Name}");

            LoadProducts();
            ClearEditFields();
            dataGridView1.ClearSelection();
        }
    }
}
