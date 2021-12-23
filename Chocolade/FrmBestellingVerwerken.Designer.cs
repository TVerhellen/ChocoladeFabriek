
namespace Chocolade
{
    partial class FrmBestellingVerwerken
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
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.lblOrderNummer = new System.Windows.Forms.Label();
            this.btnAfwerken = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.lvwBatches = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 15;
            this.lbOrders.Location = new System.Drawing.Point(28, 26);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(419, 124);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged);
            // 
            // lblOrderNummer
            // 
            this.lblOrderNummer.AutoSize = true;
            this.lblOrderNummer.Location = new System.Drawing.Point(28, 173);
            this.lblOrderNummer.Name = "lblOrderNummer";
            this.lblOrderNummer.Size = new System.Drawing.Size(35, 15);
            this.lblOrderNummer.TabIndex = 2;
            this.lblOrderNummer.Text = "order";
            // 
            // btnAfwerken
            // 
            this.btnAfwerken.Enabled = false;
            this.btnAfwerken.Location = new System.Drawing.Point(453, 26);
            this.btnAfwerken.Name = "btnAfwerken";
            this.btnAfwerken.Size = new System.Drawing.Size(96, 23);
            this.btnAfwerken.TabIndex = 3;
            this.btnAfwerken.Text = "Afwerken";
            this.btnAfwerken.UseVisualStyleBackColor = true;
            this.btnAfwerken.Click += new System.EventHandler(this.btnAfwerken_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Enabled = false;
            this.btnVerwijderen.Location = new System.Drawing.Point(453, 77);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(96, 23);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(453, 127);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(96, 23);
            this.btnSluiten.TabIndex = 5;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // lvwBatches
            // 
            this.lvwBatches.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwBatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwBatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwBatches.FullRowSelect = true;
            this.lvwBatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwBatches.HideSelection = false;
            this.lvwBatches.LabelWrap = false;
            this.lvwBatches.Location = new System.Drawing.Point(28, 190);
            this.lvwBatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwBatches.Name = "lvwBatches";
            this.lvwBatches.Size = new System.Drawing.Size(521, 231);
            this.lvwBatches.TabIndex = 6;
            this.lvwBatches.UseCompatibleStateImageBehavior = false;
            this.lvwBatches.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type chocolade";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hoeveelheid";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Houdbaarheidsdatum";
            this.columnHeader3.Width = 180;
            // 
            // FrmBestellingVerwerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwBatches);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAfwerken);
            this.Controls.Add(this.lblOrderNummer);
            this.Controls.Add(this.lbOrders);
            this.Name = "FrmBestellingVerwerken";
            this.Text = "FrmBestellingVerwerken";
            this.Load += new System.EventHandler(this.FrmBestellingVerwerken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Label lblOrderNummer;
        private System.Windows.Forms.Button btnAfwerken;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.ListView lvwBatches;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}