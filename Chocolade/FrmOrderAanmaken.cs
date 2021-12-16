using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmOrderAanmaken : Form
    {
        public FrmOrderAanmaken()
        {
            InitializeComponent();
        }
        Leverancier LeverancierGegevens = new Leverancier();
        List<Leverancier> mijnLeveranciers = new List<Leverancier>();
        string[] tempArtikelLijn;
        private void FrmOrderAanmaken_Load(object sender, System.EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            txtDatum.Text = vandaag.ToString("dd/MM/yyyy");
            lblTotalePrijs.Text = "0,00";
            lblTotaleHoeveelheidInput.Text = "0,00";
            int leverancierNummer = 1;

            cmbLeverancier.Items.Add("- Geen leverancier geselecteerd -");
            InlezenBestand();

            foreach (var LeverancierGegevens in mijnLeveranciers)
            {
                cmbLeverancier.Items.Add(leverancierNummer.ToString() + ".".PadRight(3) + LeverancierGegevens.Naam);
                leverancierNummer++;
            }
            cmbLeverancier.SelectedIndex = 0;
        }

        private void btnImporteerBestand_Click(object sender, System.EventArgs e)
        {
            InlezenBestandLeverancier();

            if (!string.IsNullOrEmpty(tempArtikelLijn[0]))
            {
                btnImporteerBestand.Enabled = false;
            }
        }

        private void btnArtikelToevoegen_Click(object sender, EventArgs e)
        {
            if (lvCatalogus.Items.Count > 1)
            {
                if (lvCatalogus.SelectedItems.Count > 0)
                {
                    InlezenBestandLeverancier();
                    txtHoeveelheid.Text = "";
                }
                else
                {
                    MessageBox.Show("Gelieve een artikel te selecteren in het artikeloverzicht.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gelieve eerst een artikelbestand te importeren.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrderPlaatsen_Click(object sender, EventArgs e)
        {
            string fileNaam;
            if (lvOrderAanmaken.Items.Count > 0 && cmbLeverancier.SelectedIndex != 0)
            {
                fileNaam = "bon.txt";
                using (StreamWriter writer = new StreamWriter("Aankoop/Bestelorders/" + fileNaam))
                {
                    writer.Write(orderLeverancier);
                }

                cmbLeverancier.SelectedIndex = 0;
                lvCatalogus.Items.Clear();
                lvOrderAanmaken.Items.Clear();
                btnImporteerBestand.Enabled = true;
            }
            else
            {
                MessageBox.Show("Er is geen leverancier en/of artikels geselecteerd", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLijnVerwijderen_Click(object sender, EventArgs e)
        {
            string[] tempSelectedItem;
            int temp;
            if (lvOrderAanmaken.SelectedItems.Count > 0)
            {
                temp = lvOrderAanmaken.FocusedItem.Index;
                lvOrderAanmaken.Items.Clear();
                lblTotalePrijs.Text = "0,00";
                lblTotaleHoeveelheidInput.Text = "0,00";

                using (StreamWriter writer = new StreamWriter("Tempfile.txt"))
                {
                    writer.Write(orderLeverancier);
                }

                using (StreamReader reader = new StreamReader("Tempfile.txt"))
                {
                    orderLeverancier = "";
                    for (int i = 0; i < File.ReadAllLines("Tempfile.txt").Length; i++)
                    {
                        tempSelectedItem = reader.ReadLine().Split(";");

                        if (i != temp)
                        {
                            ListViewItem newItem = new ListViewItem(tempOrderLeverancier = new string[] { tempSelectedItem[0], tempSelectedItem[1], tempSelectedItem[2], tempSelectedItem[3], tempSelectedItem[4], tempSelectedItem[5] });
                            lvOrderAanmaken.Items.Add(newItem);
                            orderLeverancier += string.Join(";", tempOrderLeverancier) + Environment.NewLine;
                            double totalePrijs = Convert.ToDouble(tempSelectedItem[2]) * Convert.ToDouble(tempSelectedItem[4].Substring(0, tempSelectedItem[4].IndexOf(" ")));
                            lblTotalePrijs.Text = (Convert.ToDouble(lblTotalePrijs.Text) + totalePrijs).ToString("0.00");
                            lblTotaleHoeveelheidInput.Text = (Convert.ToDouble(lblTotaleHoeveelheidInput.Text) + Convert.ToDouble(tempSelectedItem[2])).ToString("0.00");
                        }
                    }
                }
                File.Delete("Tempfile.txt");
            }
            else
            {
                MessageBox.Show("U heeft geen lijn geselecteerd om te verwijderen.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cmbLeverancier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLeverancier.SelectedIndex == 0)
            {
                txtBtw.Text = "";
                txtGemeente.Text = "";
                txtStraatnaam.Text = "";
                txtStraatnummer.Text = "";
                txtPostCode.Text = "";
            }
            else
            {
                txtBtw.Text = mijnLeveranciers[cmbLeverancier.SelectedIndex - 1].BTW; ;
                txtGemeente.Text = mijnLeveranciers[cmbLeverancier.SelectedIndex - 1].Gemeente;
                txtStraatnaam.Text = mijnLeveranciers[cmbLeverancier.SelectedIndex - 1].Straat;
                txtStraatnummer.Text = mijnLeveranciers[cmbLeverancier.SelectedIndex - 1].StraatNummer;
                txtPostCode.Text = mijnLeveranciers[cmbLeverancier.SelectedIndex - 1].Postcode;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lvCatalogus.Items.Clear();
            btnImporteerBestand.Enabled = true;
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            lvOrderAanmaken.Items.Clear();
        }

        string[] tempOrderLeverancier;
        string orderLeverancier = "";
        public void InlezenBestandLeverancier()
        {
            double hoeveelheid;

            using (StreamReader reader = new StreamReader("Aankoop/Catalogus/Catalogus.txt"))
            {
                for (int i = 0; i < File.ReadAllLines("Aankoop/Catalogus/Catalogus.txt").Length; i++)
                {
                    tempArtikelLijn = reader.ReadLine().Split(";");

                    if (lvCatalogus.Items.Count < File.ReadAllLines("Aankoop/Catalogus/Catalogus.txt").Length)
                    {
                        ListViewItem theNewItem = new ListViewItem(new string[] { tempArtikelLijn[0], tempArtikelLijn[1], "Kg", Convert.ToDouble(tempArtikelLijn[2]).ToString("0.00") + " €" });
                        lvCatalogus.Items.Add(theNewItem);
                    }
                    else if (tempArtikelLijn[0] == lvCatalogus.SelectedItems[0].Text)
                    {
                        if (double.TryParse(txtHoeveelheid.Text, out hoeveelheid) && !string.IsNullOrEmpty(txtHoeveelheid.Text))
                        {
                            ListViewItem newItem = new ListViewItem(tempOrderLeverancier = new string[] { tempArtikelLijn[0], tempArtikelLijn[1], hoeveelheid.ToString("0.00"), "Kg", Convert.ToDouble(tempArtikelLijn[2]).ToString("0.00") + " €", (hoeveelheid * Convert.ToDouble(tempArtikelLijn[2])).ToString("0.00") + " €" });
                            lvOrderAanmaken.Items.Add(newItem);
                            orderLeverancier += string.Join(";", tempOrderLeverancier) + Environment.NewLine;
                            double totalePrijs = hoeveelheid * Convert.ToDouble(tempArtikelLijn[2]);
                            lblTotalePrijs.Text = (Convert.ToDouble(lblTotalePrijs.Text) + totalePrijs).ToString("0.00");
                            lblTotaleHoeveelheidInput.Text = (Convert.ToDouble(lblTotaleHoeveelheidInput.Text) + hoeveelheid).ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("Uw ingave is niet numeriek of is leeg. Gelieve een getal in te vullen.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
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
                            LeverancierGegevens = new Leverancier(Convert.ToInt32(tempGegevensLeverancier[0]), tempGegevensLeverancier[1], tempGegevensLeverancier[2], tempGegevensLeverancier[3], tempGegevensLeverancier[4], tempGegevensLeverancier[5], tempGegevensLeverancier[6], tempGegevensLeverancier[7], tempGegevensLeverancier[8]);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
