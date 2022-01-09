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

            cmbArtikelnummer.Items.Add("- Geen artikel geselecteerd -");

            cmbArtikelnummer.SelectedIndex = 0;
            InlezenArtikelGegevens();
        }
        private void lvArtikelOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvArtikelOverzicht.SelectedItems != null)
            {
                if (lvArtikelOverzicht.FocusedItem.Index != -1)
                {
                    cmbArtikelnummer.SelectedIndex = lvArtikelOverzicht.FocusedItem.Index + 1;
                }

            }
        }
        private void cmbArtikelnummer_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in aankoopArtikels)
            {
                if (cmbArtikelnummer.SelectedIndex > 0)
                {
                    if (cmbArtikelnummer.SelectedIndex.ToString("0000") == item.EigenArtikelnummer)
                    {
                        txtArtikelnaam.Text = item.EigenArtikelnaam;
                        txtRekeningnummer.Text = item.RekeningNummer;
                        if (item.BtwPercentage == "6")
                        {
                            rdnBtw6.Checked = true;
                        }
                        else
                        {
                            rdnBtw21.Checked = true;
                        }
                        txtPrijs.Text = item.Prijs.ToString("0.00");
                        txtHoofdleverancier.Text = item.HoofdLeverancier;
                        txtArtikelNummerLev.Text = item.ArtikelNummer;
                        if (item.Kwaliteit == "01")
                        {
                            cmbKwaliteit.SelectedIndex = 0;
                        }
                        else if (item.Kwaliteit == "02")
                        {
                            cmbKwaliteit.SelectedIndex = 1;
                        }
                        else if (item.Kwaliteit == "03")
                        {
                            cmbKwaliteit.SelectedIndex = 2;
                        }
                        else
                        {
                            cmbKwaliteit.SelectedIndex = 3;
                        }
                        if (item.Soort == "11")
                        {
                            cmbSoort.SelectedIndex = 0;
                        }
                        else if (item.Soort == "12")
                        {
                            cmbSoort.SelectedIndex = 1;
                        }
                        else if (item.Soort == "13")
                        {
                            cmbSoort.SelectedIndex = 2;
                        }
                        else
                        {
                            cmbSoort.SelectedIndex = 3;
                        }
                    }
                }
                else
                {
                    Reset();
                }
            }

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
            if (cmbArtikelnummer.SelectedIndex == 0)
            {
                Artikels();
            }
            else
            {
                MessageBox.Show("error.");
            }
        }
        private void btnArtikelWijzigen_Click(object sender, EventArgs e)
        {
            Artikels();
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
        public void Artikels()
        {
            string artikelNummerEigen = "";
            string artikelNaamEigen = "";
            string rekeningNummer = "";
            string prijsPerKg = "";
            string hoofdLeverancier = "";
            string artikelNummerLeverancier = "";
            string btw = "";
            string[] arrNieuwArtikel;
            string[] arrGewijzigdArtikel;

            try
            {
                if (cmbArtikelnummer.SelectedIndex == 0)
                {
                    artikelNummerEigen = (cmbArtikelnummer.Items.Count).ToString("0000");
                }
                else
                {
                    artikelNummerEigen = (cmbArtikelnummer.SelectedIndex).ToString("0000");
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
                    throw new Exception("Er is geen Btw-selectie gemaakt.");
                }

                if (cmbKwaliteit.SelectedIndex == -1 || cmbSoort.SelectedIndex == -1)
                {
                    throw new Exception("Er is geen kwaliteit of soort geselecteerd.");
                }

                rekeningNummer = txtRekeningnummer.Text;

                if (double.TryParse((txtPrijs.Text), out double prijs))
                {
                    prijsPerKg = prijs.ToString("0.00");
                }

                if (cmbSelectieLeverancier.SelectedIndex > 0)
                {
                    hoofdLeverancier = txtHoofdleverancier.Text;
                }
                else
                {
                    throw new Exception("Er is geen hoofdleverancier geselecteerd.");
                }

                artikelNummerLeverancier = txtArtikelNummerLev.Text;

                if (txtArtikelnaam.Text == "" || txtArtikelNummerLev.Text == "" || txtPrijs.Text == "" || txtRekeningnummer.Text == "")
                {
                    throw new Exception("Niet alle vakken zijn ingevuld.");
                }

                DisplayArtikel nieuwAankoopArtikel = new DisplayArtikel(artikelNummerEigen, artikelNaamEigen, kwaliteitsReferentie, soortReferentie, prijsPerKg, hoofdLeverancier, artikelNummerLeverancier, rekeningNummer, btw);
                ListViewItem item = new ListViewItem(arrNieuwArtikel = new string[] { artikelNummerEigen, artikelNaamEigen, kwaliteitsReferentie, soortReferentie, prijsPerKg, hoofdLeverancier, artikelNummerLeverancier, rekeningNummer, btw });

                if (cmbArtikelnummer.SelectedIndex != 0)
                {
                    lvArtikelOverzicht.Items.Insert(cmbArtikelnummer.SelectedIndex - 1, item);
                    lvArtikelOverzicht.Items.RemoveAt(cmbArtikelnummer.SelectedIndex);
                }
                else
                {
                    lvArtikelOverzicht.Items.Add(item);
                    aankoopArtikels.Add(nieuwAankoopArtikel);
                    cmbArtikelnummer.Items.Add(nieuwAankoopArtikel.EigenArtikelnummer + " " + nieuwAankoopArtikel.EigenArtikelnaam);
                }

                string bestaandeArtikels = "";

                if (File.Exists("Aankoop/Artikelgegevens.txt"))
                {
                    using (StreamReader reader = new StreamReader("Aankoop/Artikelgegevens.txt"))
                    {
                        while (!reader.EndOfStream)
                        {
                            if (cmbArtikelnummer.SelectedIndex == 0 || lvArtikelOverzicht.FocusedItem.Index == -1)
                            {
                                bestaandeArtikels += reader.ReadLine() + Environment.NewLine;
                            }
                            else
                            {
                                arrGewijzigdArtikel = reader.ReadLine().Split("|");
                                string temp = arrGewijzigdArtikel[0];
                                string temp2 = cmbArtikelnummer.Text.Substring(0, 4);

                                if ((temp2 == temp))
                                {
                                    bestaandeArtikels += string.Join("|", arrNieuwArtikel) + Environment.NewLine;
                                }
                                else
                                {
                                    bestaandeArtikels += string.Join("|", arrGewijzigdArtikel) + Environment.NewLine;
                                }
                            }
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter("Aankoop/Artikelgegevens.txt"))
                {
                    if (cmbArtikelnummer.SelectedIndex == 0)
                    {
                        writer.Write(bestaandeArtikels);
                        writer.WriteLine(string.Join("|", arrNieuwArtikel));
                    }
                    else
                    {
                        writer.Write(bestaandeArtikels);
                    }

                }
                cmbArtikelnummer.Items.Clear();
                InlezenArtikelGegevens();

                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void InlezenArtikelGegevens()
        {
            if (File.Exists("Aankoop/Artikelgegevens.txt"))
            {
                string[] bestaandArtikel;

                using (StreamReader reader = new StreamReader("Aankoop/Artikelgegevens.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        bestaandArtikel = reader.ReadLine().Split("|");
                        DisplayArtikel bestaandArtikels = new DisplayArtikel(bestaandArtikel[0], bestaandArtikel[1], bestaandArtikel[2], bestaandArtikel[3], bestaandArtikel[4], bestaandArtikel[5], bestaandArtikel[6], bestaandArtikel[7], bestaandArtikel[8]);
                        cmbArtikelnummer.Items.Add(bestaandArtikels.EigenArtikelnummer + " " + bestaandArtikels.EigenArtikelnaam);
                        aankoopArtikels.Add(bestaandArtikels);

                        if (cmbArtikelnummer.SelectedIndex == 0)
                        {
                            ListViewItem item = new ListViewItem(bestaandArtikel);
                            lvArtikelOverzicht.Items.Add(item);
                        }


                    }
                }
            }
        }
        public void Reset()
        {
            txtArtikelnaam.Text = "";
            txtArtikelNummerLev.Text = "";
            txtHoofdleverancier.Text = "";
            txtPrijs.Text = "";
            txtRekeningnummer.Text = "";
            rdnBtw21.Checked = false;
            rdnBtw6.Checked = false;
            cmbKwaliteit.Text = "";
            cmbSoort.Text = "";
            cmbSelectieLeverancier.SelectedIndex = 0;
        }

        private void btnHoofdMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
