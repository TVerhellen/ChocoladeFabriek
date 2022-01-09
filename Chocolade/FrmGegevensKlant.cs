using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chocolade
{
    public partial class FrmGegevensKlant : Form
    {
        public FrmGegevensKlant()
        {
            InitializeComponent();
        }
        
        List<string[]> klanten = new List<string[]>();

        private void FrmGegevensKlant_Load(object sender, EventArgs e)
        {
            
            lblNaamBedrijf.Text = "";
            lblBtwNummer.Text = "";
            lblNaamPersoon.Text = "";
            lblTelefoonNr.Text = "";
            lblEmail.Text = "";
            lblFacturatieAdres.Text = "";
            lblLeveringsAdres.Text = "";
            StreamReader reader;
            var txtFiles = Directory.EnumerateFiles("Verkoop/Klanten", "*.txt");
            foreach (string currentFile in txtFiles)
            {
                using (reader = new StreamReader(currentFile))
                {
                    string[] klant = new string[7];
                    for (int i = 0; i < klant.Length; i++)
                    {
                        klant[i] = reader.ReadLine();
                    }
                    
                    klanten.Add(klant);
                    cmbKlanten.Items.Add(klant[0]);
                }
            }
        }

        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKlanten.SelectedIndex != -1)
            {
                string[] selectedKlant = klanten[cmbKlanten.SelectedIndex];
                lblNaamBedrijf.Text = selectedKlant[0];
                lblBtwNummer.Text = selectedKlant[1];
                lblNaamPersoon.Text = selectedKlant[2];
                lblTelefoonNr.Text = selectedKlant[3];
                lblEmail.Text = selectedKlant[4];
                lblFacturatieAdres.Text = selectedKlant[5];
                lblLeveringsAdres.Text = selectedKlant[6];
            }
        }
    }
}
