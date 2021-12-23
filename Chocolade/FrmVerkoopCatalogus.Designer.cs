
namespace Chocolade
{
    partial class FrmVerkoopCatalogus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.txtHoeveelheid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAfwerken = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.lvwCatalogus = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order";
            // 
            // lbOrder
            // 
            this.lbOrder.Enabled = false;
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 15;
            this.lbOrder.Location = new System.Drawing.Point(32, 248);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(653, 154);
            this.lbOrder.TabIndex = 3;
            // 
            // txtHoeveelheid
            // 
            this.txtHoeveelheid.Location = new System.Drawing.Point(392, 215);
            this.txtHoeveelheid.Name = "txtHoeveelheid";
            this.txtHoeveelheid.Size = new System.Drawing.Size(186, 23);
            this.txtHoeveelheid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoeveelheid";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(584, 215);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(101, 23);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAfwerken
            // 
            this.btnAfwerken.Location = new System.Drawing.Point(584, 408);
            this.btnAfwerken.Name = "btnAfwerken";
            this.btnAfwerken.Size = new System.Drawing.Size(101, 23);
            this.btnAfwerken.TabIndex = 7;
            this.btnAfwerken.Text = "Afwerken";
            this.btnAfwerken.UseVisualStyleBackColor = true;
            this.btnAfwerken.Click += new System.EventHandler(this.btnAfwerken_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(477, 408);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(101, 23);
            this.btnAnnuleren.TabIndex = 8;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(584, 437);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(101, 23);
            this.btnSluiten.TabIndex = 9;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // lvwCatalogus
            // 
            this.lvwCatalogus.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwCatalogus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwCatalogus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwCatalogus.FullRowSelect = true;
            this.lvwCatalogus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwCatalogus.HideSelection = false;
            this.lvwCatalogus.LabelWrap = false;
            this.lvwCatalogus.Location = new System.Drawing.Point(32, 42);
            this.lvwCatalogus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwCatalogus.Name = "lvwCatalogus";
            this.lvwCatalogus.Size = new System.Drawing.Size(594, 168);
            this.lvwCatalogus.TabIndex = 10;
            this.lvwCatalogus.UseCompatibleStateImageBehavior = false;
            this.lvwCatalogus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type chocolade";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prijs per kg";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Houdbaarheidsperiode";
            this.columnHeader3.Width = 180;
            // 
            // FrmVerkoopCatalogus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 478);
            this.Controls.Add(this.lvwCatalogus);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAfwerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoeveelheid);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerkoopCatalogus";
            this.Text = "FrmVerkoopCatalogus";
            this.Load += new System.EventHandler(this.FrmVerkoopCatalogus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.TextBox txtHoeveelheid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnAfwerken;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.ListView lvwCatalogus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}