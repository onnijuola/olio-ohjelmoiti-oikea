using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Harjoitus25
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Joukkue> Joukkueet { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Joukkueet = new ObservableCollection<Joukkue>();
            DataContext = this;

            
            Joukkue joukkue1 = new Joukkue
            {
                Nimi = "Joukkue 1",
                Kotikaupunki = "Kaupunki 1",
                Pelaajat = new List<Pelaaja>
                {
                    new Pelaaja { Etunimi = "Pelaaja 1", Sukunimi = "Sukunimi 1", PelaajaNumero = 1 },
                    new Pelaaja { Etunimi = "Pelaaja 2", Sukunimi = "Sukunimi 2", PelaajaNumero = 2 }
                }
            };

            Joukkue joukkue2 = new Joukkue
            {
                Nimi = "Joukkue 2",
                Kotikaupunki = "Kaupunki 2",
                Pelaajat = new List<Pelaaja>
                {
                    new Pelaaja { Etunimi = "Pelaaja 3", Sukunimi = "Sukunimi 3", PelaajaNumero = 3 },
                    new Pelaaja { Etunimi = "Pelaaja 4", Sukunimi = "Sukunimi 4", PelaajaNumero = 4 }
                }
            };

            Joukkueet.Add(joukkue1);
            Joukkueet.Add(joukkue2);
        }
    }

    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }
    }

    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int PelaajaNumero { get; set; }
    }
}



