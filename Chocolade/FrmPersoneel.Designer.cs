
namespace Chocolade
{
    partial class FrmPersoneel
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbFunctie = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lvwPersoneel = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(569, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Functie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(321, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Wachtwoord:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(56, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Gebruikersnaam:";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWachtwoord.Location = new System.Drawing.Point(333, 102);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(181, 20);
            this.txtWachtwoord.TabIndex = 39;
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGebruikersnaam.Location = new System.Drawing.Point(68, 102);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(181, 20);
            this.txtGebruikersnaam.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cmbFunctie);
            this.panel3.Location = new System.Drawing.Point(569, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 41);
            this.panel3.TabIndex = 47;
            // 
            // cmbFunctie
            // 
            this.cmbFunctie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunctie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFunctie.FormattingEnabled = true;
            this.cmbFunctie.Location = new System.Drawing.Point(3, 7);
            this.cmbFunctie.Name = "cmbFunctie";
            this.cmbFunctie.Size = new System.Drawing.Size(198, 28);
            this.cmbFunctie.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(321, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 41);
            this.panel2.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(56, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 41);
            this.panel1.TabIndex = 45;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.btnVoegToe.FlatAppearance.BorderSize = 0;
            this.btnVoegToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegToe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoegToe.ForeColor = System.Drawing.Color.White;
            this.btnVoegToe.Location = new System.Drawing.Point(509, 14);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(105, 35);
            this.btnVoegToe.TabIndex = 37;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = false;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnWijzig
            // 
            this.btnWijzig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.btnWijzig.FlatAppearance.BorderSize = 0;
            this.btnWijzig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWijzig.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWijzig.ForeColor = System.Drawing.Color.White;
            this.btnWijzig.Location = new System.Drawing.Point(668, 14);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(105, 35);
            this.btnWijzig.TabIndex = 36;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerwijder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnVerwijder.FlatAppearance.BorderSize = 0;
            this.btnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerwijder.ForeColor = System.Drawing.Color.White;
            this.btnVerwijder.Location = new System.Drawing.Point(56, 506);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(105, 35);
            this.btnVerwijder.TabIndex = 35;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = false;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lvwPersoneel
            // 
            this.lvwPersoneel.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwPersoneel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPersoneel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwPersoneel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwPersoneel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwPersoneel.FullRowSelect = true;
            this.lvwPersoneel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPersoneel.HideSelection = false;
            this.lvwPersoneel.LabelWrap = false;
            this.lvwPersoneel.Location = new System.Drawing.Point(56, 157);
            this.lvwPersoneel.Name = "lvwPersoneel";
            this.lvwPersoneel.Size = new System.Drawing.Size(717, 329);
            this.lvwPersoneel.TabIndex = 34;
            this.lvwPersoneel.UseCompatibleStateImageBehavior = false;
            this.lvwPersoneel.View = System.Windows.Forms.View.Details;
            this.lvwPersoneel.SelectedIndexChanged += new System.EventHandler(this.lvwPersoneel_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gebruikersnaam";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wachtwoord";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Functie";
            this.columnHeader3.Width = 180;
            // 
            // FrmPersoneel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 573);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lvwPersoneel);
            this.Name = "FrmPersoneel";
            this.Text = "FrmPersoneel";
            this.Load += new System.EventHandler(this.FrmPersoneel_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListView lvwPersoneel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cmbFunctie;
    }
}