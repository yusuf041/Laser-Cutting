using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using WpfDersleri1.classlar;

namespace WpfDersleri1.icerik
{
    /// <summary>
    /// Interaction logic for User1.xaml
    /// </summary>
    public partial class User1 : UserControl
    {
       
        
        public User1()
        {
            InitializeComponent();
        }

        public int bul;

        private void yumuşak_çelik_hava_Click(object sender, RoutedEventArgs e)
        {
            bul = 0;
            var send_variable = new show_DB_datas();
            
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();

        }

        private void yumuşak_çelik_nitrojen_Click(object sender, RoutedEventArgs e)
        {
            bul = 1;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void yumuşak_çelik_oksijen_Click(object sender, RoutedEventArgs e)
        {
            bul = 2;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void galvanize_hava_Click(object sender, RoutedEventArgs e)
        {
            bul = 3;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void galvanize_nitrojen_Click(object sender, RoutedEventArgs e)
        {
            bul = 4;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void paslanmaz_celik_nitrojen_Click(object sender, RoutedEventArgs e)
        {
            bul = 5;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void paslanmaz_celik_hava_Click(object sender, RoutedEventArgs e)
        {
            bul = 6;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void bakır_oksijen_Click(object sender, RoutedEventArgs e)
        {
            bul = 7;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void prinç_nitrojen_Click(object sender, RoutedEventArgs e)
        {
            bul = 8;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }

        private void aluminyum_Click(object sender, RoutedEventArgs e)
        {
            bul = 9;
            var send_variable = new show_DB_datas();
            send_variable.test(bul);

            Window2 a = new Window2();
            a.ShowDialog();
        }
    }
}
