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

namespace tehtävä21_oikea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void check1(object sender, RoutedEventArgs e)
        {

        }

        private void check2(object sender, RoutedEventArgs e)
        {

        }

        private void check3(object sender, RoutedEventArgs e)
        {

        }

        private void click1(object sender, RoutedEventArgs e)
        {
            cb1.IsChecked = false;
            cb2.IsChecked = false;
        }
    }
}
