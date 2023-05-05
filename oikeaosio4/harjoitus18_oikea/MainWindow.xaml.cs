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

namespace harjoitus18_oikea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numero1;
        double numero2;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void laskee_click(object sender, RoutedEventArgs e)
        {
            if (summa_rb.IsChecked == true)
            {
                numero1 = double.Parse(tb1.Text);
                numero2 = double.Parse(tb3.Text);
                double summa = numero1 + numero2;
                tb2.Text = summa.ToString();    
            }
            else if (erotus.IsChecked == true)
            {
                numero1 = double.Parse(tb1.Text);
                numero2 = double.Parse(tb3.Text);
                double summa = numero1 - numero2;
                tb2.Text = summa.ToString();

            }
            else if (jako_rb.IsChecked == true)
            {
                numero1 = double.Parse(tb1.Text);
                numero2 = double.Parse(tb3.Text);
                double summa = numero1 / numero2;
                tb2.Text = summa.ToString();

            }
            else if (kerto_rb.IsChecked == true)
            {
                numero1 = double.Parse(tb1.Text);
                numero2 = double.Parse(tb3.Text);
                double summa = numero1 * numero2;
                tb2.Text = summa.ToString();

            }
        }
    }
}
