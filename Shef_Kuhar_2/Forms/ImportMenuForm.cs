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

namespace Shef_Kuhar_2.Forms
{
    public partial class ImportMenuForm : Form
    {
        public List<MenuItemModel> ImportedItems { get; private set; } = new List<MenuItemModel>();
        public ImportMenuForm()
        {
            InitializeComponent();
        }

        private void ImportMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker1.Value.Date;

            var menu = DailyMenuService.LoadMenu(selectedDate);
            if (menu != null && menu.Items.Count > 0)
            {
                ImportedItems = menu.Items;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("На цю дату меню не знайдено.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
