using System.Net;

namespace Labwork_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Centrobank();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private String Centrobank()
        {
            WebClient client = new WebClient();
            String parsedHtmlPage = client.DownloadString("http://www.finmarket.ru/currency/USD/");
            String parsedValue = System.Text.RegularExpressions.Regex.Match(parsedHtmlPage, @"<div class=""valvalue"">([0-9]+\,[0-9]+)</div>").Groups[1].Value;
            return "Курс USD (ЦБ): " + parsedValue;

        }
    }
}