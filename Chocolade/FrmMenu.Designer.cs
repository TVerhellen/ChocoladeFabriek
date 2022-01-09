namespace Chocolade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMachinesOverview = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnAankoopArtikels = new System.Windows.Forms.Button();
            this.pnlProfileCircle = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnStockBatches = new System.Windows.Forms.Button();
            this.btnStockGrondstoffen = new System.Windows.Forms.Button();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.btnPersoneel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGegevensLeverancier = new System.Windows.Forms.Button();
            this.btnOrderVerwerken = new System.Windows.Forms.Button();
            this.btnOrderPlaatsen = new System.Windows.Forms.Button();
            this.btnAankoop = new System.Windows.Forms.Button();
            this.btnLopendeBestellingen = new System.Windows.Forms.Button();
            this.btnHistoriek = new System.Windows.Forms.Button();
            this.btnBestellingVerwerken = new System.Windows.Forms.Button();
            this.btnCatalogus = new System.Windows.Forms.Button();
            this.btnGegevensKlant = new System.Windows.Forms.Button();
            this.btnVerkoop = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCurrentMenu = new System.Windows.Forms.Label();
            this.pnlProfileCircle.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMachinesOverview
            // 
            this.btnMachinesOverview.BackColor = System.Drawing.Color.White;
            this.btnMachinesOverview.FlatAppearance.BorderSize = 0;
            this.btnMachinesOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachinesOverview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMachinesOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnMachinesOverview.Location = new System.Drawing.Point(4, 292);
            this.btnMachinesOverview.Name = "btnMachinesOverview";
            this.btnMachinesOverview.Size = new System.Drawing.Size(274, 60);
            this.btnMachinesOverview.TabIndex = 1;
            this.btnMachinesOverview.Text = "Machines";
            this.btnMachinesOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMachinesOverview.UseVisualStyleBackColor = false;
            this.btnMachinesOverview.Click += new System.EventHandler(this.btnMachinesOverview_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Location = new System.Drawing.Point(274, 107);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1034, 917);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // btnAankoopArtikels
            // 
            this.btnAankoopArtikels.BackColor = System.Drawing.Color.White;
            this.btnAankoopArtikels.FlatAppearance.BorderSize = 0;
            this.btnAankoopArtikels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAankoopArtikels.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAankoopArtikels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnAankoopArtikels.Location = new System.Drawing.Point(2, 860);
            this.btnAankoopArtikels.Name = "btnAankoopArtikels";
            this.btnAankoopArtikels.Size = new System.Drawing.Size(274, 60);
            this.btnAankoopArtikels.TabIndex = 22;
            this.btnAankoopArtikels.Text = "Aankoopartikels";
            this.btnAankoopArtikels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAankoopArtikels.UseVisualStyleBackColor = false;
            this.btnAankoopArtikels.Visible = false;
            this.btnAankoopArtikels.Click += new System.EventHandler(this.btnAankoopArtikels_Click);
            // 
            // pnlProfileCircle
            // 
            this.pnlProfileCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfileCircle.Controls.Add(this.lblProfile);
            this.pnlProfileCircle.Location = new System.Drawing.Point(1076, 26);
            this.pnlProfileCircle.Name = "pnlProfileCircle";
            this.pnlProfileCircle.Size = new System.Drawing.Size(60, 60);
            this.pnlProfileCircle.TabIndex = 23;
            this.pnlProfileCircle.Click += new System.EventHandler(this.pnlProfileCircle_Click);
            this.pnlProfileCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProfileCircle_Paint);
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.lblProfile.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(8, 14);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(45, 32);
            this.lblProfile.TabIndex = 22;
            this.lblProfile.Text = "Kr";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            // 
            // btnStockBatches
            // 
            this.btnStockBatches.BackColor = System.Drawing.Color.White;
            this.btnStockBatches.FlatAppearance.BorderSize = 0;
            this.btnStockBatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockBatches.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStockBatches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnStockBatches.Location = new System.Drawing.Point(4, 180);
            this.btnStockBatches.Name = "btnStockBatches";
            this.btnStockBatches.Size = new System.Drawing.Size(274, 60);
            this.btnStockBatches.TabIndex = 3;
            this.btnStockBatches.Text = "Chocolade";
            this.btnStockBatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockBatches.UseVisualStyleBackColor = false;
            this.btnStockBatches.Visible = false;
            this.btnStockBatches.Click += new System.EventHandler(this.btnBatches_Click);
            // 
            // btnStockGrondstoffen
            // 
            this.btnStockGrondstoffen.BackColor = System.Drawing.Color.White;
            this.btnStockGrondstoffen.FlatAppearance.BorderSize = 0;
            this.btnStockGrondstoffen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockGrondstoffen.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStockGrondstoffen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnStockGrondstoffen.Location = new System.Drawing.Point(4, 246);
            this.btnStockGrondstoffen.Name = "btnStockGrondstoffen";
            this.btnStockGrondstoffen.Size = new System.Drawing.Size(274, 60);
            this.btnStockGrondstoffen.TabIndex = 4;
            this.btnStockGrondstoffen.Text = "Grondstoffen";
            this.btnStockGrondstoffen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockGrondstoffen.UseVisualStyleBackColor = false;
            this.btnStockGrondstoffen.Visible = false;
            this.btnStockGrondstoffen.Click += new System.EventHandler(this.btnStockGrondstoffen_Click);
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.White;
            this.pnlLeftMenu.Controls.Add(this.btnAankoopArtikels);
            this.pnlLeftMenu.Controls.Add(this.btnPersoneel);
            this.pnlLeftMenu.Controls.Add(this.pictureBox1);
            this.pnlLeftMenu.Controls.Add(this.btnGegevensLeverancier);
            this.pnlLeftMenu.Controls.Add(this.btnOrderVerwerken);
            this.pnlLeftMenu.Controls.Add(this.btnOrderPlaatsen);
            this.pnlLeftMenu.Controls.Add(this.btnAankoop);
            this.pnlLeftMenu.Controls.Add(this.btnLopendeBestellingen);
            this.pnlLeftMenu.Controls.Add(this.btnHistoriek);
            this.pnlLeftMenu.Controls.Add(this.btnBestellingVerwerken);
            this.pnlLeftMenu.Controls.Add(this.btnCatalogus);
            this.pnlLeftMenu.Controls.Add(this.btnGegevensKlant);
            this.pnlLeftMenu.Controls.Add(this.btnVerkoop);
            this.pnlLeftMenu.Controls.Add(this.btnStock);
            this.pnlLeftMenu.Controls.Add(this.btnStockGrondstoffen);
            this.pnlLeftMenu.Controls.Add(this.btnStockBatches);
            this.pnlLeftMenu.Controls.Add(this.btnMachinesOverview);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(274, 1024);
            this.pnlLeftMenu.TabIndex = 5;
            // 
            // btnPersoneel
            // 
            this.btnPersoneel.BackColor = System.Drawing.Color.White;
            this.btnPersoneel.FlatAppearance.BorderSize = 0;
            this.btnPersoneel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersoneel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnPersoneel.Location = new System.Drawing.Point(-3, 485);
            this.btnPersoneel.Name = "btnPersoneel";
            this.btnPersoneel.Size = new System.Drawing.Size(274, 60);
            this.btnPersoneel.TabIndex = 21;
            this.btnPersoneel.Text = "Personeel";
            this.btnPersoneel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersoneel.UseVisualStyleBackColor = false;
            this.btnPersoneel.Click += new System.EventHandler(this.btnPersoneel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chocolade.Properties.Resources.Chocolate;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(54, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnGegevensLeverancier
            // 
            this.btnGegevensLeverancier.BackColor = System.Drawing.Color.White;
            this.btnGegevensLeverancier.FlatAppearance.BorderSize = 0;
            this.btnGegevensLeverancier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGegevensLeverancier.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGegevensLeverancier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnGegevensLeverancier.Location = new System.Drawing.Point(12, 973);
            this.btnGegevensLeverancier.Name = "btnGegevensLeverancier";
            this.btnGegevensLeverancier.Size = new System.Drawing.Size(274, 60);
            this.btnGegevensLeverancier.TabIndex = 19;
            this.btnGegevensLeverancier.Text = "Gegevens Leverancier";
            this.btnGegevensLeverancier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGegevensLeverancier.UseVisualStyleBackColor = false;
            this.btnGegevensLeverancier.Visible = false;
            this.btnGegevensLeverancier.Click += new System.EventHandler(this.btnGegevensLeverancier_Click);
            // 
            // btnOrderVerwerken
            // 
            this.btnOrderVerwerken.BackColor = System.Drawing.Color.White;
            this.btnOrderVerwerken.FlatAppearance.BorderSize = 0;
            this.btnOrderVerwerken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderVerwerken.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderVerwerken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnOrderVerwerken.Location = new System.Drawing.Point(-2, 810);
            this.btnOrderVerwerken.Name = "btnOrderVerwerken";
            this.btnOrderVerwerken.Size = new System.Drawing.Size(274, 60);
            this.btnOrderVerwerken.TabIndex = 15;
            this.btnOrderVerwerken.Text = "Order Verwerken";
            this.btnOrderVerwerken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderVerwerken.UseVisualStyleBackColor = false;
            this.btnOrderVerwerken.Visible = false;
            this.btnOrderVerwerken.Click += new System.EventHandler(this.btnOrderVerwerken_Click);
            // 
            // btnOrderPlaatsen
            // 
            this.btnOrderPlaatsen.BackColor = System.Drawing.Color.White;
            this.btnOrderPlaatsen.FlatAppearance.BorderSize = 0;
            this.btnOrderPlaatsen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPlaatsen.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderPlaatsen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnOrderPlaatsen.Location = new System.Drawing.Point(1, 709);
            this.btnOrderPlaatsen.Name = "btnOrderPlaatsen";
            this.btnOrderPlaatsen.Size = new System.Drawing.Size(274, 60);
            this.btnOrderPlaatsen.TabIndex = 13;
            this.btnOrderPlaatsen.Text = "Order Plaatsen";
            this.btnOrderPlaatsen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderPlaatsen.UseVisualStyleBackColor = false;
            this.btnOrderPlaatsen.Visible = false;
            this.btnOrderPlaatsen.Click += new System.EventHandler(this.btnOrderPlaatsen_Click);
            // 
            // btnAankoop
            // 
            this.btnAankoop.BackColor = System.Drawing.Color.White;
            this.btnAankoop.FlatAppearance.BorderSize = 0;
            this.btnAankoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAankoop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAankoop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnAankoop.Location = new System.Drawing.Point(4, 672);
            this.btnAankoop.Name = "btnAankoop";
            this.btnAankoop.Size = new System.Drawing.Size(274, 60);
            this.btnAankoop.TabIndex = 12;
            this.btnAankoop.Text = "Aankoop";
            this.btnAankoop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAankoop.UseVisualStyleBackColor = false;
            this.btnAankoop.Click += new System.EventHandler(this.btnAankoop_Click);
            // 
            // btnLopendeBestellingen
            // 
            this.btnLopendeBestellingen.BackColor = System.Drawing.Color.White;
            this.btnLopendeBestellingen.FlatAppearance.BorderSize = 0;
            this.btnLopendeBestellingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopendeBestellingen.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLopendeBestellingen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnLopendeBestellingen.Location = new System.Drawing.Point(-6, 615);
            this.btnLopendeBestellingen.Name = "btnLopendeBestellingen";
            this.btnLopendeBestellingen.Size = new System.Drawing.Size(274, 60);
            this.btnLopendeBestellingen.TabIndex = 11;
            this.btnLopendeBestellingen.Text = "Lopende Bestellingen";
            this.btnLopendeBestellingen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopendeBestellingen.UseVisualStyleBackColor = false;
            this.btnLopendeBestellingen.Visible = false;
            this.btnLopendeBestellingen.Click += new System.EventHandler(this.btnLopendeBestellingen_Click);
            // 
            // btnHistoriek
            // 
            this.btnHistoriek.BackColor = System.Drawing.Color.White;
            this.btnHistoriek.FlatAppearance.BorderSize = 0;
            this.btnHistoriek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoriek.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistoriek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnHistoriek.Location = new System.Drawing.Point(3, 565);
            this.btnHistoriek.Name = "btnHistoriek";
            this.btnHistoriek.Size = new System.Drawing.Size(274, 60);
            this.btnHistoriek.TabIndex = 10;
            this.btnHistoriek.Text = "Historiek";
            this.btnHistoriek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoriek.UseVisualStyleBackColor = false;
            this.btnHistoriek.Visible = false;
            this.btnHistoriek.Click += new System.EventHandler(this.btnHistoriek_Click);
            // 
            // btnBestellingVerwerken
            // 
            this.btnBestellingVerwerken.BackColor = System.Drawing.Color.White;
            this.btnBestellingVerwerken.FlatAppearance.BorderSize = 0;
            this.btnBestellingVerwerken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestellingVerwerken.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBestellingVerwerken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnBestellingVerwerken.Location = new System.Drawing.Point(3, 531);
            this.btnBestellingVerwerken.Name = "btnBestellingVerwerken";
            this.btnBestellingVerwerken.Size = new System.Drawing.Size(274, 60);
            this.btnBestellingVerwerken.TabIndex = 9;
            this.btnBestellingVerwerken.Text = "Bestelling Verwerken";
            this.btnBestellingVerwerken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestellingVerwerken.UseVisualStyleBackColor = false;
            this.btnBestellingVerwerken.Visible = false;
            this.btnBestellingVerwerken.Click += new System.EventHandler(this.btnBestellingVerwerken_Click);
            // 
            // btnCatalogus
            // 
            this.btnCatalogus.BackColor = System.Drawing.Color.White;
            this.btnCatalogus.FlatAppearance.BorderSize = 0;
            this.btnCatalogus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCatalogus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCatalogus.Location = new System.Drawing.Point(4, 433);
            this.btnCatalogus.Name = "btnCatalogus";
            this.btnCatalogus.Size = new System.Drawing.Size(274, 60);
            this.btnCatalogus.TabIndex = 8;
            this.btnCatalogus.Text = "Catalogus";
            this.btnCatalogus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogus.UseVisualStyleBackColor = false;
            this.btnCatalogus.Visible = false;
            this.btnCatalogus.Click += new System.EventHandler(this.btnCatalogus_Click);
            // 
            // btnGegevensKlant
            // 
            this.btnGegevensKlant.BackColor = System.Drawing.Color.White;
            this.btnGegevensKlant.FlatAppearance.BorderSize = 0;
            this.btnGegevensKlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGegevensKlant.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGegevensKlant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnGegevensKlant.Location = new System.Drawing.Point(1, 378);
            this.btnGegevensKlant.Name = "btnGegevensKlant";
            this.btnGegevensKlant.Size = new System.Drawing.Size(274, 60);
            this.btnGegevensKlant.TabIndex = 7;
            this.btnGegevensKlant.Text = "Gegevens Klant";
            this.btnGegevensKlant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGegevensKlant.UseVisualStyleBackColor = false;
            this.btnGegevensKlant.Visible = false;
            this.btnGegevensKlant.Click += new System.EventHandler(this.btnGegevensKlant_Click);
            // 
            // btnVerkoop
            // 
            this.btnVerkoop.BackColor = System.Drawing.Color.White;
            this.btnVerkoop.FlatAppearance.BorderSize = 0;
            this.btnVerkoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerkoop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerkoop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnVerkoop.Location = new System.Drawing.Point(4, 332);
            this.btnVerkoop.Name = "btnVerkoop";
            this.btnVerkoop.Size = new System.Drawing.Size(274, 60);
            this.btnVerkoop.TabIndex = 6;
            this.btnVerkoop.Text = "Verkoop";
            this.btnVerkoop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerkoop.UseVisualStyleBackColor = false;
            this.btnVerkoop.Click += new System.EventHandler(this.btnVerkoop_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnStock.Location = new System.Drawing.Point(4, 114);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(274, 60);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1158, 31);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 47);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCurrentMenu
            // 
            this.lblCurrentMenu.AutoSize = true;
            this.lblCurrentMenu.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentMenu.Location = new System.Drawing.Point(342, 41);
            this.lblCurrentMenu.Name = "lblCurrentMenu";
            this.lblCurrentMenu.Size = new System.Drawing.Size(90, 32);
            this.lblCurrentMenu.TabIndex = 25;
            this.lblCurrentMenu.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1024);
            this.Controls.Add(this.lblCurrentMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlProfileCircle);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLeftMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProfileCircle.ResumeLayout(false);
            this.pnlProfileCircle.PerformLayout();
            this.pnlLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMachinesOverview;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnStockBatches;
        private System.Windows.Forms.Button btnStockGrondstoffen;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnVerkoop;
        private System.Windows.Forms.Button btnHistoriek;
        private System.Windows.Forms.Button btnBestellingVerwerken;
        private System.Windows.Forms.Button btnCatalogus;
        private System.Windows.Forms.Button btnGegevensKlant;
        private System.Windows.Forms.Button btnGegevensLeverancier;
        private System.Windows.Forms.Button btnOrderVerwerken;
        private System.Windows.Forms.Button btnOrderPlaatsen;
        private System.Windows.Forms.Button btnAankoop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel pnlProfileCircle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPersoneel;
        private System.Windows.Forms.Button btnAankoopArtikels;
        private System.Windows.Forms.Button btnLopendeBestellingen;
        private System.Windows.Forms.Label lblCurrentMenu;
    }
}
