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

        public DailyMenuForm(List<Recipe> recipes)
        {
            InitializeComponent();
            allRecipes = recipes;
        }
        private void DailyMenuForm_Load(object sender, EventArgs e)
        {
            InitializeRecipeListView();
        }
        private void InitializeRecipeListView()
        {
            listViewSelectedRecipes.Columns.Add("Назва", 150);
            listViewSelectedRecipes.Columns.Add("Категорія", 150);
            listViewSelectedRecipes.Columns.Add("Вихід (г)", 100);
        }
        private void btnSelectDishes_Click(object sender, EventArgs e)
        {
            var form = new SelectRecipesForm(allRecipes);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (var selected in form.SelectedRecipes)
                {
                    selectedItems.Add(new MenuItemModel(selected, (int)numericUpDown1.Value));
                    listViewSelectedRecipes.Items.Add(new ListViewItem(new[]
                    {
                        selected.Name,
                        numericUpDown1.Value.ToString()
                    }));
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
