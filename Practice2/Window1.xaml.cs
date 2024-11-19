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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }

        private void Translate_Click(object sender, RoutedEventArgs e)
        {
            string input = Input.Text.ToLower(); ;
            switch (input)
            {
                case "солнечно":
                case "солнце":
                case "ясно":
                    Translation.Content = "Sunny";
                    break;
                case "ветрено":
                case "ветер":
                    Translation.Content = "Windy";
                    break;
                case "дождь":
                case "дождливо":
                case "ливни":
                    Translation.Content = "Rainy";
                    break;
                case "пасмурно":
                case "облачно":
                    Translation.Content = "Cloudy";
                    break;
                case "снег":
                    Translation.Content = "Snowy";
                    break;
                case "шторм":
                    Translation.Content = "Storm";
                    break;
                case "тепло":
                    Translation.Content = "Warm";
                    break;
                case "жарко":
                    Translation.Content = "Hot";
                    break;
                case "прохладно":
                case "холодно":
                    Translation.Content = "Cold";
                    break;
                case "мороз":
                    Translation.Content = "Freezing";
                    break;
                default:
                    Translation.Content = "Такого слова нет в переводчике, \n попробуйте другое.";
                    break;
            }
        }
    }
}
