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
    public partial class FrmStockGrondstof : Form
    {
        public Gebruiker ingelogdeGebruiker = null;

        public FrmStockGrondstof()
        {
            InitializeComponent();
        }

        private void FrmStockGrondstof_Load(object sender, EventArgs e)
        {
            updateLvw();
        }

        private void updateLvw()
        {
            lvwGrondstof.Items.Clear();
            foreach (var item in Grondstof.stock)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { item.Naam, item.Hoeveelheid.ToString(), item.Houdbaarheid.ToString("dd/MM/yyyy") });
                lvwGrondstof.Items.Add(theNewItem);
            }
        }


        private void lvwGrondstof_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwGrondstof.SelectedIndices.Count != 0)
            {
                txtTypeGrondstof.Text = Grondstof.stock[lvwGrondstof.SelectedIndices[0]].Naam;
                txtHoeveelheidGrondstof.Text = Grondstof.stock[lvwGrondstof.SelectedIndices[0]].Hoeveelheid.ToString();
                txtHoudbaarheidGrondstof.Text = Grondstof.stock[lvwGrondstof.SelectedIndices[0]].Houdbaarheid.ToString("dd/MM/yyyy");
            }
            else
            {
                txtTypeGrondstof.Clear();
                txtHoeveelheidGrondstof.Clear();
                txtHoudbaarheidGrondstof.Clear();
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            if (ingelogdeGebruiker.Rol == Gebruikersrol.werknemer)
            {
                MessageBox.Show("U heeft niet de juiste bevoegdheden om deze actie uit te voeren.");
            }
            else
            {
                Artikel nieuweGrondstof = new Grondstof(txtTypeGrondstof.Text, Convert.ToDouble(txtHoeveelheidGrondstof.Text));
                nieuweGrondstof.Houdbaarheid = Convert.ToDateTime(txtHoudbaarheidGrondstof.Text);
                Grondstof.stock.Add(nieuweGrondstof);
                Grondstof.SlaLijstOp();
                updateLvw();
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (ingelogdeGebruiker.Rol == Gebruikersrol.werknemer)
            {
                MessageBox.Show("U heeft niet de juiste bevoegdheden om deze actie uit te voeren.");
            }
            else
            {
                Grondstof.stock.RemoveAt(lvwGrondstof.SelectedIndices[0]);
                Grondstof.SlaLijstOp();
                updateLvw();
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if (ingelogdeGebruiker.Rol == Gebruikersrol.werknemer)
            {
                MessageBox.Show("U heeft niet de juiste bevoegdheden om deze actie uit te voeren.");
            }
            else
            {
                Artikel dezeGrondstof = Grondstof.stock[lvwGrondstof.SelectedIndices[0]];
                dezeGrondstof.Naam = txtTypeGrondstof.Text;
                dezeGrondstof.Hoeveelheid = Convert.ToDouble(txtHoeveelheidGrondstof.Text);
                dezeGrondstof.Houdbaarheid = Convert.ToDateTime(txtHoudbaarheidGrondstof.Text);
                Grondstof.SlaLijstOp();
                updateLvw();
            }
        }
    }
}
