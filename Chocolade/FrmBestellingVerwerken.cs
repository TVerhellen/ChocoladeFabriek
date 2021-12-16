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
                using(reader = new StreamReader(currentFile))
                {
                    double id = Convert.ToDouble(reader.ReadLine());
                    List<string> batches = new List<string>();
                    while(!reader.EndOfStream)
                    {
                        batches.Add(reader.ReadLine());
                    }
                    VerkoopOrder order = new VerkoopOrder(id, batches);
                    orders.Add(order);
                }
            }
            lbOrders.DataSource = orders;
            lbOrders.SelectedIndex = -1;
            lbBatches.DataSource = null;
            lblOrderNummer.Text = "";
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrders.SelectedIndex != -1)
            {
                lbBatches.DataSource = null;
                lbBatches.DataSource = ((VerkoopOrder)lbOrders.SelectedItem).Lijst;
                lbBatches.SelectedIndex = -1;

                lblOrderNummer.Text = ((VerkoopOrder)lbOrders.SelectedItem).ToString();

                btnAfwerken.Enabled = true;
                btnVerwijderen.Enabled = true;
            }
            else
            {
                lblOrderNummer.Text = "";

                lbBatches.DataSource = null;

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


    }
}
