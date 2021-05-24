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
    /// Логика взаимодействия для NextMenu.xaml
    /// </summary>
    public partial class NextMenu : Window
    {
        public NextMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dat rr = new Dat(1);
            rr.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dat rr = new Dat(2);
            rr.Show();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if( e.Key == Key.Escape)
            {
                MainWindow ww = new MainWindow();
                ww.Show();
                this.Close();
            }
        }

        private void GS_Click(object sender, RoutedEventArgs e)
        {
            GSINThis ww = new GSINThis();
            ww.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SAMWIN ww = new SAMWIN();
            ww.Show();
        }
    }
}
