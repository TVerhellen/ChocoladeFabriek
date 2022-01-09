using Microsoft.Win32;
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
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        public Gebruiker ingelogdeGebruiker = null;

        List<List<Button>> buttongroupList = new List<List<Button>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Text bestanden worden ingelezen


            FrmLogin login = new FrmLogin();
            DialogResult result = login.ShowDialog();
            if (result != DialogResult.OK)
            {
                Environment.Exit(1);
            }
            LoadProfile(login);

            Grondstof.LaadLijst();
            ChocoladeBatch.LaadLijst();
            Machine.laadLijsten();

            Recept.LaadLijst();
            //Recept.receptenLijst[0].Produceer(5);
            //Recept.receptenLijst[1].Produceer(5, 123456);
            List<Button> machineButtons = new List<Button> { btnMachinesOverview };
            List<Button> stockButtons = new List<Button> { btnStock, btnStockGrondstoffen, btnStockBatches };
            List<Button> verkoopButtons = new List<Button> { btnVerkoop, btnGegevensKlant, btnCatalogus, btnBestellingVerwerken, btnHistoriek, btnLopendeBestellingen };
            List<Button> aankoopButtons = new List<Button> { btnAankoop, btnOrderPlaatsen, btnOrderVerwerken, btnGegevensLeverancier };
            List<Button> personeelButton = new List<Button> { btnPersoneel };

            buttongroupList.Add(stockButtons);
            buttongroupList.Add(aankoopButtons);
            buttongroupList.Add(machineButtons);
            buttongroupList.Add(verkoopButtons);
            AdjustSizeAndTextButtons();
            AlignButtonGroups();
        }

        private void LoadProfile(FrmLogin login)
        {
            ingelogdeGebruiker = login.ingelogdeGebruiker;
            lblProfile.Text = ingelogdeGebruiker.Gebruikersnaam.Substring(0, 2);
            lblProfile.Location = new Point((pnlProfileCircle.Width - lblProfile.Width) / 2, lblProfile.Location.Y);

            FrmHome thisForm = new FrmHome();
            thisForm.ingelogdeGebruiker = ingelogdeGebruiker;
            OpenChildForm(thisForm);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(childForm);
            this.pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void btnMachinesOverview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMachines());
        }

        private void btnBatches_Click(object sender, EventArgs e)
        {
            if (ingelogdeGebruiker.Rol == Gebruikersrol.werknemer)
            {
                MessageBox.Show("U heeft niet de juiste bevoegdheden om dit te doen!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                OpenChildForm(new FrmStockChocolade());
            }
        }

        private void btnStockGrondstoffen_Click(object sender, EventArgs e)
        {
            FrmStockGrondstof thisForm = new FrmStockGrondstof();
            thisForm.ingelogdeGebruiker = ingelogdeGebruiker;
            OpenChildForm(thisForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ToggleButtons(sender);
        }

        private void ToggleButtons(object sender)
        {
            List<Button> thisButtonGroup = FindGroupButtonBelongsTo(sender);
            //TODO
            //CloseOtherGroups(thisButtonGroup);
            RepositionOtherButtons(thisButtonGroup);
        }

        private void CloseOtherGroups(List<Button> thisButtonGroup)
        {
            for (int i = 0; i < buttongroupList.Count; i++)
            {
                List<Button> g = buttongroupList[i];
                if (thisButtonGroup != g)
                {
                    if (g.Count > 1 && g[1].Visible == true)
                    {
                        foreach (var button in g)
                        {
                            button.Visible = false;
                        }
                    }
                }
            }
        }

        private void AdjustSizeAndTextButtons()
        {
            for (int i = 0; i < buttongroupList.Count; i++)
            {
                for (int j = 0; j < buttongroupList[i].Count; j++)
                {
                    Button b = buttongroupList[i][j];
                    b.Width = pnlLeftMenu.Width;
                    b.Location = new Point(0, b.Location.Y);
                    if (buttongroupList[i].Count > 1)
                    {
                        if (j == 0)
                        {
                            b.Text = "             + " + b.Text;
                        }
                        else
                        {
                            b.Text = "             └ " + b.Text;
                        }
                    }
                    else
                    {
                        b.Text = "             " + b.Text;
                    }
                }
            }
        }

        private void RepositionOtherButtons(List<Button> thisButtonGroup)
        {
            if (thisButtonGroup.Count > 1)
            {
                bool setToValue = !thisButtonGroup[1].Visible;
                for (int i = 1; i < thisButtonGroup.Count; i++)
                {
                    thisButtonGroup[i].Visible = setToValue;
                    thisButtonGroup[i].Location = new Point(thisButtonGroup[0].Location.X, thisButtonGroup[0].Location.Y + thisButtonGroup[0].Height * i);
                }
                int signMultiplier = 1;
                if (!setToValue)
                {
                    signMultiplier = -1;
                }
                int offsetAmount = (thisButtonGroup.Count - 1) * btnMachinesOverview.Height * signMultiplier;
                for (int i = buttongroupList.IndexOf(thisButtonGroup) + 1; i < buttongroupList.Count; i++)
                {
                    foreach (var button in buttongroupList[i])
                    {
                        button.Location = new Point(button.Location.X, button.Location.Y + offsetAmount);
                    }
                }
            }

        }
        private List<Button> FindGroupButtonBelongsTo(object sender)
        {
            foreach (var buttonsGroup in buttongroupList)
            {
                foreach (var button in buttonsGroup)
                {
                    if (button == sender)
                    {
                        if (button.Text.IndexOf("-") != -1)
                        {
                            button.Text = button.Text.Replace("-", "+");
                        }
                        else
                        {
                            button.Text = button.Text.Replace("+", "-");
                        }
                        return buttonsGroup;
                    }
                }
            }
            throw new Exception("Buttongroup not found.");
        }

        private void AlignButtonGroups()
        {
            Button topButton = buttongroupList[0][0];
            for (int i = 1; i < buttongroupList.Count; i++)
            {
                buttongroupList[i][0].Location = new Point(buttongroupList[i][0].Location.X, topButton.Location.Y + topButton.Height * i);
            }
        }

        private void btnVerkoop_Click(object sender, EventArgs e)
        {
            ToggleButtons(sender);
        }

        private void btnAankoop_Click(object sender, EventArgs e)
        {
            ToggleButtons(sender);
        }
        private void pnlProfileCircle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush myBrush = new SolidBrush(Color.FromArgb(255, 100, 100, 255));
            int centerX = pnlProfileCircle.Width / 2;
            int centerY = pnlProfileCircle.Width / 2;
            int radius = pnlProfileCircle.Width / 2 - 2;
            g.FillEllipse(myBrush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }

        private void pnlProfileCircle_Click(object sender, EventArgs e)
        {
            ProfileWindow();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            ProfileWindow();
        }

        private void ProfileWindow()
        {
            FrmLogout logout = new FrmLogout();
            DialogResult dialogResult = logout.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FrmLogin login = new FrmLogin();
                DialogResult result = DialogResult.OK;
                result = login.ShowDialog();
                if (result != DialogResult.OK)
                {
                    Application.Exit();
                }
                LoadProfile(login);
            }
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

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
