using System;

namespace Chocolade
{
    class DisplayArtikel : Artikel
    {
        private double _prijs;
        private string _artikelNummer;
        private string _kwaliteit;
        private string _soort;
        private string _eigenArtikelnummer;
        private string _rekeningnummer;
        private string _eigenArtikelnaam;
        private string _btwPercentage;
        private string _hoofdLeverancier;

        public DisplayArtikel()
        {
        }

        public DisplayArtikel(string eigennummer, string eigennaam, string kwaliteit, string soort, string prijs, string hoofdlev, string artikelnummer, string rekeningnummer, string btw)
        {
            EigenArtikelnummer = eigennummer;
            EigenArtikelnaam = eigennaam;
            Kwaliteit = kwaliteit;
            Soort = soort;
            Prijs = Convert.ToDouble(prijs);
            ArtikelNummer = artikelnummer;
            RekeningNummer = rekeningnummer;
            BtwPercentage = btw;
            HoofdLeverancier = hoofdlev;
        }
        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        public string ArtikelNummer
        {
            get { return _artikelNummer; }
            set { _artikelNummer = value; }
        }
        public string Soort
        {
            get { return _soort; }
            set { _soort = value; }
        }
        public string Kwaliteit
        {
            get { return _kwaliteit; }
            set { _kwaliteit = value; }
        }
        public string EigenArtikelnummer
        {
            get { return _eigenArtikelnummer; }
            set { _eigenArtikelnummer = value; }
        }
        public string RekeningNummer
        {
            get { return _rekeningnummer; }
            set { _rekeningnummer = value; }
        }
        public string EigenArtikelnaam
        {
            get { return _eigenArtikelnaam; }
            set { _eigenArtikelnaam = value; }
        }
        public string BtwPercentage
        {
            get { return _btwPercentage; }
            set { _btwPercentage = value; }
        }
        public string HoofdLeverancier
        {
            get { return _hoofdLeverancier; }
            set { _hoofdLeverancier = value; }
        }
    }
}
