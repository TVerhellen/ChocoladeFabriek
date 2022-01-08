
namespace Chocolade
{
    partial class FrmAankoopArtikels
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
            this.lvArtikelOverzicht = new System.Windows.Forms.ListView();
            this.chArtikelnummer = new System.Windows.Forms.ColumnHeader();
            this.chArtikelnaam = new System.Windows.Forms.ColumnHeader();
            this.chKwaliteit = new System.Windows.Forms.ColumnHeader();
            this.chSoort = new System.Windows.Forms.ColumnHeader();
            this.chPrijs = new System.Windows.Forms.ColumnHeader();
            this.chRekeningnummer = new System.Windows.Forms.ColumnHeader();
            this.chHoofdleverancier = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnBtw21 = new System.Windows.Forms.RadioButton();
            this.rdnBtw6 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnArtikelAanmaken = new System.Windows.Forms.Button();
            this.btnArtikelWijzigen = new System.Windows.Forms.Button();
            this.btnHoofdMenu = new System.Windows.Forms.Button();
            this.txtArtikelnaam = new System.Windows.Forms.TextBox();
            this.txtRekeningnummer = new System.Windows.Forms.TextBox();
            this.cmbSelectieLeverancier = new System.Windows.Forms.ComboBox();
            this.txtHoofdleverancier = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbArtikelnummer = new System.Windows.Forms.ComboBox();
            this.cmbKwaliteit = new System.Windows.Forms.ComboBox();
            this.cmbSoort = new System.Windows.Forms.ComboBox();
            this.chArtikelnummerLeverancier = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvArtikelOverzicht
            // 
            this.lvArtikelOverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArtikelnummer,
            this.chArtikelnaam,
            this.chKwaliteit,
            this.chSoort,
            this.chPrijs,
            this.chHoofdleverancier,
            this.chArtikelnummerLeverancier,
            this.chRekeningnummer});
            this.lvArtikelOverzicht.HideSelection = false;
            this.lvArtikelOverzicht.Location = new System.Drawing.Point(48, 410);
            this.lvArtikelOverzicht.Name = "lvArtikelOverzicht";
            this.lvArtikelOverzicht.Size = new System.Drawing.Size(755, 365);
            this.lvArtikelOverzicht.TabIndex = 0;
            this.lvArtikelOverzicht.UseCompatibleStateImageBehavior = false;
            this.lvArtikelOverzicht.View = System.Windows.Forms.View.Details;
            // 
            // chArtikelnummer
            // 
            this.chArtikelnummer.Text = "Artikelnummer";
            this.chArtikelnummer.Width = 110;
            // 
            // chArtikelnaam
            // 
            this.chArtikelnaam.Text = "Artikelnaam";
            this.chArtikelnaam.Width = 190;
            // 
            // chKwaliteit
            // 
            this.chKwaliteit.Text = "Kwaliteit";
            this.chKwaliteit.Width = 90;
            // 
            // chSoort
            // 
            this.chSoort.Text = "Soort";
            this.chSoort.Width = 90;
            // 
            // chPrijs
            // 
            this.chPrijs.Text = "Prijs/kg";
            this.chPrijs.Width = 65;
            // 
            // chRekeningnummer
            // 
            this.chRekeningnummer.Text = "Rekeningnummer";
            this.chRekeningnummer.Width = 80;
            // 
            // chHoofdleverancier
            // 
            this.chHoofdleverancier.Text = "Hoofdleverancier";
            this.chHoofdleverancier.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikelnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikelnaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rekeningnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kwaliteit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selectie leverancier:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnBtw21);
            this.groupBox1.Controls.Add(this.rdnBtw6);
            this.groupBox1.Location = new System.Drawing.Point(48, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Btw";
            // 
            // rdnBtw21
            // 
            this.rdnBtw21.AutoSize = true;
            this.rdnBtw21.Location = new System.Drawing.Point(23, 51);
            this.rdnBtw21.Name = "rdnBtw21";
            this.rdnBtw21.Size = new System.Drawing.Size(62, 24);
            this.rdnBtw21.TabIndex = 1;
            this.rdnBtw21.TabStop = true;
            this.rdnBtw21.Text = "21 %";
            this.rdnBtw21.UseVisualStyleBackColor = true;
            // 
            // rdnBtw6
            // 
            this.rdnBtw6.AutoSize = true;
            this.rdnBtw6.Location = new System.Drawing.Point(23, 26);
            this.rdnBtw6.Name = "rdnBtw6";
            this.rdnBtw6.Size = new System.Drawing.Size(54, 24);
            this.rdnBtw6.TabIndex = 0;
            this.rdnBtw6.TabStop = true;
            this.rdnBtw6.Text = "6 %";
            this.rdnBtw6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "HoofdLeverancier:";
            // 
            // btnArtikelAanmaken
            // 
            this.btnArtikelAanmaken.Location = new System.Drawing.Point(48, 331);
            this.btnArtikelAanmaken.Name = "btnArtikelAanmaken";
            this.btnArtikelAanmaken.Size = new System.Drawing.Size(219, 47);
            this.btnArtikelAanmaken.TabIndex = 9;
            this.btnArtikelAanmaken.Text = "Artikel aanmaken";
            this.btnArtikelAanmaken.UseVisualStyleBackColor = true;
            this.btnArtikelAanmaken.Click += new System.EventHandler(this.btnArtikelAanmaken_Click);
            // 
            // btnArtikelWijzigen
            // 
            this.btnArtikelWijzigen.Location = new System.Drawing.Point(312, 331);
            this.btnArtikelWijzigen.Name = "btnArtikelWijzigen";
            this.btnArtikelWijzigen.Size = new System.Drawing.Size(219, 47);
            this.btnArtikelWijzigen.TabIndex = 10;
            this.btnArtikelWijzigen.Text = "Artikel wijzigen";
            this.btnArtikelWijzigen.UseVisualStyleBackColor = true;
            // 
            // btnHoofdMenu
            // 
            this.btnHoofdMenu.Location = new System.Drawing.Point(584, 331);
            this.btnHoofdMenu.Name = "btnHoofdMenu";
            this.btnHoofdMenu.Size = new System.Drawing.Size(219, 47);
            this.btnHoofdMenu.TabIndex = 11;
            this.btnHoofdMenu.Text = "Hoofdmenu";
            this.btnHoofdMenu.UseVisualStyleBackColor = true;
            // 
            // txtArtikelnaam
            // 
            this.txtArtikelnaam.Location = new System.Drawing.Point(197, 88);
            this.txtArtikelnaam.Name = "txtArtikelnaam";
            this.txtArtikelnaam.Size = new System.Drawing.Size(192, 27);
            this.txtArtikelnaam.TabIndex = 14;
            // 
            // txtRekeningnummer
            // 
            this.txtRekeningnummer.Location = new System.Drawing.Point(197, 142);
            this.txtRekeningnummer.Name = "txtRekeningnummer";
            this.txtRekeningnummer.Size = new System.Drawing.Size(192, 27);
            this.txtRekeningnummer.TabIndex = 15;
            // 
            // cmbSelectieLeverancier
            // 
            this.cmbSelectieLeverancier.FormattingEnabled = true;
            this.cmbSelectieLeverancier.Location = new System.Drawing.Point(611, 180);
            this.cmbSelectieLeverancier.Name = "cmbSelectieLeverancier";
            this.cmbSelectieLeverancier.Size = new System.Drawing.Size(192, 28);
            this.cmbSelectieLeverancier.TabIndex = 18;
            this.cmbSelectieLeverancier.SelectedIndexChanged += new System.EventHandler(this.cmbSelectieLeverancier_SelectedIndexChanged);
            // 
            // txtHoofdleverancier
            // 
            this.txtHoofdleverancier.Location = new System.Drawing.Point(611, 221);
            this.txtHoofdleverancier.Name = "txtHoofdleverancier";
            this.txtHoofdleverancier.Size = new System.Drawing.Size(192, 27);
            this.txtHoofdleverancier.TabIndex = 19;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(611, 135);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(79, 27);
            this.txtPrijs.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Prijs per kg:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 40);
            this.label10.TabIndex = 23;
            this.label10.Text = "Artikelnummer\r\nhoofdLeverancier:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 27);
            this.textBox1.TabIndex = 24;
            // 
            // cmbArtikelnummer
            // 
            this.cmbArtikelnummer.FormattingEnabled = true;
            this.cmbArtikelnummer.Location = new System.Drawing.Point(197, 48);
            this.cmbArtikelnummer.Name = "cmbArtikelnummer";
            this.cmbArtikelnummer.Size = new System.Drawing.Size(192, 28);
            this.cmbArtikelnummer.TabIndex = 25;
            // 
            // cmbKwaliteit
            // 
            this.cmbKwaliteit.FormattingEnabled = true;
            this.cmbKwaliteit.Items.AddRange(new object[] {
            "Bio",
            "Criollo",
            "Smaak1",
            "Smaak2"});
            this.cmbKwaliteit.Location = new System.Drawing.Point(611, 48);
            this.cmbKwaliteit.Name = "cmbKwaliteit";
            this.cmbKwaliteit.Size = new System.Drawing.Size(192, 28);
            this.cmbKwaliteit.TabIndex = 26;
            this.cmbKwaliteit.SelectedIndexChanged += new System.EventHandler(this.cmbKwaliteit_SelectedIndexChanged);
            // 
            // cmbSoort
            // 
            this.cmbSoort.FormattingEnabled = true;
            this.cmbSoort.Items.AddRange(new object[] {
            "Ariba",
            "Gmo",
            "Trinitario",
            "Wild"});
            this.cmbSoort.Location = new System.Drawing.Point(611, 88);
            this.cmbSoort.Name = "cmbSoort";
            this.cmbSoort.Size = new System.Drawing.Size(192, 28);
            this.cmbSoort.TabIndex = 27;
            this.cmbSoort.SelectedIndexChanged += new System.EventHandler(this.cmbSoort_SelectedIndexChanged);
            // 
            // chArtikelnummerLeverancier
            // 
            this.chArtikelnummerLeverancier.Text = "Art. nummer lev.";
            this.chArtikelnummerLeverancier.Width = 70;
            // 
            // FrmAankoopArtikels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 815);
            this.Controls.Add(this.cmbSoort);
            this.Controls.Add(this.cmbKwaliteit);
            this.Controls.Add(this.cmbArtikelnummer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtHoofdleverancier);
            this.Controls.Add(this.cmbSelectieLeverancier);
            this.Controls.Add(this.txtRekeningnummer);
            this.Controls.Add(this.txtArtikelnaam);
            this.Controls.Add(this.btnHoofdMenu);
            this.Controls.Add(this.btnArtikelWijzigen);
            this.Controls.Add(this.btnArtikelAanmaken);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvArtikelOverzicht);
            this.Name = "FrmAankoopArtikels";
            this.Text = "FrmAankoopArtikels";
            this.Load += new System.EventHandler(this.FrmAankoopArtikels_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvArtikelOverzicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnBtw21;
        private System.Windows.Forms.RadioButton rdnBtw6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnArtikelAanmaken;
        private System.Windows.Forms.Button btnArtikelWijzigen;
        private System.Windows.Forms.Button btnHoofdMenu;
        private System.Windows.Forms.TextBox txtArtikelnaam;
        private System.Windows.Forms.TextBox txtRekeningnummer;
        private System.Windows.Forms.ComboBox cmbSelectieLeverancier;
        private System.Windows.Forms.ColumnHeader chArtikelnummer;
        private System.Windows.Forms.ColumnHeader chArtikelnaam;
        private System.Windows.Forms.ColumnHeader chKwaliteit;
        private System.Windows.Forms.ColumnHeader chSoort;
        private System.Windows.Forms.ColumnHeader chPrijs;
        private System.Windows.Forms.ColumnHeader chRekeningnummer;
        private System.Windows.Forms.ColumnHeader chHoofdleverancier;
        private System.Windows.Forms.TextBox txtHoofdleverancier;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbArtikelnummer;
        private System.Windows.Forms.ComboBox cmbKwaliteit;
        private System.Windows.Forms.ComboBox cmbSoort;
        private System.Windows.Forms.ColumnHeader chArtikelnummerLeverancier;
    }
}