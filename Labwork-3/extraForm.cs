using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labwork_3
{
    public partial class extraForm : Form
    {
        public extraForm()
        {
            InitializeComponent();
        }

        private void extraForm_Load(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Gray)   // Проверка на тёмную тему
            {
                DarkThemeCheckBox.Checked = true;
            }
        }

        private void backButton_extra_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();    // Создаём экземпляр основного окна
            this.Hide();    // Прячём окно "Дополнительно" 
            form1.Show();

            if (DarkThemeCheckBox.Checked)  // Ставим тёмную тему для основного окна
            {
                form1.BackColor = Color.Gray;
            }
            else
            {
                form1.BackColor = Color.White;
            }
        }

        private void DarkThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkThemeCheckBox.Checked)  // Динамическая смена темы в этом окне (окно "Дополнительно")
            {
                this.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
