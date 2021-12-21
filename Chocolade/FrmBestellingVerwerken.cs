using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmBestellingVerwerken : Form
    {
        public FrmBestellingVerwerken()
        {
            InitializeComponent();
        }

        private List<VerkoopOrder> orders = new List<VerkoopOrder>();

        private void FrmBestellingVerwerken_Load(object sender, EventArgs e)
        {
            StreamReader reader;
            var txtFiles = Directory.EnumerateFiles("Verkoop/Lopend", "*.txt");
            foreach (string currentFile in txtFiles)
            {
                using (reader = new StreamReader(currentFile))
                {
                    double id = Convert.ToDouble(reader.ReadLine());
                    List<string> batches = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        batches.Add(reader.ReadLine());
                    }
                    VerkoopOrder order = new VerkoopOrder(id, batches);
                    orders.Add(order);
                }
            }
            lbOrders.DataSource = orders;
            lbOrders.SelectedIndex = -1;
            lvwBatches.Items.Clear();
            lblOrderNummer.Text = "";
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrders.SelectedIndex != -1)
            {
                btnAfwerken.Enabled = true;
                btnVerwijderen.Enabled = true;
                updateLvw();
            }
            else
            {
                btnAfwerken.Enabled = false;
                btnVerwijderen.Enabled = false;
            }

        }

        private void btnAfwerken_Click(object sender, EventArgs e)
        {
            File.Move($"Verkoop/Lopend/{(VerkoopOrder)lbOrders.SelectedItem}.txt", $"Verkoop/Historiek/Afgewerkt/{((VerkoopOrder)lbOrders.SelectedItem).ToString()}.txt");

            ((VerkoopOrder)lbOrders.SelectedItem).Lijst.Clear();
            lbOrders.SelectedIndex = -1;
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            VerkoopOrder order = (VerkoopOrder)lbOrders.SelectedItem;
            File.Move($"Verkoop/Lopend/{order}.txt", $"Verkoop/Historiek/Geannuleerd/{order}.txt");

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
            orders.RemoveAt(lbOrders.SelectedIndex);
            lbOrders.DataSource = null;
            lbOrders.DataSource = orders;
            lbOrders.SelectedIndex = -1;
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void updateLvw()
        {
            lvwBatches.Items.Clear();

            foreach (ChocoladeBatch batch in ((VerkoopOrder)lbOrders.SelectedItem).Lijst)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { batch.Naam, batch.Hoeveelheid.ToString(), batch.Houdbaarheid.ToString("dd/MM/yyyy") });
                lvwBatches.Items.Add(theNewItem);
            }
        }

    }
}
