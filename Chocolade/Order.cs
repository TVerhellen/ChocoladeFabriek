namespace Chocolade
{
    class Order
    {
        private string _artikelNummer;
        private string _artikelNaam;
        private double _prijs;


        public double MyProperty
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        public string ArtikelNaam
        {
            get { return _artikelNaam; }
            set { _artikelNaam = value; }
        }

        public string ArtikelNummer
        {
            get { return _artikelNummer; ; }
            set { _artikelNummer = value; }
        }

    }
}
