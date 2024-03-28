using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfDersleri1.icerik
{
    /// <summary>
    /// help_section.xaml etkileşim mantığı
    /// </summary>
    public partial class help_section : UserControl
    {
        public help_section()
        {
            InitializeComponent();
        }

        private void PdfListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected_item = PdfListBox.SelectedItem;

            if (selected_item != null)
            {
                string selected_pdf = selected_item.ToString();

                // "System.Windows.Controls.ListBoxItem:" metnini kaldır
                selected_pdf = selected_pdf.Substring(selected_pdf.IndexOf(':') + 1).Trim() +".pdf";

                // Dosya adını kontrol et
                if (selected_pdf.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    // Dosya adı geçerli bir PDF dosyası adıysa
                    string pdfPath = System.IO.Path.Combine(@"C:\Users\kinan\Desktop\WpfDersleri1\WpfDersleri1", selected_pdf);

                    // Dosyanın varlığını kontrol et
                    if (System.IO.File.Exists(pdfPath))
                    {
                        // Dosya varsa, başlatma işlemini gerçekleştirin
                        Process.Start(pdfPath);
                    }
                    else
                    {
                        // Dosya yoksa kullanıcıya bir hata mesajı gösterin
                        MessageBox.Show("Belirtilen PDF dosyası bulunamadı.");
                    }
                }
                else
                {
                    // Seçilen öğe bir PDF dosyası değilse
                    MessageBox.Show("Lütfen bir PDF dosyası seçin.");
                }
            }
        }

        

        private void linkLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=saVE7pMhaxk&ab_channel=MITOpenCourseWare";

            // OpenLink metodu çağrılır
            OpenLink(url);
        }
        private void OpenLink(string url)
        {
            try
            {
                // URL'yi varsayılan tarayıcıda açmak için Process.Start metodu kullanılır
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Hata durumunda burada işlem yapabilirsiniz
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        

        private void linkLabel_MouseLeftButtonDown2(object sender, MouseButtonEventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=1sw2H1qvFeo&t=2s&ab_channel=Bystronic";

            // OpenLink metodu çağrılır
            OpenLink(url);
        }
    }
}
