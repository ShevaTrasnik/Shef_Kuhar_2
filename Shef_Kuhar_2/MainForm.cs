using Shef_Kuhar_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shef_Kuhar_2
{
    
    public partial class MainForm: Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            RecipeListForm recipeForm = new RecipeListForm();
            recipeForm.Show();
        }

        private void btnDailyMenu_Click(object sender, EventArgs e)
        {
            var dailyMenuForm = new DailyMenuForm();
            dailyMenuForm.ShowDialog();
        }
    }
}
