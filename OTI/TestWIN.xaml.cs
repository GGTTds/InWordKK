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
    /// Логика взаимодействия для TestWIN.xaml
    /// </summary>
    public partial class TestWIN : Window
    {
        public TestWIN()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TEST1VAR1 ww = new TEST1VAR1();
            ww.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TEST2VAR1 ww = new TEST2VAR1();
            ww.Show();
        }
    }
}
