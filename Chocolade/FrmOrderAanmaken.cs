using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

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
        string[] tempArtikelLijn = new string[4];
        DisplayArtikel bestellijst = new DisplayArtikel();
        List<DisplayArtikel> bestelCatalogus = new List<DisplayArtikel>();
        ArrayList displayCatalogus = new ArrayList();
        ArrayList displayBestelOrder = new ArrayList();
        string[] arrTempBestellijst = new string[4];
        string fileName;
        string filePath;
        string[] tempOrderLeverancier;
        ArrayList startElementenCatalogus = new ArrayList();

        private void FrmOrderAanmaken_Load(object sender, System.EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            txtDatum.Text = vandaag.ToString("dd/MM/yyyy");
            lblTotalePrijs.Text = "0,00";
            lblTotaleHoeveelheidInput.Text = "0,00";

            InlezenBestand();

        }
        private void btnSelecteerBestand_Click(object sender, EventArgs e)
        {
            openBestelCatalogus.ShowDialog();
            fileName = openBestelCatalogus.FileName;
            txtPadBestand.Text = System.IO.Path.GetDirectoryName(openBestelCatalogus.FileName).ToString();
            filePath = openBestelCatalogus.InitialDirectory.ToString();
            string leveranciersmap = txtPadBestand.Text.Substring(txtPadBestand.Text.LastIndexOf("\\") + 1).Substring(0, 4);

            foreach (var leverancierGegevens in mijnLeveranciers)
            {
                if (leveranciersmap == leverancierGegevens.LeverancierNummer)
                {
                    txtLeverancierNummer.Text = leverancierGegevens.LeverancierNummer;
                    txtLeveranciersNaam.Text = leverancierGegevens.Naam;
                    txtBtw.Text = leverancierGegevens.BTW; ;
                    txtGemeente.Text = leverancierGegevens.Gemeente;
                    txtStraatnaam.Text = leverancierGegevens.Straat;
                    txtStraatnummer.Text = leverancierGegevens.StraatNummer;
                    txtPostCode.Text = leverancierGegevens.Postcode;
                }
            }
        }
        private void btnImporteerBestand_Click(object sender, System.EventArgs e)
        {
            string pad = filePath + fileName;
            InlezenXmlBestand(pad);

            btnImporteerBestand.Enabled = false;
            btnSelecteerBestand.Enabled = false;
            txtPadBestand.Clear();
        }
        private void btnArtikelToevoegen_Click(object sender, EventArgs e)
        {
            double hoeveelheid;

            if (lvCatalogus.SelectedItems.Count > 0)
            {
                if (double.TryParse(txtHoeveelheid.Text, out hoeveelheid) && !string.IsNullOrEmpty(txtHoeveelheid.Text))
                {
                    foreach (string[] item in displayCatalogus)
                    {
                        if (lvCatalogus.SelectedItems[0].Text.ToString() == item[0])
                        {
                            double totalePrijs;

                            totalePrijs = hoeveelheid * Convert.ToDouble(item[4]);
                            ListViewItem newItem = new ListViewItem(tempOrderLeverancier = new string[] { item[0].ToString(), item[1].ToString(), item[2].ToString(), hoeveelheid.ToString("0.00"), item[3].ToString(), item[4].ToString(), totalePrijs.ToString("0.00") });
                            lvOrderAanmaken.Items.Add(newItem);
                            displayBestelOrder.Add(tempOrderLeverancier);
                            lblTotalePrijs.Text = (Convert.ToDouble(lblTotalePrijs.Text) + totalePrijs).ToString("0.00");
                            lblTotaleHoeveelheidInput.Text = (Convert.ToDouble(lblTotaleHoeveelheidInput.Text) + hoeveelheid).ToString("0.00");
                            txtHoeveelheid.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Uw ingave is niet numeriek of is leeg. Gelieve een hoeveelheid in te vullen.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("U heeft geen artikel geselecteerd. Graag een artikel selecteren om een bestelling te kunnen plaatsen.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLijnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lvOrderAanmaken.SelectedItems.Count > 0)
            {
                int geselecteerdeIndex = lvOrderAanmaken.FocusedItem.Index;
                int index = 0;
                int teller = 0;

                lvOrderAanmaken.Items.Clear();
                lblTotalePrijs.Text = "0,00";
                lblTotaleHoeveelheidInput.Text = "0,00";

                foreach (string[] item in displayBestelOrder)
                {
                    if (geselecteerdeIndex != teller)
                    {
                        ListViewItem newItem = new ListViewItem(tempOrderLeverancier = new string[] { item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString() });
                        lvOrderAanmaken.Items.Add(newItem);
                        lblTotalePrijs.Text = (Convert.ToDouble(lblTotalePrijs.Text) + Convert.ToDouble(item[6])).ToString("0.00");
                        lblTotaleHoeveelheidInput.Text = (Convert.ToDouble(lblTotaleHoeveelheidInput.Text) + Convert.ToDouble(item[3])).ToString("0.00");
                        txtHoeveelheid.Clear();
                    }
                    else
                    {
                        index = displayBestelOrder.IndexOf(item);
                    }
                    teller++;
                }
                displayBestelOrder.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("U heeft geen lijn geselecteerd om te verwijderen.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOrderPlaatsen_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            string bestelReferentie;
            string geselecteerdeLeverancier = txtLeveranciersNaam.Text;
            string datumGewensteBestelling;

            if (lvOrderAanmaken.Items.Count > 0)
            {
                bestelReferentie = generator.Next(10000, 99000).ToString();
                datumGewensteBestelling = dtpDatumOrder.Value.ToString("dd/MM/yyyy");

                InlezenBestand();

                using (XmlWriter writer = XmlWriter.Create(Environment.CurrentDirectory + @"\Aankoop\Bestelorders\" + txtLeverancierNummer.Text + " " + geselecteerdeLeverancier + "\\" + "Ref" + bestelReferentie + ".xml"))
                {
                    writer.WriteStartElement("Bestelorders");
                    writer.WriteAttributeString("Bestelreferentie", "Ref" + bestelReferentie);
                    writer.WriteAttributeString("Datumvandaag", DateTime.Now.ToShortTimeString());
                    foreach (string[] artikel in displayBestelOrder)
                    {
                        writer.WriteStartElement("Bestelorder");
                        writer.WriteElementString(startElementenCatalogus[2].ToString(), artikel[0].ToString());
                        writer.WriteElementString("Hoeveelheid", artikel[3].ToString());
                        writer.WriteElementString("Gewensteleverdatum", datumGewensteBestelling.ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                lvCatalogus.Items.Clear();
                lvOrderAanmaken.Items.Clear();
                DataReset();
            }
            else
            {
                MessageBox.Show("Er zijn nog geen artikels toegevoegd", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lvCatalogus.Items.Clear();
            DataReset();
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            lvOrderAanmaken.Items.Clear();
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
        public void InlezenXmlBestand(string pad)
        {
            int controleGetal = 2;

            using (XmlReader xmlBestelCatalogus = XmlReader.Create(pad))
            {
                while (xmlBestelCatalogus.Read())
                {
                    if (xmlBestelCatalogus.NodeType == XmlNodeType.Element)
                    {
                        if (controleGetal > 1 && controleGetal < 6)
                        {
                            startElementenCatalogus.Add(xmlBestelCatalogus.Name);
                        }
                    }
                    else if (xmlBestelCatalogus.NodeType == XmlNodeType.Text)
                    {
                        switch (controleGetal)
                        {
                            //case (1):
                            //    controleGetal = 2;
                            //    break;
                            case (2):
                                arrTempBestellijst[0] = xmlBestelCatalogus.Value;
                                bestellijst.ArtikelNummer = xmlBestelCatalogus.Value.ToString();
                                controleGetal = 3;
                                break;
                            case (3):
                                arrTempBestellijst[2] += xmlBestelCatalogus.Value;
                                bestellijst.Kwaliteit = xmlBestelCatalogus.Value;
                                controleGetal = 4;
                                break;
                            case (4):
                                arrTempBestellijst[1] = xmlBestelCatalogus.Value;
                                bestellijst.Soort += xmlBestelCatalogus.Value;
                                controleGetal = 5;
                                break;
                            case (5):
                                arrTempBestellijst[3] = xmlBestelCatalogus.Value;
                                bestellijst.Prijs = Convert.ToDouble(xmlBestelCatalogus.Value.Replace(".", ","));

                                ListViewItem newItem = new ListViewItem(tempOrderLeverancier = new string[] { arrTempBestellijst[0], arrTempBestellijst[1], arrTempBestellijst[2], "kg", arrTempBestellijst[3].Replace(".", ",") });
                                bestelCatalogus.Add(bestellijst);
                                lvCatalogus.Items.Add(newItem);
                                displayCatalogus.Add(tempOrderLeverancier);
                                Array.Clear(arrTempBestellijst, 0, arrTempBestellijst.Length);
                                controleGetal = 2;
                                break;
                            //case (6):
                            //    controleGetal = 7;
                            //    break;
                            //case (7):
                            //    controleGetal = 8;
                            //    break;
                            //case (8):
                            //    controleGetal = 9;
                            //    break;
                            //case (9):
                            //    controleGetal = 1;
                            //    break;
                            default:
                                break;
                        }

                    }
                    else if (xmlBestelCatalogus.NodeType == XmlNodeType.EndElement)
                    {

                    }
                }
            }
        }
        public void DataReset()
        {
            btnImporteerBestand.Enabled = true;
            btnSelecteerBestand.Enabled = true;
            txtLeverancierNummer.Text = "";
            txtLeveranciersNaam.Text = "";
            txtBtw.Text = "";
            txtGemeente.Text = "";
            txtStraatnaam.Text = "";
            txtStraatnummer.Text = "";
            txtPostCode.Text = "";
            dtpDatumOrder.Value = DateTime.Now;
        }

    }
}
