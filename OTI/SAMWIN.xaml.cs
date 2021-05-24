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
    /// Логика взаимодействия для SAMWIN.xaml
    /// </summary>
    public partial class SAMWIN : Window
    {
        int x = 1;
        public SAMWIN()
        {
            InitializeComponent();
            WhoIS();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
          
        }

        public void WhoIS()
        {
            using (Model1 v = new Model1())
            {
                var saw = v.SAMost.ToList();

                if (x == 1)
                {
                    DDE.ItemsSource = saw.Where(p => p.Thems == "Информация и ее свойства").ToList();
                }
                if (x == 2)
                {
                    DDE.ItemsSource = saw.Where(p => p.Thems == "Системы счисления").ToList();
                }
                if (x == 3)
                {
                    DDE.ItemsSource = saw.Where(p => p.Thems == "Типы данных, кодирование, передача данных").ToList();
                }
            }
        }
           


        private void w1_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            Static.WhoISSAm = "Информация и ее свойства";
            WhoIS();
        }

        private void w2_Click(object sender, RoutedEventArgs e)
        {
            x = 2;
            Static.WhoISSAm = "Системы счисления";
            WhoIS();
        }

        private void w3_Click(object sender, RoutedEventArgs e)
        {
            x = 3;
            Static.WhoISSAm = "Типы данных, кодирование, передача данных";
            WhoIS();
        }
    }
}
