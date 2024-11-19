using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
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
            string result;
            double operand1;
            double operand2;
            double answer;
            operand1 = Convert.ToDouble(NumberOne.Text);
            operand2 = Convert.ToDouble(NumberTwo.Text);
            string sign = Operator.Text;
            switch (sign)
            {
                case "+":
                    answer = operand1 + operand2;
                    result = Convert.ToString(answer);
                    Result.Content = result;
                    break;
                    case "-":
                    answer = operand1 - operand2;
                    result = Convert.ToString(answer);
                    Result.Content = result;
                    break;
                    case "*":
                    answer = operand1 * operand2;
                    result = Convert.ToString(answer);
                    Result.Content = result;
                    break;
                    case "/":
                    if (operand2 == 0)
                        Result.Content = "На 0 делить нельзя";
                    else
                    {
                        answer = operand1 / operand2;
                        result = Convert.ToString(answer);
                        Result.Content = result;
                    }
                    break;
                default:
                    Result.Content = "Ошибка";
                    break;
                    }
            }
    }
}
