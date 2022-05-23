namespace Labwork_3
{
    partial class helpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpForm));
            this.backButton_help = new System.Windows.Forms.Button();
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton_help
            // 
            this.backButton_help.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton_help.Location = new System.Drawing.Point(12, 12);
            this.backButton_help.Name = "backButton_help";
            this.backButton_help.Size = new System.Drawing.Size(475, 34);
            this.backButton_help.TabIndex = 0;
            this.backButton_help.Text = "Назад";
            this.backButton_help.UseVisualStyleBackColor = true;
            this.backButton_help.Click += new System.EventHandler(this.backButton_help_Click);
            // 
            // helpTextBox
            // 
            this.helpTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.helpTextBox.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpTextBox.Location = new System.Drawing.Point(12, 52);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.Size = new System.Drawing.Size(475, 386);
            this.helpTextBox.TabIndex = 1;
            this.helpTextBox.Text = resources.GetString("helpTextBox.Text");
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.helpTextBox);
            this.Controls.Add(this.backButton_help);
            this.MaximumSize = new System.Drawing.Size(515, 489);
            this.MinimumSize = new System.Drawing.Size(515, 489);
            this.Name = "helpForm";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton_help;
        private TextBox helpTextBox;
    }
}