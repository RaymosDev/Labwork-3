﻿namespace Labwork_3
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
            this.firstValueTextBox = new System.Windows.Forms.TextBox();
            this.secondValueTextBox = new System.Windows.Forms.TextBox();
            this.firstCurrencySelector = new System.Windows.Forms.ComboBox();
            this.secondCurrencySelector = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstValueTextBox
            // 
            this.firstValueTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstValueTextBox.Location = new System.Drawing.Point(82, 80);
            this.firstValueTextBox.Name = "firstValueTextBox";
            this.firstValueTextBox.Size = new System.Drawing.Size(121, 36);
            this.firstValueTextBox.TabIndex = 0;
            // 
            // secondValueTextBox
            // 
            this.secondValueTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondValueTextBox.Location = new System.Drawing.Point(309, 80);
            this.secondValueTextBox.Name = "secondValueTextBox";
            this.secondValueTextBox.ReadOnly = true;
            this.secondValueTextBox.Size = new System.Drawing.Size(121, 36);
            this.secondValueTextBox.TabIndex = 1;
            this.secondValueTextBox.TextChanged += new System.EventHandler(this.secondValueTextBox_TextChanged);
            // 
            // firstCurrencySelector
            // 
            this.firstCurrencySelector.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstCurrencySelector.FormattingEnabled = true;
            this.firstCurrencySelector.Location = new System.Drawing.Point(82, 36);
            this.firstCurrencySelector.Name = "firstCurrencySelector";
            this.firstCurrencySelector.Size = new System.Drawing.Size(121, 38);
            this.firstCurrencySelector.TabIndex = 2;
            this.firstCurrencySelector.SelectedIndexChanged += new System.EventHandler(this.firstCurrencySelector_SelectedIndexChanged);
            // 
            // secondCurrencySelector
            // 
            this.secondCurrencySelector.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondCurrencySelector.FormattingEnabled = true;
            this.secondCurrencySelector.Location = new System.Drawing.Point(309, 36);
            this.secondCurrencySelector.Name = "secondCurrencySelector";
            this.secondCurrencySelector.Size = new System.Drawing.Size(121, 38);
            this.secondCurrencySelector.TabIndex = 3;
            this.secondCurrencySelector.SelectedIndexChanged += new System.EventHandler(this.secondCurrencySelector_SelectedIndexChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(297, 175);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(146, 64);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondCurrencySelector);
            this.Controls.Add(this.firstCurrencySelector);
            this.Controls.Add(this.secondValueTextBox);
            this.Controls.Add(this.firstValueTextBox);
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
    }
}