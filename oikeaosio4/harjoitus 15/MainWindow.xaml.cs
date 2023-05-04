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

namespace harjoitus_15
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
        private int autojen_määrä = 0;
        private int auotojen_määrä2 = 0;


        private void kuormaauto_onclick(object sender, RoutedEventArgs e)
        {
            autojen_määrä++;
            tbn.Text =  autojen_määrä.ToString();
        }

        private void auto_onclick(object sender, RoutedEventArgs e)
        {
            auotojen_määrä2++;
           textblock2.Text = auotojen_määrä2.ToString();

        }
    }
}
