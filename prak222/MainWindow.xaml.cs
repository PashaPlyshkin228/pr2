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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prak222
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

        private void Program_Click(object sender, RoutedEventArgs e)//Кнопка с информацией о варианте задания и разработчике
        {
            MessageBox.Show("Практическая работа №2 \n Коннов Вадим,вариант 5 \n Ввести n целых чисел. Найти произведение чисел < 3. Результат вывести на экран.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)//Кнопка выхода из программы
        {
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)//Кнопка добавление записи в список
        {
            bool f1;
            f1 = Int32.TryParse(zn.Text, out int x);
            if (zn.Text != "" && f1 == true)//Делаем проверку на корректность введенных нами значений
            {
                lb1.Items.Add(zn.Text);//Добавляем значение в список
                zn.Clear();
            }
            else MessageBox.Show("Введите правильные значение");
        }

        private void delete_Click(object sender, RoutedEventArgs e)//Кнопка удаления записи из списка
        {
            lb1.Items.RemoveAt(lb1.SelectedIndex);
        }

        private void clearspisok_Click(object sender, RoutedEventArgs e)//Кнопка очищения списка от всех записей
        {
            lb1.Items.Clear();
        }

        private void zapoln_Click(object sender, RoutedEventArgs e)//Кнопка заполнения списка случайным набором чисел
        {
            bool f1;
            f1 = Int32.TryParse(randomzn.Text, out int x);
            int i;
            Random rnd = new Random();//Создаем класс Random для генерации случайных чисел


            if (randomzn.Text != "" && f1 == true)//Делаем проверку на корректность введенных нами значений
            {
                for (i = 1; i <= x; i++)
                {
                    lb1.Items.Add(rnd.Next(-10,10));//Добавляем случайно сгенерированные числа в определенном диапазоне в список

                }
            }
            else MessageBox.Show("Введите правильные значение");
            randomzn.Clear();
        }

        private void rez_Click(object sender, RoutedEventArgs e)//Кнопка выполнения расчета по заданию
        {
            int i, pr = 1;//Создаем исходную переменную и переменную для произведения
            for (i = 0; i < lb1.Items.Count; i++)//просматриваем наш список чисел
                if (Convert.ToInt32(lb1.Items[i]) < 3)//запускаем цикл,который ищет числа в списке меньше трех
                {
                    pr = pr * Convert.ToInt32(lb1.Items[i]);
                }


            result.Text = pr.ToString();//выводим результат в TextBox
        }

        private void clear_Click(object sender, RoutedEventArgs e)//Кнопка очищения поля результата
        {
            result.Clear();
        }
    }
}
