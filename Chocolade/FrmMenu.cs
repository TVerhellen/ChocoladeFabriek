using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Chocolade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Text bestanden worden ingelezen
            Machine.laadLijsten();

            Grondstof.LaadLijst();
            ChocoladeBatch.LaadLijst();
            Recept.LaadLijst();
            Recept.receptenLijst[0].Produceer(5);
            Recept.receptenLijst[1].Produceer(5, 123456);

        }

        private void catalogusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerkoopCatalogus catalogus = new FrmVerkoopCatalogus();
            catalogus.ShowDialog();
        }

        private void bestellingVerwerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBestellingVerwerken verwerken = new FrmBestellingVerwerken();
            verwerken.ShowDialog();
        }

        private void productenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockChocolade chocoladeStockOverview = new FrmStockChocolade();
            chocoladeStockOverview.Show();
        }

        private void grondstoffenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockGrondstof grondstoffenOverview = new FrmStockGrondstof();
            grondstoffenOverview.Show();
        }

        private void machinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMachines machinesForm = new FrmMachines();
            machinesForm.Show();
        }

        private void gegevensLeverancierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGegevensLeveranciers NieuweGegevensLeveranciers = new FrmGegevensLeveranciers();
            NieuweGegevensLeveranciers.Show();
        }

        private void orderPlaatsenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderAanmaken nieuweOrder = new FrmOrderAanmaken();
            nieuweOrder.Show();
        }

        private void historiekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVerkoopHistoriek nieuweHistoriek = new FrmVerkoopHistoriek();
            nieuweHistoriek.ShowDialog();
        }
    }
}
