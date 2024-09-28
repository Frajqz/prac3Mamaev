using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mamaev_slovesnie_chisla
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputNumber.Text, out int number) && number >= 1 && number <= 9999)
            {
                string parity = GetParityDescription(number);
                string digitsCount = GetDigitsCount(number);
                string description = $"{parity} {digitsCount} число";

                Result.Text = description;
            }
            else
            {
                Result.Text = "Введите правильное число от 1 до 9999.";
            }
        }

        private string GetParityDescription(int number)
        {
            return number % 2 == 0 ? "четное" : "нечетное";
        }

        private string GetDigitsCount(int number)
        {
            int digitsCount = number.ToString().Length;
            switch (digitsCount)
            {
                case 1:
                    return "однозначное";
                case 2:
                    return "двузначное";
                case 3:
                    return "трехзначное";
                case 4:
                    return "четырехзначное";
                default:
                    return "";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}

