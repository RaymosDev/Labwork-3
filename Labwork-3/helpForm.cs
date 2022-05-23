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
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
        }

        private void backButton_help_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();    // Создаём экземпляр основного окна
            this.Hide();    // Прячём окно "Справка" 
            form1.Show();

            
            if (this.BackColor.Equals(Color.Gray))  // Ставим тёмную тему для основного окна
            {
                form1.BackColor = Color.Gray;
            }
            else
            {
                form1.BackColor = Color.White;
            }
        }
    }
}
