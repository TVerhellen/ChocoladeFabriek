using System;
using System.Collections.Generic;
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
        private Gebruikersrol _rol;

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
        #endregion
    }
}
