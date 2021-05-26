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
    /// Логика взаимодействия для TEST3.xaml
    /// </summary>
    public partial class TEST3 : Window
    {
        public TEST3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            if(q1.IsChecked == true)
            {
                x += 1;
            }
            if (q2.IsChecked == true)
            {
                x += 1;
            }
            if (q3.IsChecked == true)
            {
                x += 1;
            }
            if (q4.IsChecked == true)
            {
                x += 1;
            }
            if (q5.IsChecked == true)
            {
                x += 1;
            }
            if (q6.IsChecked == true)
            {
                x += 1;
            }
            if (q7.IsChecked == true)
            {
                x += 1;
            }
            if (q8.IsChecked == true)
            {
                x += 1;
            }
            if (q9.IsChecked == true)
            {
                x += 1;
            }
            if (q10.IsChecked == true)
            {
                x += 1;
            }
            if (q11.IsChecked == true)
            {
                x += 1;
            }
            if (q12.IsChecked == true)
            {
                x += 1;
            }
            if (q13.IsChecked == true)
            {
                x += 1;
            }
            if (q14.IsChecked == true)
            {
                x += 1;
            }
            if (q15.IsChecked == true)
            {
                x += 1;
            }
            if (q16.IsChecked == true)
            {
                x += 1;
            }
            if (q17.IsChecked == true)
            {
                x += 1;
            }
            if (q18.IsChecked == true)
            {
                x += 1;
            }
            if (q19.IsChecked == true)
            {
                x += 1;
            }
            if (q20.IsChecked == true)
            {
                x += 1;
            }
            MessageBox.Show($"Тест пройден на {x}/20", "Тест пройдет");
            this.Close();
        }
    }
}
