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

            RefreshBoxes();

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (lbCatalogus.SelectedIndex != -1 && double.TryParse(txtHoeveelheid.Text, out double hoeveelheid))
            {
                if (((ChocoladeBatch)lbCatalogus.SelectedItem).Hoeveelheid >= hoeveelheid)
                {
                    order.VoegToe((ChocoladeBatch)lbCatalogus.SelectedItem, hoeveelheid);
                    RefreshBoxes();
                    txtHoeveelheid.Clear();
                }
                else
                {
                    MessageBox.Show("Foute hoeveelheid");
                }
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
            foreach(ChocoladeBatch batch in order.Lijst)
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
            lbCatalogus.DataSource = null;
            lbCatalogus.DataSource = ChocoladeBatch.stock;
            lbOrder.SelectedIndex = -1;
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
