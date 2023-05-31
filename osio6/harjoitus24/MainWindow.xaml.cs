using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LottoSovellus
{
    public partial class MainWindow : Window
    {
        private static readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tulostaButton_Click(object sender, RoutedEventArgs e)
        {
            arvotutRivitTextBlock.Text = String.Empty;
            int rivienMaara = 0;
            if (Int32.TryParse(rivienMaaraTextBox.Text, out rivienMaara))
            {
                if (rivienMaara > 0)
                {
                    string peli = ((ComboBoxItem)pelivalintaComboBox.SelectedItem).Content.ToString();
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < rivienMaara; i++)
                    {
                        string rivi = ArvoRivi(peli);
                        sb.AppendLine(rivi);
                    }

                    arvotutRivitTextBlock.Text = sb.ToString();
                }
                else
                {
                    MessageBox.Show("Syötä positiivinen rivien määrä!");
                }
            }
            else
            {
                MessageBox.Show("Syötä numeroina rivien määrä!");
            }
        }

        private void tyhjennaButton_Click(object sender, RoutedEventArgs e)
        {
            arvotutRivitTextBlock.Text = String.Empty;
        }

        private string ArvoRivi(string peli)
        {
            switch (peli)
            {
                case "Lotto":
                    return ArvoLottoRivi();
                case "Viking Lotto":
                    return ArvoVikingLottoRivi();
                case "Eurojackpot":
                    return ArvoEurojackpotRivi();
                default:
                    return String.Empty;
            }
        }

        private string ArvoLottoRivi()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                int numero = random.Next(1, 40);
                sb.Append(numero + " ");
            }
            return sb.ToString();
        }

        private string ArvoVikingLottoRivi()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                int numero = random.Next(1, 49);
                sb.Append(numero + " ");
            }
            return sb.ToString();
        }

        private string ArvoEurojackpotRivi()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                int numero = random.Next(1, 51);
                sb.Append(numero + " ");
            }
            sb.Append("Tähtinumerot: ");
            for (int i = 0; i < 2; i++)
            {
                int numero = random.Next(1, 11);
                sb.Append(numero + " ");
            }
            return sb.ToString();
        }
    }
}


