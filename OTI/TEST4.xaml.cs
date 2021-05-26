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
    /// Логика взаимодействия для TEST4.xaml
    /// </summary>
    public partial class TEST4 : Window
    {
        public TEST4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            if(t1.IsChecked == true)
            {
                x += 1;
            }
            if (t2.IsChecked == true)
            {
                x += 1;
            }
            if (t3.IsChecked == true)
            {
                x += 1;
            }
            if (t4.IsChecked == true)
            {
                x += 1;
            }
            if (t5.IsChecked == true)
            {
                x += 1;
            }
            if (t7.IsChecked == true)
            {
                x += 1;
            }
            if (t8.IsChecked == true)
            {
                x += 1;
            }
            if (t9.IsChecked == true)
            {
                x += 1;
            }
            if (t10.IsChecked == true)
            {
                x += 1;
            }
            if (t11.IsChecked == true)
            {
                x += 1;
            }
            if (t12.IsChecked == true)
            {
                x += 1;
            }
            if (t13.IsChecked == true)
            {
                x += 1;
            }
            if (t5.IsChecked == true)
            {
                x += 1;
            }
            MessageBox.Show($"Тест пройден на {x}/15", "Тест завершен");
            this.Close();
        }
    }
}
