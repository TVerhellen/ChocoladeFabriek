using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Chocolade
{
    public partial class FrmVerkoopCatalogus : Form
    {
        public FrmVerkoopCatalogus()
        {
            InitializeComponent();
        }

        VerkoopOrder order = new VerkoopOrder();
        List<string> orderNames = new List<string>();


        private void FrmVerkoopCatalogus_Load(object sender, EventArgs e)
        {
            VerkoopOrder.IDCounter = 0000;

            var txtFiles = Directory.EnumerateFiles("Verkoop/Binnengekomen/TeBevestigen", "*.xml");
            foreach (string currentFile in txtFiles)
            {
                orderNames.Add(currentFile.Substring(36));
                using (XmlReader xmlIn = XmlReader.Create(currentFile))
                {
                    List<ChocoladeBatch> batches = new List<ChocoladeBatch>();
                    int tracker = 0;
                    string[] artikel = new string[4];
                    int counter = 0;
                    while (xmlIn.Read())
                    {
                        switch (xmlIn.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (xmlIn.GetAttribute("id") != null)
                                {
                                    artikel[0] = xmlIn.GetAttribute("id");
                                }
                                switch (xmlIn.Name)
                                {
                                    case "Omschrijving":
                                        tracker = 1;
                                        break;
                                    case "PrijsPerKg":
                                        tracker = 2;
                                        break;
                                    case "AantalKgBesteld":
                                        tracker = 3;
                                        break;
                                    default:
                                        tracker = 0;
                                        break;
                                }
                                break;
                            case XmlNodeType.Text:
                                if (tracker != 0)
                                {
                                    artikel[tracker] = xmlIn.Value;
                                }
                                break;
                            case XmlNodeType.EndElement:
                                if (xmlIn.Name == "Artikel")
                                {
                                    ChocoladeBatch batch = new ChocoladeBatch(artikel[1], Convert.ToDouble(artikel[2]));
                                    batch.Prijs = batch.Hoeveelheid * Convert.ToDouble(artikel[2]);
                                    batch.ID = Convert.ToInt64(artikel[0]);
                                    batches.Add(batch);
                                }
                                if (xmlIn.Name == "BesteldeArtikels")
                                {
                                    VerkoopOrder order = new VerkoopOrder();
                                    order.ID += counter;
                                    foreach (ChocoladeBatch batch in batches)
                                    {
                                        order.VoegToe(batch);
                                    }

                                    lbXmlOrders.Items.Add(order);
                                }
                                break;
                        }
                        counter++;
                    }
                }
            }


            using (XmlReader xmlIn = XmlReader.Create("Verkoop/Prijslijsten/prijslijst.xml"))
            {
                int tracker = 0;
                string[] artikel = new string[4];
                while (xmlIn.Read())
                {
                    switch (xmlIn.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (xmlIn.GetAttribute("id") != null)
                            {
                                artikel[0] = xmlIn.GetAttribute("id");
                            }
                            switch (xmlIn.Name)
                            {
                                case "naam":
                                    tracker = 1;
                                    break;
                                case "prijsperkg":
                                    tracker = 2;
                                    break;
                                case "houdbaar":
                                    tracker = 3;
                                    break;
                                default:
                                    tracker = 0;
                                    break;
                            }
                            break;
                        case XmlNodeType.Text:
                            if (tracker != 0)
                            {
                                artikel[tracker] = xmlIn.Value;
                            }
                            break;
                        case XmlNodeType.EndElement:
                            if (xmlIn.Name == "artikel")
                            {
                                lvwCatalogus.Items.Add(new ListViewItem(artikel));
                            }
                            break;
                    }
                }
            }

            updateLvw();
            radXml.Checked = true;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (lvwCatalogus.SelectedItems.Count != 0 && double.TryParse(txtHoeveelheid.Text, out double hoeveelheid))
            {
                string batchgegevens = lvwCatalogus.FocusedItem.SubItems[1].Text;
                batchgegevens += "|" + lvwCatalogus.FocusedItem.SubItems[0].Text;
                batchgegevens += "|" + hoeveelheid.ToString();
                batchgegevens += "|01/01/0001";
                batchgegevens += "|" + (Convert.ToDouble(lvwCatalogus.FocusedItem.SubItems[2].Text) * hoeveelheid).ToString();


                ChocoladeBatch batch = new ChocoladeBatch(batchgegevens, false);
                order.VoegToe(batch);
                updateLvw();
                txtHoeveelheid.Clear();
            }
            else
            {
                MessageBox.Show("Foute ingave");
            }
        }

        private void btnAfwerken_Click(object sender, EventArgs e)
        {
            if (radXml.Checked)
            {
                File.Move($"Verkoop/binnengekomen/TeBevestigen/{orderNames[lbXmlOrders.SelectedIndex]}", $"Verkoop/binnengekomen/Bevestigd/{orderNames[lbXmlOrders.SelectedIndex]}");
                lbXmlOrders.Items.RemoveAt(lbXmlOrders.SelectedIndex);
                lbXmlOrders.SelectedIndex = -1;
            }
            if (order.Lijst.Count != 0)
            {
                using (StreamWriter opslag = new StreamWriter($"Verkoop/Lopend/{order}.txt"))
                {
                    opslag.WriteLine(order.ID);
                    foreach (ChocoladeBatch batch in order.Lijst)
                    {
                        opslag.WriteLine(batch.ToString());
                    }
                }
                VerkoopOrder.IDCounter++;
            }
            order = new VerkoopOrder();
            updateLvw();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            if (radXml.Checked)
            {
                File.Move($"Verkoop/binnengekomen/TeBevestigen/{orderNames[lbXmlOrders.SelectedIndex]}", $"Verkoop/binnengekomen/Geannuleerd/{orderNames[lbXmlOrders.SelectedIndex]}");
                lbXmlOrders.Items.RemoveAt(lbXmlOrders.SelectedIndex);
                lbXmlOrders.SelectedIndex = -1;
            }
            foreach (ChocoladeBatch batch in order.Lijst)
            {
                if (!ChocoladeBatch.stock.Contains(batch))
                {
                    ChocoladeBatch.stock.Add(batch);
                    ChocoladeBatch.SorteerStockLijst();
                }
                else
                {
                    for (int i = 0; i < ChocoladeBatch.stock.Count; i++)
                    {
                        if (batch.Equals(ChocoladeBatch.stock[i]))
                        {
                            ChocoladeBatch.stock[i].Hoeveelheid += batch.Hoeveelheid;
                            break;
                        }
                    }
                }

            }
            order = new VerkoopOrder();
            updateLvw();
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLvw()
        {
            lvwOrder.Items.Clear();

            foreach (ChocoladeBatch batch in order.Lijst)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { batch.Naam, batch.Hoeveelheid.ToString(), batch.Houdbaarheid.ToString("dd/MM/yyyy"), batch.Prijs.ToString() });
                lvwOrder.Items.Add(theNewItem);
            }
        }

        private void radManueel_CheckedChanged(object sender, EventArgs e)
        {
            if (radManueel.Checked)
            {
                lbXmlOrders.Enabled = false;
                lvwCatalogus.Enabled = true;
                txtHoeveelheid.Enabled = true;
                btnToevoegen.Enabled = true;
                lbXmlOrders.SelectedIndex = -1;
                lvwOrder.Items.Clear();
                order = new VerkoopOrder();
            }
        }

        private void radXml_CheckedChanged(object sender, EventArgs e)
        {
            if (radXml.Checked)
            {
                lbXmlOrders.Enabled = true;
                lvwCatalogus.Enabled = false;
                txtHoeveelheid.Enabled = false;
                btnToevoegen.Enabled = false;
                lvwCatalogus.SelectedIndices.Clear();
                lvwOrder.Items.Clear();
                order = new VerkoopOrder();
            }
        }

        private void lbXmlOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbXmlOrders.SelectedIndex != -1)
            {
                order = (VerkoopOrder)(lbXmlOrders.SelectedItem);
            }
            updateLvw();
        }
    }
}
