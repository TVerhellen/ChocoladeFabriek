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
            Grondstof.LaadLijst();
            ChocoladeBatch.LaadLijst();
            Recept.LaadLijst();

            Machine.laadLijsten();
            Debug.WriteLine(RoastMachine.list[0].ProductieTijd);
            Debug.WriteLine(RoastMachine.list[0].MaxCapaciteit);
            Debug.WriteLine(RoastMachine.list[0].Bezetting);
            foreach (var item in RoastMachine.list[0].Bezetting)
            {
                Debug.WriteLine(item);
            }

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
    }
}
