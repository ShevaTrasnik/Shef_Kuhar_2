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
    public partial class RecipeListForm : Form
    {
        private List<Recipe> recipes = new List<Recipe>();
        private void RefreshRecipeList()
        {
            listViewRecipes.Items.Clear();
            foreach (var recipe in recipes)
            {
                AddRecipeToListView(recipe);
            }
        }
        private void InitializeRecipeListView()
        {
            dgvIngredients.Columns.Clear();
            listViewRecipes.Columns.Add("Назва", 150);
            listViewRecipes.Columns.Add("Категорія", 150);
            listViewRecipes.Columns.Add("Вихід (г)", 100);
        }
        private void InitializeIngredientListView()
        {
            dgvIngredients.Columns.Clear();
            dgvIngredients.Columns.Add("ProductName", "Назва продукту");
            dgvIngredients.Columns.Add("Quantity", "Кількість (г)");
            dgvIngredients.Columns.Add("Calories", "Калорії");
        }
        public RecipeListForm()
        {
            InitializeComponent();
        }
        private void RecipeListForm_Load(object sender, EventArgs e)
        {
            InitializeRecipeListView();
            InitializeIngredientListView();
            LoadRecipes();
            RefreshRecipeList();
            txtInstructions.Clear();

            comboSort.Items.AddRange(new string[]{               
            "Назва: А → Я",
            "Назва: Я → А",
            "Категорія",
            "Вихід (г): зростання",
            "Вихід (г): спадання"
            });
            comboSort.SelectedIndex = 0;
            comboSort.SelectedIndexChanged += comboSort_SelectedIndexChanged;
        }
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            using (var addRecipeForm = new AddRecipeForm())
            {
                if (addRecipeForm.ShowDialog() == DialogResult.OK)
                {
                    var recipe = addRecipeForm.NewRecipe;
                    if (recipe != null)
                    {
                        recipes.Add(recipe);
                        RecipeService.SaveRecipes(recipes);
                        AddRecipeToListView(recipe);
                    }
                }
            }
        }
        private void AddRecipeToListView(Recipe recipe)
        {
            var item = new ListViewItem(recipe.Name);
            item.SubItems.Add(recipe.Category);
            item.SubItems.Add(recipe.OutputGrams.ToString("0.##"));
            item.Tag = recipe;
            listViewRecipes.Items.Add(item);
        }
        private void LoadRecipes()
        {
            recipes = RecipeService.LoadRecipes();
            listViewRecipes.Items.Clear();

            foreach (var recipe in recipes)
            {
                AddRecipeToListView(recipe);
            }
            txtInstructions.Clear();
            dgvIngredients.Rows.Clear();
        }
        private void listViewIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRecipes.SelectedItems.Count > 0)
            {
                var selectedItem = listViewRecipes.SelectedItems[0];
                if (selectedItem.Tag is Recipe selectedRecipe)
                {
                    txtInstructions.Text = selectedRecipe.Instructions;
                    dgvIngredients.Rows.Clear();
                    foreach (var ingredient in selectedRecipe.Ingredients)
                    {
                        dgvIngredients.Rows.Add(
                            ingredient.ProductName,
                            ingredient.Quantity,
                            ingredient.GetCalories().ToString("0.##")
                        );
                    }
                }
            }
        }
        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (listViewRecipes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть рецепт для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedItem = listViewRecipes.SelectedItems[0];
            if (selectedItem.Tag is Recipe selectedRecipe)
            {
                recipes.Remove(selectedRecipe);
                RecipeService.SaveRecipes(recipes);
                RefreshRecipeList();
                txtInstructions.Clear();
                dgvIngredients.Rows.Clear();
                MessageBox.Show($"Рецепт \"{selectedRecipe.Name}\" успішно видалено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtInstructions_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (listViewRecipes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть рецепт для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedItem = listViewRecipes.SelectedItems[0];
            if (selectedItem.Tag is Recipe selectedRecipe)
            {
                using (var editForm = new AddRecipeForm(selectedRecipe))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedItem.Text = selectedRecipe.Name;
                        selectedItem.SubItems[1].Text = selectedRecipe.Category;
                        selectedItem.Text = selectedRecipe.Name;
                        selectedItem.SubItems[1].Text = selectedRecipe.Category;

                        txtInstructions.Text = selectedRecipe.Instructions;
                        dgvIngredients.Rows.Clear();
                        foreach (var ingredient in selectedRecipe.Ingredients)
                        {
                            dgvIngredients.Rows.Add(
                                ingredient.ProductName,
                                ingredient.Quantity,
                                ingredient.GetCalories().ToString("0.##")
                            );
                        }
                        RecipeService.SaveRecipes(recipes);
                        MessageBox.Show("Рецепт оновлено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboSort.SelectedItem.ToString();
            switch (selected)
            {
                case "Назва: А → Я":
                    recipes = recipes.OrderBy(r => r.Name).ToList();
                    break;
                case "Назва: Я → А":
                    recipes = recipes.OrderByDescending(r => r.Name).ToList();
                    break;
                case "Категорія":
                    recipes = recipes.OrderBy(r => r.Category).ToList();
                    break;
                case "Вихід (г): зростання":
                    recipes = recipes.OrderBy(r => r.OutputGrams).ToList();
                    break;
                case "Вихід (г): спадання":
                    recipes = recipes.OrderByDescending(r => r.OutputGrams).ToList();
                    break;
            }
            RefreshRecipeList();
            txtInstructions.Clear();
            dgvIngredients.Rows.Clear();
        }
    }
    }
