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
        private string _leverancierNummer;

        public Leverancier()
        {

        }
        public Leverancier(string leverancierNummer, string naam, string straat, string straatnummer, string postcode, string gemeente, string btw, string email, string telefoonnummer)
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

        public string LeverancierNummer
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
        //public void InlezenBestand()
        //{
        //    string[] tempGegevensLeverancier;
        //    Leverancier LeverancierGegevens = new Leverancier();
        //    List<Leverancier> mijnLeveranciers = new List<Leverancier>();
        //    if (File.Exists("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
        //    {
        //        using (StreamReader reader = new StreamReader("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                tempGegevensLeverancier = reader.ReadLine().Split(";");
        //                if (tempGegevensLeverancier.Length > 1)
        //                {
        //                    LeverancierGegevens = new Leverancier(Convert.ToInt32(tempGegevensLeverancier[0]).ToString("0000"), tempGegevensLeverancier[1], tempGegevensLeverancier[2], tempGegevensLeverancier[3], tempGegevensLeverancier[4], tempGegevensLeverancier[5], tempGegevensLeverancier[6], tempGegevensLeverancier[7], tempGegevensLeverancier[8]);
        //                    mijnLeveranciers.Add(LeverancierGegevens);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        using (StreamWriter writer = new StreamWriter("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
        //        {
        //            writer.WriteLine("- Geen leverancier geselecteerd -");
        //        }
        //    }

        //} 

    }
}
