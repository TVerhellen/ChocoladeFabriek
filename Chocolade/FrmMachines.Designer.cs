
namespace Chocolade
{
    partial class FrmMachines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartDiagram = new System.Windows.Forms.Label();
            this.lblEndDiagram = new System.Windows.Forms.Label();
            this.pnlNamesMachines = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlThisBatch = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblHoudbaarheid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPackagingTime = new System.Windows.Forms.Label();
            this.lblTemperTime = new System.Windows.Forms.Label();
            this.lblGrindTime = new System.Windows.Forms.Label();
            this.lblCrackTime = new System.Windows.Forms.Label();
            this.lblRoastTime = new System.Windows.Forms.Label();
            this.lblPackaging = new System.Windows.Forms.Label();
            this.lblTemper = new System.Windows.Forms.Label();
            this.lblGrind = new System.Windows.Forms.Label();
            this.lblCrack = new System.Windows.Forms.Label();
            this.lblRoast = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVorigTijd = new System.Windows.Forms.Button();
            this.btnVolgendTijd = new System.Windows.Forms.Button();
            this.lblReservatieID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlThisBatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(308, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 262);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblStartDiagram
            // 
            this.lblStartDiagram.AutoSize = true;
            this.lblStartDiagram.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartDiagram.Location = new System.Drawing.Point(308, 56);
            this.lblStartDiagram.Name = "lblStartDiagram";
            this.lblStartDiagram.Size = new System.Drawing.Size(46, 17);
            this.lblStartDiagram.TabIndex = 1;
            this.lblStartDiagram.Text = "label1";
            // 
            // lblEndDiagram
            // 
            this.lblEndDiagram.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndDiagram.Location = new System.Drawing.Point(671, 56);
            this.lblEndDiagram.Name = "lblEndDiagram";
            this.lblEndDiagram.Size = new System.Drawing.Size(219, 20);
            this.lblEndDiagram.TabIndex = 2;
            this.lblEndDiagram.Text = "label2";
            this.lblEndDiagram.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlNamesMachines
            // 
            this.pnlNamesMachines.Location = new System.Drawing.Point(39, 93);
            this.pnlNamesMachines.Name = "pnlNamesMachines";
            this.pnlNamesMachines.Size = new System.Drawing.Size(237, 262);
            this.pnlNamesMachines.TabIndex = 1;
            this.pnlNamesMachines.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNamesMachines_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Overzicht Machines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deze Batch";
            // 
            // pnlThisBatch
            // 
            this.pnlThisBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThisBatch.Controls.Add(this.lblReservatieID);
            this.pnlThisBatch.Controls.Add(this.label11);
            this.pnlThisBatch.Controls.Add(this.lblID);
            this.pnlThisBatch.Controls.Add(this.lblHoudbaarheid);
            this.pnlThisBatch.Controls.Add(this.label9);
            this.pnlThisBatch.Controls.Add(this.label8);
            this.pnlThisBatch.Controls.Add(this.lblPackagingTime);
            this.pnlThisBatch.Controls.Add(this.lblTemperTime);
            this.pnlThisBatch.Controls.Add(this.lblGrindTime);
            this.pnlThisBatch.Controls.Add(this.lblCrackTime);
            this.pnlThisBatch.Controls.Add(this.lblRoastTime);
            this.pnlThisBatch.Controls.Add(this.lblPackaging);
            this.pnlThisBatch.Controls.Add(this.lblTemper);
            this.pnlThisBatch.Controls.Add(this.lblGrind);
            this.pnlThisBatch.Controls.Add(this.lblCrack);
            this.pnlThisBatch.Controls.Add(this.lblRoast);
            this.pnlThisBatch.Controls.Add(this.label7);
            this.pnlThisBatch.Controls.Add(this.label6);
            this.pnlThisBatch.Controls.Add(this.label5);
            this.pnlThisBatch.Controls.Add(this.label4);
            this.pnlThisBatch.Controls.Add(this.label3);
            this.pnlThisBatch.Location = new System.Drawing.Point(39, 429);
            this.pnlThisBatch.Name = "pnlThisBatch";
            this.pnlThisBatch.Size = new System.Drawing.Size(851, 370);
            this.pnlThisBatch.TabIndex = 1;
            this.pnlThisBatch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThisBatch_Paint);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(225, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(12, 17);
            this.lblID.TabIndex = 23;
            this.lblID.Text = " ";
            // 
            // lblHoudbaarheid
            // 
            this.lblHoudbaarheid.AutoSize = true;
            this.lblHoudbaarheid.BackColor = System.Drawing.Color.White;
            this.lblHoudbaarheid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoudbaarheid.Location = new System.Drawing.Point(225, 90);
            this.lblHoudbaarheid.Name = "lblHoudbaarheid";
            this.lblHoudbaarheid.Size = new System.Drawing.Size(12, 17);
            this.lblHoudbaarheid.TabIndex = 22;
            this.lblHoudbaarheid.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Houdbaarheid:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Batch Id:";
            // 
            // lblPackagingTime
            // 
            this.lblPackagingTime.AutoSize = true;
            this.lblPackagingTime.BackColor = System.Drawing.Color.White;
            this.lblPackagingTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackagingTime.Location = new System.Drawing.Point(485, 283);
            this.lblPackagingTime.Name = "lblPackagingTime";
            this.lblPackagingTime.Size = new System.Drawing.Size(12, 17);
            this.lblPackagingTime.TabIndex = 19;
            this.lblPackagingTime.Text = " ";
            // 
            // lblTemperTime
            // 
            this.lblTemperTime.AutoSize = true;
            this.lblTemperTime.BackColor = System.Drawing.Color.White;
            this.lblTemperTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemperTime.Location = new System.Drawing.Point(485, 245);
            this.lblTemperTime.Name = "lblTemperTime";
            this.lblTemperTime.Size = new System.Drawing.Size(12, 17);
            this.lblTemperTime.TabIndex = 18;
            this.lblTemperTime.Text = " ";
            // 
            // lblGrindTime
            // 
            this.lblGrindTime.AutoSize = true;
            this.lblGrindTime.BackColor = System.Drawing.Color.White;
            this.lblGrindTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrindTime.Location = new System.Drawing.Point(485, 207);
            this.lblGrindTime.Name = "lblGrindTime";
            this.lblGrindTime.Size = new System.Drawing.Size(12, 17);
            this.lblGrindTime.TabIndex = 17;
            this.lblGrindTime.Text = " ";
            // 
            // lblCrackTime
            // 
            this.lblCrackTime.AutoSize = true;
            this.lblCrackTime.BackColor = System.Drawing.Color.White;
            this.lblCrackTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCrackTime.Location = new System.Drawing.Point(485, 169);
            this.lblCrackTime.Name = "lblCrackTime";
            this.lblCrackTime.Size = new System.Drawing.Size(12, 17);
            this.lblCrackTime.TabIndex = 16;
            this.lblCrackTime.Text = " ";
            // 
            // lblRoastTime
            // 
            this.lblRoastTime.AutoSize = true;
            this.lblRoastTime.BackColor = System.Drawing.Color.White;
            this.lblRoastTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoastTime.Location = new System.Drawing.Point(485, 131);
            this.lblRoastTime.Name = "lblRoastTime";
            this.lblRoastTime.Size = new System.Drawing.Size(12, 17);
            this.lblRoastTime.TabIndex = 15;
            this.lblRoastTime.Text = " ";
            // 
            // lblPackaging
            // 
            this.lblPackaging.AutoSize = true;
            this.lblPackaging.BackColor = System.Drawing.Color.White;
            this.lblPackaging.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPackaging.Location = new System.Drawing.Point(224, 283);
            this.lblPackaging.Name = "lblPackaging";
            this.lblPackaging.Size = new System.Drawing.Size(12, 17);
            this.lblPackaging.TabIndex = 14;
            this.lblPackaging.Text = " ";
            // 
            // lblTemper
            // 
            this.lblTemper.AutoSize = true;
            this.lblTemper.BackColor = System.Drawing.Color.White;
            this.lblTemper.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemper.Location = new System.Drawing.Point(224, 245);
            this.lblTemper.Name = "lblTemper";
            this.lblTemper.Size = new System.Drawing.Size(12, 17);
            this.lblTemper.TabIndex = 13;
            this.lblTemper.Text = " ";
            // 
            // lblGrind
            // 
            this.lblGrind.AutoSize = true;
            this.lblGrind.BackColor = System.Drawing.Color.White;
            this.lblGrind.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrind.Location = new System.Drawing.Point(224, 207);
            this.lblGrind.Name = "lblGrind";
            this.lblGrind.Size = new System.Drawing.Size(12, 17);
            this.lblGrind.TabIndex = 12;
            this.lblGrind.Text = " ";
            // 
            // lblCrack
            // 
            this.lblCrack.AutoSize = true;
            this.lblCrack.BackColor = System.Drawing.Color.White;
            this.lblCrack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCrack.Location = new System.Drawing.Point(224, 169);
            this.lblCrack.Name = "lblCrack";
            this.lblCrack.Size = new System.Drawing.Size(12, 17);
            this.lblCrack.TabIndex = 11;
            this.lblCrack.Text = " ";
            // 
            // lblRoast
            // 
            this.lblRoast.AutoSize = true;
            this.lblRoast.BackColor = System.Drawing.Color.White;
            this.lblRoast.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoast.Location = new System.Drawing.Point(224, 131);
            this.lblRoast.Name = "lblRoast";
            this.lblRoast.Size = new System.Drawing.Size(12, 17);
            this.lblRoast.TabIndex = 10;
            this.lblRoast.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Packagingmachine:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Temperingmachine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Grindmachine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crackmachine:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Roastmachine:";
            // 
            // btnVorigTijd
            // 
            this.btnVorigTijd.Location = new System.Drawing.Point(480, 50);
            this.btnVorigTijd.Name = "btnVorigTijd";
            this.btnVorigTijd.Size = new System.Drawing.Size(29, 29);
            this.btnVorigTijd.TabIndex = 5;
            this.btnVorigTijd.Text = "<";
            this.btnVorigTijd.UseVisualStyleBackColor = true;
            this.btnVorigTijd.Click += new System.EventHandler(this.btnVorigTijd_Click);
            // 
            // btnVolgendTijd
            // 
            this.btnVolgendTijd.Location = new System.Drawing.Point(627, 50);
            this.btnVolgendTijd.Name = "btnVolgendTijd";
            this.btnVolgendTijd.Size = new System.Drawing.Size(29, 29);
            this.btnVolgendTijd.TabIndex = 6;
            this.btnVolgendTijd.Text = ">";
            this.btnVolgendTijd.UseVisualStyleBackColor = true;
            this.btnVolgendTijd.Click += new System.EventHandler(this.btnVolgendTijd_Click);
            // 
            // lblReservatieID
            // 
            this.lblReservatieID.AutoSize = true;
            this.lblReservatieID.BackColor = System.Drawing.Color.White;
            this.lblReservatieID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservatieID.Location = new System.Drawing.Point(225, 56);
            this.lblReservatieID.Name = "lblReservatieID";
            this.lblReservatieID.Size = new System.Drawing.Size(12, 17);
            this.lblReservatieID.TabIndex = 25;
            this.lblReservatieID.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(30, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Reservatie Id:";
            // 
            // FrmMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(932, 873);
            this.Controls.Add(this.btnVolgendTijd);
            this.Controls.Add(this.btnVorigTijd);
            this.Controls.Add(this.pnlThisBatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlNamesMachines);
            this.Controls.Add(this.lblEndDiagram);
            this.Controls.Add(this.lblStartDiagram);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMachines";
            this.Text = "Machines";
            this.Load += new System.EventHandler(this.FrmMachines_Load);
            this.pnlThisBatch.ResumeLayout(false);
            this.pnlThisBatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStartDiagram;
        private System.Windows.Forms.Label lblEndDiagram;
        private System.Windows.Forms.Panel pnlNamesMachines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlThisBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPackaging;
        private System.Windows.Forms.Label lblTemper;
        private System.Windows.Forms.Label lblGrind;
        private System.Windows.Forms.Label lblCrack;
        private System.Windows.Forms.Label lblRoast;
        private System.Windows.Forms.Label lblPackagingTime;
        private System.Windows.Forms.Label lblTemperTime;
        private System.Windows.Forms.Label lblGrindTime;
        private System.Windows.Forms.Label lblCrackTime;
        private System.Windows.Forms.Label lblRoastTime;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHoudbaarheid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVorigTijd;
        private System.Windows.Forms.Button btnVolgendTijd;
        private System.Windows.Forms.Label lblReservatieID;
        private System.Windows.Forms.Label label11;
    }
}