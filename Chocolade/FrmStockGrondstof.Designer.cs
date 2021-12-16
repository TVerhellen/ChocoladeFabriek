
namespace Chocolade
{
    partial class FrmStockGrondstof
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
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lvwGrondstof = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.txtTypeGrondstof = new System.Windows.Forms.TextBox();
            this.txtHoeveelheidGrondstof = new System.Windows.Forms.TextBox();
            this.txtHoudbaarheidGrondstof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(63, 456);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(94, 29);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lvwGrondstof
            // 
            this.lvwGrondstof.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwGrondstof.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwGrondstof.FullRowSelect = true;
            this.lvwGrondstof.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGrondstof.HideSelection = false;
            this.lvwGrondstof.LabelWrap = false;
            this.lvwGrondstof.Location = new System.Drawing.Point(63, 130);
            this.lvwGrondstof.Name = "lvwGrondstof";
            this.lvwGrondstof.Size = new System.Drawing.Size(678, 307);
            this.lvwGrondstof.TabIndex = 2;
            this.lvwGrondstof.UseCompatibleStateImageBehavior = false;
            this.lvwGrondstof.View = System.Windows.Forms.View.Details;
            this.lvwGrondstof.SelectedIndexChanged += new System.EventHandler(this.lvwGrondstof_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type Grondstof";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hoeveelheid";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Houdbaarheidsdatum";
            this.columnHeader3.Width = 180;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(647, 40);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(94, 29);
            this.btnWijzig.TabIndex = 4;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // txtTypeGrondstof
            // 
            this.txtTypeGrondstof.Location = new System.Drawing.Point(63, 74);
            this.txtTypeGrondstof.Name = "txtTypeGrondstof";
            this.txtTypeGrondstof.Size = new System.Drawing.Size(181, 27);
            this.txtTypeGrondstof.TabIndex = 5;
            // 
            // txtHoeveelheidGrondstof
            // 
            this.txtHoeveelheidGrondstof.Location = new System.Drawing.Point(265, 74);
            this.txtHoeveelheidGrondstof.Name = "txtHoeveelheidGrondstof";
            this.txtHoeveelheidGrondstof.Size = new System.Drawing.Size(181, 27);
            this.txtHoeveelheidGrondstof.TabIndex = 6;
            // 
            // txtHoudbaarheidGrondstof
            // 
            this.txtHoudbaarheidGrondstof.Location = new System.Drawing.Point(468, 74);
            this.txtHoudbaarheidGrondstof.Name = "txtHoudbaarheidGrondstof";
            this.txtHoudbaarheidGrondstof.Size = new System.Drawing.Size(147, 27);
            this.txtHoudbaarheidGrondstof.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type Grondstof:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hoeveelheid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Houdbaarheid:";
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(647, 86);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(94, 29);
            this.btnVoegToe.TabIndex = 11;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // FrmStockGrondstof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoudbaarheidGrondstof);
            this.Controls.Add(this.txtHoeveelheidGrondstof);
            this.Controls.Add(this.txtTypeGrondstof);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lvwGrondstof);
            this.Name = "FrmStockGrondstof";
            this.Text = "Stock Grondstoffen";
            this.Load += new System.EventHandler(this.FrmStockGrondstof_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListView lvwGrondstof;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.TextBox txtTypeGrondstof;
        private System.Windows.Forms.TextBox txtHoeveelheidGrondstof;
        private System.Windows.Forms.TextBox txtHoudbaarheidGrondstof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoegToe;
    }
}