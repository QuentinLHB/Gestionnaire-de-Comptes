namespace Comptes.Vue
{
    partial class frmAnalysis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreFen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitter.Location = new System.Drawing.Point(922, 0);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(78, 31);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblTitreFen);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 95);
            this.panel1.TabIndex = 20;
            // 
            // lblTitreFen
            // 
            this.lblTitreFen.AutoSize = true;
            this.lblTitreFen.Font = new System.Drawing.Font("Script MT Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreFen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitreFen.Location = new System.Drawing.Point(367, 5);
            this.lblTitreFen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreFen.Name = "lblTitreFen";
            this.lblTitreFen.Size = new System.Drawing.Size(255, 81);
            this.lblTitreFen.TabIndex = 0;
            this.lblTitreFen.Text = "Analyse";
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAnalysis";
            this.Text = "frmAnalysis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreFen;
    }
}