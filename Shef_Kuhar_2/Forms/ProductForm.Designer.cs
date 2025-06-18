namespace Shef_Kuhar_2.Forms
{
    partial class ProductForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.numericEditQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboEditUnit = new System.Windows.Forms.ComboBox();
            this.dateEditExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericEditPrice = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numCal = new System.Windows.Forms.NumericUpDown();
            this.numEditCal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEditCal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(778, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Додати продукт";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 346);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(782, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва продукту";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(782, 73);
            this.numericQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericQuantity.TabIndex = 4;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кількість:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(306, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Видалити вибраний продукт";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(778, 336);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(176, 34);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Оновити список";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(778, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = " Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboUnit
            // 
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.Location = new System.Drawing.Point(781, 116);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(121, 21);
            this.comboUnit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Одиниця виміру:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Термін придатності:";
            // 
            // dateExpiry
            // 
            this.dateExpiry.Location = new System.Drawing.Point(781, 160);
            this.dateExpiry.Name = "dateExpiry";
            this.dateExpiry.Size = new System.Drawing.Size(180, 20);
            this.dateExpiry.TabIndex = 12;
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Location = new System.Drawing.Point(781, 445);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(173, 31);
            this.btnShowHistory.TabIndex = 13;
            this.btnShowHistory.Text = "Історія змін";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // comboSort
            // 
            this.comboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Location = new System.Drawing.Point(781, 389);
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(149, 21);
            this.comboSort.TabIndex = 14;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(778, 416);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(108, 23);
            this.btnSort.TabIndex = 15;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Відсортувати";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(13, 395);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(139, 20);
            this.txtEditName.TabIndex = 17;
            // 
            // numericEditQuantity
            // 
            this.numericEditQuantity.Location = new System.Drawing.Point(180, 395);
            this.numericEditQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericEditQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEditQuantity.Name = "numericEditQuantity";
            this.numericEditQuantity.Size = new System.Drawing.Size(127, 20);
            this.numericEditQuantity.TabIndex = 18;
            this.numericEditQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboEditUnit
            // 
            this.comboEditUnit.FormattingEnabled = true;
            this.comboEditUnit.Location = new System.Drawing.Point(345, 395);
            this.comboEditUnit.Name = "comboEditUnit";
            this.comboEditUnit.Size = new System.Drawing.Size(115, 21);
            this.comboEditUnit.TabIndex = 19;
            // 
            // dateEditExpiry
            // 
            this.dateEditExpiry.Location = new System.Drawing.Point(488, 395);
            this.dateEditExpiry.Name = "dateEditExpiry";
            this.dateEditExpiry.Size = new System.Drawing.Size(200, 20);
            this.dateEditExpiry.TabIndex = 20;
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(488, 445);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(200, 31);
            this.btnEditSave.TabIndex = 21;
            this.btnEditSave.Text = "Оновити продукт";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Назва продукту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Кількість";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Одиниця виміру";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Термін придатності";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(782, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ціна:";
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Location = new System.Drawing.Point(781, 204);
            this.numericPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(120, 20);
            this.numericPrice.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ціна:";
            // 
            // numericEditPrice
            // 
            this.numericEditPrice.DecimalPlaces = 2;
            this.numericEditPrice.Location = new System.Drawing.Point(13, 443);
            this.numericEditPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericEditPrice.Name = "numericEditPrice";
            this.numericEditPrice.Size = new System.Drawing.Size(120, 20);
            this.numericEditPrice.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(778, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Калорійність (ккал)/ 100 г";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Калорійність (ккал)/ 100 г";
            // 
            // numCal
            // 
            this.numCal.Location = new System.Drawing.Point(782, 244);
            this.numCal.Name = "numCal";
            this.numCal.Size = new System.Drawing.Size(120, 20);
            this.numCal.TabIndex = 34;
            // 
            // numEditCal
            // 
            this.numEditCal.DecimalPlaces = 2;
            this.numEditCal.Location = new System.Drawing.Point(157, 443);
            this.numEditCal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEditCal.Name = "numEditCal";
            this.numEditCal.Size = new System.Drawing.Size(120, 20);
            this.numEditCal.TabIndex = 35;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(966, 529);
            this.Controls.Add(this.numEditCal);
            this.Controls.Add(this.numCal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericEditPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.dateEditExpiry);
            this.Controls.Add(this.comboEditUnit);
            this.Controls.Add(this.numericEditQuantity);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.dateExpiry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.Text = "Склад продуктів";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEditCal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateExpiry;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.NumericUpDown numericEditQuantity;
        private System.Windows.Forms.ComboBox comboEditUnit;
        private System.Windows.Forms.DateTimePicker dateEditExpiry;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericEditPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numCal;
        private System.Windows.Forms.NumericUpDown numEditCal;
    }
}