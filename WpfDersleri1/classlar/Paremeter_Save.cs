using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.SQLite;
using WpfDersleri1.icerik;
using System.Windows;



namespace WpfDersleri1.classlar
{
    public class Paremeter_Save
    {

        public void save_datas(string loc_of_parametre, params TextBox[] textBoxes)
        {
            parametre_save get_location_of_paremeter = new parametre_save();

            string paremeter_locationn = loc_of_parametre;

            MessageBox.Show(paremeter_locationn);
          // MessageBox.Show(textBoxes[0].ToString, textBoxes[1].ToString, textBoxes[2], textBoxes[3], textBoxes[4], textBoxes[5], textBoxes[6], textBoxes[7], textBoxes[8], textBoxes[9], textBoxes[10], textBoxes[11]);

            SQLiteConnection conn = new SQLiteConnection(Parametre.DBadres);
            conn.Open();

            string add = $"insert into {paremeter_locationn}(ParemetreAdi, LazerGucu, Frekans, Duty, KesimHizi, GazCinsi, GazBasinci, KesimYüksekligi, OdakNoktasi, NozleTipi,MalzemeKalinlik) values('{textBoxes[0].Text}', '{textBoxes[1].Text}', '{textBoxes[2].Text}', '{textBoxes[3].Text}', '{textBoxes[4].Text}', " +
                         $"'{textBoxes[5].Text}', '{textBoxes[6].Text}', '{textBoxes[7].Text}', '{textBoxes[8].Text}', '{textBoxes[9].Text}','{textBoxes[10].Text}')";

            SQLiteCommand komut = new SQLiteCommand(add, conn);
            komut.ExecuteNonQuery();

        }
    }
}
