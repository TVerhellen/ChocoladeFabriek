using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmAankoopArtikels : Form
    {
        public FrmAankoopArtikels()
        {
            InitializeComponent();
        }
        Leverancier LeverancierGegevens = new Leverancier();
        List<Leverancier> mijnLeveranciers = new List<Leverancier>();
        DisplayArtikel AankoopArtikel = new DisplayArtikel();
        List<DisplayArtikel> aankoopArtikels = new List<DisplayArtikel>();
        string kwaliteitsReferentie = "";
        string soortReferentie = "";
        int leverancierNummer = 1;
        private void FrmAankoopArtikels_Load(object sender, EventArgs e)
        {
            cmbSelectieLeverancier.Items.Add("- Geen leverancier geselecteerd -");
            InlezenBestand();

            foreach (var LeverancierGegevens in mijnLeveranciers)
            {
                cmbSelectieLeverancier.Items.Add(leverancierNummer.ToString("0000") + ".".PadRight(3) + LeverancierGegevens.Naam);
                leverancierNummer++;
            }
            cmbSelectieLeverancier.SelectedIndex = 0;
        }
        private void cmbKwaliteit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbKwaliteit.SelectedIndex + 1)
            {
                case 1:
                    kwaliteitsReferentie = "01";
                    break;
                case 2:
                    kwaliteitsReferentie = "02";
                    break;
                case 3:
                    kwaliteitsReferentie = "03";
                    break;
                case 4:
                    kwaliteitsReferentie = "04";
                    break;

                default:
                    break;
            }
        }
        private void cmbSoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSoort.SelectedIndex + 1)
            {
                case 1:
                    soortReferentie = "11";
                    break;
                case 2:
                    soortReferentie = "12";
                    break;
                case 3:
                    soortReferentie = "13";
                    break;
                case 4:
                    soortReferentie = "14";
                    break;

                default:
                    break;
            }
        }
        private void cmbSelectieLeverancier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectieLeverancier.SelectedIndex > 0)
            {
                txtHoofdleverancier.Text = cmbSelectieLeverancier.Text.Substring(cmbSelectieLeverancier.Text.LastIndexOf(".") + 2);
            }
        }
        private void btnArtikelAanmaken_Click(object sender, EventArgs e)
        {

            string artikelNummerEigen = "";
            string artikelNaamEigen = "";
            string rekeningNummer = "";
            string prijsPerKg = "";
            string hoofdLeverancier = "";
            string artikelNummerLeverancier = "";
            string btw = "";
            string[] arrNieuwArtikel;

            if (cmbArtikelnummer.Items.Count < 2)
            {
                artikelNummerEigen = (cmbArtikelnummer.Items.Count).ToString("0000");
            }
            else
            {
                artikelNummerEigen = (cmbArtikelnummer.Items.Count + 1).ToString("0000");
            }

            artikelNaamEigen = txtArtikelnaam.Text;

            if (rdnBtw6.Checked || rdnBtw21.Checked)
            {
                if (rdnBtw6.Checked)
                {
                    btw = "6";
                }
                else
                {
                    btw = "21";
                }
            }
            else
            {
                MessageBox.Show("Er is geen Btw-selectie gemaakt", "Fout", MessageBoxButtons.OK);
            }


            rekeningNummer = txtRekeningnummer.Text;

            if (double.TryParse((txtPrijs.Text), out double prijs))
            {
                prijsPerKg = prijs.ToString("0.00");
            }

            hoofdLeverancier = txtHoofdleverancier.Text;



            DisplayArtikel nieuwAankoopArtikel = new DisplayArtikel(artikelNummerEigen, artikelNaamEigen, kwaliteitsReferentie, soortReferentie, prijsPerKg, hoofdLeverancier, artikelNummerLeverancier, rekeningNummer, btw);
            ListViewItem item = new ListViewItem(arrNieuwArtikel = new string[] { artikelNummerEigen, artikelNaamEigen, kwaliteitsReferentie, soortReferentie, prijsPerKg, hoofdLeverancier, artikelNummerLeverancier, rekeningNummer });
            lvArtikelOverzicht.Items.Add(item);
        }

        public void InlezenBestand()
        {
            string[] tempGegevensLeverancier;
            if (File.Exists("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
            {
                using (StreamReader reader = new StreamReader("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        tempGegevensLeverancier = reader.ReadLine().Split(";");
                        if (tempGegevensLeverancier.Length > 1)
                        {
                            LeverancierGegevens = new Leverancier(Convert.ToInt32(tempGegevensLeverancier[0]).ToString("0000"), tempGegevensLeverancier[1], tempGegevensLeverancier[2], tempGegevensLeverancier[3], tempGegevensLeverancier[4], tempGegevensLeverancier[5], tempGegevensLeverancier[6], tempGegevensLeverancier[7], tempGegevensLeverancier[8]);
                            mijnLeveranciers.Add(LeverancierGegevens);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
                {
                    writer.WriteLine("- Geen leverancier geselecteerd -");
                }
            }

        }
    }
}
