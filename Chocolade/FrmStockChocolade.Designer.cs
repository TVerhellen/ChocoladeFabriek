
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
            this.SuspendLayout();
            // 
            // lvwChocoladeBatch
            // 
            this.lvwChocoladeBatch.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwChocoladeBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwChocoladeBatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwChocoladeBatch.FullRowSelect = true;
            this.lvwChocoladeBatch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwChocoladeBatch.HideSelection = false;
            this.lvwChocoladeBatch.LabelWrap = false;
            this.lvwChocoladeBatch.Location = new System.Drawing.Point(58, 92);
            this.lvwChocoladeBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwChocoladeBatch.Name = "lvwChocoladeBatch";
            this.lvwChocoladeBatch.Size = new System.Drawing.Size(594, 231);
            this.lvwChocoladeBatch.TabIndex = 0;
            this.lvwChocoladeBatch.UseCompatibleStateImageBehavior = false;
            this.lvwChocoladeBatch.View = System.Windows.Forms.View.Details;
            this.lvwChocoladeBatch.SelectedIndexChanged += new System.EventHandler(this.lvwChocoladeBatch_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type chocolade";
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
            this.btnVerwijder.Location = new System.Drawing.Point(58, 334);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(82, 22);
            this.btnVerwijder.TabIndex = 1;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(569, 65);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(82, 22);
            this.btnVoegToe.TabIndex = 19;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Houdbaarheid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hoeveelheid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type Grondstof:";
            // 
            // txtHoudbaarheidGrondstof
            // 
            this.txtHoudbaarheidGrondstof.Location = new System.Drawing.Point(412, 56);
            this.txtHoudbaarheidGrondstof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoudbaarheidGrondstof.Name = "txtHoudbaarheidGrondstof";
            this.txtHoudbaarheidGrondstof.Size = new System.Drawing.Size(129, 23);
            this.txtHoudbaarheidGrondstof.TabIndex = 15;
            // 
            // txtHoeveelheidGrondstof
            // 
            this.txtHoeveelheidGrondstof.Location = new System.Drawing.Point(234, 56);
            this.txtHoeveelheidGrondstof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoeveelheidGrondstof.Name = "txtHoeveelheidGrondstof";
            this.txtHoeveelheidGrondstof.Size = new System.Drawing.Size(159, 23);
            this.txtHoeveelheidGrondstof.TabIndex = 14;
            // 
            // txtTypeGrondstof
            // 
            this.txtTypeGrondstof.Location = new System.Drawing.Point(58, 56);
            this.txtTypeGrondstof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTypeGrondstof.Name = "txtTypeGrondstof";
            this.txtTypeGrondstof.Size = new System.Drawing.Size(159, 23);
            this.txtTypeGrondstof.TabIndex = 13;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(569, 31);
            this.btnWijzig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(82, 22);
            this.btnWijzig.TabIndex = 12;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // FrmStockChocolade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 374);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStockChocolade";
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
    }
}