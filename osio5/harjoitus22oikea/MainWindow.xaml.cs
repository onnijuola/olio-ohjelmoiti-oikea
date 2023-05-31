using System;
using System.Windows;
using System.Windows.Controls;

namespace IkkunaSovellus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaskeButton_Click(object sender, RoutedEventArgs e)
        {
            double leveys = double.Parse(leveysTextBox.Text);
            double korkeus = double.Parse(korkeusTextBox.Text);
            double karmi = double.Parse(karmiTextBox.Text);

            double piiri = 2 * (leveys + korkeus);
            double lasiPintaala = (leveys - 2 * karmi) * (korkeus - 2 * karmi);
            double pintaala = leveys * korkeus;

            piiriTextBlock.Text = "Karmin piiri: " + (piiri / 10).ToString("F2") + " cm";
            lasiTextBlock.Text = "Lasin pinta-ala: " + lasiPintaala.ToString("F2") + " cm^2";
            pintaalaTextBlock.Text = "Ikkunan Pinta-ala: " + pintaala.ToString("F2") + " cm^2";

            // Päivitä ikkunan koko ja sijainti
            ikkunaRectangle.Width = leveys;
            ikkunaRectangle.Height = korkeus;
            Canvas.SetLeft(ikkunaRectangle, karmi);
            Canvas.SetTop(ikkunaRectangle, karmi);
        }
    }
}


