namespace Shef_Kuhar_2.Forms
{
    partial class DailyMenuForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Дата = new System.Windows.Forms.Label();
            this.nudPersons = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSelectedRecipes = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectDishes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemoveDish = new System.Windows.Forms.Button();
            this.textBoxTotalGrams = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Дата
            // 
            this.Дата.AutoSize = true;
            this.Дата.Location = new System.Drawing.Point(13, 13);
            this.Дата.Name = "Дата";
            this.Дата.Size = new System.Drawing.Size(33, 13);
            this.Дата.TabIndex = 1;
            this.Дата.Text = "Дата";
            // 
            // nudPersons
            // 
            this.nudPersons.Location = new System.Drawing.Point(302, 32);
            this.nudPersons.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersons.Name = "nudPersons";
            this.nudPersons.Size = new System.Drawing.Size(203, 20);
            this.nudPersons.TabIndex = 2;
            this.nudPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кількість персон";
            // 
            // listViewSelectedRecipes
            // 
            this.listViewSelectedRecipes.FullRowSelect = true;
            this.listViewSelectedRecipes.HideSelection = false;
            this.listViewSelectedRecipes.Location = new System.Drawing.Point(13, 93);
            this.listViewSelectedRecipes.Name = "listViewSelectedRecipes";
            this.listViewSelectedRecipes.Size = new System.Drawing.Size(492, 167);
            this.listViewSelectedRecipes.TabIndex = 4;
            this.listViewSelectedRecipes.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedRecipes.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список рецептів";
            // 
            // btnSelectDishes
            // 
            this.btnSelectDishes.Location = new System.Drawing.Point(194, 267);
            this.btnSelectDishes.Name = "btnSelectDishes";
            this.btnSelectDishes.Size = new System.Drawing.Size(129, 37);
            this.btnSelectDishes.TabIndex = 6;
            this.btnSelectDishes.Text = "Додати блюдо";
            this.btnSelectDishes.UseVisualStyleBackColor = true;
            this.btnSelectDishes.Click += new System.EventHandler(this.btnSelectDishes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(372, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 51);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemoveDish
            // 
            this.btnRemoveDish.Location = new System.Drawing.Point(416, 267);
            this.btnRemoveDish.Name = "btnRemoveDish";
            this.btnRemoveDish.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveDish.TabIndex = 8;
            this.btnRemoveDish.Text = "Видалити";
            this.btnRemoveDish.UseVisualStyleBackColor = true;
            this.btnRemoveDish.Click += new System.EventHandler(this.btnRemoveDish_Click);
            // 
            // textBoxTotalGrams
            // 
            this.textBoxTotalGrams.Location = new System.Drawing.Point(16, 308);
            this.textBoxTotalGrams.Name = "textBoxTotalGrams";
            this.textBoxTotalGrams.ReadOnly = true;
            this.textBoxTotalGrams.Size = new System.Drawing.Size(145, 20);
            this.textBoxTotalGrams.TabIndex = 9;
            this.textBoxTotalGrams.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Загальна грамовка страв";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 59);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(195, 28);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "Завантажити меню з дати";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(19, 374);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(125, 51);
            this.btnCheckStock.TabIndex = 12;
            this.btnCheckStock.Text = "Перевірити запаси";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.Location = new System.Drawing.Point(416, 297);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(89, 23);
            this.btnSaveMenu.TabIndex = 13;
            this.btnSaveMenu.Text = "Зберегти";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // DailyMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(517, 437);
            this.Controls.Add(this.btnSaveMenu);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTotalGrams);
            this.Controls.Add(this.btnRemoveDish);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelectDishes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewSelectedRecipes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPersons);
            this.Controls.Add(this.Дата);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyMenuForm";
            this.Text = "Меню на день";
            this.Load += new System.EventHandler(this.DailyMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Дата;
        private System.Windows.Forms.NumericUpDown nudPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSelectedRecipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectDishes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemoveDish;
        private System.Windows.Forms.TextBox textBoxTotalGrams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Button btnSaveMenu;
    }
}