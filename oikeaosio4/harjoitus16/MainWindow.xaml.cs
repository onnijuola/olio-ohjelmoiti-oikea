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

namespace harjoitus16
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double kilometri = 0 ;
        private double maili =0  ;

       
        
        private void convert_onclick(object sender, RoutedEventArgs e)
        {

            if (KilometersRadioButton.IsChecked == true)
            {
                double miles = double.Parse(tb1.Text) / 1.609;
                tb2.Text = miles.ToString();
            }
            else if (MilesRadioButton.IsChecked == true)
            {
                double kilometers = double.Parse(tb1.Text) * 1.609;
                tb2.Text = kilometers.ToString();
            }
        }
    }



}
