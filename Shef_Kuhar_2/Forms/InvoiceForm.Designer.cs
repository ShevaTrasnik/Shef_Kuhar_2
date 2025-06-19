namespace Shef_Kuhar_2.Forms
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGeneratePurchaseOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(437, 237);
            this.dataGridViewInvoice.TabIndex = 0;
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Location = new System.Drawing.Point(22, 272);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(167, 49);
            this.btnWriteOff.TabIndex = 1;
            this.btnWriteOff.Text = "Списати зі складу";
            this.btnWriteOff.UseVisualStyleBackColor = true;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 49);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Відхилити";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGeneratePurchaseOrder
            // 
            this.btnGeneratePurchaseOrder.Location = new System.Drawing.Point(22, 328);
            this.btnGeneratePurchaseOrder.Name = "btnGeneratePurchaseOrder";
            this.btnGeneratePurchaseOrder.Size = new System.Drawing.Size(167, 45);
            this.btnGeneratePurchaseOrder.TabIndex = 3;
            this.btnGeneratePurchaseOrder.Text = "Сформувати видаткову накладну";
            this.btnGeneratePurchaseOrder.UseVisualStyleBackColor = true;
            this.btnGeneratePurchaseOrder.Click += new System.EventHandler(this.btnGeneratePurchaseOrder_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(462, 404);
            this.Controls.Add(this.btnGeneratePurchaseOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWriteOff);
            this.Controls.Add(this.dataGridViewInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.Text = "Накладна";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGeneratePurchaseOrder;
    }
}