using System;


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


        private void aankoopartikelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAankoopArtikels aankoopArtikelsOverzicht = new FrmAankoopArtikels();
            aankoopArtikelsOverzicht.Show();
        }

        private void historiekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVerkoopHistoriek nieuweHistoriek = new FrmVerkoopHistoriek();
            nieuweHistoriek.ShowDialog();
        }

        private void lopendeBestellingenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerkoopLopend nieuwLopend = new FrmVerkoopLopend();
            nieuwLopend.ShowDialog();
        }

        private void gegevensKlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGegevensKlant nieuwGegevensKlant = new FrmGegevensKlant();
            nieuwGegevensKlant.Show();

        }

        private void orderVerwerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderVerwerken nieuwOrder = new FrmOrderVerwerken();
            nieuwOrder.Show();
        }
    }
}
