using Shef_Kuhar_2.Models;
using ShefKuhar.Services;
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
    
    public partial class AddRecipeForm : Form
    {
        public Recipe NewRecipe { get; private set; }
        public List<RecipeIngredient> Ingredients { get; private set; } = new List<RecipeIngredient>();
        private bool isEditMode = false;
        private Recipe editingRecipe = null;
        public AddRecipeForm()
        {
            InitializeComponent();
        }
        public AddRecipeForm(Recipe recipeToEdit) : this()
        {
            isEditMode = true;
            editingRecipe = recipeToEdit;
            FillCategoryOptions();
            InitializeDgvIngredients();

            txtName.Text = recipeToEdit.Name;
            cmbCategory.SelectedItem = recipeToEdit.Category;
            nudOutputGrams.Value = (decimal)recipeToEdit.OutputGrams;
            txtInstructions.Text = recipeToEdit.Instructions;

            Ingredients = new List<RecipeIngredient>(recipeToEdit.Ingredients);
            dgvIngredients.Rows.Clear();

            foreach (var ingredient in Ingredients)
            {
                dgvIngredients.Rows.Add(
                    ingredient.ProductName,
                    ingredient.Quantity,
                    ingredient.GetCalories().ToString("0.##")
                );
            }
        }
        private void FillCategoryOptions()
        {
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.AddRange(new string[]
                {
            "Салат",
            "Десерт",
            "Суп",
            "Основне блюдо",
            "Напої",
            "Гарнір"
                });
            }
        }
        private void AddRecipeForm_Load(object sender, EventArgs e)
        {
            FillCategoryOptions();
            InitializeDgvIngredients();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            List<Product> productsFromStorage = ProductService.GetAllProducts();
            using (var ingredientDialog = new AddIngredientDialog(productsFromStorage))
            {
                if (ingredientDialog.ShowDialog() == DialogResult.OK)
                {
                    if (ingredientDialog.Ingredients != null)
                    {
                        foreach (var ingredient in ingredientDialog.Ingredients)
                        {
                            Ingredients.Add(ingredient);

                            dgvIngredients.Rows.Add(
                                ingredient.ProductName,
                                ingredient.Quantity,
                                ingredient.GetCalories().ToString("0.##")
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ингредиенты не были добавлены.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву рецепта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Оберіть категорію рецепта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Ingredients.Count == 0)
            {
                MessageBox.Show("Додайте хоча б один інгредієнт до рецепта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isEditMode && editingRecipe != null)
            {
                editingRecipe.Name = txtName.Text.Trim();
                editingRecipe.Category = cmbCategory.SelectedItem.ToString();
                editingRecipe.OutputGrams = (double)nudOutputGrams.Value;
                editingRecipe.Instructions = txtInstructions.Text.Trim();
                editingRecipe.Ingredients = new List<RecipeIngredient>(Ingredients);
            }
            else
            {
                NewRecipe = new Recipe
                {
                    Name = txtName.Text.Trim(),
                    Category = cmbCategory.SelectedItem.ToString(),
                    OutputGrams = (double)nudOutputGrams.Value,
                    Instructions = txtInstructions.Text.Trim(),
                    Ingredients = new List<RecipeIngredient>(Ingredients)
                };
            }
            MessageBox.Show("Рецепт успішно збережено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitializeDgvIngredients()
        {
            if (dgvIngredients.Columns.Count > 0)
                return;
            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Продукт",
                DataPropertyName = "ProductName",
                Width = 150
            });
            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Кількість",
                DataPropertyName = "Quantity",
                Width = 100
            });
            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "КалоріЇ/100г",
                DataPropertyName = "Calories",
                Width = 100
            });
        }
        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
