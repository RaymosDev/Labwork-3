namespace Labwork_3
{
    partial class extraForm
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
            this.backButton_extra = new System.Windows.Forms.Button();
            this.DarkThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // backButton_extra
            // 
            this.backButton_extra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton_extra.Location = new System.Drawing.Point(12, 12);
            this.backButton_extra.Name = "backButton_extra";
            this.backButton_extra.Size = new System.Drawing.Size(160, 34);
            this.backButton_extra.TabIndex = 1;
            this.backButton_extra.Text = "Назад";
            this.backButton_extra.UseVisualStyleBackColor = true;
            this.backButton_extra.Click += new System.EventHandler(this.backButton_extra_Click);
            // 
            // DarkThemeCheckBox
            // 
            this.DarkThemeCheckBox.AutoSize = true;
            this.DarkThemeCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DarkThemeCheckBox.Location = new System.Drawing.Point(21, 65);
            this.DarkThemeCheckBox.Name = "DarkThemeCheckBox";
            this.DarkThemeCheckBox.Size = new System.Drawing.Size(141, 29);
            this.DarkThemeCheckBox.TabIndex = 2;
            this.DarkThemeCheckBox.Text = "Тёмная тема";
            this.DarkThemeCheckBox.UseVisualStyleBackColor = true;
            this.DarkThemeCheckBox.CheckedChanged += new System.EventHandler(this.DarkThemeCheckBox_CheckedChanged);
            // 
            // extraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 118);
            this.Controls.Add(this.DarkThemeCheckBox);
            this.Controls.Add(this.backButton_extra);
            this.Name = "extraForm";
            this.Text = "Дополнительно";
            this.Load += new System.EventHandler(this.extraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton_extra;
        private CheckBox DarkThemeCheckBox;
    }
}