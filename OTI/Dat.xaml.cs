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
using System.Diagnostics;

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для Dat.xaml
    /// </summary>
    public partial class Dat : Window
    {
        public static int? j = 0;
        public static int? k = 0;
        public Dat( int g)
        {
            InitializeComponent();
            ds.Visibility = Visibility.Hidden;
            GetSourGrid(g);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (j == 0)
            {
                var s = ((sender as Button).DataContext as leck);
                Process.Start(s.linkS);
            }
            if (j == 1)
            {
                using (Model1 v = new Model1())
                {
                    var s = ((sender as Button).DataContext as HeadPark);
                    Grid.ItemsSource = v.Prak.Where( p => p.WhoHead == s.ID).ToList();
                    k = 3;
                }
            }
        }

        private void EditBtn1_Click(object sender, RoutedEventArgs e)
        {
            //red
        }

        public void GetSourGrid(int x)
        {
            using (Model1 v = new Model1())
            {
                if (x == 1)
                {
                    sd.Content = "Лекции";
                    Grid.ItemsSource = v.leck.ToList();
                    k = 1;
                }
                if (x == 2)
                {
                    sd.Content = "Практические";
                    Grid.ItemsSource = v.HeadPark.ToList();
                    Grid.Columns[2].Visibility = Visibility.Hidden;
                    j += 1;
                    ds.Visibility = Visibility.Visible;
                    k = 2;

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Model1 v = new Model1())
            {

                Grid.ItemsSource = v.HeadPark.ToList();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //add
            if(k == 1)
            {
                ADD_all ww = new ADD_all(1,0);
                    ww.Show();
            }
            if (k == 2)
            {
                ADD_all ww = new ADD_all(2,0);
                ww.Show();
            }
            if (k == 3)
            {
                ADD_all ww = new ADD_all(3,0);
                ww.Show();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //del
        }


    }
}

