using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfDersleri1.icerik;

namespace WpfDersleri1.classlar
{
    public class us_cagir
    {
        public static void Uc_Ekle(Grid grd, UserControl uc)
        {

            if (grd.Children.Count>0) {
                grd.Children.Clear();
                grd.Children.Add(uc);
            } else
            {
                grd.Children.Add(uc);
            }
        }

        
    }
}
