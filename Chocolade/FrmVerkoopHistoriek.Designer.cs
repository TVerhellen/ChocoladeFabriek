
namespace Chocolade
{
    partial class FrmVerkoopHistoriek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGeannuleerd = new System.Windows.Forms.RadioButton();
            this.radAfgewerkt = new System.Windows.Forms.RadioButton();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.lvwChocoladeBatch = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lblOrderNummer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGeannuleerd);
            this.groupBox1.Controls.Add(this.radAfgewerkt);
            this.groupBox1.Location = new System.Drawing.Point(39, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type historiek";
            // 
            // radGeannuleerd
            // 
            this.radGeannuleerd.AutoSize = true;
            this.radGeannuleerd.Location = new System.Drawing.Point(22, 59);
            this.radGeannuleerd.Name = "radGeannuleerd";
            this.radGeannuleerd.Size = new System.Drawing.Size(92, 19);
            this.radGeannuleerd.TabIndex = 1;
            this.radGeannuleerd.TabStop = true;
            this.radGeannuleerd.Text = "Geannuleerd";
            this.radGeannuleerd.UseVisualStyleBackColor = true;
            this.radGeannuleerd.CheckedChanged += new System.EventHandler(this.radGeannuleerd_CheckedChanged);
            // 
            // radAfgewerkt
            // 
            this.radAfgewerkt.AutoSize = true;
            this.radAfgewerkt.Location = new System.Drawing.Point(22, 33);
            this.radAfgewerkt.Name = "radAfgewerkt";
            this.radAfgewerkt.Size = new System.Drawing.Size(79, 19);
            this.radAfgewerkt.TabIndex = 0;
            this.radAfgewerkt.TabStop = true;
            this.radAfgewerkt.Text = "Afgewerkt";
            this.radAfgewerkt.UseVisualStyleBackColor = true;
            this.radAfgewerkt.CheckedChanged += new System.EventHandler(this.radAfgewerkt_CheckedChanged);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 15;
            this.lbOrders.Location = new System.Drawing.Point(231, 30);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(402, 94);
            this.lbOrders.TabIndex = 1;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged);
            // 
            // lvwChocoladeBatch
            // 
            this.lvwChocoladeBatch.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwChocoladeBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwChocoladeBatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwChocoladeBatch.FullRowSelect = true;
            this.lvwChocoladeBatch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwChocoladeBatch.HideSelection = false;
            this.lvwChocoladeBatch.LabelWrap = false;
            this.lvwChocoladeBatch.Location = new System.Drawing.Point(39, 170);
            this.lvwChocoladeBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwChocoladeBatch.Name = "lvwChocoladeBatch";
            this.lvwChocoladeBatch.Size = new System.Drawing.Size(594, 231);
            this.lvwChocoladeBatch.TabIndex = 4;
            this.lvwChocoladeBatch.UseCompatibleStateImageBehavior = false;
            this.lvwChocoladeBatch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type chocolade";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hoeveelheid";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Houdbaarheidsdatum";
            this.columnHeader6.Width = 180;
            // 
            // lblOrderNummer
            // 
            this.lblOrderNummer.AutoSize = true;
            this.lblOrderNummer.Location = new System.Drawing.Point(39, 153);
            this.lblOrderNummer.Name = "lblOrderNummer";
            this.lblOrderNummer.Size = new System.Drawing.Size(45, 15);
            this.lblOrderNummer.TabIndex = 5;
            this.lblOrderNummer.Text = "orderid";
            // 
            // FrmVerkoopHistoriek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 433);
            this.Controls.Add(this.lblOrderNummer);
            this.Controls.Add(this.lvwChocoladeBatch);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVerkoopHistoriek";
            this.Text = "Verkoop: Historiek";
            this.Load += new System.EventHandler(this.FrmVerkoopHistoriek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGeannuleerd;
        private System.Windows.Forms.RadioButton radAfgewerkt;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.ListView lvwChocoladeBatch;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblOrderNummer;
    }
}