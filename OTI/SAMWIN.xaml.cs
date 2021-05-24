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
using System.Data.SqlClient;

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
            if (Static.QStatus == 2)
            {
                WhoISAD();
            }

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            WhoIS();
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

        private void ddd_Click(object sender, RoutedEventArgs e)
        {
            ADDSAmR ww = new ADDSAmR((sender as Button).DataContext as SAMost,1);
            ww.Show();
        }

        private void yd_Click(object sender, RoutedEventArgs e)
        {
            string con = @"data source=localhost\sqlexpress;initial catalog=BDOTI;integrated security=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(con))
            {

                var g = ((sender as Button).DataContext as SAMost);
                connection.Open();
                string kl = $@"DELETE FROM SAMost WHERE ID ={g.ID}";
                SqlCommand command = new SqlCommand(kl, connection);
                int numb = command.ExecuteNonQuery();
                MessageBox.Show("Запись удалена!");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ADDSAmR ww = new ADDSAmR(null,0);
            ww.Show();
        }
   public void WhoISAD()
        {
            DDE.Columns[0].Visibility = Visibility.Hidden;
            DDE.Columns[1].Visibility = Visibility.Hidden;
            ad.Visibility = Visibility.Hidden;
        }
    
    }
}
