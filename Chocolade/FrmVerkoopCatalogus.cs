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

        private List<ChocoladeBatch> stockLijst = new List<ChocoladeBatch>();
        VerkoopOrder order = new VerkoopOrder();

        private void FrmVerkoopCatalogus_Load(object sender, EventArgs e)
        {
            VerkoopOrder.IDCounter = 0000;

            ChocoladeBatch batch = new ChocoladeBatch("a");
            batch.Naam = "Zwart 80%";
            batch.ID = 123456798;
            batch.Hoeveelheid = 100;
            batch.Houdbaarheid = DateTime.Now.AddDays(5);
            stockLijst.Add(batch);
            ChocoladeBatch batch2 = new ChocoladeBatch("a");
            batch2.Naam = "melk 40%";
            batch2.ID = 48354;
            batch2.Hoeveelheid = 20;
            batch2.Houdbaarheid = DateTime.Now.AddDays(5);
            stockLijst.Add(batch2);
            ChocoladeBatch batch3 = new ChocoladeBatch("a");
            batch3.Naam = "Wit";
            batch3.ID = 951;
            batch3.Hoeveelheid = 500;
            batch3.Houdbaarheid = DateTime.Now.AddDays(5);
            stockLijst.Add(batch3);

            lbOrder.DataSource = order.Lijst;
            lbOrder.SelectedIndex = -1;

            lbCatalogus.DataSource = stockLijst;
            lbCatalogus.SelectedIndex = -1;

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (lbCatalogus.SelectedIndex != -1)
            {
                
                order.VoegToe((ChocoladeBatch)lbCatalogus.SelectedItem, Convert.ToDouble(txtHoeveelheid.Text));
                lbOrder.DataSource = null;
                lbOrder.DataSource = order.Lijst;
                lbOrder.SelectedIndex = -1;
            }
        }

        private void btnAfwerken_Click(object sender, EventArgs e)
        {
            order.GenereerID();
            using (StreamWriter opslag = new StreamWriter($"order{order.ID}.txt"))
            {
                opslag.WriteLine(order.ID);
                foreach (ChocoladeBatch batch in order.Lijst)
                {
                    opslag.WriteLine(batch.ToString());
                }
            }

        }
    }
}
