using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDersleri1.classlar
{
    public class Parametre
    {
        public static string DBadres = @"Data Source=" + Environment.CurrentDirectory + "\\DB\\cuttingparemeters.db.db;Version=3;New=False;Compress=True;Read Only=False;";

        public void BagTest()
        {
           using (SQLiteConnection deneme = new SQLiteConnection(DBadres))
            {
                if (deneme.State == ConnectionState.Closed)
                {
                    deneme.Open();
                    MessageBox.Show("Veri Tabani Baglanti Saglandi");
                } else
                {
                    MessageBox.Show("Veri Tabani Baglanti Saglanmadi");
                }
            }

            

        }
    }
}