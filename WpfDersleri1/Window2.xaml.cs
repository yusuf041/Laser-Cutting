using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
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
using WpfDersleri1.classlar;
using WpfDersleri1.icerik;

namespace WpfDersleri1
{
    /// <summary>
    /// Window2.xaml etkileşim mantığı
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        
   
        public void UserControlLoaded(object sender, RoutedEventArgs e)
        {

            show_DB_datas show_DB_Datas = new show_DB_datas();
            show_DB_Datas.Data_Grid_Full(db);
            
            }
        }
    }
