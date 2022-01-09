
namespace Chocolade
{
    partial class FrmGegevensLeveranciers
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
            this.lblLeverancier = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblStraat = new System.Windows.Forms.Label();
            this.lblNummer = new System.Windows.Forms.Label();
            this.lblGemeente = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblTelefoon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbLeveranciers = new System.Windows.Forms.ComboBox();
            this.txtLevNaam = new System.Windows.Forms.TextBox();
            this.txtStraatNaam = new System.Windows.Forms.TextBox();
            this.txtStraatNummer = new System.Windows.Forms.TextBox();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtBtwNummer = new System.Windows.Forms.TextBox();
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.btnHoofdMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLeverancier
            // 
            this.lblLeverancier.AutoSize = true;
            this.lblLeverancier.Location = new System.Drawing.Point(38, 34);
            this.lblLeverancier.Name = "lblLeverancier";
            this.lblLeverancier.Size = new System.Drawing.Size(128, 20);
            this.lblLeverancier.TabIndex = 0;
            this.lblLeverancier.Text = "Select leverancier:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(38, 94);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(130, 20);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Leveranciersnaam:";
            // 
            // lblStraat
            // 
            this.lblStraat.AutoSize = true;
            this.lblStraat.Location = new System.Drawing.Point(38, 149);
            this.lblStraat.Name = "lblStraat";
            this.lblStraat.Size = new System.Drawing.Size(88, 20);
            this.lblStraat.TabIndex = 2;
            this.lblStraat.Text = "Straatnaam:";
            // 
            // lblNummer
            // 
            this.lblNummer.AutoSize = true;
            this.lblNummer.Location = new System.Drawing.Point(416, 146);
            this.lblNummer.Name = "lblNummer";
            this.lblNummer.Size = new System.Drawing.Size(106, 20);
            this.lblNummer.TabIndex = 3;
            this.lblNummer.Text = "Straatnummer:";
            // 
            // lblGemeente
            // 
            this.lblGemeente.AutoSize = true;
            this.lblGemeente.Location = new System.Drawing.Point(354, 206);
            this.lblGemeente.Name = "lblGemeente";
            this.lblGemeente.Size = new System.Drawing.Size(80, 20);
            this.lblGemeente.TabIndex = 4;
            this.lblGemeente.Text = "Gemeente:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(38, 206);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(72, 20);
            this.lblPostCode.TabIndex = 5;
            this.lblPostCode.Text = "Postcode:";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(38, 262);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(98, 20);
            this.lblBtw.TabIndex = 6;
            this.lblBtw.Text = "btw-nummer:";
            // 
            // lblTelefoon
            // 
            this.lblTelefoon.AutoSize = true;
            this.lblTelefoon.Location = new System.Drawing.Point(38, 319);
            this.lblTelefoon.Name = "lblTelefoon";
            this.lblTelefoon.Size = new System.Drawing.Size(70, 20);
            this.lblTelefoon.TabIndex = 7;
            this.lblTelefoon.Text = "Telefoon:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 370);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // cmbLeveranciers
            // 
            this.cmbLeveranciers.FormattingEnabled = true;
            this.cmbLeveranciers.Location = new System.Drawing.Point(194, 34);
            this.cmbLeveranciers.Name = "cmbLeveranciers";
            this.cmbLeveranciers.Size = new System.Drawing.Size(415, 28);
            this.cmbLeveranciers.TabIndex = 9;
            this.cmbLeveranciers.SelectedIndexChanged += new System.EventHandler(this.cmbLeveranciers_SelectedIndexChanged);
            // 
            // txtLevNaam
            // 
            this.txtLevNaam.Location = new System.Drawing.Point(194, 91);
            this.txtLevNaam.Name = "txtLevNaam";
            this.txtLevNaam.Size = new System.Drawing.Size(415, 27);
            this.txtLevNaam.TabIndex = 10;
            // 
            // txtStraatNaam
            // 
            this.txtStraatNaam.Location = new System.Drawing.Point(194, 146);
            this.txtStraatNaam.Name = "txtStraatNaam";
            this.txtStraatNaam.Size = new System.Drawing.Size(196, 27);
            this.txtStraatNaam.TabIndex = 11;
            // 
            // txtStraatNummer
            // 
            this.txtStraatNummer.Location = new System.Drawing.Point(553, 146);
            this.txtStraatNummer.Name = "txtStraatNummer";
            this.txtStraatNummer.Size = new System.Drawing.Size(56, 27);
            this.txtStraatNummer.TabIndex = 12;
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(466, 199);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(143, 27);
            this.txtGemeente.TabIndex = 14;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(194, 203);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(104, 27);
            this.txtPostCode.TabIndex = 13;
            // 
            // txtBtwNummer
            // 
            this.txtBtwNummer.Location = new System.Drawing.Point(194, 262);
            this.txtBtwNummer.Name = "txtBtwNummer";
            this.txtBtwNummer.Size = new System.Drawing.Size(196, 27);
            this.txtBtwNummer.TabIndex = 15;
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Location = new System.Drawing.Point(194, 319);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(196, 27);
            this.txtTelefoon.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(194, 370);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(752, 91);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(223, 55);
            this.btnToevoegen.TabIndex = 18;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.Location = new System.Drawing.Point(752, 171);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(223, 55);
            this.btnWijzigen.TabIndex = 19;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // btnHoofdMenu
            // 
            this.btnHoofdMenu.Location = new System.Drawing.Point(752, 248);
            this.btnHoofdMenu.Name = "btnHoofdMenu";
            this.btnHoofdMenu.Size = new System.Drawing.Size(223, 55);
            this.btnHoofdMenu.TabIndex = 22;
            this.btnHoofdMenu.Text = "Hoofdmenu";
            this.btnHoofdMenu.UseVisualStyleBackColor = true;
            this.btnHoofdMenu.Click += new System.EventHandler(this.btnHoofdMenu_Click);
            // 
            // FrmGegevensLeveranciers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.btnHoofdMenu);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefoon);
            this.Controls.Add(this.txtBtwNummer);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.txtStraatNummer);
            this.Controls.Add(this.txtStraatNaam);
            this.Controls.Add(this.txtLevNaam);
            this.Controls.Add(this.cmbLeveranciers);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefoon);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblGemeente);
            this.Controls.Add(this.lblNummer);
            this.Controls.Add(this.lblStraat);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblLeverancier);
            this.Name = "FrmGegevensLeveranciers";
            this.Text = "FrmGegevensLeveranciers";
            this.Load += new System.EventHandler(this.GegevensLeveranciers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeverancier;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblStraat;
        private System.Windows.Forms.Label lblNummer;
        private System.Windows.Forms.Label lblGemeente;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblTelefoon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbLeveranciers;
        private System.Windows.Forms.TextBox txtLevNaam;
        private System.Windows.Forms.TextBox txtStraatNaam;
        private System.Windows.Forms.TextBox txtStraatNummer;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtBtwNummer;
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.Button btnHoofdMenu;
    }
}