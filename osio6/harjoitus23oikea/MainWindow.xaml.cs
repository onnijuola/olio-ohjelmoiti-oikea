using System.Windows;
using System.Windows.Controls;

namespace KiuasOhjelma
{
    public partial class MainWindow : Window
    {
        private Kiuas kiuas;

        public MainWindow()
        {
            InitializeComponent();
            kiuas = new Kiuas();
        }

        private void tilaButton_Click(object sender, RoutedEventArgs e)
        {
            kiuas.VaihdaTila();
            if (kiuas.OnkoPaalla)
            {
                tilaButton.Content = "Kiukaan tila: ON";
            }
            else
            {
                tilaButton.Content = "Kiukaan tila: OFF";
            }
        }

        private void lampotilaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            int lampotila = (int)slider.Value;
            kiuas.AsetaLampotila(lampotila);
            lampotilaText.Text = lampotila.ToString();
        }

        private void kosteusSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            int kosteus = (int)slider.Value;
            kiuas.AsetaKosteus(kosteus);
            kosteusText.Text = kosteus.ToString();
        }
    }

    class Kiuas
    {
        public int Lampotila { get; private set; }
        public int Kosteus { get; private set; }
        public bool OnkoPaalla { get; private set; }

        public Kiuas()
        {
            Lampotila = 0;
            Kosteus = 0;
            OnkoPaalla = false;
        }

        public void AsetaLampotila(int uusiLampotila)
        {
            Lampotila = uusiLampotila;
        }

        public void AsetaKosteus(int uusiKosteus)
        {
            Kosteus = uusiKosteus;
        }

        public void VaihdaTila()
        {
            OnkoPaalla = !OnkoPaalla;
        }
    }
}






