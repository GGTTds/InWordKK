using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для ADD_all.xaml
    /// </summary>
    public partial class ADD_all : Window
    {
        public static int? WW = null;
        public static int? WWS = null;
        public static int? ID = null;
        public Prak _pra = new Prak();
        public leck _lec = new leck();
        public HeadPark _hea = new HeadPark();
        public HeadLeck _lea = new HeadLeck();
        public string putin = null;
        public ADD_all(int f, int t)
        {
            InitializeComponent();
            zad_Copy.Visibility = Visibility.Hidden;
            PP.Visibility = Visibility.Hidden;
            WWS = t;
          
            if(f == 1)
            {
                zad.Visibility = Visibility.Hidden;
                NNam.Visibility = Visibility.Hidden;
                zag.Visibility = Visibility.Visible;
                zag.Visibility = Visibility.Hidden;
                pu.Visibility = Visibility.Hidden;
                put.Visibility = Visibility.Hidden;
                WW = 1;
            }
            if (f == 2)
            {
                    WW = 2;
            }
            if (f == 3)
            {
                zad.Visibility = Visibility.Hidden;
                NNam.Visibility = Visibility.Hidden;
                zag.Visibility = Visibility.Visible;
                zag.Visibility = Visibility.Hidden;
                pu.Visibility = Visibility.Hidden;
                put.Visibility = Visibility.Hidden;
                WW = 3;
            }
            if( f == 4)
            {
                zad.Visibility = Visibility.Hidden;
                NNam.Visibility = Visibility.Hidden;
                zag.Visibility = Visibility.Visible;
                zag.Visibility = Visibility.Hidden;
                pu.Visibility = Visibility.Hidden;
                put.Visibility = Visibility.Hidden;
                WW = 4;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (Model1 ui = new Model1())
            {
                if (WWS == 0)
                {
                    if (WW == 1)
                    {

                        _lea.Name = HHed.Text;
                        _lea.date = DDat.SelectedDate;
                        ui.HeadLeck.Add(_lea);
                        ui.SaveChanges();
                        System.Windows.MessageBox.Show("Данные сохранены");
                        this.Close();
                    }
                    if (WW == 3)
                    {
                        _hea.Name = HHed.Text;
                        _hea.date = DDat.SelectedDate;
                        ui.HeadPark.Add(_hea);
                        ui.SaveChanges();
                        System.Windows.MessageBox.Show("Данные сохранены");
                        this.Close();

                    }
                    if (WW == 2)
                    {
                        _pra.Name = NNam.Text;
                        _pra.Head = HHed.Text;
                        _pra.date = DDat.SelectedDate;
                        _pra.linkS = $@"Практика\{Path.GetFileName(putin)}";
                        _pra.WhoHead = Static.Nom;
                        ui.Prak.Add(_pra);
                        ui.SaveChanges();
                        System.Windows.MessageBox.Show("Данные сохранены");
                        this.Close();
                    }
                    if (WW == 4)
                    {

                      
                    }
                }
                string con = @"data source=localhost\sqlexpress;initial catalog=BDOTI;integrated security=True;MultipleActiveResultSets=True;";
                if (WWS == 1)
                {
                    pu.Visibility = Visibility.Hidden;
                    put.Visibility = Visibility.Hidden;
                    _lec.Name = NNam.Text;
                    _lec.date = DDat.SelectedDate;
                    _lec.linkS = PP.Text;

                    using (SqlConnection connection = new SqlConnection(con))
                    {

                        connection.Open();
                        string kl = $@"UPDATE leck SET Name ='{NNam.Text}', date ='{DDat.SelectedDate}', Head ='{HHed.Text}', linkS='{PP.Text}' WHERE id ={ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Данные сохранены");
                        this.Close();
                    }
                }
                if (WWS == 2)
                {
                    pu.Visibility = Visibility.Hidden;
                    put.Visibility = Visibility.Hidden;
                    _pra.Name = NNam.Text;
                    _pra.Head = HHed.Text;
                    _pra.date = DDat.SelectedDate;
                    _pra.linkS = PP.Text;

                    using (SqlConnection connection = new SqlConnection(con))
                    {

                        connection.Open();
                        string kl = $@"UPDATE Prak SET Name ='{NNam.Text}', date ='{DDat.SelectedDate}', Head ='{HHed.Text}', linkS='{PP.Text}' WHERE id ={ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Данные сохранены");
                        this.Close();
                    }
                }
                if (WWS == 3)
                {

                   
                    _pra.Name = NNam.Text;
                    _pra.Head = HHed.Text;
                    _pra.date = DDat.SelectedDate;
                    _pra.linkS = PP.Text;

                    using (SqlConnection connection = new SqlConnection(con))
                    {

                        connection.Open();
                        string kl = $@"UPDATE HeadPark SET Name ='{HHed.Text}', date ='{DDat.SelectedDate}'  WHERE id ={ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Данные сохранены");
                        this.Close();
                    }
                }

            }
        }

        private void put_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                putin = dialog.FileName;
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Путь к файлу задан", "Файл", MessageBoxButtons.OK);
            }
        }

        public void GETleck(leck f)
        {
            zad_Copy.Visibility = Visibility.Visible;
            PP.Visibility = Visibility.Visible;
            pu.Visibility = Visibility.Hidden;
            put.Visibility = Visibility.Hidden;
            NNam.Text = f.Name;
            DDat.SelectedDate = f.date;
            PP.Text = f.linkS;
            ID = f.ID;
        }
        public void GEtPrak(Prak f)
        {
            zad_Copy.Visibility = Visibility.Visible;
            PP.Visibility = Visibility.Visible;
            pu.Visibility = Visibility.Hidden;
            put.Visibility = Visibility.Hidden;
            NNam.Text = f.Name;
            HHed.Text = f.Head;
            DDat.SelectedDate = f.date;
            PP.Text = f.linkS;
            ID = f.ID;
        }
        public void GETWH(HeadPark f)
        {
            zad.Visibility = Visibility.Hidden;
            NNam.Visibility = Visibility.Hidden;
            zag.Visibility = Visibility.Visible;
            zag.Visibility = Visibility.Hidden;
            pu.Visibility = Visibility.Hidden;
            put.Visibility = Visibility.Hidden;
            HHed.Text = f.Name;
            DDat.SelectedDate = f.date;
            ID = f.ID;
        }
    }
}
