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
    /// Логика взаимодействия для ADDSAmR.xaml
    /// </summary>
    public partial class ADDSAmR : Window
    {
        public SAMost _Sam = new SAMost();
        public int sd = 0;
        public ADDSAmR(SAMost SAW,int x)
        {
            InitializeComponent();
            if(SAW != null)
            {
                _Sam = SAW;
                sd = x;
            }
            DataContext = _Sam;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sd == 0)
                {
                    _Sam.Name = tem.Text;
                    _Sam.Thems = Static.WhoISSAm;
                    if (tem.Text.Length == 0)
                    {
                        MessageBox.Show("Введите тему самостоятельной работы", "Ошибка");
                    }
                    else
                    {
                        using (Model1 v = new Model1())
                        {
                            v.SAMost.Add(_Sam);
                            v.SaveChanges();
                            MessageBox.Show("Записи успешно добавлены");
                            this.Close();
                        }
                    }
                }
                if (sd == 1)
                {
                    string con = @"data source=localhost\sqlexpress;initial catalog=BDOTI;integrated security=True;MultipleActiveResultSets=True;";
                    using (SqlConnection connection = new SqlConnection(con))
                    {

                        connection.Open();
                        string kl = $@"UPDATE SAMost SET Name ='{tem.Text}', Thems ='{_Sam.Thems}' WHERE id ={_Sam.ID}";
                        SqlCommand command = new SqlCommand(kl, connection);
                        int numb = command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно изменены");
                        this.Close();
                    }
                }
                    
                
            }
            catch
            { }
        }
    }
}
