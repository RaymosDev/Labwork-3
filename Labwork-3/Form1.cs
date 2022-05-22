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
            // Парсинг актуальных курсов валют
            double usd = double.Parse(GetUsd());
            double eur = double.Parse(GetEur());
            //textBox1.Text = GetEur();
            // usd_string = GetUsd().Replace(",", ".");
            firstCurrencySelector.Items.Add("USD");
            firstCurrencySelector.Items.Add("EUR");
            secondCurrencySelector.Items.Add("USD");
            secondCurrencySelector.Items.Add("EUR");
            firstValueTextBox.Text = GetUsd();


        }

        private void firstCurrencySelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void secondCurrencySelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //получаем кэф
            double usd = double.Parse(GetUsd());
            double eur = double.Parse(GetEur());
            double a;
            double b;
            if (firstCurrencySelector.Text == "USD")
            {
                a = usd;
            }
            else if (firstCurrencySelector.Text == "EUR")
            {
                a = eur;
            }
            else
            {
                a = 0;
            }

            if (secondCurrencySelector.Text == "USD")
            {
                b = usd;
            }
            else if (secondCurrencySelector.Text == "EUR")
            {
                b = eur;
            }
            else
            {
                b = 0;
            }

            double ratio = a / b;
            //получили кэф

            //итог знач
            double firstValueTextBox_double = double.Parse(firstValueTextBox.Text);
            secondValueTextBox.Text = Convert.ToString(firstValueTextBox_double * ratio);
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