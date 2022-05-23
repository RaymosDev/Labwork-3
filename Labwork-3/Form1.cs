using System.Net;
using System.Text.RegularExpressions;
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
            // Белый фон
            this.BackColor = Color.White;

            // Создаём массив с валютами для ComboBox'ов
            object[] currencies = new object[] { "Доллар США", "Евро", "Российский рубль", "Белорусский рубль", "Китайский юань", "Швейцарский франк", "Польский злотый", "Украинская гривна", "Чешская крона", "Японская иена" };
            firstCurrencySelector.Items.AddRange(currencies);
            secondCurrencySelector.Items.AddRange(currencies);

            // Задаём начальные значения для удобства
            firstCurrencySelector.Text = "Доллар США";
            secondCurrencySelector.Text = "Российский рубль";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // * Расчёт коэффициента первой выбранной валюты ко второй выбранной валюте *
            // Переменные a и b нужны для расчёта коэффициента одной валюты к другой (double ratio = a/b)
            double a;
            double b;

            // Задаём значение для a в зависимости от выбранной валюты
            switch(firstCurrencySelector.Text)  
            {
                case "Доллар США":
                    a = double.Parse(GetRate("Доллар США"));
                    break;
                case "Евро":
                    a = double.Parse(GetRate("Евро"));
                    break;
                case "Российский рубль":
                    a = 1;
                    break;
                case "Белорусский рубль":
                    a = double.Parse(GetRate("Белорусский рубль"));
                    break;
                case "Китайский юань":
                    a = double.Parse(GetRate("Китайский юань"));
                    break;
                case "Швейцарский франк":
                    a = double.Parse(GetRate("Швейцарский франк"));
                    break;
                case "Польский злотый":
                    a = double.Parse(GetRate("Польский злотый"));
                    break;
                case "Украинская гривна":
                    a = double.Parse(GetRate("Украинская гривна"));
                    break;
                case "Чешская крона":
                    a = double.Parse(GetRate("Чешская крона"));
                    break;
                case "Японская иена":
                    a = double.Parse(GetRate("Японская иена"));
                    break;
                default:
                    a = 0;
                    break;
            }

            // Задаём значение для b в зависимости от выбранной валюты
            switch (secondCurrencySelector.Text)
            {
                case "Доллар США":
                    b = double.Parse(GetRate("Доллар США"));
                    break;
                case "Евро":
                    b = double.Parse(GetRate("Евро"));
                    break;
                case "Российский рубль":
                    b = 1;
                    break;
                case "Белорусский рубль":
                    b = double.Parse(GetRate("Белорусский рубль"));
                    break;
                case "Китайский юань":
                    b = double.Parse(GetRate("Китайский юань"));
                    break;
                case "Швейцарский франк":
                    b = double.Parse(GetRate("Швейцарский франк"));
                    break;
                case "Польский злотый":
                    b = double.Parse(GetRate("Польский злотый"));
                    break;
                case "Украинская гривна":
                    b = double.Parse(GetRate("Украинская гривна"));
                    break;
                case "Чешская крона":
                    b = double.Parse(GetRate("Чешская крона"));
                    break;
                case "Японская иена":
                    b = double.Parse(GetRate("Японская иена"));
                    break;
                default:
                    b = 0;
                    break;
            }

            // Рассчитываем коэффициент
            double ratio = a / b;

            // Расчёт итогового значения в правом текст боксе

            if (Regex.IsMatch(firstValueTextBox.Text, "[0-9]") || (Regex.IsMatch(firstValueTextBox.Text, "[0-9]") && Regex.IsMatch(firstValueTextBox.Text, "[^,$,/b,/B,]")))     // Проверка на то, ввёл ли пользователь только цифры или только цифры+запятые (для дробных чисел)
            {
                double firstValueTextBox_double = double.Parse(firstValueTextBox.Text);        // Если посторонних символов нет - делаем обычный расчёт 
                secondValueTextBox.Text = Convert.ToString(firstValueTextBox_double * ratio);
            }
            else
            {
                firstValueTextBox.Text = "Введите число!";      // Если есть посторонние символы - выдаём ошибку
                secondValueTextBox.Text = null;
            }

        }

        // Код для кнопки "Справка"

        private void helpButton_Click(object sender, EventArgs e)
        {
            var helpform = new helpForm();  // Создаём экземпляр окна "Справка"
            this.Hide();    // Прячем Основное окно

            if (this.BackColor.Equals(Color.Gray))  // Проверка на тёмную тему
            {
                helpform.BackColor = Color.Gray;
            }
            else
            {
                helpform.BackColor = Color.White;
            }
            helpform.Show();
        }

        // Код для кнопки "Дополнительно"

        private void extraButton_Click(object sender, EventArgs e)
        {
            var extraform = new extraForm();    // Создаём экземпляр окна "Дополнительно"
            this.Hide();    // Прячем основное окно

            if (this.BackColor.Equals(Color.Gray))  // Проверка на тёмную тему
            {
                extraform.BackColor = Color.Gray;
            }
            else
            {
                extraform.BackColor = Color.White;
            }
            extraform.Show();
        }


        // Парсинг актуальных курсов валют

        private String GetRate(string currency)
        {
            WebClient client = new WebClient();
            string url;
            switch (currency)
            {
                case "Доллар США":
                    url = "http://www.finmarket.ru/currency/USD/";
                    break;
                case "Евро":
                    url = "http://www.finmarket.ru/currency/EUR/";
                    break;
                case "Белорусский рубль":
                    url = "http://www.finmarket.ru/currency/details/?val=52200";
                    break;
                case "Китайский юань":
                    url = "http://www.finmarket.ru/currency/details/?val=52207";
                    break;
                case "Швейцарский франк":
                    url = "http://www.finmarket.ru/currency/CHF/";
                    break;
                case "usd":
                    url = "http://www.finmarket.ru/currency/USD/";
                    break;
                case "Польский злотый":
                    url = "http://www.finmarket.ru/currency/details/?val=52173";
                    break;
                case "Украинская гривна":
                    url = "http://www.finmarket.ru/currency/details/?val=52171";
                    break;
                case "Чешская крона":
                    url = "http://www.finmarket.ru/currency/details/?val=52214";
                    break;
                case "Японская иена":
                    url = "http://www.finmarket.ru/currency/JPY/";
                    break;
                default:
                    url = null;
                    break;
            }
            string parsedHtmlPage = client.DownloadString(url);
            string parsedValue = Regex.Match(parsedHtmlPage, @"<div class=""valvalue"">([0-9]+\,[0-9]+)</div>").Groups[1].Value;
            return parsedValue;
        }

        
    }
}