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
            this.nudPersons = new System.Windows.Forms.DateTimePicker();
            this.Дата = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSelectedRecipes = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectDishes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPersons
            // 
            this.nudPersons.Location = new System.Drawing.Point(13, 32);
            this.nudPersons.Name = "nudPersons";
            this.nudPersons.Size = new System.Drawing.Size(200, 20);
            this.nudPersons.TabIndex = 0;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(302, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(203, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            this.btnSelectDishes.Location = new System.Drawing.Point(186, 267);
            this.btnSelectDishes.Name = "btnSelectDishes";
            this.btnSelectDishes.Size = new System.Drawing.Size(129, 37);
            this.btnSelectDishes.TabIndex = 6;
            this.btnSelectDishes.Text = "Додати блюдо";
            this.btnSelectDishes.UseVisualStyleBackColor = true;
            this.btnSelectDishes.Click += new System.EventHandler(this.btnSelectDishes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(355, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 51);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DailyMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(517, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelectDishes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewSelectedRecipes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Дата);
            this.Controls.Add(this.nudPersons);
            this.Name = "DailyMenuForm";
            this.Text = "DailyMenuForm";
            this.Load += new System.EventHandler(this.DailyMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker nudPersons;
        private System.Windows.Forms.Label Дата;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSelectedRecipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectDishes;
        private System.Windows.Forms.Button btnClose;
    }
}