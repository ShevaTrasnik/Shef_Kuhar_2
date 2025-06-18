namespace Shef_Kuhar_2.Forms
{
    partial class RecipeListForm
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
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewRecipes = new System.Windows.Forms.ListView();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(13, 323);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(145, 43);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Додати рецепт";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(423, 253);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstructions.Size = new System.Drawing.Size(429, 162);
            this.txtInstructions.TabIndex = 2;
            this.txtInstructions.TextChanged += new System.EventHandler(this.txtInstructions_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Інструкція приготування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Продукти";
            // 
            // listViewRecipes
            // 
            this.listViewRecipes.FullRowSelect = true;
            this.listViewRecipes.GridLines = true;
            this.listViewRecipes.HideSelection = false;
            this.listViewRecipes.Location = new System.Drawing.Point(13, 13);
            this.listViewRecipes.MultiSelect = false;
            this.listViewRecipes.Name = "listViewRecipes";
            this.listViewRecipes.Size = new System.Drawing.Size(386, 293);
            this.listViewRecipes.TabIndex = 9;
            this.listViewRecipes.UseCompatibleStateImageBehavior = false;
            this.listViewRecipes.View = System.Windows.Forms.View.Details;
            this.listViewRecipes.SelectedIndexChanged += new System.EventHandler(this.listViewIngredients_SelectedIndexChanged);
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Location = new System.Drawing.Point(426, 29);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.Size = new System.Drawing.Size(426, 194);
            this.dgvIngredients.TabIndex = 10;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(256, 372);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(143, 43);
            this.btnDeleteRecipe.TabIndex = 11;
            this.btnDeleteRecipe.Text = "Видалити";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Location = new System.Drawing.Point(256, 323);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(143, 43);
            this.btnEditRecipe.TabIndex = 12;
            this.btnEditRecipe.Text = "Редагувати рецепт";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // comboSort
            // 
            this.comboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Location = new System.Drawing.Point(12, 384);
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(145, 21);
            this.comboSort.TabIndex = 13;
            this.comboSort.SelectedIndexChanged += new System.EventHandler(this.comboSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Сортування";
            // 
            // RecipeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(864, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.listViewRecipes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnAddRecipe);
            this.Name = "RecipeListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RecipeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRecipes;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.Label label3;
    }
}