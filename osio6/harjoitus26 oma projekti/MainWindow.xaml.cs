using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Option_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton selectedOption = sender as RadioButton;
            if (selectedOption == option1)
            {
                displayImage.Source = new BitmapImage(new Uri(@"C:\Users\onni.juola\OneDrive - Careeria\Työpöytä\kuva1.jpg"));
            }
            else if (selectedOption == option2)
            {
                displayImage.Source = new BitmapImage(new Uri(@"C:\Users\onni.juola\OneDrive - Careeria\Työpöytä\kuva2.jpg"));
            }
            else if (selectedOption == option3)
            {
                displayImage.Source = new BitmapImage(new Uri(@"C:\Users\onni.juola\OneDrive - Careeria\Työpöytä\kuva3.jpg"));
            }

            displayImage.Visibility = Visibility.Visible;
        }
    }
}

