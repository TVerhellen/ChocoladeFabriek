using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class FrmMachines : Form
    {
        public FrmMachines()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

        }
        public DateTime start = DateTime.Now.Date;
        public DateTime end = DateTime.Now.AddDays(1).Date;
        List<Machine> ToDisplayMachines = new List<Machine>();
        int machinePage = 0;
        int maxPage = 0;
        int thicknessBar = 20;
        int spacingBar = 20;
        int margin = 20;

        private void FrmMachines_Load(object sender, EventArgs e)
        {
            maxPage = (int)(Machine.allMachines.Count / 6);
            lblStartDiagram.Text = start.ToString("dd/MM/yyyy");
            Debug.WriteLine(panel1.Height);
            thicknessBar = spacingBar = margin = (int)(panel1.Height * 0.077);
            RefreshMachineList();
            tmrBarAnimation.Start();
        }

        private void RefreshMachineList()
        {
            ToDisplayMachines.Clear();
            for (int i = 0; i < 6; i++)
            {
                int indexMachine = i + 6 * machinePage;
                if (indexMachine < Machine.allMachines.Count)
                {
                    ToDisplayMachines.Add(Machine.allMachines[indexMachine]);
                }
            }
            pnlNamesMachines.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            int totalWidth = panel1.Width;

            int canvasWidth = totalWidth - 2 * margin;
            int canvasHeight = panel1.Height - 2 * margin;
            int canvasX = margin;
            int canvasY = margin;

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            g.FillPath(blueBrush, GetRoundPath(new Rectangle(0, 0, totalWidth, panel1.Height), 40));

            for (int i = 0; i < ToDisplayMachines.Count; i++)
            {
                Machine m = ToDisplayMachines[i];
                int counter = 0;

                paintRectangle(g, Color.FromArgb(255, 248, 248, 248), margin, i * (thicknessBar + spacingBar) + canvasY, canvasWidth, thicknessBar);

                foreach (var timeslot in m.Bezetting)
                {
                    if (start < timeslot.Start && timeslot.End < end || start < timeslot.Start && timeslot.End > end || start > timeslot.Start && timeslot.End < end)
                    {
                        DateTime thisStart = timeslot.Start;
                        DateTime thisEnd = timeslot.End;

                        if (start < timeslot.Start && timeslot.End > end)
                        {
                            thisEnd = end;
                        }
                        if (start > timeslot.Start && timeslot.End < end)
                        {
                            thisStart = start;
                        }

                        int bartStart = canvasX + (int)((thisStart - start).TotalMinutes / (end - start).TotalMinutes * canvasWidth);
                        int bartEnd = canvasX + (int)((thisEnd - start).TotalMinutes / (end - start).TotalMinutes * canvasWidth);
                        int barWidth = bartEnd - bartStart;
                        int startY = i * (thicknessBar + spacingBar) + canvasY;
                        Color thisColor = Color.FromArgb(255, 20, 60, 140);
                        if (counter == 0)
                        {
                            thisColor = Color.FromArgb(255, 133, 142, 243);
                            counter = 1;
                        }
                        else
                        {
                            counter = 0;
                        }
                        paintRectangle(g, thisColor, bartStart, startY, barWidth, thicknessBar);
                    }
                }
            }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        private void paintRectangle(Graphics g, Color thisColor, int x, int y, int height, int width)
        {
            SolidBrush blueBrush = new SolidBrush(thisColor);
            Rectangle rect = new Rectangle(x, y, height, width);
            try
            {
                g.FillRectangle(blueBrush, rect);
            }
            catch (Exception e)
            {
                Debug.WriteLine(rect);
            }
        }

        private void pnlNamesMachines_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int totalWidth = pnlNamesMachines.Width;

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            g.FillPath(blueBrush, GetRoundPath(new Rectangle(0, 0, totalWidth, panel1.Height), 40));
            int counter = 0;
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 100, 100, 130));
            foreach (var item in ToDisplayMachines)
            {
                string drawString = item.Naam;
                float x = margin;
                float y = margin + counter * margin * 2;
                StringFormat drawFormat = new StringFormat();
                g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                counter++;
            }
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //Retrieve Period
            double thisX = e.Location.X;
            double thisY = e.Location.Y;
            int thisRow = (int)(thisY - margin) / (thicknessBar + spacingBar);
            if (thisRow < 0 || thisRow > ToDisplayMachines.Count - 1)
            {
                return;
            }
            Machine thisMachine = ToDisplayMachines[thisRow];
            double percentage = (thisX - margin) / (panel1.Width - (2 * margin));
            DateTime thisTime = start.AddMinutes(percentage * (end - start).TotalMinutes);
            TimePeriod checkThisPeriod = new TimePeriod(thisTime, thisTime.AddMilliseconds(2));
            TimePeriod thisPeriod = null;
            foreach (var timeslot in thisMachine.Bezetting)
            {
                if (checkThisPeriod.OverlapsWithThisPeriod(timeslot))
                {
                    thisPeriod = timeslot;
                    break;
                }
            }

            //Retrieve Batch
            ChocoladeBatch thisBatch = null;
            List<Artikel>[] lists = { ChocoladeBatch.stock, ChocoladeBatch.gereserveerd };
            for (int i = 0; i < lists.Length; i++)
            {
                foreach (var batch in lists[i])
                {
                    foreach (var machineEnTijdslot in ((ChocoladeBatch)batch).MachinesEnTijdsloten)
                    {
                        if (thisMachine.Naam == machineEnTijdslot.GebruiktMachine.Naam && machineEnTijdslot.Tijdslot.Equals(thisPeriod))
                        {
                            thisBatch = (ChocoladeBatch)batch;
                            break;
                        }
                    }
                    if (thisBatch != null)
                    {
                        lblRoast.Text = thisBatch.MachinesEnTijdsloten[0].GebruiktMachine.Naam;
                        lblCrack.Text = thisBatch.MachinesEnTijdsloten[1].GebruiktMachine.Naam;
                        lblGrind.Text = thisBatch.MachinesEnTijdsloten[2].GebruiktMachine.Naam;
                        lblTemper.Text = thisBatch.MachinesEnTijdsloten[3].GebruiktMachine.Naam;
                        lblPackaging.Text = thisBatch.MachinesEnTijdsloten[4].GebruiktMachine.Naam;

                        lblRoastTime.Text = thisBatch.MachinesEnTijdsloten[0].Tijdslot.Start + " - " + thisBatch.MachinesEnTijdsloten[0].Tijdslot.End;
                        lblCrackTime.Text = thisBatch.MachinesEnTijdsloten[1].Tijdslot.Start + " - " + thisBatch.MachinesEnTijdsloten[1].Tijdslot.End;
                        lblGrindTime.Text = thisBatch.MachinesEnTijdsloten[2].Tijdslot.Start + " - " + thisBatch.MachinesEnTijdsloten[2].Tijdslot.End;
                        lblTemperTime.Text = thisBatch.MachinesEnTijdsloten[3].Tijdslot.Start + " - " + thisBatch.MachinesEnTijdsloten[3].Tijdslot.End;
                        lblPackagingTime.Text = thisBatch.MachinesEnTijdsloten[4].Tijdslot.Start + " - " + thisBatch.MachinesEnTijdsloten[4].Tijdslot.End;
                        if (thisBatch.ReservatieNummer == -1)
                        {
                            lblReservatieID.Text = "Niet gereserveerd";
                        }
                        else
                        {
                            lblReservatieID.Text = thisBatch.ReservatieNummer.ToString();
                        }

                        lblID.Text = thisBatch.ID.ToString();
                        lblHoudbaarheid.Text = thisBatch.Houdbaarheid.ToString();
                        lblBeschikbaar.Text = thisBatch.MomentBeschikbaar.ToString();
                        lblPrijs.Text = thisBatch.Prijs.ToString();
                        break;
                    }
                }
            }
        }

        private void pnlThisBatch_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Control);
            Graphics g = e.Graphics;
            int totalWidth = pnlThisBatch.Width;
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            g.FillPath(blueBrush, GetRoundPath(new Rectangle(0, 0, pnlThisBatch.Width, pnlThisBatch.Height), 40));

        }

        private void btnVolgendTijd_Click(object sender, EventArgs e)
        {
            start = start.AddDays(1);
            end = start.AddDays(1);
            lblStartDiagram.Text = start.ToString("dd/MM/yyyy");
            panel1.Refresh();
        }

        private void btnVorigTijd_Click(object sender, EventArgs e)
        {
            start = start.AddDays(-1);
            end = start.AddDays(1);
            lblStartDiagram.Text = start.ToString("dd/MM/yyyy");
            panel1.Refresh();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (machinePage > 0)
            {
                machinePage--;
                RefreshMachineList();
                panel1.Refresh();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (machinePage < maxPage)
            {
                machinePage++;
                RefreshMachineList();
                panel1.Refresh();
            }

        }
        int counter = 0;
        int speed = 30;

        private void ShrinkPanel(Panel thisPanel)
        {
            if (thisPanel.Width > 1)
            {
                thisPanel.Width -= speed;
                thisPanel.Location = new Point(thisPanel.Location.X + speed, thisPanel.Location.Y);
            }
        }
        private int EaseInOutCubic(int x)
        {
            return (int)(x < 0.5 ? 4 * x * x * x : 1 - Math.Pow(-2 * x + 2, 3) / 2);
        }

        private void tmrBarAnimation_Tick(object sender, EventArgs e)
        {
            counter++;

            ShrinkPanel(pnlAnimationBar1);

            if (counter > 5)
            {
                ShrinkPanel(pnlAnimationBar2);
            }
            if (counter > 10)
            {
                ShrinkPanel(pnlAnimationBar3);
            }
            if (counter > 15)
            {
                ShrinkPanel(pnlAnimationBar4);
            }
            if (counter > 20)
            {
                ShrinkPanel(pnlAnimationBar5);
            }
            if (counter > 25)
            {
                ShrinkPanel(pnlAnimationBar6);
            }

            if (pnlAnimationBar6.Width < 10)
            {
                tmrBarAnimation.Stop();
            }
        }
    }
}
