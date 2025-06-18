namespace Shef_Kuhar_2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenProductForm = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnDailyMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenProductForm
            // 
            this.btnOpenProductForm.Location = new System.Drawing.Point(104, 58);
            this.btnOpenProductForm.Name = "btnOpenProductForm";
            this.btnOpenProductForm.Size = new System.Drawing.Size(323, 44);
            this.btnOpenProductForm.TabIndex = 0;
            this.btnOpenProductForm.Text = "Склад";
            this.btnOpenProductForm.UseVisualStyleBackColor = true;
            this.btnOpenProductForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.Location = new System.Drawing.Point(104, 123);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(323, 42);
            this.btnRecipe.TabIndex = 1;
            this.btnRecipe.Text = "Список рецептів";
            this.btnRecipe.UseVisualStyleBackColor = true;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // btnDailyMenu
            // 
            this.btnDailyMenu.Location = new System.Drawing.Point(104, 183);
            this.btnDailyMenu.Name = "btnDailyMenu";
            this.btnDailyMenu.Size = new System.Drawing.Size(323, 43);
            this.btnDailyMenu.TabIndex = 2;
            this.btnDailyMenu.Text = "Меню";
            this.btnDailyMenu.UseVisualStyleBackColor = true;
            this.btnDailyMenu.Click += new System.EventHandler(this.btnDailyMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(523, 311);
            this.Controls.Add(this.btnDailyMenu);
            this.Controls.Add(this.btnRecipe);
            this.Controls.Add(this.btnOpenProductForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProductForm;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnDailyMenu;
    }
}

