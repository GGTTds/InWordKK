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
using System.Data.SqlClient;

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для Dat.xaml
    /// </summary>
    public partial class Dat : Window
    {
        public static int? j = 0;
        public static int? k = 0;
        public static int? tr = 0;
        public Dat( int g)
        {
            InitializeComponent();
            if (Static.QStatus == 2)
            {
                WhoIS();
                GetSourGrid(g);
                tr = g;
            }
            else
            {
                ds.Visibility = Visibility.Hidden;
                Grid.Columns[0].Visibility = Visibility.Hidden;
                GetSourGrid(g);
            }

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (j == 0)
                {
                    var s = ((sender as Button).DataContext as leck);
                    Process.Start(s.linkS);

                }
            }
            catch { System.Windows.MessageBox.Show("Неверный путь к файлу"); }
            if (j == 1)
            {
                using (Model1 v = new Model1())
                {
                    var s = ((sender as Button).DataContext as HeadPark);
                    sd.Content = "Практические работы";
                    Grid.ItemsSource = v.Prak.Where( p => p.WhoHead == s.ID).ToList();
                    Static._IF = s.ID;
                    
                        Grid.Columns[3].Visibility = Visibility.Visible;
                        Grid.Columns[0].Visibility = Visibility.Visible;
                        Grid.Columns[1].Visibility = Visibility.Hidden;

                        Grid.Columns[2].Width = 150;
                        Static.Nom = s.ID;
                        k = 2;
                    
                    
                }
            }
           
        }

        private void EditBtn1_Click(object sender, RoutedEventArgs e)
        {
            if (k == 1)
            {
                //l
                var s = ((sender as Button).DataContext as leck);
                ADD_all ww = new ADD_all(0,1);
                ww.GETleck(s);
                ww.Show();

            }
            if (k == 2)
            {
                var s = ((sender as Button).DataContext as Prak);
                ADD_all ww = new ADD_all(0, 2);
                ww.GEtPrak(s);
                ww.Show();
            }
            if (k == 3)
            {
                var s = ((sender as Button).DataContext as HeadPark);
                ADD_all ww = new ADD_all(0, 3);
                ww.GETWH(s);
                ww.Show();
            }

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
                    j = 0;
                }
                if (x == 2)
                {
                    sd.Content = "Темы";
                    Grid.ItemsSource = v.HeadPark.ToList();
                    Grid.Columns[3].Visibility = Visibility.Hidden;
                    j = 1;
                    ds.Visibility = Visibility.Visible;
                    k = 3;

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Model1 v = new Model1())
            {

                Grid.ItemsSource = v.HeadPark.ToList();
                Grid.Columns[2].Width = 450;
                
                    Grid.Columns[0].Visibility = Visibility.Hidden;
                    Grid.Columns[1].Visibility = Visibility.Visible;
                    Grid.Columns[3].Visibility = Visibility.Hidden;
                
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

      
        private void ddd_Click(object sender, RoutedEventArgs e)
        {
            //fri
            var s = ((sender as Button).DataContext as Prak);
            Process.Start(s.linkS);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            using (Model1 s = new Model1())
            {
                if( k == 1)
                {
                    s.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Grid.ItemsSource = s.leck.ToList();
                }
                if (k == 2)
                {
                    s.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Grid.ItemsSource = s.Prak.Where(p => p.WhoHead == Static._IF).ToList();
                }
                if (k == 3)
                {
                    s.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Grid.ItemsSource = s.HeadPark.ToList();
                }
            }
        }

        private void ddd_Click_1(object sender, RoutedEventArgs e)
        {
            //del
            using(Model1 s = new Model1())
            {
                
                    
                    string con = @"data source=localhost\sqlexpress;initial catalog=BDOTI;integrated security=True;MultipleActiveResultSets=True;";
                using (SqlConnection connection = new SqlConnection(con))
                {

                    if (k == 1)
                    {
                        var g = ((sender as Button).DataContext as leck);
                        connection.Open();
                        string kl = $@"DELETE FROM Leck WHERE ID ={g.ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!");
                    }
                    if (k == 2)
                    {
                        var g = ((sender as Button).DataContext as Prak);
                        connection.Open();
                        string kl = $@"DELETE FROM Prak WHERE ID ={g.ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!");
                    }
                    if (k == 3)
                    {
                        var g = ((sender as Button).DataContext as HeadPark);
                        connection.Open();
                        string kl = $@"DELETE FROM HeadPark WHERE ID ={g.ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!");
                    }

                }
                    
                
            }
        }
   
    public void WhoIS()
        {
            if(Static.QStatus == 2)
            {
                    Grid.Columns[0].Visibility = Visibility.Hidden;
                    Grid.Columns[5].Visibility = Visibility.Hidden;
                    Grid.Columns[6].Visibility = Visibility.Hidden;
                    fd.Visibility = Visibility.Hidden;
                    ds.Visibility = Visibility.Hidden;
                
            }
        }
    
    }
}

