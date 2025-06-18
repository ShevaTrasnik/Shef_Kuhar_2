using Shef_Kuhar_2.Models;
using Shef_Kuhar_2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shef_Kuhar_2.Models.MenuItemModel;

namespace Shef_Kuhar_2.Forms
{
    public partial class DailyMenuForm : Form
    {
        private List<Recipe> allRecipes;
        private List<MenuItemModel> selectedItems = new List<MenuItemModel>();
        public DailyMenuForm()
        {
            InitializeComponent();
        }
        private void SaveDailyMenu()
        {
            var menu = new DailyMenuModel
            {
                Date = dateTimePicker1.Value,
                Persons = (int)nudPersons.Value,
                Items = selectedItems
            };

            DailyMenuService.SaveMenu(menu);
        }
        private void LoadDailyMenu()
        {
            var loadedMenu = DailyMenuService.LoadMenu(dateTimePicker1.Value);

            selectedItems = new List<MenuItemModel>();
            listViewSelectedRecipes.Items.Clear();

            if (loadedMenu != null)
            {
                selectedItems = loadedMenu.Items;
                nudPersons.Value = loadedMenu.Persons;
                foreach (var item in selectedItems)
                {
                    listViewSelectedRecipes.Items.Add(new ListViewItem(new[]
                    {
                item.Recipe.Name,
                item.Recipe.Category,
                item.Recipe.OutputGrams.ToString("0.##")
            }));
                }
            }
            else
            {
                nudPersons.Value = 1;
            }
            UpdateTotalOutputGrams();
        }

        public DailyMenuForm(List<Recipe> recipes)
        {
            InitializeComponent();
            allRecipes = recipes;
        }
        private void DailyMenuForm_Load(object sender, EventArgs e)
        {
            InitializeRecipeListView();
            var loadedMenu = DailyMenuService.LoadMenu(dateTimePicker1.Value);
            if (loadedMenu != null)
            {
                selectedItems = loadedMenu.Items;
                nudPersons.Value = loadedMenu.Persons;

                foreach (var item in selectedItems)
                {
                    listViewSelectedRecipes.Items.Add(new ListViewItem(new[]
                    {
            item.Recipe.Name,
            item.Recipe.Category,
            item.Recipe.OutputGrams.ToString("0.##")
        }));
                }
            }
            UpdateTotalOutputGrams();
        }
        private void InitializeRecipeListView()
        {
            listViewSelectedRecipes.Columns.Add("Назва", 150);
            listViewSelectedRecipes.Columns.Add("Категорія", 150);
            listViewSelectedRecipes.Columns.Add("Вихід (г)", 100);
        }
        private void btnSelectDishes_Click(object sender, EventArgs e)
        {
            var recipes = RecipeService.LoadRecipes();
            var form = new SelectRecipesForm(recipes);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var selected = form.SelectedRecipe;
                if (selected != null)
                {
                    selectedItems.Add(new MenuItemModel(selected, (int)nudPersons.Value));
                    SaveDailyMenu();
                    listViewSelectedRecipes.Items.Add(new ListViewItem(new[]
                    {
                        selected.Name,
                        selected.Category,
                        selected.OutputGrams.ToString("0.##")}));
                    UpdateTotalOutputGrams();
                }
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var importForm = new ImportMenuForm())
            {
                if (importForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in importForm.ImportedItems)
                    {
                        selectedItems.Add(item);

                        listViewSelectedRecipes.Items.Add(new ListViewItem(new[]
                        {
                    item.Recipe.Name,
                    item.Recipe.Category,
                    item.Recipe.OutputGrams.ToString("0.##")
                }));
                    }

                    SaveDailyMenu();
                    UpdateTotalOutputGrams();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveDish_Click(object sender, EventArgs e)
        {
            if (listViewSelectedRecipes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть страву для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedItem = listViewSelectedRecipes.SelectedItems[0];
            int index = selectedItem.Index;
            if (index >= 0 && index < selectedItems.Count)
                selectedItems.RemoveAt(index);

            listViewSelectedRecipes.Items.RemoveAt(index);
            UpdateTotalOutputGrams();
            SaveDailyMenu();
            UpdateTotalOutputGrams();
        }
        private void UpdateTotalOutputGrams()
        {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                textBoxTotalGrams.Text = "0";
                return;
            }

            double total = selectedItems
                .Select(item => item.Recipe.OutputGrams)
                .Sum();

            textBoxTotalGrams.Text = $"{total:0.##}";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDailyMenu();
            UpdateTotalOutputGrams();
        }
    }
}
