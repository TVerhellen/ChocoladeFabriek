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
    public partial class FrmHome : Form
    {
        public Personeel ingelogdeGebruiker = null;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            ChangeGreeting();
        }
        private void ChangeGreeting()
        {
            string[] aanspreking = { "Goedenacht", "Goedemorgen", "Goedemiddag", "Goedenavond" };
            int uur = DateTime.Now.Hour;
            lblGroet.Text = aanspreking[(int)(uur / 6)] + ", " + ingelogdeGebruiker.Gebruikersnaam;
        }
    }
}
