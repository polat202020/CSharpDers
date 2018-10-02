using BusinessLayer;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BankamatikProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Hesap OguzunHesabi { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //oguzun hesabı ilk açılışta açıldı
            OguzunHesabi = new Hesap();
        }

       


        private void btnCek_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var btn = sender as Button;
                switch (btn.Name)
                {
                    case "btn10Cek":
                        OguzunHesabi.ParaCek(10);
                        break;
                    case "btn20Cek":
                        OguzunHesabi.ParaCek(20);
                        break;
                    case "btn30Cek":
                        OguzunHesabi.ParaCek(30);
                        break;
                    default:
                        MessageBox.Show("Hatalı işlem");
                        break;
                }

              
                BakiyeGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
         
        }

      

        private void btnYatir_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            switch (btn.Name)
            {
                case "btn10Yatir":
                    OguzunHesabi.ParaYatir(10);
                    break;
                case "btn20Yatir":
                    OguzunHesabi.ParaYatir(20);
                    break;
                case "btn30Yatir":
                    OguzunHesabi.ParaYatir(30);
                    break;
                default:
                    MessageBox.Show("Hatalı işlem");
                    break;
            }


        
            BakiyeGoster();
        }

        private void BakiyeGoster()
        {
           
            tbBakiye.Text = (OguzunHesabi.Bakiye).ToString();
        }

    }
}
