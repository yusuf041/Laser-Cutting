using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Media3D;
using WpfDersleri1.icerik;


namespace WpfDersleri1.classlar
{
    public  class show_DB_datas
    {

        // **** data_grid doldurma **** \\      

        public static int al;
       
        public void Data_Grid_Full(DataGrid grd)
        {
            
            
            SQLiteConnection con = new SQLiteConnection(Parametre.DBadres);
            con.Open();
            string meterial_name = "";

           
            switch (al)
            {
                case 0: 
                    meterial_name = "MSAIR";
                    break;
                case 1:
                    meterial_name = "MSN2";
                    break;
                case 2:
                    meterial_name = "MSO2";
                    break;
                case 3:
                    meterial_name = "GLVNZAIR";
                    break;
                case 4:
                    meterial_name = "GLVNZN2";
                    break;
                case 5:
                    meterial_name = "SSN2";
                    break;
                case 6:
                    meterial_name = "SSAIR";
                    break;
                case 7:
                    meterial_name = "COPPER";
                    break;
                case 8:
                    meterial_name = "BRASS";
                    break;
                case 9:
                    meterial_name = "Aluminyum";
                    break;

                default:
                    
                    break;
            }

                                         string show = $"select *from {meterial_name}";
     //  MessageBox.Show(show);
                                        SQLiteCommand cmd = new SQLiteCommand(show, con);
     // SQLiteDataReader reader = cmd.ExecuteReader();

            try
            {

                // var test3 = new show_DB_datas();

                SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }
            finally
            {

                con.Dispose();
            }

            //  if (i > 0) return true; else return false;

        }

        public void test(int all)
        {
            
           // User1 get_variable = new User1();
            al = all;
          // MessageBox.Show(al.ToString());

        }
    }
}
