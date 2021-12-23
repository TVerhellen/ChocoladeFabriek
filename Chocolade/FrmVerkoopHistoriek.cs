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
    public partial class FrmVerkoopHistoriek : Form
    {
        public FrmVerkoopHistoriek()
        {
            InitializeComponent();
        }

        List<VerkoopOrder> afgewerkt = new List<VerkoopOrder>();
        List<VerkoopOrder> geannuleerd = new List<VerkoopOrder>();

        private void FrmVerkoopHistoriek_Load(object sender, EventArgs e)
        {
            StreamReader reader;
            var txtFiles = Directory.EnumerateFiles("Verkoop/Historiek/Afgewerkt", "*.txt");
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
                    afgewerkt.Add(order);
                }
            }
            txtFiles = Directory.EnumerateFiles("Verkoop/Historiek/Geannuleerd", "*.txt");
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
                    geannuleerd.Add(order);
                }
            }
            lblOrderNummer.Text = "";
        }

        private void updateLb()
        {
            lbOrders.DataSource = null;
            if (radAfgewerkt.Checked)
            {
                lbOrders.DataSource = afgewerkt;
            }
            else
            {
                lbOrders.DataSource = geannuleerd;
            }
        }

        private void updateLvw()
        {
            lvwChocoladeBatch.Items.Clear();

            foreach (ChocoladeBatch batch in ((VerkoopOrder)lbOrders.SelectedItem).Lijst)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { batch.Naam, batch.Hoeveelheid.ToString(), batch.Houdbaarheid.ToString("dd/MM/yyyy"), batch.Prijs.ToString() });
                lvwChocoladeBatch.Items.Add(theNewItem);
            }
        }

        private void radAfgewerkt_CheckedChanged(object sender, EventArgs e)
        {
            updateLb();
        }

        private void radGeannuleerd_CheckedChanged(object sender, EventArgs e)
        {
            updateLb();
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrders.SelectedIndex != -1)
            {
                updateLvw();
                lblOrderNummer.Text = lbOrders.SelectedItem.ToString();
            }
        }
    }
}
