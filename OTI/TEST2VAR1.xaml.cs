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

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для TEST2VAR1.xaml
    /// </summary>
    public partial class TEST2VAR1 : Window
    {
        public TEST2VAR1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            if (e1.IsChecked == true)
            {
                x += 1;
            }
            if (e2.IsChecked == true)
            {
                x += 1;
            }
            if (w3.IsChecked == true)
            {
                x += 1;
            }
            if (e4.IsChecked == true)
            {
                x += 1;
            }
            if (e5.IsChecked == true)
            {
                x += 1;
            }
            if (e6.IsChecked == true)
            {
                x += 1;
            }
            if (e7.IsChecked == true)
            {
                x += 1;
            }
            if (e8.IsChecked == true)
            {
                x += 1;
            }
            if (e9.IsChecked == true)
            {
                x += 1;
            }
            if (e10.IsChecked == true)
            {
                x += 1;
            }
            if (e11.IsChecked == true)
            {
                x += 1;
            }
            if (e2.IsChecked == true)
            {
                x += 1;
            }
            if (_13.IsChecked == true)
            {
                x += 1;
            }
            if (e14.IsChecked == true)
            {
                x += 1;
            }
            if (e15.IsChecked == true)
            {
                x += 1;
            }
          
            MessageBox.Show($"Вы ответили правильно на {x}/15 ", "Тест завершен");
            this.Close();
        }
    }
}
