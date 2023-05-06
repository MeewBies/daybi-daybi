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
using System.Windows.Threading;

namespace daybi2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Timervhod.Tick += new EventHandler(_Tick);

        }
        int count = 0;
        DispatcherTimer Timervhod = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 10) };
        


   

        private void btVhod_Click_1(object sender, RoutedEventArgs e)
        {

            uchetstudEntities students = new uchetstudEntities();
            var Users = students.Users.FirstOrDefault(i => i.Login == tbLogin.Text && i.Password == tbPass.Text);
            if (Users != null)
                if (Users.ID == 1)
                {
                    MessageBox.Show("Администратор");

                }
                else
                {
                    MessageBox.Show("Сотрудник");
                }
            else
            {
                MessageBox.Show("Неверно! ");
                count++;
                if (count > 5)
                {
                    btVhod.IsEnabled = false;
                    Timervhod.Start();
                }
            }
            
           
        }
        private void _Tick(object sender, EventArgs e)
        {
            Timervhod.Stop();
            btVhod.IsEnabled = true;
            count = 0;
        }

    }
}





        