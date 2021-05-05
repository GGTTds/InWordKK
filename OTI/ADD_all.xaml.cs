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

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для ADD_all.xaml
    /// </summary>
    public partial class ADD_all : Window
    {
        public static int? WW = null;
        public Prak _pra = new Prak();
        public leck _lec = new leck();
        public HeadPark _hea = new HeadPark();
        public string putin = null;
        public ADD_all(int f, int t)
        {
            InitializeComponent();
            whoPra.Visibility = Visibility.Hidden;
            ew.Visibility = Visibility.Hidden;
          
            if(f == 1)
            {
                WW = 1;
            }
            if (f == 2)
            {
                using (Model1 ui = new Model1())
                {
                    WW = 2;
                    ew.Visibility = Visibility.Visible;
                    whoPra.Visibility = Visibility.Visible;
                    whoPra.ItemsSource = ui.HeadPark.ToList();
                }

            }
            if (f == 3)
            {
                zad.Visibility = Visibility.Hidden;
                NNam.Visibility = Visibility.Hidden;
                zag.Visibility = Visibility.Hidden;
                zag.Visibility = Visibility.Hidden;
                pu.Visibility = Visibility.Hidden;
                put.Visibility = Visibility.Hidden;
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
                if (WW == 1)
                {
                    _lec.Name = NNam.Text;
                    _lec.Head = HHed.Text;
                    _lec.date = DDat.SelectedDate;
                    _lec.linkS = $@"Лекции\{Path.GetFileName(putin)}";
                    ui.leck.Add(_lec);
                    ui.SaveChanges();
                    System.Windows.MessageBox.Show("Данные сохранены");
                    this.Close();
                }
                if (WW == 3)
                {

                }
                if(WW == 2)
                {
                    _pra.Name = NNam.Text;
                    _pra.Head = HHed.Text;
                    _pra.date = DDat.SelectedDate;
                    _pra.linkS = $@"Практика\{Path.GetFileName(putin)}";
                    _pra.WhoHead = int.Parse(whoPra.SelectedItem.ToString());
                    ui.Prak.Add(_pra);
                    ui.SaveChanges();
                    System.Windows.MessageBox.Show("Данные сохранены");
                    this.Close();
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
    }
}
