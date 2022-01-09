using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmVerkoopLopend : Form
    {
        public FrmVerkoopLopend()
        {
            InitializeComponent();
        }

        private List<VerkoopOrder> orders = new List<VerkoopOrder>();

        private void FrmVerkoopLopend_Load(object sender, EventArgs e)
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
                        string data = reader.ReadLine();
                        batches.Add(data);
                    }
                    VerkoopOrder order = new VerkoopOrder(id, batches);
                    orders.Add(order);
                }
            }

            lblOrderNummer.Text = "";
            lbOrders.DataSource = orders;
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrders.SelectedIndex != -1)
            {
                UpdateLvw();
            }
            else
            {
                lvwBatches.Items.Clear();
            }
        }

        private void UpdateLvw()
        {
            lvwBatches.Items.Clear();

            foreach (ChocoladeBatch batch in ((VerkoopOrder)lbOrders.SelectedItem).Lijst)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { batch.Naam, batch.Hoeveelheid.ToString(), batch.Prijs.ToString() });
                lvwBatches.Items.Add(theNewItem);
            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            List<VerkoopOrder> filteredList = new List<VerkoopOrder>();
            foreach (VerkoopOrder order in orders)
            {
                if (order.ToString().Contains(txtZoekterm.Text))
                {
                    filteredList.Add(order);
                }
            }
            lbOrders.DataSource = null;
            lbOrders.DataSource = filteredList;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbOrders.DataSource = null;
            lbOrders.DataSource = orders;
            btnReset.Enabled = false;
            txtZoekterm.Clear();
        }

    }
}
