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
    /// Логика взаимодействия для ADDSAmR.xaml
    /// </summary>
    public partial class ADDSAmR : Window
    {
        public SAMost _Sam = new SAMost();
        public ADDSAmR()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Sam.Name = tem.Text;
                _Sam.Thems = Static.WhoISSAm;
                if (tem.Text.Length == 0)
                {
                    MessageBox.Show("Введите тему самостоятельной работы", "Ошибка");
                }
                else
                {
                    using(Model1 v = new Model1())
                    {
                        v.SAMost.Add(_Sam);
                        v.SaveChanges();
                    }
                }
            }
            catch
            { }
        }
    }
}
