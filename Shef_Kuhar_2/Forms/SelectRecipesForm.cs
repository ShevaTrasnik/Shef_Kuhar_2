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
    public partial class SelectRecipesForm : Form
    {
        public List<Recipe> SelectedRecipes { get; private set; } = new List<Recipe>();
        private List<Recipe> allRecipes;
        public SelectRecipesForm()
        {
            InitializeComponent();
        }
        public SelectRecipesForm(List<Recipe> recipes)
        {
            InitializeComponent();
            allRecipes = recipes;
            if (allRecipes != null)
            {
                foreach (var recipe in allRecipes)
                {
                    checkedListBoxRecipes.Items.Add(recipe, false);
                }
            }
        }

        private void SelectRecipesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedRecipes = checkedListBoxRecipes.CheckedItems
            .Cast<Recipe>()
            .ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
