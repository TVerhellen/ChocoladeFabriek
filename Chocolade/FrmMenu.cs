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
            Grondstof.LaadLijst();
            ChocoladeBatch.LaadLijst();
            Debug.WriteLine(Recept.receptenLijst.Count);

            Recept.LaadLijst();
            Debug.WriteLine(Recept.receptenLijst.Count);
            foreach (var recept in Recept.receptenLijst)
            {
                if (recept.Naam == "Ruby Chocolade")
                {
                    recept.Produceer(20);
                }
            }


            Grondstof.SlaLijstOp();
        }
    }
}
