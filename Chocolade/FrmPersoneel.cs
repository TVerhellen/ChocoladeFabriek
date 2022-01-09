using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmPersoneel : Form
    {
        public FrmPersoneel()
        {
            InitializeComponent();
        }

        private void FrmPersoneel_Load(object sender, EventArgs e)
        {
            updateLvw();
        }

        private void updateLvw()
        {
            lvwPersoneel.Items.Clear();

            foreach (var persoon in Gebruiker.list)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { persoon.Gebruikersnaam, persoon.Wachtwoord, persoon.Rol.ToString() });
                lvwPersoneel.Items.Add(theNewItem);
            }
        }
        private void btnWijzig_Click(object sender, EventArgs e)
        {
            Gebruiker ditPersoon = Gebruiker.list[lvwPersoneel.SelectedIndices[0]];
            ditPersoon.Gebruikersnaam = txtGebruikersnaam.Text;
            ditPersoon.Wachtwoord = txtWachtwoord.Text;
            string functie = txtFunctie.Text;
            switch (functie)
            {
                case "ceo":
                    ditPersoon.Rol = Gebruikersrol.ceo;
                    break;
                case "manager":
                    ditPersoon.Rol = Gebruikersrol.manager;
                    break;
                case "werknemer":
                    ditPersoon.Rol = Gebruikersrol.werknemer;
                    break;
                default:
                    break;
            }
            SlaLijstOp();
            updateLvw();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            Artikel nieuweChocoladeBatch = new ChocoladeBatch(txtGebruikersnaam.Text, Convert.ToDouble(txtWachtwoord.Text));
            nieuweChocoladeBatch.Houdbaarheid = Convert.ToDateTime(txtFunctie.Text);
            ChocoladeBatch.stock.Add(nieuweChocoladeBatch);
            ChocoladeBatch.SlaLijstOp();
            updateLvw();
        }

        private void lvwPersoneel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPersoneel.SelectedIndices.Count != 0)
            {
                txtGebruikersnaam.Text = Gebruiker.list[lvwPersoneel.SelectedIndices[0]].Gebruikersnaam;
                txtWachtwoord.Text = Gebruiker.list[lvwPersoneel.SelectedIndices[0]].Wachtwoord;
                txtFunctie.Text = Gebruiker.list[lvwPersoneel.SelectedIndices[0]].Rol.ToString();
            }
            else
            {
                txtGebruikersnaam.Clear();
                txtWachtwoord.Clear();
                txtFunctie.Clear();
            }
        }
        private void SlaLijstOp()
        {
            if (File.Exists("gebruikers.txt"))
            {
                using (StreamWriter writer = new StreamWriter("gebruikers.txt"))
                {
                    foreach (var item in Gebruiker.list)
                    {
                        writer.WriteLine($"{item.Gebruikersnaam}|{item.Voornaam}|{item.Achternaam}|{item.Wachtwoord}|{item.Rol}");
                    }
                }
            }
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            ChocoladeBatch.stock.RemoveAt(lvwPersoneel.SelectedIndices[0]);
            ChocoladeBatch.SlaLijstOp();
            updateLvw();
        }
    }
}
