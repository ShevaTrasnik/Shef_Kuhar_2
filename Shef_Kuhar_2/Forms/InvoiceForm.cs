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
using System.IO;
using System.Text;
using static Shef_Kuhar_2.Services.DailyMenuService;

namespace Shef_Kuhar_2.Forms
{
    public partial class InvoiceForm : Form
    {
        private List<InvoiceItem> invoice;
        private List<Product> products;
        public InvoiceForm(List<InvoiceItem> invoice, List<Product> products)
        {
            InitializeComponent();
            this.invoice = invoice;
            this.products = products;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            var tableData = invoice.Select(i => new
            {
                ProductName = i.ProductName,
                NeededAmount = i.NeededAmount,
                AvailableAmount = i.AvailableAmount,
                Shortage = i.Shortage
            }).ToList();

            dataGridViewInvoice.DataSource = null;
            dataGridViewInvoice.DataSource = tableData;
            if (dataGridViewInvoice.Columns["ProductName"] != null)
                dataGridViewInvoice.Columns["ProductName"].HeaderText = "Продукт";
            if (dataGridViewInvoice.Columns["NeededAmount"] != null)
                dataGridViewInvoice.Columns["NeededAmount"].HeaderText = "Потрібно";
            if (dataGridViewInvoice.Columns["AvailableAmount"] != null)
                dataGridViewInvoice.Columns["AvailableAmount"].HeaderText = "Є на складі";
            if (dataGridViewInvoice.Columns["Shortage"] != null)
                dataGridViewInvoice.Columns["Shortage"].HeaderText = "Не вистачає";
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            foreach (var item in invoice)
            {
                var product = products.FirstOrDefault(p => p.Name == item.ProductName);
                if (product != null)
                {
                    if (double.TryParse(product.Quantity, out double available))
                    {
                        double neededInStockUnit = UnitConverter.ConvertToSameUnit(item.Unit, item.NeededAmount, product.Unit);
                        double newQty = available - neededInStockUnit;
                        product.Quantity = Math.Max(0, newQty).ToString("0.##");
                    }
                }
            }

            MessageBox.Show("Запаси оновлено на складі.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeneratePurchaseOrder_Click(object sender, EventArgs e)
        {
            var shortages = invoice.Where(i => i.Shortage > 0).ToList();
            if (shortages.Count == 0)
            {
                MessageBox.Show("Усі продукти є в наявності. Немає потреби у видатковій накладній.");
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Видаткова накладна на закупівлю:");
            sb.AppendLine("Дата: " + DateTime.Now.ToShortDateString());
            sb.AppendLine("---------------------------------------------");
            foreach (var item in shortages)
            {
                sb.AppendLine($"{item.ProductName}: потрібно докупити {item.Shortage:0.##} {item.Unit}");
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.FileName = "Видаткова_накладна.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Накладну збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
