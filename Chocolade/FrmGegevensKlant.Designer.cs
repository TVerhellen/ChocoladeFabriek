
namespace Chocolade
{
    partial class FrmGegevensKlant
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
            this.cmbKlanten = new System.Windows.Forms.ComboBox();
            this.lblNaamBedrijf = new System.Windows.Forms.Label();
            this.lblFacturatieAdres = new System.Windows.Forms.Label();
            this.lblLeveringsAdres = new System.Windows.Forms.Label();
            this.lblTelefoonNr = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNaamPersoon = new System.Windows.Forms.Label();
            this.lblBtwNummer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKlanten
            // 
            this.cmbKlanten.FormattingEnabled = true;
            this.cmbKlanten.Location = new System.Drawing.Point(39, 40);
            this.cmbKlanten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKlanten.Name = "cmbKlanten";
            this.cmbKlanten.Size = new System.Drawing.Size(358, 28);
            this.cmbKlanten.TabIndex = 0;
            this.cmbKlanten.SelectedIndexChanged += new System.EventHandler(this.cmbKlanten_SelectedIndexChanged);
            // 
            // lblNaamBedrijf
            // 
            this.lblNaamBedrijf.AutoSize = true;
            this.lblNaamBedrijf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaamBedrijf.Location = new System.Drawing.Point(229, 109);
            this.lblNaamBedrijf.Name = "lblNaamBedrijf";
            this.lblNaamBedrijf.Size = new System.Drawing.Size(47, 17);
            this.lblNaamBedrijf.TabIndex = 1;
            this.lblNaamBedrijf.Text = "Naam";
            // 
            // lblFacturatieAdres
            // 
            this.lblFacturatieAdres.AutoSize = true;
            this.lblFacturatieAdres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFacturatieAdres.Location = new System.Drawing.Point(229, 243);
            this.lblFacturatieAdres.Name = "lblFacturatieAdres";
            this.lblFacturatieAdres.Size = new System.Drawing.Size(111, 17);
            this.lblFacturatieAdres.TabIndex = 2;
            this.lblFacturatieAdres.Text = "FacturatieAdres";
            // 
            // lblLeveringsAdres
            // 
            this.lblLeveringsAdres.AutoSize = true;
            this.lblLeveringsAdres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeveringsAdres.Location = new System.Drawing.Point(229, 269);
            this.lblLeveringsAdres.Name = "lblLeveringsAdres";
            this.lblLeveringsAdres.Size = new System.Drawing.Size(109, 17);
            this.lblLeveringsAdres.TabIndex = 3;
            this.lblLeveringsAdres.Text = "LeveringsAdres";
            // 
            // lblTelefoonNr
            // 
            this.lblTelefoonNr.AutoSize = true;
            this.lblTelefoonNr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefoonNr.Location = new System.Drawing.Point(229, 189);
            this.lblTelefoonNr.Name = "lblTelefoonNr";
            this.lblTelefoonNr.Size = new System.Drawing.Size(77, 17);
            this.lblTelefoonNr.TabIndex = 4;
            this.lblTelefoonNr.Text = "TelefoonNr";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(229, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblNaamPersoon
            // 
            this.lblNaamPersoon.AutoSize = true;
            this.lblNaamPersoon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaamPersoon.Location = new System.Drawing.Point(229, 163);
            this.lblNaamPersoon.Name = "lblNaamPersoon";
            this.lblNaamPersoon.Size = new System.Drawing.Size(102, 17);
            this.lblNaamPersoon.TabIndex = 6;
            this.lblNaamPersoon.Text = "NaamPersoon";
            // 
            // lblBtwNummer
            // 
            this.lblBtwNummer.AutoSize = true;
            this.lblBtwNummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBtwNummer.Location = new System.Drawing.Point(229, 136);
            this.lblBtwNummer.Name = "lblBtwNummer";
            this.lblBtwNummer.Size = new System.Drawing.Size(91, 17);
            this.lblBtwNummer.TabIndex = 7;
            this.lblBtwNummer.Text = "btw-nummer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "BTW nummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contactpersoon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefoonnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mailadres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Facturatieadres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Leveringsadres:";
            // 
            // FrmGegevensKlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 321);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBtwNummer);
            this.Controls.Add(this.lblNaamPersoon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefoonNr);
            this.Controls.Add(this.lblLeveringsAdres);
            this.Controls.Add(this.lblFacturatieAdres);
            this.Controls.Add(this.lblNaamBedrijf);
            this.Controls.Add(this.cmbKlanten);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGegevensKlant";
            this.Text = "FrmGegevensKlant";
            this.Load += new System.EventHandler(this.FrmGegevensKlant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKlanten;
        private System.Windows.Forms.Label lblNaamBedrijf;
        private System.Windows.Forms.Label lblFacturatieAdres;
        private System.Windows.Forms.Label lblLeveringsAdres;
        private System.Windows.Forms.Label lblTelefoonNr;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNaamPersoon;
        private System.Windows.Forms.Label lblBtwNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}