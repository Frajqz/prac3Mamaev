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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            int vowelCount = CountVowels(input);
            resultTextBlock.Text = $"Количество гласных: {vowelCount}";
        }

        private int CountVowels(string input)
        {
            int count = 0;
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
          Window3 window3 = new Window3();
            window3.Show();
        }
    }
}

