namespace Labwork_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstValueTextBox = new System.Windows.Forms.TextBox();
            this.secondValueTextBox = new System.Windows.Forms.TextBox();
            this.firstCurrencySelector = new System.Windows.Forms.ComboBox();
            this.secondCurrencySelector = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.extraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstValueTextBox
            // 
            this.firstValueTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstValueTextBox.Location = new System.Drawing.Point(12, 70);
            this.firstValueTextBox.Name = "firstValueTextBox";
            this.firstValueTextBox.Size = new System.Drawing.Size(219, 36);
            this.firstValueTextBox.TabIndex = 0;
            // 
            // secondValueTextBox
            // 
            this.secondValueTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondValueTextBox.Location = new System.Drawing.Point(305, 70);
            this.secondValueTextBox.Name = "secondValueTextBox";
            this.secondValueTextBox.ReadOnly = true;
            this.secondValueTextBox.Size = new System.Drawing.Size(219, 36);
            this.secondValueTextBox.TabIndex = 1;
            // 
            // firstCurrencySelector
            // 
            this.firstCurrencySelector.BackColor = System.Drawing.SystemColors.Window;
            this.firstCurrencySelector.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstCurrencySelector.FormattingEnabled = true;
            this.firstCurrencySelector.Location = new System.Drawing.Point(12, 12);
            this.firstCurrencySelector.Name = "firstCurrencySelector";
            this.firstCurrencySelector.Size = new System.Drawing.Size(219, 38);
            this.firstCurrencySelector.TabIndex = 2;
            // 
            // secondCurrencySelector
            // 
            this.secondCurrencySelector.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondCurrencySelector.FormattingEnabled = true;
            this.secondCurrencySelector.Location = new System.Drawing.Point(305, 12);
            this.secondCurrencySelector.Name = "secondCurrencySelector";
            this.secondCurrencySelector.Size = new System.Drawing.Size(219, 38);
            this.secondCurrencySelector.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(305, 138);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(219, 78);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.Location = new System.Drawing.Point(12, 194);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(107, 34);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Справка";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // extraButton
            // 
            this.extraButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extraButton.Location = new System.Drawing.Point(12, 234);
            this.extraButton.Name = "extraButton";
            this.extraButton.Size = new System.Drawing.Size(164, 34);
            this.extraButton.TabIndex = 6;
            this.extraButton.Text = "Дополнительно";
            this.extraButton.UseVisualStyleBackColor = true;
            this.extraButton.Click += new System.EventHandler(this.extraButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.extraButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondCurrencySelector);
            this.Controls.Add(this.firstCurrencySelector);
            this.Controls.Add(this.secondValueTextBox);
            this.Controls.Add(this.firstValueTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstValueTextBox;
        private TextBox secondValueTextBox;
        private ComboBox firstCurrencySelector;
        private ComboBox secondCurrencySelector;
        private Button calculateButton;
        private Button helpButton;
        private Button extraButton;
    }
}