namespace Shef_Kuhar_2.Forms
{
    partial class AddRecipeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOutputGrams = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveIngredien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputGrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва страви";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(25, 77);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(211, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вибір категорії";
            // 
            // nudOutputGrams
            // 
            this.nudOutputGrams.Location = new System.Drawing.Point(25, 127);
            this.nudOutputGrams.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOutputGrams.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOutputGrams.Name = "nudOutputGrams";
            this.nudOutputGrams.Size = new System.Drawing.Size(211, 20);
            this.nudOutputGrams.TabIndex = 4;
            this.nudOutputGrams.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вихід (г)";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(25, 170);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstructions.Size = new System.Drawing.Size(463, 121);
            this.txtInstructions.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Інструкція приготування";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Location = new System.Drawing.Point(25, 319);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvIngredients.Size = new System.Drawing.Size(463, 150);
            this.dgvIngredients.TabIndex = 8;
            this.dgvIngredients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredients_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Список продуктів";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(335, 521);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(153, 39);
            this.btnAddIngredient.TabIndex = 10;
            this.btnAddIngredient.Text = "Додати інгредієнт";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(326, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти рецепт";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveIngredien
            // 
            this.btnRemoveIngredien.Location = new System.Drawing.Point(28, 475);
            this.btnRemoveIngredien.Name = "btnRemoveIngredien";
            this.btnRemoveIngredien.Size = new System.Drawing.Size(153, 36);
            this.btnRemoveIngredien.TabIndex = 12;
            this.btnRemoveIngredien.Text = "Видалити";
            this.btnRemoveIngredien.UseVisualStyleBackColor = true;
            this.btnRemoveIngredien.Click += new System.EventHandler(this.btnRemoveIngredien_Click);
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(500, 582);
            this.Controls.Add(this.btnRemoveIngredien);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudOutputGrams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRecipeForm";
            this.Text = "Додати рецепт";
            this.Load += new System.EventHandler(this.AddRecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputGrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOutputGrams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveIngredien;
    }
}