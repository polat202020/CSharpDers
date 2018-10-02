using System;
using System.Collections.Generic;
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

       


        private void btn10Cek_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                OguzunHesabi.ParaCek();
                BakiyeGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
         
        }

      

        private void btn10Yatir_Click(object sender, RoutedEventArgs e)
        {

            OguzunHesabi.ParaYatir();
            BakiyeGoster();
        }

        private void BakiyeGoster()
        {
           
            tbBakiye.Text = (OguzunHesabi.Bakiye).ToString();
        }

    }
}
