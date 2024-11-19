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

namespace Practice2
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

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(Number.Text);
            if (number >= 0 & number <= 14) Result.Content = "Число в промежутке [0-14]";
            else if (number >= 15 & number <= 35) Result.Content = "Число в промежутке [15-35]";
            else if (number >= 36 & number <= 50) Result.Content = "Число в промежутке [36-50]";
            else if (number >= 51 & number <= 100) Result.Content = "Число в промежутке [50-100]";
            else Result.Content = "Число не найдено";
        }
    }
}
