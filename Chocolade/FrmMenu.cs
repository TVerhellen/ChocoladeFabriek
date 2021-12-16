using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Grondstof> stockGrondstof = new List<Grondstof>();
        List<ChocoladeBatch> stockChocolade = new List<ChocoladeBatch>();

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
