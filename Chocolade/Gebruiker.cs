using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{

    public enum Gebruikersrol { werknemer, manager, ceo }

    public class Gebruiker
    {
        private string _gebruikersnaam;
        private string _wachtwoord;
        private string _voornaam;
        private string _achternaam;
        private Gebruikersrol _rol;
        public static List<Gebruiker> list = new List<Gebruiker>();

        public Gebruiker() { }
        public Gebruiker(string gebruikersnaam, string wachtwoord, string rol)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            switch (rol)
            {
                case "werknemer":
                    Rol = Gebruikersrol.werknemer;
                    break;
                case "manager":
                    Rol = Gebruikersrol.manager;
                    break;
                case "ceo":
                    Rol = Gebruikersrol.ceo;
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
            List<Gebruiker> accounts = new List<Gebruiker>();
            if (File.Exists("gebruikers.txt"))
            {
                string[] accountsAsStrings = File.ReadAllLines("gebruikers.txt");
                Gebruiker tempGebruiker = null;
                foreach (var accountAsLine in accountsAsStrings)
                {
                    string[] accountAsStrings = accountAsLine.Split('|');
                    string gebruikersnaam = accountAsStrings[0];
                    string voornaam = accountAsStrings[1];
                    string achternaam = accountAsStrings[2];
                    string wachtwoord = accountAsStrings[3];
                    string rol = accountAsStrings[4];

                    tempGebruiker = new Gebruiker(gebruikersnaam, wachtwoord, rol);
                    accounts.Add(tempGebruiker);
                }
                list = accounts;
            }
            else
            {
                throw new FileLoadException("Could not find gebruikers.txt");
            }
        }
    }
}
