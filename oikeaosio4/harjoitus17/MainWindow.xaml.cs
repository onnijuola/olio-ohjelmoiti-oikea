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

namespace harjoitus17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        float lämpöt;
        bool keittiö;
        bool olohuone;
        bool lukko;
        public MainWindow()
        {
            InitializeComponent();
            
        }


       



        private void keittiö_check(object sender, RoutedEventArgs e)
        {
            string päälle = "päällä";
            string pois = "pois";
              if(keittiövalot.IsChecked == true)
              {
                tb_keittiö.Text = päälle;
            
              }
              else if (keittiövalot.IsChecked == false)
              { 
                tb_keittiö.Text = pois;
            
              }
        }

        private void olohuone_check(object sender, RoutedEventArgs e)
        {
            string päälle = "päällä";
            string pois = "pois";
            if (olohuoneenvalot.IsChecked == true)
            {
                tb_olohuone.Text = päälle;

            }
            else
            {
                tb_olohuone.Text = pois;

            }
        }

        private void lukko_check(object sender, RoutedEventArgs e)
        {
            string lukitttu = "on lukossa";
            string auki = "ovi on auki";
            if(talolukkoon.IsChecked == true)
            {
                tb_lukko.Text = lukitttu;

            }
            else
            {
                tb_lukko.Text= auki;

            }
        }

        private void text_check(object sender, TextChangedEventArgs e)
        {
            lämpö.Text = lämpöt.ToString();
            tb_lämpö.Text = lämpö.Text.ToString();

        }
    }
}
