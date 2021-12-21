using System;
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

        private void FrmVerkoopCatalogus_Load(object sender, EventArgs e)
        {
            VerkoopOrder.IDCounter = 0000;

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

            RefreshBoxes();

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (lvwCatalogus.SelectedItems.Count != 0 && double.TryParse(txtHoeveelheid.Text, out double hoeveelheid))
            {
                string batchgegevens = lvwCatalogus.FocusedItem.SubItems[1].Text;
                batchgegevens += "|" + lvwCatalogus.FocusedItem.SubItems[0].Text;
                batchgegevens += "|" + hoeveelheid.ToString();
                batchgegevens += "|01/01/3001";


                ChocoladeBatch batch = new ChocoladeBatch(batchgegevens, false);
                order.VoegToe(batch);
                RefreshBoxes();
                txtHoeveelheid.Clear();
            }
            else
            {
                MessageBox.Show("Foute ingave");
            }
        }

        private void btnAfwerken_Click(object sender, EventArgs e)
        {
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
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
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
            RefreshBoxes();
        }

        private void RefreshBoxes()
        {
            lbOrder.DataSource = null;
            lbOrder.DataSource = order.Lijst;
            lbOrder.SelectedIndex = -1;
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
