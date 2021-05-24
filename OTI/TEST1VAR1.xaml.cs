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
    /// Логика взаимодействия для TEST1VAR1.xaml
    /// </summary>
    public partial class TEST1VAR1 : Window
    {
        public TEST1VAR1()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            if(w1.IsChecked == true)
            {
                x += 1;
            }
            if (w2.IsChecked == true)
            {
                x += 1;
            }
            if (w3.IsChecked == true)
            {
                x += 1;
            }
            if (w4.IsChecked == true)
            {
                x += 1;
            }
            if (w5.IsChecked == true)
            {
                x += 1;
            }
            if (w6.IsChecked == true)
            {
                x += 1;
            }
            if (w7.IsChecked == true)
            {
                x += 1;
            }
            if (w8.IsChecked == true)
            {
                x += 1;
            }
            if (w9.IsChecked == true)
            {
                x += 1;
            }
            if (w10.IsChecked == true)
            {
                x += 1;
            }
            if (w11.IsChecked == true)
            {
                x += 1;
            }
            if (w12.IsChecked == true)
            {
                x += 1;
            }
            if (w13.IsChecked == true)
            {
                x += 1;
            }
            if (w14.IsChecked == true)
            {
                x += 1;
            }
            if (w15.IsChecked == true)
            {
                x += 1;
            }
            if (w161.IsChecked == true)
            {
                x += 1;
            }
            if (w17.IsChecked == true)
            {
                x += 1;
            }
            if (w18.IsChecked == true)
            {
                x += 1;
            }
            if (w19.IsChecked == true)
            {
                x += 1;
            }
            if (w20.IsChecked == true)
            {
                x += 1;
            }
            MessageBox.Show($"Вы ответили правильно на {x}/20 ", "Тест завершен");
            this.Close();

        }
    }
}
