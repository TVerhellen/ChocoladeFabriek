using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Chocolade
{
    public partial class FrmOrderVerwerken : Form
    {
        public FrmOrderVerwerken()
        {
            InitializeComponent();
        }
        string fileName;
        string bestelReferentie;
        string filePath;
        string leveranciersMapNaam;
        string grondstoffen;
        string[] arrLeverbonArtikels = new string[6];
        string[] tempLeverbon;
        string[] arrBestelorderLijst = new string[6];
        string[] tempBestelorder;
        string[] arrBestelbonVerwerking = new string[7];
        bool xmlIngelezen = false;
        DisplayArtikel leverbonArtikels = new DisplayArtikel();
        List<DisplayArtikel> Leverbon = new List<DisplayArtikel>();
        Leverancier LeverancierGegevens = new Leverancier();
        List<Leverancier> mijnLeveranciers = new List<Leverancier>();
        ArrayList arrLeverbonArt = new ArrayList();
        ArrayList artikelBestand = new ArrayList();
        ArrayList grondstoffenBestand = new ArrayList();

        private void FrmOrderVerwerken_Load(object sender, EventArgs e)
        {
            DateTime vandaag = new DateTime();
            txtDatum.Text = vandaag.ToString("dd/MM/yyyy");
            InlezenArtikelGegevens();
            InlezenBestand();
        }

        private void btnPadXmlBestand_Click(object sender, EventArgs e)
        {
            openLeveringsbon.ShowDialog();
            fileName = openLeveringsbon.FileName;
            txtXmlPad.Text = System.IO.Path.GetDirectoryName(openLeveringsbon.FileName).ToString();
            filePath = openLeveringsbon.InitialDirectory.ToString();
            leveranciersMapNaam = txtXmlPad.Text.Substring(txtXmlPad.Text.LastIndexOf("\\") + 1);
        }

        private void btnImporterenXml_Click(object sender, EventArgs e)
        {
            string pad = fileName;
            if (txtXmlPad.Text != "")
            {
                InlezenXmlBestand(pad);
                xmlIngelezen = true;
                if (xmlIngelezen)
                {

                    int controleGetal = 1;
                    pad = Environment.CurrentDirectory + @"\Aankoop\Bestelorders\" + leveranciersMapNaam + "\\" + bestelReferentie + ".xml";

                    using (XmlReader xmlBestelRef = XmlReader.Create(pad))
                    {
                        while (xmlBestelRef.Read())
                        {
                            if (xmlBestelRef.NodeType == XmlNodeType.Element)
                            {

                            }
                            else if (xmlBestelRef.NodeType == XmlNodeType.Text)
                            {
                                switch (controleGetal)
                                {
                                    case (1):
                                        arrBestelorderLijst[0] = xmlBestelRef.Value;

                                        foreach (string[] item in arrLeverbonArt)
                                        {
                                            if (item[0] == arrBestelorderLijst[0])
                                            {
                                                arrBestelorderLijst[1] = item[1];
                                                arrBestelorderLijst[2] = item[2];
                                                arrBestelorderLijst[3] = item[4];
                                            }
                                        }
                                        controleGetal = 2;
                                        break;
                                    case (2):
                                        arrBestelorderLijst[4] = xmlBestelRef.Value;
                                        arrBestelorderLijst[5] = (Convert.ToDouble(arrBestelorderLijst[3]) * Convert.ToDouble(arrBestelorderLijst[4])).ToString("0.00");

                                        ListViewItem newItem = new ListViewItem(tempBestelorder = new string[] { arrBestelorderLijst[0], arrBestelorderLijst[1], arrBestelorderLijst[2], arrBestelorderLijst[4], "kg", arrBestelorderLijst[3].Replace(".", ",").ToString() + " €", arrBestelorderLijst[5].ToString() + " €" });
                                        lvBestelorder.Items.Add(newItem);
                                        controleGetal = 3;
                                        break;
                                    case (3):
                                        controleGetal = 1;
                                        break;
                                    default:
                                        break;
                                }

                            }
                            else if (xmlBestelRef.NodeType == XmlNodeType.EndElement)
                            {

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Er is nog geen file geselecteerd.", "Fout", MessageBoxButtons.OK);
            }

            txtBestelref.Text = bestelReferentie;
            txtleverancier.Text = leveranciersMapNaam;
            btnImporterenXml.Enabled = false;
            btnPadXmlBestand.Enabled = false;

        }
        private void btnGoedkeuren_Click(object sender, EventArgs e)
        {
            string nieuwGronstof = "";
            int teller = 1;


            if (lvLeveringsbon.Items.Count > 0)
            {
                DialogResult = MessageBox.Show("Bent u zeker dat u deze bestelling wilt goedkeuren?", "Vraag", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    InlezenGrondstoffenBestand();

                    foreach (string[] items in arrLeverbonArt)
                    {
                        foreach (string[] item in artikelBestand)
                        {
                            if (item[0] == items[0])
                            {
                                if (teller < Leverbon.Count)
                                {
                                    nieuwGronstof += item[1] + "|" + item[2] + item[3] + DateTime.Today.ToString("ddMMyyyy") + "|" + items[3] + "|" + items[6].ToString() + Environment.NewLine;
                                    teller++;
                                    break;
                                }
                                else
                                {
                                    nieuwGronstof += item[1] + "|" + item[2] + item[3] + DateTime.Today.ToString("ddMMyyyy") + "|" + items[3] + "|" + items[6].ToString();
                                    break;
                                }
                            }
                        }
                    }

                    using (StreamWriter writer = new StreamWriter("Stock/Grondstoffen.txt"))
                    {
                        writer.WriteLine(grondstoffen + nieuwGronstof);
                    }

                    Grondstof.SorteerStockLijst();

                    grondstoffen = "";
                    nieuwGronstof = "";
                    txtBestelref.Text = "";
                    txtleverancier.Text = "";
                    txtXmlPad.Text = "";
                    btnImporterenXml.Enabled = true;
                    btnPadXmlBestand.Enabled = true;
                    lvBestelorder.Items.Clear();
                    lvLeveringsbon.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Er is nog geen xml geïmporteerd.", "fout", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Er is nog geen xml geïmporteerd.", "fout", MessageBoxButtons.OK);
            }
        }
        private void btnWeigeren_Click(object sender, EventArgs e)
        {
            if ((lvLeveringsbon.Items.Count > 0))
            {
                DialogResult = MessageBox.Show("Bent u zeker dat u deze bestelling wilt weigeren?", "Vraag", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    DialogResult = MessageBox.Show("Wilt u een mail sturen met opmerkingen naar de desbetreffende contactpersoon?", "Vraag", MessageBoxButtons.YesNo);

                    if (DialogResult == DialogResult.Yes)
                    {
                        foreach (var item in mijnLeveranciers)
                        {
                            if (leveranciersMapNaam.Substring(0, 4) == item.LeverancierNummer)
                            {
                                MessageBox.Show("Email contactpersoon: " + item.Email, "Email");

                            }
                        }
                    }

                    txtBestelref.Text = "";
                    txtleverancier.Text = "";
                    txtXmlPad.Text = "";
                    btnImporterenXml.Enabled = true;
                    btnPadXmlBestand.Enabled = true;
                    lvBestelorder.Items.Clear();
                    lvLeveringsbon.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Er is nog geen xml geïmporteerd.", "fout", MessageBoxButtons.OK);
            }

        }
        private void lvBestelorder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void InlezenXmlBestand(string bestandspad)
        {
            int controleGetal = 1;

            using (XmlReader xmxLeveringsbon = XmlReader.Create(bestandspad))
            {
                while (xmxLeveringsbon.Read())
                {
                    if (xmxLeveringsbon.NodeType == XmlNodeType.Element)
                    {
                        if (xmxLeveringsbon.GetAttribute("ordernummer") != null)
                        {
                            bestelReferentie = xmxLeveringsbon.GetAttribute("ordernummer");
                        }
                    }
                    else if (xmxLeveringsbon.NodeType == XmlNodeType.Text)
                    {
                        switch (controleGetal)
                        {
                            case (1):
                                controleGetal = 2;
                                break;
                            case (2):
                                arrLeverbonArtikels[0] = xmxLeveringsbon.Value;
                                leverbonArtikels.Kwaliteit = xmxLeveringsbon.Value;
                                controleGetal = 3;
                                break;
                            case (3):
                                arrLeverbonArtikels[1] = xmxLeveringsbon.Value;
                                leverbonArtikels.Prijs = Convert.ToDouble(xmxLeveringsbon.Value.Replace(".", ","));
                                controleGetal = 4;
                                break;
                            case (4):
                                arrLeverbonArtikels[2] = xmxLeveringsbon.Value;
                                leverbonArtikels.ArtikelNummer = xmxLeveringsbon.Value.ToString();
                                controleGetal = 5;
                                break;
                            case (5):
                                arrLeverbonArtikels[3] = xmxLeveringsbon.Value;
                                leverbonArtikels.Soort = xmxLeveringsbon.Value;
                                controleGetal = 6;
                                break;
                            case (6):
                                controleGetal = 7;
                                break;
                            case (7):
                                arrLeverbonArtikels[4] = xmxLeveringsbon.Value;
                                arrLeverbonArtikels[5] = (Convert.ToDouble(arrLeverbonArtikels[4]) * Convert.ToDouble(arrLeverbonArtikels[1])).ToString("0.00");
                                leverbonArtikels.Hoeveelheid = Convert.ToDouble(xmxLeveringsbon.Value);
                                controleGetal = 8;
                                break;
                            case (8):
                                leverbonArtikels.Houdbaarheid = Convert.ToDateTime(xmxLeveringsbon.Value);
                                controleGetal = 9;
                                break;
                            case (9):
                                ListViewItem newItem = new ListViewItem(tempLeverbon = new string[] { arrLeverbonArtikels[2], arrLeverbonArtikels[0], arrLeverbonArtikels[3], arrLeverbonArtikels[4], "kg", arrLeverbonArtikels[1].Replace(".", ",") + " €", arrLeverbonArtikels[5] + " €" });
                                Leverbon.Add(leverbonArtikels);
                                lvLeveringsbon.Items.Add(newItem);
                                arrBestelbonVerwerking = new string[] { arrLeverbonArtikels[2], arrLeverbonArtikels[0], arrLeverbonArtikels[3], arrLeverbonArtikels[4], arrLeverbonArtikels[1].Replace(".", ","), arrLeverbonArtikels[5], leverbonArtikels.Houdbaarheid.ToString("dd/MM/yyyy") };
                                arrLeverbonArt.Add(arrBestelbonVerwerking);
                                Array.Clear(arrLeverbonArtikels, 0, arrLeverbonArtikels.Length);
                                controleGetal = 1;
                                break;
                            default:
                                break;
                        }

                    }
                    else if (xmxLeveringsbon.NodeType == XmlNodeType.EndElement)
                    {

                    }
                }
            }
        }
        public void InlezenArtikelGegevens()
        {
            if (File.Exists("Aankoop/Artikelgegevens.txt"))
            {
                string[] arrArtikelBestand;

                using (StreamReader reader = new StreamReader("Aankoop/Artikelgegevens.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        arrArtikelBestand = reader.ReadLine().Split("|");
                        artikelBestand.Add(arrArtikelBestand);
                    }
                }
            }
        }
        public void InlezenGrondstoffenBestand()
        {
            if (File.Exists("Stock/Grondstoffen.txt"))
            {
                using (StreamReader reader = new StreamReader("Stock/Grondstoffen.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        grondstoffen += reader.ReadLine() + Environment.NewLine;
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

        private void btnHoofdMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
