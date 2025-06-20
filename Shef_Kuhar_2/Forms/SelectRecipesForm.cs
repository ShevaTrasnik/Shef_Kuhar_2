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
        public Recipe SelectedRecipe { get; private set; }
        private List<Recipe> allRecipes;
        public SelectRecipesForm()
        {
           
        }
        public SelectRecipesForm(List<Recipe> recipes)
        {
            InitializeComponent();
            allRecipes = recipes;
            comboBoxRecipes.DataSource = allRecipes;
            comboBoxRecipes.DisplayMember = "Name"; 
        }
        private void SelectRecipesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBoxRecipes.SelectedItem is Recipe selected)
            {
                SelectedRecipe = selected;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Оберіть рецепт зі списку.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
