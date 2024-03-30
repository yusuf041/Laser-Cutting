using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfDersleri1.icerik;

namespace WpfDersleri1.classlar
{
    public class show_db2_datas
    {
        public static string first = "";
        public static string second = "";
        public static string thirth = "";


        public void Data_Grid_FuLL(DataGrid grd2)
        {
            SQLiteConnection con = new SQLiteConnection(Parametre.DBadres);
            con.Open();

            string show = $"SELECT*from {first}  WHERE LazerGucu = {second} and MalzemeKalinlik = {thirth}";
            
            SQLiteCommand cmd = new SQLiteCommand(show, con);

            try
            {

                // var test3 = new show_DB_datas();

                SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grd2.ItemsSource = null;
                grd2.ItemsSource = dt.DefaultView;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }
            finally
            {

                con.Dispose();
            }


        }



        public void determine_way_db(string get1, string get2, string get3)
        {
            
            first = get1;
            second = get2;
            thirth = get3;

        }




    }
}
