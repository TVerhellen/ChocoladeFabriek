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
    public partial class FrmStockChocolade : Form
    {
        public FrmStockChocolade()
        {
            InitializeComponent();
        }

        private void FrmStockChocolade_Load(object sender, EventArgs e)
        {
            updateLvw();
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            ChocoladeBatch.stock.RemoveAt(lvwChocoladeBatch.SelectedIndices[0]);
            ChocoladeBatch.SlaLijstOp();
            updateLvw();
        }

        private void updateLvw()
        {
            lvwChocoladeBatch.Items.Clear();

            foreach (var item in ChocoladeBatch.stock)
            {
                ListViewItem theNewItem = new ListViewItem(new string[] { item.Naam, item.Hoeveelheid.ToString(), item.Houdbaarheid.ToString("dd/MM/yyyy") });
                lvwChocoladeBatch.Items.Add(theNewItem);
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            Artikel dezeChocoladeBatch = ChocoladeBatch.stock[lvwChocoladeBatch.SelectedIndices[0]];
            dezeChocoladeBatch.Naam = txtTypeGrondstof.Text;
            dezeChocoladeBatch.Hoeveelheid = Convert.ToDouble(txtHoeveelheidGrondstof.Text);
            dezeChocoladeBatch.Houdbaarheid = Convert.ToDateTime(txtHoudbaarheidGrondstof.Text);
            ChocoladeBatch.SlaLijstOp();
            updateLvw();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            Artikel nieuweChocoladeBatch = new ChocoladeBatch(txtTypeGrondstof.Text, Convert.ToDouble(txtHoeveelheidGrondstof.Text));
            nieuweChocoladeBatch.Houdbaarheid = Convert.ToDateTime(txtHoudbaarheidGrondstof.Text);
            ChocoladeBatch.stock.Add(nieuweChocoladeBatch);
            ChocoladeBatch.SlaLijstOp();
            updateLvw();
        }

        private void lvwChocoladeBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwChocoladeBatch.SelectedIndices.Count != 0)
            {
                txtTypeGrondstof.Text = ChocoladeBatch.stock[lvwChocoladeBatch.SelectedIndices[0]].Naam;
                txtHoeveelheidGrondstof.Text = ChocoladeBatch.stock[lvwChocoladeBatch.SelectedIndices[0]].Hoeveelheid.ToString();
                txtHoudbaarheidGrondstof.Text = ChocoladeBatch.stock[lvwChocoladeBatch.SelectedIndices[0]].Houdbaarheid.ToString("dd/MM/yyyy");
            }
            else
            {
                txtTypeGrondstof.Clear();
                txtHoeveelheidGrondstof.Clear();
                txtHoudbaarheidGrondstof.Clear();
            }
        }
    }
}

