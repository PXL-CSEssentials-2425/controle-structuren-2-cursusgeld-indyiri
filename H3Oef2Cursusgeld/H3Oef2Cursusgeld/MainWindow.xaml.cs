using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H3Oef2Cursusgeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void numericalButton_Click(object sender, RoutedEventArgs e)
        {
            string yearText = yearTextBox.Text;
            int yearNumber;

            bool isYearTextNumber = int.TryParse(yearText, out yearNumber);

            if (isYearTextNumber)
            {
                numericalTextBlock.Text = "Is numeriek";
            }
            else if (string.IsNullOrEmpty(yearText))
            {
                numericalTextBlock.Text = "Geef een jaartal in!";
            }
            else
            {
                numericalTextBlock.Text = "Geef een correct jaartal!";
            }
        }

        private void yearTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string yearText = yearTextBox.Text;
                int yearNumber;

                bool isYearTextNumber = int.TryParse(yearText, out yearNumber);

                if (isYearTextNumber)
                {
                    numericalTextBlock.Text = "Is numeriek";
                }
                else if (string.IsNullOrEmpty(yearText))
                {
                    numericalTextBlock.Text = "Geef een jaartal in!";
                }
                else
                {
                    numericalTextBlock.Text = "Geef een correct jaartal!";
                }
            }
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string yearText = yearTextBox.Text;
            int yearNumber;
            string amountOfHoursText = amountOfHoursTextBox.Text;
            int amountOfHoursNumber;

            bool isYearTextNumber = int.TryParse(yearText, out yearNumber);
            bool isAmountOfHoursNumber = int.TryParse(amountOfHoursText, out amountOfHoursNumber);

            if (isYearTextNumber && yearNumber % 4 == 0 && yearNumber % 100 != 0 )
            {
                leapYearTextBlock.Text = "Is een schrikkeljaar";
                registrationFeeTextBox.Text = $"{(amountOfHoursNumber + 1)*1.5}";
            }
            else if (isYearTextNumber)
            {
                leapYearTextBlock.Text = "Is geen schrikkeljaar";
                registrationFeeTextBox.Text = $"{(amountOfHoursNumber) * 1.5}";
            }
            else if (string.IsNullOrWhiteSpace(yearText) || string.IsNullOrWhiteSpace(amountOfHoursText))
            {
                leapYearTextBlock.Text = "Geef een jaartal en aantal uren in";
            }
        }

        private void amountOfHoursTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string yearText = yearTextBox.Text;
            int yearNumber;
            string amountOfHoursText = amountOfHoursTextBox.Text;
            int amountOfHoursNumber;

            bool isYearTextNumber = int.TryParse(yearText, out yearNumber);
            bool isAmountOfHoursNumber = int.TryParse(amountOfHoursText, out amountOfHoursNumber);

            if (isYearTextNumber && yearNumber % 4 == 0 && yearNumber % 100 != 0)
            {
                leapYearTextBlock.Text = "Is een schrikkeljaar";
                registrationFeeTextBox.Text = $"{(amountOfHoursNumber + 1) * 1.5}";
            }
            else if (isYearTextNumber)
            {
                leapYearTextBlock.Text = "Is geen schrikkeljaar";
                registrationFeeTextBox.Text = $"{(amountOfHoursNumber) * 1.5}";
            }
            else if (string.IsNullOrWhiteSpace(yearText) || string.IsNullOrWhiteSpace(amountOfHoursText))
            {
                leapYearTextBlock.Text = "Geef een jaartal en aantal uren in";
            }
        }
    }
}