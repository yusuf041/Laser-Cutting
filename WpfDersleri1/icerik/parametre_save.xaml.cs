using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfDersleri1.icerik
{
    /// <summary>
    /// Interaction logic for parametre_save.xaml
    /// </summary>
    public partial class parametre_save : UserControl
    {

         private string paremeter_location;

        private string loc_of_parametre;
        public parametre_save()
        {
            InitializeComponent();
        }

        public void Save_Button(object sender, RoutedEventArgs e)
        {
          //  MessageBox.Show(loc_of_parametre);

            Paremeter_Save paremeter_Save = new Paremeter_Save();
           
            paremeter_Save.save_datas(loc_of_parametre, Parameter_Name, Laser_Power, Frequence, Duty_Cycle, Feed_Rade, Gass_Type, Gass_Pressure, Cutting_Gap, Focal_Point, Nozzle_Type, Kalinlik);

        }

        private void paremeter_selection(object sender, SelectionChangedEventArgs e)
        {

           //  Paremeter_Location.Items.Clear();

             paremeter_location = (Paremeter_Location.SelectedItem as ComboBoxItem)?.Content as string;

            // MessageBox.Show(paremeter_location);

            loc_of_parametre = paremeter_location;
            

        }
    }
}
