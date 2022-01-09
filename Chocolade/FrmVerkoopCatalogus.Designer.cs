
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
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.grbTypeBestelling = new System.Windows.Forms.GroupBox();
            this.radXml = new System.Windows.Forms.RadioButton();
            this.radManueel = new System.Windows.Forms.RadioButton();
            this.lbXmlOrders = new System.Windows.Forms.ListBox();
            this.grbTypeBestelling.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order";
            // 
            // txtHoeveelheid
            // 
            this.txtHoeveelheid.Location = new System.Drawing.Point(385, 317);
            this.txtHoeveelheid.Name = "txtHoeveelheid";
            this.txtHoeveelheid.Size = new System.Drawing.Size(186, 23);
            this.txtHoeveelheid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoeveelheid";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(577, 317);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(101, 23);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAfwerken
            // 
            this.btnAfwerken.Location = new System.Drawing.Point(577, 510);
            this.btnAfwerken.Name = "btnAfwerken";
            this.btnAfwerken.Size = new System.Drawing.Size(101, 23);
            this.btnAfwerken.TabIndex = 7;
            this.btnAfwerken.Text = "Afwerken";
            this.btnAfwerken.UseVisualStyleBackColor = true;
            this.btnAfwerken.Click += new System.EventHandler(this.btnAfwerken_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(470, 510);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(101, 23);
            this.btnAnnuleren.TabIndex = 8;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(577, 539);
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
            this.lvwCatalogus.Location = new System.Drawing.Point(25, 144);
            this.lvwCatalogus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwCatalogus.Name = "lvwCatalogus";
            this.lvwCatalogus.Size = new System.Drawing.Size(653, 168);
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
            // lvwOrder
            // 
            this.lvwOrder.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwOrder.FullRowSelect = true;
            this.lvwOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.LabelWrap = false;
            this.lvwOrder.Location = new System.Drawing.Point(25, 357);
            this.lvwOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(653, 148);
            this.lvwOrder.TabIndex = 11;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type chocolade";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hoeveelheid";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Houdbaarheidsdatum";
            this.columnHeader7.Width = 180;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prijs";
            // 
            // grbTypeBestelling
            // 
            this.grbTypeBestelling.Controls.Add(this.radXml);
            this.grbTypeBestelling.Controls.Add(this.radManueel);
            this.grbTypeBestelling.Location = new System.Drawing.Point(25, 12);
            this.grbTypeBestelling.Name = "grbTypeBestelling";
            this.grbTypeBestelling.Size = new System.Drawing.Size(200, 100);
            this.grbTypeBestelling.TabIndex = 12;
            this.grbTypeBestelling.TabStop = false;
            this.grbTypeBestelling.Text = "Type bestelling";
            // 
            // radXml
            // 
            this.radXml.AutoSize = true;
            this.radXml.Location = new System.Drawing.Point(20, 62);
            this.radXml.Name = "radXml";
            this.radXml.Size = new System.Drawing.Size(49, 19);
            this.radXml.TabIndex = 1;
            this.radXml.TabStop = true;
            this.radXml.Text = "XML";
            this.radXml.UseVisualStyleBackColor = true;
            this.radXml.CheckedChanged += new System.EventHandler(this.radXml_CheckedChanged);
            // 
            // radManueel
            // 
            this.radManueel.AutoSize = true;
            this.radManueel.Location = new System.Drawing.Point(20, 28);
            this.radManueel.Name = "radManueel";
            this.radManueel.Size = new System.Drawing.Size(71, 19);
            this.radManueel.TabIndex = 0;
            this.radManueel.TabStop = true;
            this.radManueel.Text = "Manueel";
            this.radManueel.UseVisualStyleBackColor = true;
            this.radManueel.CheckedChanged += new System.EventHandler(this.radManueel_CheckedChanged);
            // 
            // lbXmlOrders
            // 
            this.lbXmlOrders.FormattingEnabled = true;
            this.lbXmlOrders.ItemHeight = 15;
            this.lbXmlOrders.Location = new System.Drawing.Point(259, 12);
            this.lbXmlOrders.Name = "lbXmlOrders";
            this.lbXmlOrders.Size = new System.Drawing.Size(419, 94);
            this.lbXmlOrders.TabIndex = 13;
            this.lbXmlOrders.SelectedIndexChanged += new System.EventHandler(this.lbXmlOrders_SelectedIndexChanged);
            // 
            // FrmVerkoopCatalogus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.lbXmlOrders);
            this.Controls.Add(this.grbTypeBestelling);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.lvwCatalogus);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAfwerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoeveelheid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerkoopCatalogus";
            this.Text = "FrmVerkoopCatalogus";
            this.Load += new System.EventHandler(this.FrmVerkoopCatalogus_Load);
            this.grbTypeBestelling.ResumeLayout(false);
            this.grbTypeBestelling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ListView lvwOrder;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox grbTypeBestelling;
        private System.Windows.Forms.RadioButton radXml;
        private System.Windows.Forms.RadioButton radManueel;
        private System.Windows.Forms.ListBox lbXmlOrders;
    }
}