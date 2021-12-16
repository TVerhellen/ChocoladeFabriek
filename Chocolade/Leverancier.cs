using System;

namespace Chocolade
{
    class Leverancier
    {
        private string _naam;
        private string _straat;
        private string _straatNummer;
        private string _postcode;
        private string _gemeente;
        private string _btwNummer;
        private string _email;
        private string _telefoonnummer;
        private int _leverancierNummer;

        public Leverancier()
        {

        }
        public Leverancier(int leverancierNummer, string naam, string straat, string straatnummer, string postcode, string gemeente, string btw, string email, string telefoonnummer)
        {
            LeverancierNummer = leverancierNummer;
            Naam = naam;
            Straat = straat;
            StraatNummer = straatnummer;
            Postcode = postcode;
            Gemeente = gemeente;
            BTW = btw;
            Email = email;
            Telefoonnumer = telefoonnummer;
        }

        public int LeverancierNummer
        {
            get { return _leverancierNummer; }
            set { _leverancierNummer = value; }
        }
        public string Telefoonnumer
        {
            get { return _telefoonnummer; }
            set { _telefoonnummer = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string BTW
        {
            get { return _btwNummer; }
            set { _btwNummer = value; }
        }
        public string Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
        }
        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string StraatNummer
        {
            get { return _straatNummer; }
            set { _straatNummer = value; }
        }
        public string Straat
        {
            get { return _straat; }
            set { _straat = value; }
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public override string ToString()
        {
            return Naam + Environment.NewLine + Straat.PadRight(20) + StraatNummer + Environment.NewLine + Postcode.PadRight(20) + Gemeente + Environment.NewLine + BTW;
        }

    }
}
