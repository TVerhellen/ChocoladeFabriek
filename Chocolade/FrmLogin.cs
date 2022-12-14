using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmLogin : Form
    {
        double startX = 0;
        public Personeel ingelogdeGebruiker = null;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = txtGebruikersnaam.Text;
            string wachtwoord = txtWachtwoord.Text;

            if (String.IsNullOrWhiteSpace(gebruikersnaam) || String.IsNullOrWhiteSpace(wachtwoord))
            {
                MessageBox.Show("Gelieve een gebruikersnaam en wachtwoord in te voeren.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (IsWachtwoordCorrect())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Uw wachtwoord of gebruikersnaam zijn niet correct.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool IsWachtwoordCorrect()
        {
            bool wachtwoordIsCorrect = false;
            List<Personeel> alleGebruikers = VulLijstMetGebruikers();

            foreach (var gebruiker in alleGebruikers)
            {
                if (gebruiker.Gebruikersnaam == txtGebruikersnaam.Text && gebruiker.Wachtwoord == txtWachtwoord.Text)
                {
                    wachtwoordIsCorrect = true;
                    ingelogdeGebruiker = gebruiker;
                    break;
                }
            }
            return wachtwoordIsCorrect;
        }

        private List<Personeel> VulLijstMetGebruikers()
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
                return accounts;
            }
            throw new FileLoadException("Could not find gebruikers.txt");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Environment.Exit(1);
        }

        private void pctChocolate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ingelogdeGebruiker = new Personeel();
            ingelogdeGebruiker.Gebruikersnaam = "Steven";
            ingelogdeGebruiker.Rol = Gebruikersrol.CEO;
        }
    }
}
