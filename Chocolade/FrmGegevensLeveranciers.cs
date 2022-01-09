using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmGegevensLeveranciers : Form
    {
        public FrmGegevensLeveranciers()
        {
            InitializeComponent();
        }

        Leverancier LeverancierGegevens = new Leverancier();
        List<Leverancier> mijnLeveranciers = new List<Leverancier>();
        int leverancierNummer = 1;
        string tekstGeselecteerdeLeverancier = "";

        private void GegevensLeveranciers_Load(object sender, System.EventArgs e)
        {
            cmbLeveranciers.Items.Add("- Geen leverancier geselecteerd -");
            InlezenBestand();

            foreach (var LeverancierGegevens in mijnLeveranciers)
            {
                cmbLeveranciers.Items.Add(leverancierNummer.ToString("0000") + ".".PadRight(3) + LeverancierGegevens.Naam);
                leverancierNummer++;
            }
            cmbLeveranciers.SelectedIndex = 0;
        }

        private void btnToevoegen_Click(object sender, System.EventArgs e)
        {


            if (cmbLeveranciers.SelectedIndex == 0)
            {
                LeverancierGegeven();
                NieuweLeveranciersMap("Catalogus");
                NieuweLeveranciersMap("Bestelorders");
                NieuweLeveranciersMap("Leveringsbonnen");
            }
            else
            {
                MessageBox.Show("Er mag geen leverancier geselecteerd zijn om een nieue leverancier toe te voegen.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWijzigen_Click(object sender, System.EventArgs e)
        {
            LeverancierGegeven();
        }

        private void btnTonen_Click(object sender, System.EventArgs e)
        {

        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {

        }
        private void cmbLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLeveranciers.SelectedIndex == 0)
            {
                txtLevNaam.Text = "";
                txtStraatNaam.Text = "";
                txtStraatNummer.Text = "";
                txtPostCode.Text = "";
                txtGemeente.Text = "";
                txtBtwNummer.Text = "";
                txtTelefoon.Text = "";
                txtEmail.Text = "";

                txtBtwNummer.Enabled = true;
            }
            else
            {
                txtLevNaam.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].Naam;
                txtStraatNaam.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].Straat;
                txtStraatNummer.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].StraatNummer;
                txtPostCode.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].Postcode;
                txtGemeente.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].Gemeente;
                txtBtwNummer.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].BTW;
                txtTelefoon.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].Telefoonnumer;
                txtEmail.Text = mijnLeveranciers[cmbLeveranciers.SelectedIndex - 1].Email;

                tekstGeselecteerdeLeverancier = txtLevNaam.Text;

                txtBtwNummer.Enabled = false;
            }
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

        public void LeverancierGegeven()
        {
            string naam;
            string straat;
            string straatNummer;
            string postcode;
            string gemeente;
            string btwNummer = "";
            string email = "";
            string telefoonnummer;
            string leverancierNummer;
            int btw = 0;
            string[] gegevensLeverancier;
            string[] tempGegevensLeverancier;

            if (cmbLeveranciers.SelectedIndex == 0)
            {
                leverancierNummer = (mijnLeveranciers.Count + 1).ToString("0000");
            }
            else
            {
                leverancierNummer = Convert.ToInt32(cmbLeveranciers.SelectedIndex).ToString("0000");

            }

            naam = txtLevNaam.Text;
            straat = txtStraatNaam.Text;
            straatNummer = txtStraatNummer.Text;
            postcode = txtPostCode.Text;
            gemeente = txtGemeente.Text;

            if ((txtBtwNummer.Text.Length == 9) || int.TryParse(txtBtwNummer.Text, out btw))
            {
                if (Convert.ToInt32(txtBtwNummer.Text.Replace(".", "").Substring(7, 2)) == (97 - (Convert.ToInt32(txtBtwNummer.Text.Replace(".", "").Substring(0, 6)) % 97)))
                {
                    btwNummer = txtBtwNummer.Text;
                }
                else
                {
                    MessageBox.Show("Btwnummer klopt niet, gelieve een correct BTW-nummer in te geven.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Btwnummer klopt niet, gelieve een correct BTW-nummer in te geven.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEmail.Text.Contains("@"))
            {
                email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Emailadres klopt niet, gelieve een correct emeiladres in te geven.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            telefoonnummer = txtTelefoon.Text;

            Leverancier LeverancierGegevens = new Leverancier(leverancierNummer, naam, straat, straatNummer, postcode, gemeente, btwNummer, email, telefoonnummer);
            gegevensLeverancier = new string[] { leverancierNummer.ToString(), naam, straat, straatNummer, postcode, gemeente, btwNummer, email, telefoonnummer };

            if (cmbLeveranciers.SelectedIndex == 0)
            {
                mijnLeveranciers.Add(LeverancierGegevens);
                cmbLeveranciers.Items.Add(leverancierNummer.ToString() + ".".PadRight(3) + LeverancierGegevens.Naam);
            }
            else
            {
                mijnLeveranciers.Insert(cmbLeveranciers.SelectedIndex, LeverancierGegevens);
                mijnLeveranciers.RemoveAt(cmbLeveranciers.SelectedIndex - 1);
                cmbLeveranciers.Items.Insert(cmbLeveranciers.SelectedIndex, leverancierNummer.ToString() + ".".PadRight(3) + LeverancierGegevens.Naam);
                cmbLeveranciers.Items.RemoveAt(cmbLeveranciers.SelectedIndex);


                if (Directory.Exists(@"Aankoop/Catalogus/" + LeverancierGegevens.LeverancierNummer + " " + tekstGeselecteerdeLeverancier))
                {
                    Directory.Move(@"Aankoop/Catalogus/" + LeverancierGegevens.LeverancierNummer + " " + tekstGeselecteerdeLeverancier, @"Aankoop/Catalogus/" + LeverancierGegevens.LeverancierNummer + " " + LeverancierGegevens.Naam);
                    Directory.Move(@"Aankoop/Bestelorders/" + LeverancierGegevens.LeverancierNummer + " " + tekstGeselecteerdeLeverancier, @"Aankoop/Bestelorders/" + LeverancierGegevens.LeverancierNummer + " " + LeverancierGegevens.Naam);
                    Directory.Move(@"Aankoop/Leveringsbonnen/" + LeverancierGegevens.LeverancierNummer + " " + tekstGeselecteerdeLeverancier, @"Aankoop/Leveringsbonnen/" + LeverancierGegevens.LeverancierNummer + " " + LeverancierGegevens.Naam);
                }
            }

            if (File.Exists("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Aankoop/Leveranciergegevens/Leveranciergegevens.txt"))
                {
                    if (mijnLeveranciers.Count != 1)
                    {
                        for (int i = 0; i < mijnLeveranciers.Count + 1; i++)
                        {
                            if (i == 0)
                            {
                                writer.WriteLine("- Geen leverancier geselecteerd -");
                            }
                            else
                            {
                                tempGegevensLeverancier = new string[] { mijnLeveranciers[i - 1].LeverancierNummer.ToString(), mijnLeveranciers[i - 1].Naam, mijnLeveranciers[i - 1].Straat, mijnLeveranciers[i - 1].StraatNummer, mijnLeveranciers[i - 1].Postcode, mijnLeveranciers[i - 1].Gemeente, mijnLeveranciers[i - 1].BTW, mijnLeveranciers[i - 1].Email, mijnLeveranciers[i - 1].Telefoonnumer };
                                writer.WriteLine(string.Join(";", tempGegevensLeverancier));
                            }
                        }
                    }
                    else
                    {
                        writer.WriteLine("- Geen leverancier geselecteerd -");
                        writer.WriteLine(string.Join(";", gegevensLeverancier));
                    }
                }
            }

            txtLevNaam.Text = "";
            txtStraatNaam.Text = "";
            txtStraatNummer.Text = "";
            txtPostCode.Text = "";
            txtGemeente.Text = "";
            txtBtwNummer.Text = "";
            txtTelefoon.Text = "";
            txtEmail.Text = "";
            cmbLeveranciers.SelectedIndex = 0;

        }

        public void NieuweLeveranciersMap(string folderNaam)
        {
            string folderPath = @"Aankoop/" + folderNaam;

            if (!Directory.Exists(folderPath + "/" + LeverancierGegevens.LeverancierNummer + " " + LeverancierGegevens.Naam))
            {
                Directory.CreateDirectory(folderPath + "/" + LeverancierGegevens.LeverancierNummer + " " + LeverancierGegevens.Naam);
            }
        }

        private void CreateDirectory()
        {
            throw new NotImplementedException();
        }
    }
}
