using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
using System.Windows.Shapes;
using System.Xml.Linq;
using WpfDersleri1.classlar;

namespace WpfDersleri1
{
    /// <summary>
    /// paremeter_find.xaml etkileşim mantığı
    /// </summary>
    public partial class paremeter_find : Window
    {
        public paremeter_find()
        {
            InitializeComponent();
        }
        public int y = 0;
        private void paremeter_name_chosed(object sender, SelectionChangedEventArgs e)
        {
            if (kind_of_meterial != null && lazer_power.SelectedItem != null && thicknesss.SelectedItem != null)
            {
                full_combobax_item(kind_of_meterial, lazer_power, thicknesss);

                var send_way = new show_db2_datas();

                int selectedgass;
                int selected_thicnes;
                selectedgass = Convert.ToInt32(lazer_power.SelectedItem);
                selected_thicnes = Convert.ToInt32(thicknesss.SelectedItem);

                ComboBoxItem selectedmateriall = (ComboBoxItem)kind_of_meterial.SelectedItem;  //table name
                // ComboBoxItem selectedgass = (ComboBoxItem)lazer_power.SelectedItem;   //laser power  //İNT TÜRÜ OLDUĞUNDAN KULLANILAMADI
                // ComboBoxItem selectedthicness = (ComboBoxItem)thicknesss.SelectedItem;  //kalınlı //İNT TÜRÜ OLDUĞUNDAN KULLANILAMADI
                string selected_table = selectedmateriall.Content.ToString();
                string selected_Gas = Convert.ToString(lazer_power.SelectedItem);
                string selected_thicnesS = Convert.ToString(thicknesss.SelectedItem);

              //  MessageBox.Show(selected_table);
              //  MessageBox.Show(selected_Gas);
              //  MessageBox.Show(selected_thicnesS);

               
                send_way.determine_way_db(selected_table, selected_Gas, selected_thicnesS);

                Window3 c = new Window3();
                c.ShowDialog();
            }



        }

        private void laser_power_chosed(object sender, SelectionChangedEventArgs e)
        {
            if (kind_of_meterial.SelectedItem != null && lazer_power.SelectedItem != null && thicknesss.SelectedItem != null)
            {
                full_combobax_item(kind_of_meterial, lazer_power, thicknesss);

                var send_way = new show_db2_datas();

                int selectedgass;
                int selected_thicnes;
                selectedgass = Convert.ToInt32(lazer_power.SelectedItem);
                selected_thicnes = Convert.ToInt32(thicknesss.SelectedItem);

                ComboBoxItem selectedmateriall = (ComboBoxItem)kind_of_meterial.SelectedItem;  //table name
                // ComboBoxItem selectedgass = (ComboBoxItem)lazer_power.SelectedItem;   //laser power //İNT TÜRÜ OLDUĞUNDAN KULLANILAMADI
                // ComboBoxItem selectedthicness = (ComboBoxItem)thicknesss.SelectedItem;  //kalınlık //İNT TÜRÜ OLDUĞUNDAN KULLANILAMADI

                string selected_table = selectedmateriall.Content.ToString();
                string selected_Gas = Convert.ToString(lazer_power.SelectedItem);
                string selected_thicnesS = Convert.ToString(thicknesss.SelectedItem);

              //  MessageBox.Show(selected_table);
              //  MessageBox.Show(selected_Gas);
               // MessageBox.Show(selected_thicnesS);


                send_way.determine_way_db(selected_table, selected_Gas, selected_thicnesS);

                Window3 c = new Window3();
                c.ShowDialog();

            }
        }

        private void thickness_chosed(object sender, SelectionChangedEventArgs e)
        {
            if (kind_of_meterial.SelectedItem != null && lazer_power.SelectedItem != null && thicknesss.SelectedItem != null)
            {
                full_combobax_item(kind_of_meterial, lazer_power, thicknesss);

                var send_way = new show_db2_datas();

                int selectedgass;
                int selected_thicnes;
                selectedgass = Convert.ToInt32(lazer_power.SelectedItem);
                selected_thicnes = Convert.ToInt32(thicknesss.SelectedItem);

                ComboBoxItem selectedmateriall = (ComboBoxItem)kind_of_meterial.SelectedItem;  //table name
                // ComboBoxItem selectedgass = (ComboBoxItem)lazer_power.SelectedItem;   //laser power //İNT TÜRÜ OLDUĞUNDAN KULLANILAMADI
                // ComboBoxItem selectedthicness = (ComboBoxItem)thicknesss.SelectedItem;  //kalınlık //İNT TÜRÜ OLDUĞUNDAN KULLANILAMADI

                string selected_table = selectedmateriall.Content.ToString();
                string selected_Gas = Convert.ToString(lazer_power.SelectedItem);
                string selected_thicnesS = Convert.ToString(thicknesss.SelectedItem);

               // MessageBox.Show(selected_table);
              //  MessageBox.Show(selected_Gas);
              //  MessageBox.Show(selected_thicnesS);

                send_way.determine_way_db(selected_table, selected_Gas, selected_thicnesS);

                Window3 c = new Window3();
                c.ShowDialog();

            }
        }
        public void full_combobax_item(ComboBox table_name, ComboBox laser_pow, ComboBox ThicNes)
        {

            string DBadres = @"Data Source=" + Environment.CurrentDirectory + "\\DB\\cuttingparemeters.db.db;Version=3;New=False;Compress=True;Read Only=False;";

            using (SQLiteConnection con = new SQLiteConnection(DBadres))
            {
                con.Open();

                string read = $"select MalzemeKalinlik from Aluminyum";

                SQLiteCommand komut = new SQLiteCommand(read, con);
                SQLiteDataReader reader = komut.ExecuteReader();

                ThicNes.ItemsSource = null; // ComboBox'ın içeriğini temizle

                while (reader.Read())
                {
                    int deger = reader.GetInt32(0); // Veritabanından 0. sütundaki(row) gelen değeri al

                    if (!ThicNes.Items.Contains(deger))
                        ThicNes.Items.Add(deger);

                }

                con.Close();
            }

            using (SQLiteConnection con = new SQLiteConnection(DBadres))
            {
                con.Open();

                string read = $"select LazerGucu from Aluminyum";

                SQLiteCommand komut = new SQLiteCommand(read, con);
                SQLiteDataReader reader = komut.ExecuteReader();

                laser_pow.ItemsSource = null; // ComboBox'ın içeriğini temizle

                while (reader.Read())
                {
                    int deger = reader.GetInt32(0); // Veritabanından 0. sütundaki(row) gelen değeri al
                   
                    if (!laser_pow.Items.Contains(deger))
                        laser_pow.Items.Add(deger);
                }

                con.Close();
            }

        }

        private void parameter_find(object sender, RoutedEventArgs e)
        {
            full_combobax_item(kind_of_meterial, lazer_power, thicknesss);
        }

    }
}