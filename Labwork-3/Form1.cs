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
            //textBox1.Text = GetEur();
                // usd_string = GetUsd().Replace(",", ".");
            /*comboBox1.Items.Add("Темная тема");
            comboBox1.Items.Add("Стандартная тема");*/
            //  textBox1.Text = usd_string;
            double usd = double.Parse(GetUsd());
            double eur = double.Parse(GetEur());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private String GetUsd()
        {
            WebClient client = new WebClient();
            String parsedHtmlPage = client.DownloadString("http://www.finmarket.ru/currency/USD/");
            String parsedValue = System.Text.RegularExpressions.Regex.Match(parsedHtmlPage, @"<div class=""valvalue"">([0-9]+\,[0-9]+)</div>").Groups[1].Value;
            return parsedValue;
        }

        private String GetEur()
        {
            WebClient client = new WebClient();
            String parsedHtmlPage = client.DownloadString("http://www.finmarket.ru/currency/EUR/");
            String parsedValue = System.Text.RegularExpressions.Regex.Match(parsedHtmlPage, @"<div class=""valvalue"">([0-9]+\,[0-9]+)</div>").Groups[1].Value;
            return parsedValue;
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains("Темная тема"))
            {
                textBox1.Text = "Тест темная тема";
            }
            else if (comboBox1.Items.Contains("Cтандартная тема"))
            {
                textBox1.Text = "Тест стандартная тема";
            }
        }*/
    }
}