
namespace Chocolade
{
    partial class FrmOrderAanmaken
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLeverancier = new System.Windows.Forms.ComboBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtBtw = new System.Windows.Forms.TextBox();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.btnArtikelToevoegen = new System.Windows.Forms.Button();
            this.txtHoeveelheid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvCatalogus = new System.Windows.Forms.ListView();
            this.chArtikelnummer = new System.Windows.Forms.ColumnHeader();
            this.chArtikelnaam = new System.Windows.Forms.ColumnHeader();
            this.chEenheid = new System.Windows.Forms.ColumnHeader();
            this.chPrijs = new System.Windows.Forms.ColumnHeader();
            this.chTotaleprijs = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOrderPlaatsen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalePrijs = new System.Windows.Forms.Label();
            this.lvOrderAanmaken = new System.Windows.Forms.ListView();
            this.chArtikelnummerOrderPlaatsen = new System.Windows.Forms.ColumnHeader();
            this.chArtikelnaamOrderPlaatsen = new System.Windows.Forms.ColumnHeader();
            this.chHoeveelheidOrderPlaatsen = new System.Windows.Forms.ColumnHeader();
            this.chEenheidOrderPlaatsen = new System.Windows.Forms.ColumnHeader();
            this.chPrijsOrderPlaatsen = new System.Windows.Forms.ColumnHeader();
            this.chTotalePrijsOrderPlaatsen = new System.Windows.Forms.ColumnHeader();
            this.dtpDatumOrder = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSelecteerBestand = new System.Windows.Forms.Label();
            this.txtPadBestand = new System.Windows.Forms.TextBox();
            this.btnSelecteerBestand = new System.Windows.Forms.Button();
            this.btnImporteerBestand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLijnVerwijderen = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.lblTotaleHoeveelheid = new System.Windows.Forms.Label();
            this.lblTotaleHoeveelheidInput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtStraatnaam = new System.Windows.Forms.TextBox();
            this.txtStraatnummer = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leverancier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Btw nummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum order:";
            // 
            // cmbLeverancier
            // 
            this.cmbLeverancier.FormattingEnabled = true;
            this.cmbLeverancier.Location = new System.Drawing.Point(189, 64);
            this.cmbLeverancier.Name = "cmbLeverancier";
            this.cmbLeverancier.Size = new System.Drawing.Size(254, 28);
            this.cmbLeverancier.TabIndex = 5;
            this.cmbLeverancier.SelectedIndexChanged += new System.EventHandler(this.cmbLeverancier_SelectedIndexChanged);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(189, 25);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(114, 27);
            this.txtDatum.TabIndex = 6;
            // 
            // txtBtw
            // 
            this.txtBtw.Location = new System.Drawing.Point(189, 177);
            this.txtBtw.Name = "txtBtw";
            this.txtBtw.ReadOnly = true;
            this.txtBtw.Size = new System.Drawing.Size(149, 27);
            this.txtBtw.TabIndex = 8;
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(308, 136);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.ReadOnly = true;
            this.txtGemeente.Size = new System.Drawing.Size(135, 27);
            this.txtGemeente.TabIndex = 9;
            // 
            // btnArtikelToevoegen
            // 
            this.btnArtikelToevoegen.Location = new System.Drawing.Point(565, 469);
            this.btnArtikelToevoegen.Name = "btnArtikelToevoegen";
            this.btnArtikelToevoegen.Size = new System.Drawing.Size(210, 61);
            this.btnArtikelToevoegen.TabIndex = 12;
            this.btnArtikelToevoegen.Text = "Artikel toevoegen aan orderlijst";
            this.btnArtikelToevoegen.UseVisualStyleBackColor = true;
            this.btnArtikelToevoegen.Click += new System.EventHandler(this.btnArtikelToevoegen_Click);
            // 
            // txtHoeveelheid
            // 
            this.txtHoeveelheid.Location = new System.Drawing.Point(189, 486);
            this.txtHoeveelheid.Name = "txtHoeveelheid";
            this.txtHoeveelheid.Size = new System.Drawing.Size(246, 27);
            this.txtHoeveelheid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hoeveelheid:";
            // 
            // lvCatalogus
            // 
            this.lvCatalogus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArtikelnummer,
            this.chArtikelnaam,
            this.chEenheid,
            this.chPrijs,
            this.chTotaleprijs});
            this.lvCatalogus.FullRowSelect = true;
            this.lvCatalogus.GridLines = true;
            this.lvCatalogus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCatalogus.HideSelection = false;
            this.lvCatalogus.HoverSelection = true;
            this.lvCatalogus.Location = new System.Drawing.Point(27, 219);
            this.lvCatalogus.MultiSelect = false;
            this.lvCatalogus.Name = "lvCatalogus";
            this.lvCatalogus.Size = new System.Drawing.Size(748, 232);
            this.lvCatalogus.TabIndex = 17;
            this.lvCatalogus.UseCompatibleStateImageBehavior = false;
            this.lvCatalogus.View = System.Windows.Forms.View.Details;
            // 
            // chArtikelnummer
            // 
            this.chArtikelnummer.Text = "Artikelnummer";
            this.chArtikelnummer.Width = 125;
            // 
            // chArtikelnaam
            // 
            this.chArtikelnaam.Text = "Artikelnaam";
            this.chArtikelnaam.Width = 300;
            // 
            // chEenheid
            // 
            this.chEenheid.Text = "Eenheid";
            this.chEenheid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEenheid.Width = 80;
            // 
            // chPrijs
            // 
            this.chPrijs.Text = "Prijs";
            this.chPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrijs.Width = 125;
            // 
            // chTotaleprijs
            // 
            this.chTotaleprijs.Text = "Totale prijs";
            this.chTotaleprijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTotaleprijs.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kg";
            // 
            // btnOrderPlaatsen
            // 
            this.btnOrderPlaatsen.Location = new System.Drawing.Point(807, 572);
            this.btnOrderPlaatsen.Name = "btnOrderPlaatsen";
            this.btnOrderPlaatsen.Size = new System.Drawing.Size(115, 56);
            this.btnOrderPlaatsen.TabIndex = 22;
            this.btnOrderPlaatsen.Text = "Order plaatsen";
            this.btnOrderPlaatsen.UseVisualStyleBackColor = true;
            this.btnOrderPlaatsen.Click += new System.EventHandler(this.btnOrderPlaatsen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 813);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Totale prijs exl. Btw:";
            // 
            // lblTotalePrijs
            // 
            this.lblTotalePrijs.AutoSize = true;
            this.lblTotalePrijs.Location = new System.Drawing.Point(668, 813);
            this.lblTotalePrijs.Name = "lblTotalePrijs";
            this.lblTotalePrijs.Size = new System.Drawing.Size(12, 20);
            this.lblTotalePrijs.TabIndex = 24;
            this.lblTotalePrijs.Text = ".";
            // 
            // lvOrderAanmaken
            // 
            this.lvOrderAanmaken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArtikelnummerOrderPlaatsen,
            this.chArtikelnaamOrderPlaatsen,
            this.chHoeveelheidOrderPlaatsen,
            this.chEenheidOrderPlaatsen,
            this.chPrijsOrderPlaatsen,
            this.chTotalePrijsOrderPlaatsen});
            this.lvOrderAanmaken.FullRowSelect = true;
            this.lvOrderAanmaken.GridLines = true;
            this.lvOrderAanmaken.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOrderAanmaken.HideSelection = false;
            this.lvOrderAanmaken.HoverSelection = true;
            this.lvOrderAanmaken.Location = new System.Drawing.Point(27, 551);
            this.lvOrderAanmaken.Name = "lvOrderAanmaken";
            this.lvOrderAanmaken.Size = new System.Drawing.Size(748, 246);
            this.lvOrderAanmaken.TabIndex = 25;
            this.lvOrderAanmaken.UseCompatibleStateImageBehavior = false;
            this.lvOrderAanmaken.View = System.Windows.Forms.View.Details;
            // 
            // chArtikelnummerOrderPlaatsen
            // 
            this.chArtikelnummerOrderPlaatsen.Text = "Artikelnummer";
            this.chArtikelnummerOrderPlaatsen.Width = 110;
            // 
            // chArtikelnaamOrderPlaatsen
            // 
            this.chArtikelnaamOrderPlaatsen.Text = "Artikelnaam";
            this.chArtikelnaamOrderPlaatsen.Width = 250;
            // 
            // chHoeveelheidOrderPlaatsen
            // 
            this.chHoeveelheidOrderPlaatsen.Text = "Hoeveelheid";
            this.chHoeveelheidOrderPlaatsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHoeveelheidOrderPlaatsen.Width = 100;
            // 
            // chEenheidOrderPlaatsen
            // 
            this.chEenheidOrderPlaatsen.Text = "Eenheid";
            this.chEenheidOrderPlaatsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEenheidOrderPlaatsen.Width = 65;
            // 
            // chPrijsOrderPlaatsen
            // 
            this.chPrijsOrderPlaatsen.Text = "Prijs";
            this.chPrijsOrderPlaatsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrijsOrderPlaatsen.Width = 110;
            // 
            // chTotalePrijsOrderPlaatsen
            // 
            this.chTotalePrijsOrderPlaatsen.Text = "Totale prijs";
            this.chTotalePrijsOrderPlaatsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTotalePrijsOrderPlaatsen.Width = 115;
            // 
            // dtpDatumOrder
            // 
            this.dtpDatumOrder.Location = new System.Drawing.Point(664, 23);
            this.dtpDatumOrder.Name = "dtpDatumOrder";
            this.dtpDatumOrder.Size = new System.Drawing.Size(229, 27);
            this.dtpDatumOrder.TabIndex = 26;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "cccccc";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.CommonProgramFiles;
            // 
            // lblSelecteerBestand
            // 
            this.lblSelecteerBestand.AutoSize = true;
            this.lblSelecteerBestand.Location = new System.Drawing.Point(474, 72);
            this.lblSelecteerBestand.Name = "lblSelecteerBestand";
            this.lblSelecteerBestand.Size = new System.Drawing.Size(159, 20);
            this.lblSelecteerBestand.TabIndex = 27;
            this.lblSelecteerBestand.Text = "Selecteer Xml.bestand:";
            // 
            // txtPadBestand
            // 
            this.txtPadBestand.Location = new System.Drawing.Point(664, 72);
            this.txtPadBestand.Name = "txtPadBestand";
            this.txtPadBestand.ReadOnly = true;
            this.txtPadBestand.Size = new System.Drawing.Size(150, 27);
            this.txtPadBestand.TabIndex = 28;
            // 
            // btnSelecteerBestand
            // 
            this.btnSelecteerBestand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelecteerBestand.Location = new System.Drawing.Point(812, 72);
            this.btnSelecteerBestand.Name = "btnSelecteerBestand";
            this.btnSelecteerBestand.Size = new System.Drawing.Size(39, 27);
            this.btnSelecteerBestand.TabIndex = 29;
            this.btnSelecteerBestand.Text = "...";
            this.btnSelecteerBestand.UseVisualStyleBackColor = true;
            // 
            // btnImporteerBestand
            // 
            this.btnImporteerBestand.Location = new System.Drawing.Point(664, 112);
            this.btnImporteerBestand.Name = "btnImporteerBestand";
            this.btnImporteerBestand.Size = new System.Drawing.Size(187, 43);
            this.btnImporteerBestand.TabIndex = 30;
            this.btnImporteerBestand.Text = "Importeer";
            this.btnImporteerBestand.UseVisualStyleBackColor = true;
            this.btnImporteerBestand.Click += new System.EventHandler(this.btnImporteerBestand_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(807, 235);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 48);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset artikelbestand";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLijnVerwijderen
            // 
            this.btnLijnVerwijderen.Location = new System.Drawing.Point(807, 634);
            this.btnLijnVerwijderen.Name = "btnLijnVerwijderen";
            this.btnLijnVerwijderen.Size = new System.Drawing.Size(115, 56);
            this.btnLijnVerwijderen.TabIndex = 32;
            this.btnLijnVerwijderen.Text = "Lijn verwijderen";
            this.btnLijnVerwijderen.UseVisualStyleBackColor = true;
            this.btnLijnVerwijderen.Click += new System.EventHandler(this.btnLijnVerwijderen_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(807, 696);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(115, 56);
            this.btnResetOrder.TabIndex = 33;
            this.btnResetOrder.Text = "Reset order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // lblTotaleHoeveelheid
            // 
            this.lblTotaleHoeveelheid.AutoSize = true;
            this.lblTotaleHoeveelheid.Location = new System.Drawing.Point(250, 813);
            this.lblTotaleHoeveelheid.Name = "lblTotaleHoeveelheid";
            this.lblTotaleHoeveelheid.Size = new System.Drawing.Size(138, 20);
            this.lblTotaleHoeveelheid.TabIndex = 34;
            this.lblTotaleHoeveelheid.Text = "Totale hoeveelheid:";
            // 
            // lblTotaleHoeveelheidInput
            // 
            this.lblTotaleHoeveelheidInput.AutoSize = true;
            this.lblTotaleHoeveelheidInput.Location = new System.Drawing.Point(394, 813);
            this.lblTotaleHoeveelheidInput.Name = "lblTotaleHoeveelheidInput";
            this.lblTotaleHoeveelheidInput.Size = new System.Drawing.Size(12, 20);
            this.lblTotaleHoeveelheidInput.TabIndex = 35;
            this.lblTotaleHoeveelheidInput.Text = ".";
            this.lblTotaleHoeveelheidInput.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 813);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 813);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "€";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(27, 103);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(50, 20);
            this.lblAdres.TabIndex = 38;
            this.lblAdres.Text = "Adres:";
            // 
            // txtStraatnaam
            // 
            this.txtStraatnaam.Location = new System.Drawing.Point(189, 103);
            this.txtStraatnaam.Name = "txtStraatnaam";
            this.txtStraatnaam.ReadOnly = true;
            this.txtStraatnaam.Size = new System.Drawing.Size(187, 27);
            this.txtStraatnaam.TabIndex = 39;
            // 
            // txtStraatnummer
            // 
            this.txtStraatnummer.Location = new System.Drawing.Point(394, 103);
            this.txtStraatnummer.Name = "txtStraatnummer";
            this.txtStraatnummer.ReadOnly = true;
            this.txtStraatnummer.Size = new System.Drawing.Size(49, 27);
            this.txtStraatnummer.TabIndex = 40;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(189, 136);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.ReadOnly = true;
            this.txtPostCode.Size = new System.Drawing.Size(86, 27);
            this.txtPostCode.TabIndex = 41;
            // 
            // FrmOrderAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 871);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtStraatnummer);
            this.Controls.Add(this.txtStraatnaam);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotaleHoeveelheidInput);
            this.Controls.Add(this.lblTotaleHoeveelheid);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnLijnVerwijderen);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnImporteerBestand);
            this.Controls.Add(this.btnSelecteerBestand);
            this.Controls.Add(this.txtPadBestand);
            this.Controls.Add(this.lblSelecteerBestand);
            this.Controls.Add(this.dtpDatumOrder);
            this.Controls.Add(this.lvOrderAanmaken);
            this.Controls.Add(this.lblTotalePrijs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOrderPlaatsen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvCatalogus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoeveelheid);
            this.Controls.Add(this.btnArtikelToevoegen);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.txtBtw);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.cmbLeverancier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOrderAanmaken";
            this.Text = "FrmOrderAanmaken";
            this.Load += new System.EventHandler(this.FrmOrderAanmaken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLeverancier;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtBtw;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Button btnArtikelToevoegen;
        private System.Windows.Forms.TextBox txtHoeveelheid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvCatalogus;
        private System.Windows.Forms.ColumnHeader chArtikelnummer;
        private System.Windows.Forms.ColumnHeader chArtikelnaam;
        private System.Windows.Forms.ColumnHeader chEenheid;
        private System.Windows.Forms.ColumnHeader chPrijs;
        private System.Windows.Forms.ColumnHeader chTotaleprijs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOrderPlaatsen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalePrijs;
        private System.Windows.Forms.ListView lvOrderAanmaken;
        private System.Windows.Forms.ColumnHeader chArtikelnummerOrderPlaatsen;
        private System.Windows.Forms.ColumnHeader chArtikelnaamOrderPlaatsen;
        private System.Windows.Forms.ColumnHeader chEenheidOrderPlaatsen;
        private System.Windows.Forms.ColumnHeader chPrijsOrderPlaatsen;
        private System.Windows.Forms.ColumnHeader chTotalePrijsOrderPlaatsen;
        private System.Windows.Forms.ColumnHeader chHoeveelheidOrderPlaatsen;
        private System.Windows.Forms.DateTimePicker dtpDatumOrder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblSelecteerBestand;
        private System.Windows.Forms.TextBox txtPadBestand;
        private System.Windows.Forms.Button btnSelecteerBestand;
        private System.Windows.Forms.Button btnImporteerBestand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLijnVerwijderen;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label lblTotaleHoeveelheid;
        private System.Windows.Forms.Label lblTotaleHoeveelheidInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtStraatnaam;
        private System.Windows.Forms.TextBox txtStraatnummer;
        private System.Windows.Forms.TextBox txtPostCode;
    }
}