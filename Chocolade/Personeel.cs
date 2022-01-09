using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{

    public enum Gebruikersrol { Werknemer, Manager, CEO, Non_actief }

    public class Personeel
    {
        private string _gebruikersnaam;
        private string _wachtwoord;
        private string _voornaam;
        private string _achternaam;
        private Gebruikersrol _rol;
        public static List<Personeel> list = new List<Personeel>();

        public Personeel() { }
        public Personeel(string gebruikersnaam, string wachtwoord, string rol)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            switch (rol)
            {
                case "Werknemer":
                    Rol = Gebruikersrol.Werknemer;
                    break;
                case "Manager":
                    Rol = Gebruikersrol.Manager;
                    break;
                case "CEO":
                    Rol = Gebruikersrol.CEO;
                    break;
                case "Non_actief":
                    Rol = Gebruikersrol.Non_actief;
                    break;
                default:
                    break;
            }
        }

        #region properties
        public Gebruikersrol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }

        public string Gebruikersnaam
        {
            get { return _gebruikersnaam; }
            set { _gebruikersnaam = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }
        #endregion

        public static void LaadLijst()
        {
            List<Personeel> accounts = new List<Personeel>();
            if (File.Exists("gebruikers.txt"))
            {
                string[] accountsAsStrings = File.ReadAllLines("gebruikers.txt");
                Personeel tempGebruiker = null;
                foreach (var accountAsLine in accountsAsStrings)
                {
                    string[] accountAsStrings = accountAsLine.Split('|');
                    string gebruikersnaam = accountAsStrings[0];
                    string voornaam = accountAsStrings[1];
                    string achternaam = accountAsStrings[2];
                    string wachtwoord = accountAsStrings[3];
                    string rol = accountAsStrings[4];

                    tempGebruiker = new Personeel(gebruikersnaam, wachtwoord, rol);
                    accounts.Add(tempGebruiker);
                }
                list = accounts;
            }
            else
            {
                throw new FileLoadException("Could not find gebruikers.txt");
            }
        }

        public override string ToString()
        {
            return Gebruikersnaam;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Personeel tempPersoneel = (Personeel)obj;

            return this.Gebruikersnaam == tempPersoneel.Gebruikersnaam;
        }
    }
}
