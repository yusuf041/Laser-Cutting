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
using WpfDersleri1.classlar;

namespace WpfDersleri1
{
    /// <summary>
    /// Window3.xaml etkileşim mantığı
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Data_base(object sender, RoutedEventArgs e)
        {
            show_db2_datas show_db2_Datas = new show_db2_datas();
            show_db2_Datas.Data_Grid_FuLL(db2);
        }
    }
}
