using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private List<Opiskelija> opiskelijat;
        private string tiedostoPolku = "opiskelijat.bin";

        public MainWindow()
        {
            InitializeComponent();
            opiskelijat = new List<Opiskelija>();
        }

        private void LisaaOpiskelija(Opiskelija opiskelija)
        {
            if (!OnUniikkiID(opiskelija.OpiskelijaID))
            {
                MessageBox.Show("OpiskelijaID ei ole uniikki!");
                return;
            }

            if (!OnUniikkiSahkoposti(opiskelija.Sahkoposti))
            {
                MessageBox.Show("Sähköposti ei ole uniikki!");
                return;
            }

            opiskelijat.Add(opiskelija);
            TulostaOpiskelijat();
        }

        private bool OnUniikkiID(int opiskelijaID)
        {
            foreach (Opiskelija opiskelija in opiskelijat)
            {
                if (opiskelija.OpiskelijaID == opiskelijaID)
                {
                    return false;
                }
            }
            return true;
        }

        private bool OnUniikkiSahkoposti(string sahkoposti)
        {
            foreach (Opiskelija opiskelija in opiskelijat)
            {
                if (opiskelija.Sahkoposti.Equals(sahkoposti, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }

        private void TulostaOpiskelijat()
        {
            studentStackPanel.Children.Clear();

            foreach (Opiskelija opiskelija in opiskelijat)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = $"Etunimi: {opiskelija.Etunimi}\nSukunimi: {opiskelija.Sukunimi}\nOpiskelijaID: {opiskelija.OpiskelijaID}\nSähköposti: {opiskelija.Sahkoposti}\nPuhelinnumero: {opiskelija.Puhelinnumero}";
                studentStackPanel.Children.Add(textBlock);
            }
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (FileStream tiedostoStream = new FileStream(tiedostoPolku, FileMode.Create))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    binFormatter.Serialize(tiedostoStream, opiskelijat);
                    MessageBox.Show("Opiskelijoiden tiedot tallennettu tiedostoon.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tiedoston tallentaminen epäonnistui: {ex.Message}");
            }
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (FileStream tiedostoStream = new FileStream(tiedostoPolku, FileMode.Open))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    opiskelijat = (List<Opiskelija>)binFormatter.Deserialize(tiedostoStream);
                    TulostaOpiskelijat();
                    MessageBox.Show("Opiskelijoiden tiedot ladattu tiedostosta.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Tiedostoa ei löytynyt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tiedoston lataaminen epäonnistui: {ex.Message}");
            }
        }
    }

    [Serializable]
    public class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int OpiskelijaID { get; set; }
        public string Sahkoposti { get; set; }
        public string Puhelinnumero { get; set; }
    }
}