using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private Random _random;
        private int[,] _array;
        private ObservableCollection<string> _items;


        public Window4()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            int M = 5; // Количество строк
            int N = 5; // Количество столбцов
            _array = new int[M, N];

            // Заполнение массива случайными числами от -10 до 10
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = _random.Next(-10, 11);
                }
            }

            // Отображение исходного массива
            DisplayArray("Исходный массив:", _array);

            // Сортировка и отображение результата
            var flatArray = _array.Cast<int>().ToArray();
            DisplaySortedArrays(flatArray);

            // Нахождение максимального и минимального элементов
            int maxElement = flatArray.Max();
            int minElement = flatArray.Min();
            MinMaxTextBlock.Text = $"Максимальный элемент: {maxElement}nМинимальный элемент: {minElement}";
        }

        private void DisplayArray(string title, int[,] array)
        {
            OriginalArrayTextBlock.Text = title + "n";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    OriginalArrayTextBlock.Text += $"{array[i, j],3} ";
                }
                OriginalArrayTextBlock.Text += "n";
            }
        }

        private void DisplaySortedArrays(int[] array)
        {
            var sortedAscending = array.OrderBy(x => x).ToArray();
            var sortedDescending = array.OrderByDescending(x => x).ToArray();

            SortedAscendingTextBlock.Text = "Отсортированный по возрастанию:n";
            foreach (var item in sortedAscending)
            {
                SortedAscendingTextBlock.Text += $"{item,3} ";
            }

            SortedDescendingTextBlock.Text = "nОтсортированный по убыванию:n";
            foreach (var item in sortedDescending)
            {
                SortedDescendingTextBlock.Text += $"{item,3} ";
            }
        }
    
    private void btnback_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
            
        
    

        

     
