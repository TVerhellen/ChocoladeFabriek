
namespace Chocolade
{
    partial class FrmVerkoopLopend
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
            this.lvwBatches = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lblOrderNummer = new System.Windows.Forms.Label();
            this.txtZoekterm = new System.Windows.Forms.TextBox();
            this.lblTeZoeken = new System.Windows.Forms.Label();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrders
            // 
            this.lbOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrders.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 17;
            this.lbOrders.Location = new System.Drawing.Point(37, 44);
            this.lbOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(285, 138);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged);
            // 
            // lvwBatches
            // 
            this.lvwBatches.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwBatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwBatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1});
            this.lvwBatches.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwBatches.FullRowSelect = true;
            this.lvwBatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwBatches.HideSelection = false;
            this.lvwBatches.LabelWrap = false;
            this.lvwBatches.Location = new System.Drawing.Point(37, 275);
            this.lvwBatches.Name = "lvwBatches";
            this.lvwBatches.Size = new System.Drawing.Size(679, 278);
            this.lvwBatches.TabIndex = 5;
            this.lvwBatches.UseCompatibleStateImageBehavior = false;
            this.lvwBatches.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type chocolade";
            this.columnHeader4.Width = 400;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hoeveelheid";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prijs";
            // 
            // lblOrderNummer
            // 
            this.lblOrderNummer.AutoSize = true;
            this.lblOrderNummer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNummer.Location = new System.Drawing.Point(37, 239);
            this.lblOrderNummer.Name = "lblOrderNummer";
            this.lblOrderNummer.Size = new System.Drawing.Size(50, 18);
            this.lblOrderNummer.TabIndex = 6;
            this.lblOrderNummer.Text = "label1";
            // 
            // txtZoekterm
            // 
            this.txtZoekterm.Location = new System.Drawing.Point(513, 44);
            this.txtZoekterm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZoekterm.Name = "txtZoekterm";
            this.txtZoekterm.Size = new System.Drawing.Size(201, 27);
            this.txtZoekterm.TabIndex = 8;
            // 
            // lblTeZoeken
            // 
            this.lblTeZoeken.AutoSize = true;
            this.lblTeZoeken.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeZoeken.Location = new System.Drawing.Point(395, 51);
            this.lblTeZoeken.Name = "lblTeZoeken";
            this.lblTeZoeken.Size = new System.Drawing.Size(105, 18);
            this.lblTeZoeken.TabIndex = 9;
            this.lblTeZoeken.Text = "Te zoeken ID:";
            // 
            // btnZoeken
            // 
            this.btnZoeken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.btnZoeken.FlatAppearance.BorderSize = 0;
            this.btnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoeken.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZoeken.ForeColor = System.Drawing.Color.White;
            this.btnZoeken.Location = new System.Drawing.Point(627, 84);
            this.btnZoeken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(86, 31);
            this.btnZoeken.TabIndex = 10;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnReset.Enabled = false;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(513, 84);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmVerkoopLopend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.lblTeZoeken);
            this.Controls.Add(this.txtZoekterm);
            this.Controls.Add(this.lblOrderNummer);
            this.Controls.Add(this.lvwBatches);
            this.Controls.Add(this.lbOrders);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVerkoopLopend";
            this.Text = "FrmVerkoopLopend";
            this.Load += new System.EventHandler(this.FrmVerkoopLopend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.ListView lvwBatches;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblOrderNummer;
        private System.Windows.Forms.TextBox txtZoekterm;
        private System.Windows.Forms.Label lblTeZoeken;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Button btnReset;
    }
}