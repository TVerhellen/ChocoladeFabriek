
namespace Chocolade
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pctChocolate = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctChocolate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGebruikersnaam.Location = new System.Drawing.Point(9, 8);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(299, 27);
            this.txtGebruikersnaam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wachtwoord:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(69, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(317, 47);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(371, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pctChocolate
            // 
            this.pctChocolate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.pctChocolate.Image = global::Chocolade.Properties.Resources.Chocolate;
            this.pctChocolate.Location = new System.Drawing.Point(168, 109);
            this.pctChocolate.Name = "pctChocolate";
            this.pctChocolate.Size = new System.Drawing.Size(124, 92);
            this.pctChocolate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctChocolate.TabIndex = 6;
            this.pctChocolate.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtGebruikersnaam);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(69, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 46);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtWachtwoord);
            this.panel2.Location = new System.Drawing.Point(69, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 46);
            this.panel2.TabIndex = 1;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWachtwoord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWachtwoord.Location = new System.Drawing.Point(9, 8);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(299, 27);
            this.txtWachtwoord.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 518);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 148);
            this.panel4.TabIndex = 12;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(447, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctChocolate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctChocolate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pctChocolate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}