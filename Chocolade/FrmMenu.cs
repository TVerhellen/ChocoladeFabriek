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
            Debug.WriteLine("START");

            Debug.WriteLine("Stock:" + ChocoladeBatch.stock.Count);
            Debug.WriteLine("Gereserveerd:" + ChocoladeBatch.gereserveerd.Count);

            Recept.receptenLijst[0].Produceer(5, 123456);
            Recept.receptenLijst[0].Produceer(4);

            Debug.WriteLine("Stock:" + ChocoladeBatch.stock.Count);
            Debug.WriteLine("Gereserveerd:" + ChocoladeBatch.gereserveerd.Count);


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
    }
}
