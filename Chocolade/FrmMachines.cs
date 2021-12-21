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
    public partial class FrmMachines : Form
    {
        public FrmMachines()
        {
            InitializeComponent();
        }
        public DateTime start = DateTime.Now;
        public DateTime end = DateTime.Now.AddDays(1);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Pen blackPen = new Pen(Color.Black, 3);
            //SolidBrush blueBrush = new SolidBrush(Color.Blue);

            //Graphics g = e.Graphics;
            //Rectangle rect = new Rectangle(0, 0, 200, 200);

            //g.FillRectangle(blueBrush, rect);
            Graphics g = e.Graphics;

            int totalWidth = panel1.Width;
            int thicknessBar = 10;
            int spacingBar = 5;

            paintRectangle(g, Color.AliceBlue, 0, 0, totalWidth, panel1.Height);


            for (int i = 0; i < RoastMachine.list.Count; i++)
            {
                Machine m = RoastMachine.list[i];
                int counter = 0;
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
                        Debug.WriteLine("got here");
                        //Zit er volledig in
                        //startlocation
                        int bartStart = (int)((thisStart - start).TotalMinutes / (end - start).TotalMinutes * totalWidth);
                        int bartEnd = (int)((thisEnd - start).TotalMinutes / (end - start).TotalMinutes * totalWidth);
                        int barWidth = bartEnd - bartStart;
                        int startY = i * (thicknessBar + spacingBar);
                        Color thisColor = Color.Black;
                        if (counter == 0)
                        {
                            thisColor = Color.Gray;
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

            for (int i = 0; i < TemperingMachine.list.Count; i++)
            {
                Machine m = TemperingMachine.list[i];
                int counter = 0;

                foreach (var timeslot in m.Bezetting)
                {
                    if (start < timeslot.Start && timeslot.End < end)
                    {
                        Debug.WriteLine("got here");
                        //Zit er volledig in
                        //startlocation
                        int bartStart = (int)((timeslot.Start - start).TotalMinutes / (end - start).TotalMinutes * totalWidth);
                        int bartEnd = (int)((timeslot.End - start).TotalMinutes / (end - start).TotalMinutes * totalWidth);
                        int barWidth = bartEnd - bartStart;
                        int startY = i * (thicknessBar + spacingBar) + 20;
                        Color thisColor = Color.Red;

                        if (counter == 0)
                        {
                            thisColor = Color.Pink;
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


        private void paintRectangle(Graphics g, Color thisColor, int x, int y, int height, int width)
        {
            SolidBrush blueBrush = new SolidBrush(thisColor);
            Rectangle rect = new Rectangle(x, y, height, width);
            g.FillRectangle(blueBrush, rect);
        }

        private void FrmMachines_Load(object sender, EventArgs e)
        {
            lblStartDiagram.Text = start.ToString();
            lblEndDiagram.Text = end.ToString();
        }
    }
}
