using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Grondstof.LaadLijst();
            ChocoladeBatch.LaadLijst();

            Recept Choco70 = new Recept();
            Choco70.Naam = "Ruby Gold 70%";
            Choco70.Ingredienten = new List<Grondstof>() { new Grondstof("Criollo bonen", 20), new Grondstof("Melk", 10) };
            Choco70.DagenHoudbaar = 10;
            Choco70.Produceer(20);

            string allData = "";
            foreach (var item in ChocoladeBatch.stock)
            {
                allData += $"{item.Naam} {item.Houdbaarheid.ToString("dd/MM/yyyy")} {item.ID}" + Environment.NewLine;
            }
            MessageBox.Show(allData);
            ChocoladeBatch.SlaLijstOp();
        }
    }
}
