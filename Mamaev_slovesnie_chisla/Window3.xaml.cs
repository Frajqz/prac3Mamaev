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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        

        private void btnback_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TransformArray(object sender, RoutedEventArgs e)
        {
            // Получаем входной массив из TextBox
            string input = InputArrayTextBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                ResultTextBlock.Text = "Введите массив целых чисел, разделяя их запятыми.";
                return;
            }

            try
            {
                // Преобразуем строку в массив целых чисел
                int[] array = input.Split(',')
                                   .Select(x => int.Parse(x.Trim()))
                                   .ToArray();

                // Проверяем размер массива
                if (array.Length < 3)
                {
                    ResultTextBlock.Text = "Массив должен содержать как минимум 3 элемента.";
                    return;
                }

                // Получаем последний элемент массива
                int lastElement = array[array.Length - 1];

                // Преобразуем массив, прибавляя последний элемент к четным числам
                for (int i = 1; i < array.Length - 1; i++) // исключаем первый и последний элементы
                {
                    if (array[i] % 2 == 0) // проверяем, четное ли число
                    {
                        array[i] += lastElement;
                    }
                }

                // Формируем строку для отображения результата
                ResultTextBlock.Text = "Преобразованный массив: " + string.Join(", ", array);
            }
            catch (FormatException)
            {
                ResultTextBlock.Text = "Ошибка формата. Убедитесь, что вводите числа.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = $"Произошла ошибка: {ex.Message}";
            }
        }

        private void btnnext_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }
    }
}

