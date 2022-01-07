
namespace Chocolade
{
    partial class FrmStockChocolade
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
            this.lvwChocoladeBatch = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoudbaarheidGrondstof = new System.Windows.Forms.TextBox();
            this.txtHoeveelheidGrondstof = new System.Windows.Forms.TextBox();
            this.txtTypeGrondstof = new System.Windows.Forms.TextBox();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lvwChocoladeBatch
            // 
            this.lvwChocoladeBatch.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwChocoladeBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwChocoladeBatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwChocoladeBatch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwChocoladeBatch.FullRowSelect = true;
            this.lvwChocoladeBatch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwChocoladeBatch.HideSelection = false;
            this.lvwChocoladeBatch.LabelWrap = false;
            this.lvwChocoladeBatch.Location = new System.Drawing.Point(58, 205);
            this.lvwChocoladeBatch.Name = "lvwChocoladeBatch";
            this.lvwChocoladeBatch.Size = new System.Drawing.Size(717, 343);
            this.lvwChocoladeBatch.TabIndex = 0;
            this.lvwChocoladeBatch.UseCompatibleStateImageBehavior = false;
            this.lvwChocoladeBatch.View = System.Windows.Forms.View.Details;
            this.lvwChocoladeBatch.SelectedIndexChanged += new System.EventHandler(this.lvwChocoladeBatch_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type Chocolade";
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
            this.btnVerwijder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnVerwijder.FlatAppearance.BorderSize = 0;
            this.btnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerwijder.ForeColor = System.Drawing.Color.White;
            this.btnVerwijder.Location = new System.Drawing.Point(58, 582);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(105, 35);
            this.btnVerwijder.TabIndex = 1;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = false;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.btnVoegToe.FlatAppearance.BorderSize = 0;
            this.btnVoegToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegToe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoegToe.ForeColor = System.Drawing.Color.White;
            this.btnVoegToe.Location = new System.Drawing.Point(511, 62);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(105, 35);
            this.btnVoegToe.TabIndex = 19;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = false;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(571, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Houdbaarheid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(323, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hoeveelheid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type Grondstof:";
            // 
            // txtHoudbaarheidGrondstof
            // 
            this.txtHoudbaarheidGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoudbaarheidGrondstof.Location = new System.Drawing.Point(583, 150);
            this.txtHoudbaarheidGrondstof.Name = "txtHoudbaarheidGrondstof";
            this.txtHoudbaarheidGrondstof.Size = new System.Drawing.Size(181, 20);
            this.txtHoudbaarheidGrondstof.TabIndex = 15;
            // 
            // txtHoeveelheidGrondstof
            // 
            this.txtHoeveelheidGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoeveelheidGrondstof.Location = new System.Drawing.Point(335, 150);
            this.txtHoeveelheidGrondstof.Name = "txtHoeveelheidGrondstof";
            this.txtHoeveelheidGrondstof.Size = new System.Drawing.Size(181, 20);
            this.txtHoeveelheidGrondstof.TabIndex = 14;
            // 
            // txtTypeGrondstof
            // 
            this.txtTypeGrondstof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeGrondstof.Location = new System.Drawing.Point(70, 150);
            this.txtTypeGrondstof.Name = "txtTypeGrondstof";
            this.txtTypeGrondstof.Size = new System.Drawing.Size(181, 20);
            this.txtTypeGrondstof.TabIndex = 13;
            // 
            // btnWijzig
            // 
            this.btnWijzig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.btnWijzig.FlatAppearance.BorderSize = 0;
            this.btnWijzig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWijzig.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWijzig.ForeColor = System.Drawing.Color.White;
            this.btnWijzig.Location = new System.Drawing.Point(670, 62);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(105, 35);
            this.btnWijzig.TabIndex = 12;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Chocolade Batches";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(58, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 41);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(323, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 41);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(571, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 41);
            this.panel3.TabIndex = 23;
            // 
            // FrmStockChocolade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(815, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoudbaarheidGrondstof);
            this.Controls.Add(this.txtHoeveelheidGrondstof);
            this.Controls.Add(this.txtTypeGrondstof);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lvwChocoladeBatch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStockChocolade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chocolade Batches";
            this.Load += new System.EventHandler(this.FrmStockChocolade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwChocoladeBatch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoudbaarheidGrondstof;
        private System.Windows.Forms.TextBox txtHoeveelheidGrondstof;
        private System.Windows.Forms.TextBox txtTypeGrondstof;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}