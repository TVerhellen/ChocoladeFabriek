
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
            this.lvwGrondstof = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTypeGrondstof = new System.Windows.Forms.TextBox();
            this.txtHoeveelheidGrondstof = new System.Windows.Forms.TextBox();
            this.txtHoudbaarheidGrondstof = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwGrondstof
            // 
            this.lvwGrondstof.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwGrondstof.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwGrondstof.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwGrondstof.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwGrondstof.FullRowSelect = true;
            this.lvwGrondstof.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGrondstof.HideSelection = false;
            this.lvwGrondstof.LabelWrap = false;
            this.lvwGrondstof.Location = new System.Drawing.Point(58, 160);
            this.lvwGrondstof.Name = "lvwGrondstof";
            this.lvwGrondstof.Size = new System.Drawing.Size(717, 326);
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
            // btnVerwijder
            // 
            this.btnVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerwijder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnVerwijder.FlatAppearance.BorderSize = 0;
            this.btnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerwijder.ForeColor = System.Drawing.Color.White;
            this.btnVerwijder.Location = new System.Drawing.Point(58, 515);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(105, 35);
            this.btnVerwijder.TabIndex = 20;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = false;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnWijzig
            // 
            this.btnWijzig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.btnWijzig.FlatAppearance.BorderSize = 0;
            this.btnWijzig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWijzig.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWijzig.ForeColor = System.Drawing.Color.White;
            this.btnWijzig.Location = new System.Drawing.Point(669, 17);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(105, 35);
            this.btnWijzig.TabIndex = 21;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.btnVoegToe.FlatAppearance.BorderSize = 0;
            this.btnVoegToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegToe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoegToe.ForeColor = System.Drawing.Color.White;
            this.btnVoegToe.Location = new System.Drawing.Point(510, 17);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(105, 35);
            this.btnVoegToe.TabIndex = 22;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = false;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(57, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 41);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(322, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 41);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(570, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 41);
            this.panel3.TabIndex = 33;
            // 
            // txtTypeGrondstof
            // 
            this.txtTypeGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeGrondstof.Location = new System.Drawing.Point(69, 105);
            this.txtTypeGrondstof.Name = "txtTypeGrondstof";
            this.txtTypeGrondstof.Size = new System.Drawing.Size(181, 20);
            this.txtTypeGrondstof.TabIndex = 24;
            // 
            // txtHoeveelheidGrondstof
            // 
            this.txtHoeveelheidGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoeveelheidGrondstof.Location = new System.Drawing.Point(334, 105);
            this.txtHoeveelheidGrondstof.Name = "txtHoeveelheidGrondstof";
            this.txtHoeveelheidGrondstof.Size = new System.Drawing.Size(181, 20);
            this.txtHoeveelheidGrondstof.TabIndex = 25;
            // 
            // txtHoudbaarheidGrondstof
            // 
            this.txtHoudbaarheidGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoudbaarheidGrondstof.Location = new System.Drawing.Point(582, 105);
            this.txtHoudbaarheidGrondstof.Name = "txtHoudbaarheidGrondstof";
            this.txtHoudbaarheidGrondstof.Size = new System.Drawing.Size(181, 20);
            this.txtHoudbaarheidGrondstof.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(57, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Type Grondstof:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(322, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hoeveelheid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(570, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Houdbaarheid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Grondstoffen";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtHoudbaarheidGrondstof);
            this.panel4.Controls.Add(this.txtHoeveelheidGrondstof);
            this.panel4.Controls.Add(this.txtTypeGrondstof);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnVoegToe);
            this.panel4.Controls.Add(this.btnWijzig);
            this.panel4.Location = new System.Drawing.Point(0, -7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 161);
            this.panel4.TabIndex = 34;
            // 
            // FrmStockGrondstof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(815, 573);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lvwGrondstof);
            this.Name = "FrmStockGrondstof";
            this.Text = "Stock Grondstoffen";
            this.Load += new System.EventHandler(this.FrmStockGrondstof_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvwGrondstof;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTypeGrondstof;
        private System.Windows.Forms.TextBox txtHoeveelheidGrondstof;
        private System.Windows.Forms.TextBox txtHoudbaarheidGrondstof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}