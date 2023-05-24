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

namespace harjoitus19
{
    /// <summary>
    /// Interaction logic for kerros1.xaml
    /// </summary>
    public partial class kerros1 : Page
    {

        int num;
        public kerros1()
        {
            InitializeComponent();
        }

        private void kerrokaet2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new kerros2());
        }

        private void click2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new kerros3());
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new kerros4());
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new kerros5());
        }

        private void click_valitse(object sender, RoutedEventArgs e)
        {
            num = int.Parse(tb1.Text);
            if ( num == 2 )
            {
                this.NavigationService.Navigate(new kerros2());

            }
            else if (num == 3 )
            {
                this.NavigationService.Navigate(new kerros3());
            }
            else if (num == 4)
            {
                this.NavigationService.Navigate(new kerros4());

            }
            else if (num == 5)
            {
                this.NavigationService.Navigate(new kerros5());
            }
            else
            {
                string väärä = "mitään ei tapahtunut";
                väärä=tb1.Text;
                
            }
        }
    }
}
