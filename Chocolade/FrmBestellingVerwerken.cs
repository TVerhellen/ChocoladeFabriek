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
            

            double tempHoeveelheid = 0;
            bool controle = false;
            List<ChocoladeBatch> actualBatches = new List<ChocoladeBatch>();
            foreach (ChocoladeBatch batch in ((VerkoopOrder)lbOrders.SelectedItem).Lijst)
            {
                controle = false;
                foreach (ChocoladeBatch stockBatch in ChocoladeBatch.stock)
                {
                    if (batch.ID.ToString().PadLeft(10, '0').Substring(0, 4) == stockBatch.ID.ToString().PadLeft(10, '0').Substring(0, 4))
                    {
                        if (tempHoeveelheid == 0)
                        {
                            batch.Houdbaarheid = stockBatch.Houdbaarheid;
                            batch.ID = stockBatch.ID;
                            if (batch.Hoeveelheid <= stockBatch.Hoeveelheid)
                            {
                                if (batch.Hoeveelheid == stockBatch.Hoeveelheid)
                                {
                                    stockBatch.Verwijder();
                                    controle = true;
                                }
                                else
                                {
                                    stockBatch.Verwijder(batch.Hoeveelheid);
                                    controle = true;
                                }
                                actualBatches.Add(batch);
                                break;
                            }
                            else
                            {
                                tempHoeveelheid = batch.Hoeveelheid - stockBatch.Hoeveelheid;
                                batch.Hoeveelheid = stockBatch.Hoeveelheid;
                                actualBatches.Add(batch);
                            }
                        }
                        else
                        {
                            ChocoladeBatch newBatch = new ChocoladeBatch(batch.Naam, tempHoeveelheid);
                            
                            newBatch.Houdbaarheid = stockBatch.Houdbaarheid;
                            newBatch.ID = stockBatch.ID;
                            if (newBatch.Hoeveelheid <= stockBatch.Hoeveelheid)
                            {
                                if (newBatch.Hoeveelheid == stockBatch.Hoeveelheid)
                                {
                                    newBatch.Prijs = stockBatch.Prijs;
                                    stockBatch.Verwijder();
                                    controle = true;
                                }
                                else
                                {
                                    newBatch.Prijs = stockBatch.Prijs * newBatch.Hoeveelheid / stockBatch.Hoeveelheid;
                                    stockBatch.Verwijder(newBatch.Hoeveelheid);
                                    controle = true;
                                }
                                actualBatches.Add(newBatch);
                                break;
                            }
                            else
                            {
                                tempHoeveelheid = newBatch.Hoeveelheid - stockBatch.Hoeveelheid;
                                newBatch.Hoeveelheid = stockBatch.Hoeveelheid;
                                actualBatches.Add(newBatch);
                            }
                        }


                    }
                }
                if (!controle)
                {
                    MessageBox.Show("Niet alle artikelen zijn in stock!");
                    foreach (ChocoladeBatch actualBatch in actualBatches)
                    {
                        ChocoladeBatch.stock.Add(actualBatch);
                    }
                    ChocoladeBatch.SorteerStockLijst();
                    break;
                }
            }
            if (controle)
            {
                ((VerkoopOrder)lbOrders.SelectedItem).Lijst = actualBatches;
                File.Move($"Verkoop/Lopend/{(VerkoopOrder)lbOrders.SelectedItem}.txt", $"Verkoop/Historiek/Afgewerkt/{(VerkoopOrder)lbOrders.SelectedItem}.txt");
                ((VerkoopOrder)lbOrders.SelectedItem).GenerateXml();
            }

            //lbOrders.Items.RemoveAt(lbOrders.SelectedIndex);
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
