
namespace Chocolade
{
    partial class FrmOrderVerwerken
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
            this.lvBestelorder = new System.Windows.Forms.ListView();
            this.chArtikelnummer = new System.Windows.Forms.ColumnHeader();
            this.chKwaliteit = new System.Windows.Forms.ColumnHeader();
            this.chSoort = new System.Windows.Forms.ColumnHeader();
            this.chHoeveelheid = new System.Windows.Forms.ColumnHeader();
            this.chEenheid = new System.Windows.Forms.ColumnHeader();
            this.chPrijs = new System.Windows.Forms.ColumnHeader();
            this.chTotalePrijs = new System.Windows.Forms.ColumnHeader();
            this.lvLeveringsbon = new System.Windows.Forms.ListView();
            this.chArtikelnr = new System.Windows.Forms.ColumnHeader();
            this.chKwaliteit2 = new System.Windows.Forms.ColumnHeader();
            this.chSoort2 = new System.Windows.Forms.ColumnHeader();
            this.chHoeveelheid2 = new System.Windows.Forms.ColumnHeader();
            this.chEenheid2 = new System.Windows.Forms.ColumnHeader();
            this.chPrijs2 = new System.Windows.Forms.ColumnHeader();
            this.chTotalePrijs2 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImporterenXml = new System.Windows.Forms.Button();
            this.btnGoedkeuren = new System.Windows.Forms.Button();
            this.btnWeigeren = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtleverancier = new System.Windows.Forms.TextBox();
            this.txtBestelref = new System.Windows.Forms.TextBox();
            this.btnPadXmlBestand = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXmlPad = new System.Windows.Forms.TextBox();
            this.openLeveringsbon = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lvBestelorder
            // 
            this.lvBestelorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBestelorder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArtikelnummer,
            this.chKwaliteit,
            this.chSoort,
            this.chHoeveelheid,
            this.chEenheid,
            this.chPrijs,
            this.chTotalePrijs});
            this.lvBestelorder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvBestelorder.HideSelection = false;
            this.lvBestelorder.Location = new System.Drawing.Point(28, 220);
            this.lvBestelorder.Name = "lvBestelorder";
            this.lvBestelorder.Size = new System.Drawing.Size(745, 223);
            this.lvBestelorder.TabIndex = 0;
            this.lvBestelorder.UseCompatibleStateImageBehavior = false;
            this.lvBestelorder.View = System.Windows.Forms.View.Details;
            this.lvBestelorder.SelectedIndexChanged += new System.EventHandler(this.lvBestelorder_SelectedIndexChanged);
            // 
            // chArtikelnummer
            // 
            this.chArtikelnummer.Text = "Artikelnummer";
            this.chArtikelnummer.Width = 110;
            // 
            // chKwaliteit
            // 
            this.chKwaliteit.Text = "Kwaliteit";
            this.chKwaliteit.Width = 110;
            // 
            // chSoort
            // 
            this.chSoort.Text = "Soort";
            this.chSoort.Width = 110;
            // 
            // chHoeveelheid
            // 
            this.chHoeveelheid.Text = "Hoeveelheid";
            this.chHoeveelheid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHoeveelheid.Width = 110;
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
            this.chPrijs.Width = 100;
            // 
            // chTotalePrijs
            // 
            this.chTotalePrijs.Text = "Totale prijs";
            this.chTotalePrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTotalePrijs.Width = 110;
            // 
            // lvLeveringsbon
            // 
            this.lvLeveringsbon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLeveringsbon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArtikelnr,
            this.chKwaliteit2,
            this.chSoort2,
            this.chHoeveelheid2,
            this.chEenheid2,
            this.chPrijs2,
            this.chTotalePrijs2});
            this.lvLeveringsbon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvLeveringsbon.HideSelection = false;
            this.lvLeveringsbon.Location = new System.Drawing.Point(28, 502);
            this.lvLeveringsbon.Name = "lvLeveringsbon";
            this.lvLeveringsbon.Size = new System.Drawing.Size(745, 223);
            this.lvLeveringsbon.TabIndex = 1;
            this.lvLeveringsbon.UseCompatibleStateImageBehavior = false;
            this.lvLeveringsbon.View = System.Windows.Forms.View.Details;
            // 
            // chArtikelnr
            // 
            this.chArtikelnr.Text = "Artikelnummer";
            this.chArtikelnr.Width = 110;
            // 
            // chKwaliteit2
            // 
            this.chKwaliteit2.Text = "Kwaliteit";
            this.chKwaliteit2.Width = 110;
            // 
            // chSoort2
            // 
            this.chSoort2.Text = "Soort";
            this.chSoort2.Width = 110;
            // 
            // chHoeveelheid2
            // 
            this.chHoeveelheid2.Text = "Hoeveelheid";
            this.chHoeveelheid2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHoeveelheid2.Width = 110;
            // 
            // chEenheid2
            // 
            this.chEenheid2.Text = "Eenheid";
            this.chEenheid2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEenheid2.Width = 80;
            // 
            // chPrijs2
            // 
            this.chPrijs2.Text = "Prijs";
            this.chPrijs2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrijs2.Width = 110;
            // 
            // chTotalePrijs2
            // 
            this.chTotalePrijs2.Text = "Totale prijs";
            this.chTotalePrijs2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTotalePrijs2.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bestelorder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leveringsbon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Leverancier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bestelref. :";
            // 
            // btnImporterenXml
            // 
            this.btnImporterenXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.btnImporterenXml.FlatAppearance.BorderSize = 0;
            this.btnImporterenXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImporterenXml.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImporterenXml.ForeColor = System.Drawing.Color.White;
            this.btnImporterenXml.Location = new System.Drawing.Point(769, 161);
            this.btnImporterenXml.Name = "btnImporterenXml";
            this.btnImporterenXml.Size = new System.Drawing.Size(165, 41);
            this.btnImporterenXml.TabIndex = 7;
            this.btnImporterenXml.Text = "Importeren Xml";
            this.btnImporterenXml.UseVisualStyleBackColor = false;
            this.btnImporterenXml.Click += new System.EventHandler(this.btnImporterenXml_Click);
            // 
            // btnGoedkeuren
            // 
            this.btnGoedkeuren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.btnGoedkeuren.FlatAppearance.BorderSize = 0;
            this.btnGoedkeuren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoedkeuren.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoedkeuren.ForeColor = System.Drawing.Color.White;
            this.btnGoedkeuren.Location = new System.Drawing.Point(787, 502);
            this.btnGoedkeuren.Name = "btnGoedkeuren";
            this.btnGoedkeuren.Size = new System.Drawing.Size(133, 42);
            this.btnGoedkeuren.TabIndex = 8;
            this.btnGoedkeuren.Text = "Goedkeuren";
            this.btnGoedkeuren.UseVisualStyleBackColor = false;
            this.btnGoedkeuren.Click += new System.EventHandler(this.btnGoedkeuren_Click);
            // 
            // btnWeigeren
            // 
            this.btnWeigeren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnWeigeren.FlatAppearance.BorderSize = 0;
            this.btnWeigeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeigeren.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeigeren.ForeColor = System.Drawing.Color.White;
            this.btnWeigeren.Location = new System.Drawing.Point(787, 566);
            this.btnWeigeren.Name = "btnWeigeren";
            this.btnWeigeren.Size = new System.Drawing.Size(133, 42);
            this.btnWeigeren.TabIndex = 9;
            this.btnWeigeren.Text = "Weigeren";
            this.btnWeigeren.UseVisualStyleBackColor = false;
            this.btnWeigeren.Click += new System.EventHandler(this.btnWeigeren_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.Color.White;
            this.txtDatum.Location = new System.Drawing.Point(137, 35);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(109, 27);
            this.txtDatum.TabIndex = 11;
            // 
            // txtleverancier
            // 
            this.txtleverancier.BackColor = System.Drawing.Color.White;
            this.txtleverancier.Location = new System.Drawing.Point(137, 76);
            this.txtleverancier.Name = "txtleverancier";
            this.txtleverancier.ReadOnly = true;
            this.txtleverancier.Size = new System.Drawing.Size(205, 27);
            this.txtleverancier.TabIndex = 12;
            // 
            // txtBestelref
            // 
            this.txtBestelref.BackColor = System.Drawing.Color.White;
            this.txtBestelref.Location = new System.Drawing.Point(137, 118);
            this.txtBestelref.Name = "txtBestelref";
            this.txtBestelref.ReadOnly = true;
            this.txtBestelref.Size = new System.Drawing.Size(205, 27);
            this.txtBestelref.TabIndex = 13;
            // 
            // btnPadXmlBestand
            // 
            this.btnPadXmlBestand.FlatAppearance.BorderSize = 0;
            this.btnPadXmlBestand.Location = new System.Drawing.Point(870, 116);
            this.btnPadXmlBestand.Name = "btnPadXmlBestand";
            this.btnPadXmlBestand.Size = new System.Drawing.Size(29, 27);
            this.btnPadXmlBestand.TabIndex = 14;
            this.btnPadXmlBestand.Text = "...";
            this.btnPadXmlBestand.UseVisualStyleBackColor = true;
            this.btnPadXmlBestand.Click += new System.EventHandler(this.btnPadXmlBestand_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(501, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Xml bestand selecteren:";
            // 
            // txtXmlPad
            // 
            this.txtXmlPad.BackColor = System.Drawing.Color.White;
            this.txtXmlPad.Location = new System.Drawing.Point(697, 116);
            this.txtXmlPad.Name = "txtXmlPad";
            this.txtXmlPad.ReadOnly = true;
            this.txtXmlPad.Size = new System.Drawing.Size(174, 27);
            this.txtXmlPad.TabIndex = 16;
            // 
            // openLeveringsbon
            // 
            this.openLeveringsbon.FileName = "openLeveringsbon";
            // 
            // FrmOrderVerwerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 758);
            this.Controls.Add(this.txtXmlPad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPadXmlBestand);
            this.Controls.Add(this.txtBestelref);
            this.Controls.Add(this.txtleverancier);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.btnWeigeren);
            this.Controls.Add(this.btnGoedkeuren);
            this.Controls.Add(this.btnImporterenXml);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLeveringsbon);
            this.Controls.Add(this.lvBestelorder);
            this.Name = "FrmOrderVerwerken";
            this.Text = "OrderVerwerken";
            this.Load += new System.EventHandler(this.FrmOrderVerwerken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvBestelorder;
        private System.Windows.Forms.ListView lvLeveringsbon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImporterenXml;
        private System.Windows.Forms.Button btnGoedkeuren;
        private System.Windows.Forms.Button btnWeigeren;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtleverancier;
        private System.Windows.Forms.TextBox txtBestelref;
        private System.Windows.Forms.Button btnPadXmlBestand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXmlPad;
        private System.Windows.Forms.OpenFileDialog openLeveringsbon;
        private System.Windows.Forms.ColumnHeader chArtikelnummer;
        private System.Windows.Forms.ColumnHeader chKwaliteit;
        private System.Windows.Forms.ColumnHeader chSoort;
        private System.Windows.Forms.ColumnHeader chHoeveelheid;
        private System.Windows.Forms.ColumnHeader chEenheid;
        private System.Windows.Forms.ColumnHeader chPrijs;
        private System.Windows.Forms.ColumnHeader chTotalePrijs;
        private System.Windows.Forms.ColumnHeader chArtikelnr;
        private System.Windows.Forms.ColumnHeader chKwaliteit2;
        private System.Windows.Forms.ColumnHeader chSoort2;
        private System.Windows.Forms.ColumnHeader chHoeveelheid2;
        private System.Windows.Forms.ColumnHeader chEenheid2;
        private System.Windows.Forms.ColumnHeader chPrijs2;
        private System.Windows.Forms.ColumnHeader chTotalePrijs2;
    }
}