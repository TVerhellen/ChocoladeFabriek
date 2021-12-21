
namespace Chocolade
{
    partial class FrmMachines
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartDiagram = new System.Windows.Forms.Label();
            this.lblEndDiagram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(55, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 237);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblStartDiagram
            // 
            this.lblStartDiagram.AutoSize = true;
            this.lblStartDiagram.Location = new System.Drawing.Point(55, 123);
            this.lblStartDiagram.Name = "lblStartDiagram";
            this.lblStartDiagram.Size = new System.Drawing.Size(50, 20);
            this.lblStartDiagram.TabIndex = 1;
            this.lblStartDiagram.Text = "label1";
            // 
            // lblEndDiagram
            // 
            this.lblEndDiagram.Location = new System.Drawing.Point(515, 123);
            this.lblEndDiagram.Name = "lblEndDiagram";
            this.lblEndDiagram.Size = new System.Drawing.Size(219, 20);
            this.lblEndDiagram.TabIndex = 2;
            this.lblEndDiagram.Text = "label2";
            this.lblEndDiagram.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEndDiagram);
            this.Controls.Add(this.lblStartDiagram);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMachines";
            this.Text = "FrmMachines";
            this.Load += new System.EventHandler(this.FrmMachines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStartDiagram;
        private System.Windows.Forms.Label lblEndDiagram;
    }
}