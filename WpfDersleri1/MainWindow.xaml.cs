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
using WpfDersleri1.classlar;
using WpfDersleri1.icerik;


namespace WpfDersleri1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_kapat_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void brd_sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void brd_solust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void ParemetreListesi_Click(object sender, RoutedEventArgs e)
        {
            us_cagir.Uc_Ekle(İcerik,new User1());
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            us_cagir.Uc_Ekle(İcerik, new User1());
        }

        private void Parametre_Kaydet_Click(object sender, RoutedEventArgs e)
        {
            us_cagir.Uc_Ekle(İcerik, new parametre_save());
        }

         // public void VeriCek() { MessageBox.Show("veri çekildi"); }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void paremeter_wizard(object sender, RoutedEventArgs e)
        {
          
            us_cagir.Uc_Ekle(İcerik, new paremeter_wizard());
        }

        private void deneme(object sender, RoutedEventArgs e)
        {
            us_cagir.Uc_Ekle(İcerik, new help_section());
        }

        private void about(object sender, RoutedEventArgs e)
        {
            us_cagir.Uc_Ekle(İcerik,new about_prg());
        }

        private void find_paremeter_Click(object sender, RoutedEventArgs e)
        {
            paremeter_find find_paremeter = new paremeter_find();
            find_paremeter.Show();

        }
    }
}
