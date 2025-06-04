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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            List<string> history = ProductService.GetHistory();
            if (history.Count == 0)
            {
                txtHistory.Text = "Історія порожня.";
            }
            else
            {
                txtHistory.Text = string.Join(Environment.NewLine, history);
            }
        }
    }
}
