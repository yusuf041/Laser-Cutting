using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDersleri1.classlar;

namespace WpfDersleri1.icerik
{
    /// <summary>
    /// paremeter_wizard.xaml etkileşim mantığı
    /// </summary>
    public partial class paremeter_wizard : UserControl
    {

        public paremeter_wizard()
        {
            InitializeComponent();
        }

      
        private void kind_of_meterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (selection_of_meterial.SelectedItem != null && selection_gass.SelectedItem != null && selection_meterial_thicness.SelectedItem != null)
            {
                ComboBoxItem selectedmaterial = (ComboBoxItem)selection_of_meterial.SelectedItem;
                ComboBoxItem selectedgas = (ComboBoxItem)selection_gass.SelectedItem;
                ComboBoxItem selectedthicness = (ComboBoxItem)selection_meterial_thicness.SelectedItem;
                string selectedOption = selectedmaterial.Content.ToString();
                string selectedGas = selectedgas.Content.ToString();
                string selectedthicnes = selectedthicness.Content.ToString();

                // Seçilen opsiyona göre metni güncelle
                first_wizard(selectedOption, selectedGas,selectedthicnes);
                second_wizard(selectedOption, selectedGas, selectedthicnes);
                thirth_wizard(selectedOption, selectedGas, selectedthicnes);
                fourth_wizard(selectedOption, selectedGas, selectedthicnes);
            }

        }

        private void kind_of_gass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selection_of_meterial.SelectedItem != null && selection_gass.SelectedItem != null && selection_meterial_thicness.SelectedItem != null)
            {
                ComboBoxItem selectedmaterial = (ComboBoxItem)selection_of_meterial.SelectedItem;
                ComboBoxItem selectedgas = (ComboBoxItem)selection_gass.SelectedItem;
                ComboBoxItem selectedthicness = (ComboBoxItem)selection_meterial_thicness.SelectedItem;
                string selectedOption = selectedmaterial.Content.ToString();
                string selectedGas = selectedgas.Content.ToString();
                string selectedthicnes = selectedthicness.Content.ToString();

                // Seçilen opsiyona göre metni güncelle
                first_wizard(selectedOption, selectedGas, selectedthicnes);
                second_wizard(selectedOption, selectedGas, selectedthicnes);
                thirth_wizard(selectedOption, selectedGas, selectedthicnes);
                fourth_wizard(selectedOption, selectedGas, selectedthicnes);
            }

        }

        private void meterial_thickness_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (selection_of_meterial.SelectedItem != null && selection_gass.SelectedItem != null && selection_meterial_thicness.SelectedItem != null)
            {
                ComboBoxItem selectedmaterial = (ComboBoxItem)selection_of_meterial.SelectedItem;
                ComboBoxItem selectedgas = (ComboBoxItem)selection_gass.SelectedItem;
                ComboBoxItem selectedthicness = (ComboBoxItem)selection_meterial_thicness.SelectedItem;
                string selectedOption = selectedmaterial.Content.ToString();
                string selectedGas = selectedgas.Content.ToString();
                string selectedthicnes = selectedthicness.Content.ToString();

                // Seçilen opsiyona göre metni güncelle
                first_wizard(selectedOption, selectedGas, selectedthicnes);
                second_wizard(selectedOption, selectedGas, selectedthicnes);
                thirth_wizard(selectedOption, selectedGas, selectedthicnes);
                fourth_wizard(selectedOption, selectedGas, selectedthicnes);
            }



        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderValueTextBlock1.Text = $"{Posibility_1.Value}%";

            double opsiyon1 = Posibility_1.Value;
           // MessageBox.Show(opsiyon1.ToString());

        }

        private void Slider_ValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            sliderValueTextBlock2.Text = $"{Posibility_2.Value}%";

            double opsiyon2 = Posibility_2.Value;
        }

        private void Slider_ValueChanged3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderValueTextBlock3.Text = $"{Posibility_3.Value}%";
            double opsiyon3 = Posibility_3.Value;
        }

        private void Slider_ValueChanged4(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderValueTextBlock4.Text = $"{Posibility_4.Value}%";
            double opsiyon4 = Posibility_4.Value;
        }


        private void first_wizard(string selectedOption, string selectedgas,string selectedthicnes)
        {

            string optionDescription = "";
            string warning = "";

            switch (selectedOption)
            {
                case "Aluminyum":
                    if (selectedgas == "Nitrojen")
                    {
                        // burda metodlar çağrılacak. bu metodlara göre optionDescription doldrulacak. 
                        // 100 - 125 50u 
                        
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if(val >=0 && val <=3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %11 - Basınç:+%20";
                        }

                        } else
                    {
                        warning = "yanlis gaz secimi yaptiniz!";
                        MessageBox.Show(warning);
                    }
                   
                    break;
                case "Prinç":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %11 - Basınç:+%20";
                        }

                    }                 
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Galvanize":
                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %11 - Basınç:+%20";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.2mm - Hız:+/- %15 - Basınç:+%10";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Paslanmaz Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.5mm - Hız:+/- %11 - Basınç:+/-%20";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.2mm - Hız:+/- %15 - Basınç:+%10";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Bakır":
                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-0.5/-1mm - Hız:+/- %11 - Basınç:+%5";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Yumuşak Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.5mm - Hız:+/- %7 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.5mm - Hız:+/- %15 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%85 - Odak:+2.5/3 mm - Hız:+/- %5 - Basınç:%15 +/-";
                        }

                    }

                    break;

                // Diğer opsiyonlara göre açıklamaları buraya ekleyin
                default:
                    optionDescription = "Lutfen Meterial Turu Seciniz.";
                    break;
            }

            optionDescriptionTextBlock.Text = optionDescription;

        }  //100-125 50u-62,5u

        private void second_wizard(string selectedOption, string selectedgas, string selectedthicnes) //100-125 100u-125u
        {

            string optionDescription = "";
            string warning = "";

            switch (selectedOption)
            {
                case "Aluminyum":
                    if (selectedgas == "Nitrojen")
                    {
                        // burda metodlar çağrılacak. bu metodlara göre optionDescription doldrulacak. 
                        
                        // 100 / 125 100u
                        

                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.3mm - Hız:+/- %8 - Basınç:+%20";
                        }

                    } 
                    else
                    {
                        warning = "yanlis gaz secimi yaptiniz!";
                        MessageBox.Show(warning);
                    }

                    break;
                case "Prinç":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.3mm - Hız:+/- %8 - Basınç:+%20";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Galvanize":
                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 40)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.3mm - Hız:+/- %8 - Basınç:+%20";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.4mm - Hız:+/- %10 - Basınç:+%10";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Paslanmaz Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.5mm - Hız:+/- %7 - Basınç:+/-%15";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %10 - Basınç:+%15";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Bakır":


                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:- 0.5/1mm - Hız:+/- %4 - Basınç:+/- %5";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Yumuşak Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %5 - Basınç:+%12";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %7 - Basınç:+%12";
                        }

                    }

                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+ 2.5/3mm - Hız:+/- %10 - Basınç:+%10";
                        }

                    }

                    break;

                // Diğer opsiyonlara göre açıklamaları buraya ekleyin
                default:
                    optionDescription = "Lutfen Meterial Turu Seciniz.";
                    break;
            }

            optionDescriptionTextBlock2.Text = optionDescription;


        }   

        private void thirth_wizard(string selectedOption, string selectedgas, string selectedthicnes)//100-150 100u-150u
        {

            string optionDescription = "";
            string warning = "";


            switch (selectedOption)
            {
                case "Aluminyum":
                    if (selectedgas == "Nitrojen")
                    {
                        
                        
                        // 100 /150 100u
                        // 100 / 200 100u 

                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.8mm - Hız:+/- %5 - Basınç:+%20";
                        }

                    } else
                    {
                        warning = "yanlis gaz sectiniz!";
                        MessageBox.Show(warning);
                    }

                    break;
                case "Prinç":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.8mm - Hız:+/- %5 - Basınç:+%20";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Galvanize":
                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.8mm - Hız:+/- %5 - Basınç:+%15";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.8mm - Hız:+/- %8 - Basınç:+%10";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Paslanmaz Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.3mm - Hız:+/- %5 - Basınç:+%15";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.3mm - Hız:+/- %8 - Basınç:+%15";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Bakır":


                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-0.5/-2mm - Hız:+/- %5 - Basınç:+%5";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Yumuşak Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.3mm - Hız:+/- %11 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 0.5mm - Hız:+/- %10 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%85 - Odak:+2.5/3 mm - Hız:+/- %5 - Basınç:%15 +/-";
                        }

                    }

                    break;

                // Diğer opsiyonlara göre açıklamaları buraya ekleyin
                default:
                    optionDescription = "Lutfen Meterial Turu Seciniz.";
                    break;
            }

            optionDescriptionTextBlock3.Text = optionDescription;


        }

        private void fourth_wizard(string selectedOption, string selectedgas, string selectedthicnes)
        {

            string optionDescription = "";
            string warning = "";


            switch (selectedOption)
            {
                case "Aluminyum":
                    if (selectedgas == "Nitrojen")
                    {
                        // burda metodlar çağrılacak. bu metodlara göre optionDescription doldrulacak. 
                        
                        // 100 / 200 100u 

                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 1mm - Hız:+/- %3 - Basınç:+%10";
                        }

                    }

                    break;
                case "Prinç":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 1mm - Hız:+/- %3 - Basınç:+%10";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Galvanize":
                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 1mm - Hız:+/- %3 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 1mm - Hız:+/- %5 - Basınç:+%10";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Paslanmaz Çelik":
                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %5 - Basınç:+%12";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 0.5mm - Hız:+/- %8 - Basınç:+%12";
                        }

                    }

                    else if (selectedgas == "Oksijen")
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Bakır":


                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-0.5/-3mm - Hız:+/- %2 - Basınç:+%5";
                        }

                    }
                    else
                    {
                        warning = "Yanlis gas secimi yaptiniz !";
                        MessageBox.Show(warning);
                    }
                    break;
                case "Yumuşak Çelik":

                    if (selectedgas == "Nitrojen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:-/+ 1mm - Hız:+/- %7 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Hava")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%100 - Odak:+/- 1mm - Hız:+/- %10 - Basınç:+%10";
                        }

                    }

                    if (selectedgas == "Oksijen")
                    {
                        int indexofMm = selectedthicnes.IndexOf("mm");

                        if (indexofMm != -1)
                        {
                            selectedthicnes = selectedthicnes.Substring(0, indexofMm);
                        }

                        int val = Convert.ToInt32(selectedthicnes);
                        if (val >= 0 && val <= 3)
                        {
                            optionDescription = "Güc:%85 - Odak:3 mm - Hız:+/- %5 - Basınç:%15 +/-";
                        }

                    }

                    break;

                // Diğer opsiyonlara göre açıklamaları buraya ekleyin
                default:
                    optionDescription = "Lutfen Meterial Turu Seciniz.";
                    break;
            }

            optionDescriptionTextBlock4.Text = optionDescription;


        }//100-200 100u-200u

    }
}
