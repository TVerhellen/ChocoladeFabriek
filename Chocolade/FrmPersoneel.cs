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
    public partial class FrmPersoneel : Form
    {
        public Personeel ingelogdeGebruiker = null;

        public FrmPersoneel()
        {
            InitializeComponent();
        }

        private void FrmPersoneel_Load(object sender, EventArgs e)
        {
            updateLvw();
            FillComboBox();
        }

        private void updateLvw()
        {
            lvwPersoneel.Items.Clear();

            foreach (var persoon in Personeel.list)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { persoon.Gebruikersnaam, persoon.Wachtwoord, persoon.Rol.ToString() });
                lvwPersoneel.Items.Add(theNewItem);
            }
        }
        private void btnWijzig_Click(object sender, EventArgs e)
        {
            Personeel ditPersoon = Personeel.list[lvwPersoneel.SelectedIndices[0]];
            ditPersoon.Gebruikersnaam = txtGebruikersnaam.Text;
            ditPersoon.Wachtwoord = txtWachtwoord.Text;
            ditPersoon.Rol = GebruikersrolVanCombo();
            SlaLijstOp();
            updateLvw();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            Personeel ditPersoon = new Personeel();
            ditPersoon.Gebruikersnaam = txtGebruikersnaam.Text;
            ditPersoon.Wachtwoord = txtWachtwoord.Text;
            ditPersoon.Rol = GebruikersrolVanCombo();
            Personeel.list.Add(ditPersoon);
            SlaLijstOp();
            updateLvw();
        }

        private void lvwPersoneel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPersoneel.SelectedIndices.Count != 0)
            {
                txtGebruikersnaam.Text = Personeel.list[lvwPersoneel.SelectedIndices[0]].Gebruikersnaam;
                txtWachtwoord.Text = Personeel.list[lvwPersoneel.SelectedIndices[0]].Wachtwoord;
                cmbFunctie.SelectedIndex = ComboVanGebruikersrol(Personeel.list[lvwPersoneel.SelectedIndices[0]]);
            }
            else
            {
                txtGebruikersnaam.Clear();
                txtWachtwoord.Clear();
                FillComboBox();
            }
        }
        private void FillComboBox()
        {
            cmbFunctie.Items.Clear();
            cmbFunctie.Items.Add("Werknemer");
            cmbFunctie.Items.Add("Manager");
            cmbFunctie.Items.Add("CEO");
            cmbFunctie.Items.Add("Non-Actief");
        }

        private int ComboVanGebruikersrol(Personeel dezeRol)
        {
            int dezeIndex = 0;
            switch (dezeRol.Rol.ToString())
            {
                case "Werknemer":
                    dezeIndex = 0;
                    break;
                case "Manager":
                    dezeIndex = 1;
                    break;
                case "CEO":
                    dezeIndex = 2;
                    break;
                case "Non_actief":
                    dezeIndex = 3;
                    break;
                default:
                    break;
            }
            return dezeIndex;
        }

        private Gebruikersrol GebruikersrolVanCombo()
        {
            Gebruikersrol Rol = Gebruikersrol.Non_actief;
            switch (cmbFunctie.Text)
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
                case "Non-Actief":
                    Rol = Gebruikersrol.Non_actief;
                    break;
                default:
                    break;
            }
            return Rol;
        }
        private void SlaLijstOp()
        {
            if (File.Exists("gebruikers.txt"))
            {
                using (StreamWriter writer = new StreamWriter("gebruikers.txt"))
                {
                    foreach (var item in Personeel.list)
                    {
                        writer.WriteLine($"{item.Gebruikersnaam}|{item.Voornaam}|{item.Achternaam}|{item.Wachtwoord}|{item.Rol}");
                    }
                }
            }
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(ingelogdeGebruiker.Gebruikersnaam);
            Personeel geselecteerdeGebruiker = Personeel.list[lvwPersoneel.SelectedIndices[0]];
            if (ingelogdeGebruiker.Equals(geselecteerdeGebruiker))
            {
                MessageBox.Show("U kan uzelf niet verwijderen!\nStel eerst een nieuwe CEO aan.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Personeel.list.RemoveAt(lvwPersoneel.SelectedIndices[0]);
                SlaLijstOp();
                updateLvw();
            }
        }
    }
}
