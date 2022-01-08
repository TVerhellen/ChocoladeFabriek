
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aankoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderPlaatsenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordermenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderVerwerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopendeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatischeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gegevensLeverancierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aankoopartikelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verkoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gegevensKlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestellingVerwerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiekToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lopendeBestellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grondstoffenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMachinesOverview = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlProfileCircle = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnStockBatches = new System.Windows.Forms.Button();
            this.btnStockGrondstoffen = new System.Windows.Forms.Button();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGegevensLeverancier = new System.Windows.Forms.Button();
            this.btnAutomatischOrders = new System.Windows.Forms.Button();
            this.btnAankoopLopendeOrders = new System.Windows.Forms.Button();
            this.btnAankoopHistoriek = new System.Windows.Forms.Button();
            this.btnOrderVerwerken = new System.Windows.Forms.Button();
            this.btnOrderMenu = new System.Windows.Forms.Button();
            this.btnOrderPlaatsen = new System.Windows.Forms.Button();
            this.btnAankoop = new System.Windows.Forms.Button();
            this.btnLopendeBestellingen = new System.Windows.Forms.Button();
            this.btnHistoriek = new System.Windows.Forms.Button();
            this.btnBestellingVerwerken = new System.Windows.Forms.Button();
            this.btnCatalogus = new System.Windows.Forms.Button();
            this.btnGegevensKlant = new System.Windows.Forms.Button();
            this.btnVerkoop = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlProfileCircle.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aankoopToolStripMenuItem,
            this.verkoopToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.productieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(274, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1034, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aankoopToolStripMenuItem
            // 
            this.aankoopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderPlaatsenToolStripMenuItem,
            this.ordermenuToolStripMenuItem,
            this.orderVerwerkenToolStripMenuItem,
            this.historiekToolStripMenuItem,
            this.lopendeOrdersToolStripMenuItem,
            this.automatischeOrdersToolStripMenuItem,
            this.gegevensLeverancierToolStripMenuItem,
            this.aankoopartikelsToolStripMenuItem});
            this.aankoopToolStripMenuItem.Name = "aankoopToolStripMenuItem";
            this.aankoopToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.aankoopToolStripMenuItem.Text = "Aankoop";
            // 
            // orderPlaatsenToolStripMenuItem
            // 
            this.orderPlaatsenToolStripMenuItem.Name = "orderPlaatsenToolStripMenuItem";
            this.orderPlaatsenToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.orderPlaatsenToolStripMenuItem.Text = "Order plaatsen";
            this.orderPlaatsenToolStripMenuItem.Click += new System.EventHandler(this.orderPlaatsenToolStripMenuItem_Click);
            // 
            // ordermenuToolStripMenuItem
            // 
            this.ordermenuToolStripMenuItem.Name = "ordermenuToolStripMenuItem";
            this.ordermenuToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ordermenuToolStripMenuItem.Text = "Ordermenu";
            // 
            // orderVerwerkenToolStripMenuItem
            // 
            this.orderVerwerkenToolStripMenuItem.Name = "orderVerwerkenToolStripMenuItem";
            this.orderVerwerkenToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.orderVerwerkenToolStripMenuItem.Text = "Order verwerken";
            // 
            // historiekToolStripMenuItem
            // 
            this.historiekToolStripMenuItem.Name = "historiekToolStripMenuItem";
            this.historiekToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.historiekToolStripMenuItem.Text = "Historiek";
            // 
            // lopendeOrdersToolStripMenuItem
            // 
            this.lopendeOrdersToolStripMenuItem.Name = "lopendeOrdersToolStripMenuItem";
            this.lopendeOrdersToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.lopendeOrdersToolStripMenuItem.Text = "Lopende orders";
            // 
            // automatischeOrdersToolStripMenuItem
            // 
            this.automatischeOrdersToolStripMenuItem.Name = "automatischeOrdersToolStripMenuItem";
            this.automatischeOrdersToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.automatischeOrdersToolStripMenuItem.Text = "Automatische orders";
            // 
            // gegevensLeverancierToolStripMenuItem
            // 
            this.gegevensLeverancierToolStripMenuItem.Name = "gegevensLeverancierToolStripMenuItem";
            this.gegevensLeverancierToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.gegevensLeverancierToolStripMenuItem.Text = "Gegevens leverancier";
            this.gegevensLeverancierToolStripMenuItem.Click += new System.EventHandler(this.gegevensLeverancierToolStripMenuItem_Click);
            // 
            // aankoopartikelsToolStripMenuItem
            // 
            this.aankoopartikelsToolStripMenuItem.Name = "aankoopartikelsToolStripMenuItem";
            this.aankoopartikelsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.aankoopartikelsToolStripMenuItem.Text = "Aankoopartikels";
            this.aankoopartikelsToolStripMenuItem.Click += new System.EventHandler(this.aankoopartikelsToolStripMenuItem_Click);
            // 
            // verkoopToolStripMenuItem
            // 
            this.verkoopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gegevensKlantToolStripMenuItem,
            this.catalogusToolStripMenuItem,
            this.bestellingVerwerkenToolStripMenuItem,
            this.historiekToolStripMenuItem1,
            this.lopendeBestellingenToolStripMenuItem});
            this.verkoopToolStripMenuItem.Name = "verkoopToolStripMenuItem";
            this.verkoopToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.verkoopToolStripMenuItem.Text = "Verkoop";
            // 
            // gegevensKlantToolStripMenuItem
            // 
            this.gegevensKlantToolStripMenuItem.Name = "gegevensKlantToolStripMenuItem";
            this.gegevensKlantToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gegevensKlantToolStripMenuItem.Text = "Gegevens klant";
            this.gegevensKlantToolStripMenuItem.Click += new System.EventHandler(this.gegevensKlantToolStripMenuItem_Click);
            // 
            // catalogusToolStripMenuItem
            // 
            this.catalogusToolStripMenuItem.Name = "catalogusToolStripMenuItem";
            this.catalogusToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.catalogusToolStripMenuItem.Text = "Catalogus";
            this.catalogusToolStripMenuItem.Click += new System.EventHandler(this.catalogusToolStripMenuItem_Click);
            // 
            // bestellingVerwerkenToolStripMenuItem
            // 
            this.bestellingVerwerkenToolStripMenuItem.Name = "bestellingVerwerkenToolStripMenuItem";
            this.bestellingVerwerkenToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.bestellingVerwerkenToolStripMenuItem.Text = "Bestelling verwerken";
            this.bestellingVerwerkenToolStripMenuItem.Click += new System.EventHandler(this.bestellingVerwerkenToolStripMenuItem_Click);
            // 
            // historiekToolStripMenuItem1
            // 
            this.historiekToolStripMenuItem1.Name = "historiekToolStripMenuItem1";
            this.historiekToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.historiekToolStripMenuItem1.Text = "Historiek";
            this.historiekToolStripMenuItem1.Click += new System.EventHandler(this.historiekToolStripMenuItem1_Click);
            // 
            // lopendeBestellingenToolStripMenuItem
            // 
            this.lopendeBestellingenToolStripMenuItem.Name = "lopendeBestellingenToolStripMenuItem";
            this.lopendeBestellingenToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.lopendeBestellingenToolStripMenuItem.Text = "Lopende Bestellingen";
            this.lopendeBestellingenToolStripMenuItem.Click += new System.EventHandler(this.lopendeBestellingenToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grondstoffenToolStripMenuItem,
            this.productenToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // grondstoffenToolStripMenuItem
            // 
            this.grondstoffenToolStripMenuItem.Name = "grondstoffenToolStripMenuItem";
            this.grondstoffenToolStripMenuItem.Size = new System.Drawing.Size(179, 26);

            this.grondstoffenToolStripMenuItem.Text = "Grondstoffen";
            this.grondstoffenToolStripMenuItem.Click += new System.EventHandler(this.grondstoffenToolStripMenuItem_Click);
            // 
            // productenToolStripMenuItem
            // 
            this.productenToolStripMenuItem.Name = "productenToolStripMenuItem";
            this.productenToolStripMenuItem.Size = new System.Drawing.Size(179, 26);

            this.productenToolStripMenuItem.Text = "Producten";
            this.productenToolStripMenuItem.Click += new System.EventHandler(this.productenToolStripMenuItem_Click);
            // 
            // productieToolStripMenuItem
            // 
            this.productieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machinesToolStripMenuItem});
            this.productieToolStripMenuItem.Name = "productieToolStripMenuItem";
            this.productieToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.productieToolStripMenuItem.Text = "Productie";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.machinesToolStripMenuItem.Text = "Machines";
            this.machinesToolStripMenuItem.Click += new System.EventHandler(this.machinesToolStripMenuItem_Click);
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
            // 
            // pnlProfileCircle
            // 
            this.pnlProfileCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfileCircle.Controls.Add(this.lblProfile);
            this.pnlProfileCircle.Location = new System.Drawing.Point(1236, 41);
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
            this.pnlLeftMenu.Controls.Add(this.pictureBox1);
            this.pnlLeftMenu.Controls.Add(this.btnGegevensLeverancier);
            this.pnlLeftMenu.Controls.Add(this.btnAutomatischOrders);
            this.pnlLeftMenu.Controls.Add(this.btnAankoopLopendeOrders);
            this.pnlLeftMenu.Controls.Add(this.btnAankoopHistoriek);
            this.pnlLeftMenu.Controls.Add(this.btnOrderVerwerken);
            this.pnlLeftMenu.Controls.Add(this.btnOrderMenu);
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
            // 
            // btnAutomatischOrders
            // 
            this.btnAutomatischOrders.BackColor = System.Drawing.Color.White;
            this.btnAutomatischOrders.FlatAppearance.BorderSize = 0;
            this.btnAutomatischOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomatischOrders.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAutomatischOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnAutomatischOrders.Location = new System.Drawing.Point(3, 942);
            this.btnAutomatischOrders.Name = "btnAutomatischOrders";
            this.btnAutomatischOrders.Size = new System.Drawing.Size(274, 60);
            this.btnAutomatischOrders.TabIndex = 18;
            this.btnAutomatischOrders.Text = "Automatische Orders";
            this.btnAutomatischOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutomatischOrders.UseVisualStyleBackColor = false;
            this.btnAutomatischOrders.Visible = false;
            // 
            // btnAankoopLopendeOrders
            // 
            this.btnAankoopLopendeOrders.BackColor = System.Drawing.Color.White;
            this.btnAankoopLopendeOrders.FlatAppearance.BorderSize = 0;
            this.btnAankoopLopendeOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAankoopLopendeOrders.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAankoopLopendeOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnAankoopLopendeOrders.Location = new System.Drawing.Point(4, 907);
            this.btnAankoopLopendeOrders.Name = "btnAankoopLopendeOrders";
            this.btnAankoopLopendeOrders.Size = new System.Drawing.Size(274, 60);
            this.btnAankoopLopendeOrders.TabIndex = 17;
            this.btnAankoopLopendeOrders.Text = "Lopende Orders";
            this.btnAankoopLopendeOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAankoopLopendeOrders.UseVisualStyleBackColor = false;
            this.btnAankoopLopendeOrders.Visible = false;
            // 
            // btnAankoopHistoriek
            // 
            this.btnAankoopHistoriek.BackColor = System.Drawing.Color.White;
            this.btnAankoopHistoriek.FlatAppearance.BorderSize = 0;
            this.btnAankoopHistoriek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAankoopHistoriek.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAankoopHistoriek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnAankoopHistoriek.Location = new System.Drawing.Point(3, 860);
            this.btnAankoopHistoriek.Name = "btnAankoopHistoriek";
            this.btnAankoopHistoriek.Size = new System.Drawing.Size(274, 60);
            this.btnAankoopHistoriek.TabIndex = 16;
            this.btnAankoopHistoriek.Text = "Historiek";
            this.btnAankoopHistoriek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAankoopHistoriek.UseVisualStyleBackColor = false;
            this.btnAankoopHistoriek.Visible = false;
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
            // 
            // btnOrderMenu
            // 
            this.btnOrderMenu.BackColor = System.Drawing.Color.White;
            this.btnOrderMenu.FlatAppearance.BorderSize = 0;
            this.btnOrderMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMenu.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnOrderMenu.Location = new System.Drawing.Point(1, 764);
            this.btnOrderMenu.Name = "btnOrderMenu";
            this.btnOrderMenu.Size = new System.Drawing.Size(274, 60);
            this.btnOrderMenu.TabIndex = 14;
            this.btnOrderMenu.Text = "Order Menu";
            this.btnOrderMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderMenu.UseVisualStyleBackColor = false;
            this.btnOrderMenu.Visible = false;
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
            this.btnLopendeBestellingen.Location = new System.Drawing.Point(0, 618);
            this.btnLopendeBestellingen.Name = "btnLopendeBestellingen";
            this.btnLopendeBestellingen.Size = new System.Drawing.Size(274, 60);
            this.btnLopendeBestellingen.TabIndex = 11;
            this.btnLopendeBestellingen.Text = "Lopende Bestellingen";
            this.btnLopendeBestellingen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopendeBestellingen.UseVisualStyleBackColor = false;
            this.btnLopendeBestellingen.Visible = false;
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
            // 
            // btnBestellingVerwerken
            // 
            this.btnBestellingVerwerken.BackColor = System.Drawing.Color.White;
            this.btnBestellingVerwerken.FlatAppearance.BorderSize = 0;
            this.btnBestellingVerwerken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestellingVerwerken.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBestellingVerwerken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnBestellingVerwerken.Location = new System.Drawing.Point(4, 499);
            this.btnBestellingVerwerken.Name = "btnBestellingVerwerken";
            this.btnBestellingVerwerken.Size = new System.Drawing.Size(274, 60);
            this.btnBestellingVerwerken.TabIndex = 9;
            this.btnBestellingVerwerken.Text = "Bestelling Verwerken";
            this.btnBestellingVerwerken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestellingVerwerken.UseVisualStyleBackColor = false;
            this.btnBestellingVerwerken.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1024);
            this.Controls.Add(this.pnlProfileCircle);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlLeftMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlProfileCircle.ResumeLayout(false);
            this.pnlProfileCircle.PerformLayout();
            this.pnlLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aankoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderPlaatsenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordermenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderVerwerkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopendeOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatischeOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gegevensLeverancierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verkoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gegevensKlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestellingVerwerkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiekToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lopendeBestellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grondstoffenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productenToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem aankoopartikelsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem productieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.Button btnMachinesOverview;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnStockBatches;
        private System.Windows.Forms.Button btnStockGrondstoffen;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnVerkoop;
        private System.Windows.Forms.Button btnLopendeBestellingen;
        private System.Windows.Forms.Button btnHistoriek;
        private System.Windows.Forms.Button btnBestellingVerwerken;
        private System.Windows.Forms.Button btnCatalogus;
        private System.Windows.Forms.Button btnGegevensKlant;
        private System.Windows.Forms.Button btnGegevensLeverancier;
        private System.Windows.Forms.Button btnAutomatischOrders;
        private System.Windows.Forms.Button btnAankoopLopendeOrders;
        private System.Windows.Forms.Button btnAankoopHistoriek;
        private System.Windows.Forms.Button btnOrderVerwerken;
        private System.Windows.Forms.Button btnOrderMenu;
        private System.Windows.Forms.Button btnOrderPlaatsen;
        private System.Windows.Forms.Button btnAankoop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel pnlProfileCircle;

    }
}

