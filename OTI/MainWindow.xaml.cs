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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VX_Click(object sender, RoutedEventArgs e)
        {
            using (Model1 b = new Model1())
            {
                int n = 0;
                var m = b.User.ToList();
                var v = m.Where(p => p.Logg.Equals(loggg.Text)).Where(p => p.Pass.Equals(passs.Password)).ToList();
                foreach (var x in v)
                {
                    if (x.Logg != null)
                    {
                        n += 1;
                        Static.ID = x.Rol;
                        NextMenu ww = new NextMenu();
                        ww.Show();
                        this.Close();

                    }

                }
                if (n == 0)
                { MessageBox.Show(" Неправильный логин или пароль", "Ошибка"); }

            }
        }

        private void RG_Copy_Click(object sender, RoutedEventArgs e)
        {
            Static.ID = 2;
            NextMenu ww = new NextMenu();
            ww.Show();
            this.Close();
        }
    }
}
