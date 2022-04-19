namespace Comptes
{
    partial class FrmDivisions
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
            this.btnAjouterRepartition = new System.Windows.Forms.Button();
            this.txtDivider = new System.Windows.Forms.TextBox();
            this.txtDividend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreFenRepartition = new System.Windows.Forms.Label();
            this.menuStripRepartition = new System.Windows.Forms.MenuStrip();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDivisions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSupprimerRepartition = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouterRepartition
            // 
            this.btnAjouterRepartition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnAjouterRepartition.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRepartition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnAjouterRepartition.Location = new System.Drawing.Point(480, 137);
            this.btnAjouterRepartition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjouterRepartition.Name = "btnAjouterRepartition";
            this.btnAjouterRepartition.Size = new System.Drawing.Size(124, 29);
            this.btnAjouterRepartition.TabIndex = 16;
            this.btnAjouterRepartition.Text = "Ajouter";
            this.btnAjouterRepartition.UseVisualStyleBackColor = false;
            this.btnAjouterRepartition.Click += new System.EventHandler(this.btnAjouterRepartition_Click);
            // 
            // txtDivider
            // 
            this.txtDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtDivider.Enabled = false;
            this.txtDivider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtDivider.Location = new System.Drawing.Point(377, 139);
            this.txtDivider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDivider.Name = "txtDivider";
            this.txtDivider.Size = new System.Drawing.Size(52, 26);
            this.txtDivider.TabIndex = 15;
            // 
            // txtDividend
            // 
            this.txtDividend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtDividend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtDividend.Location = new System.Drawing.Point(289, 139);
            this.txtDividend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDividend.Name = "txtDividend";
            this.txtDividend.Size = new System.Drawing.Size(52, 26);
            this.txtDividend.TabIndex = 14;
            this.txtDividend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDividende_KeyPress);
            this.txtDividend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDividende_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(26, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ajouter une répartition :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblTitreFenRepartition);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 76);
            this.panel1.TabIndex = 17;
            // 
            // lblTitreFenRepartition
            // 
            this.lblTitreFenRepartition.AutoSize = true;
            this.lblTitreFenRepartition.Font = new System.Drawing.Font("Script MT Bold", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreFenRepartition.Location = new System.Drawing.Point(135, 4);
            this.lblTitreFenRepartition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreFenRepartition.Name = "lblTitreFenRepartition";
            this.lblTitreFenRepartition.Size = new System.Drawing.Size(485, 65);
            this.lblTitreFenRepartition.TabIndex = 0;
            this.lblTitreFenRepartition.Text = "Editer les répartitions";
            // 
            // menuStripRepartition
            // 
            this.menuStripRepartition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStripRepartition.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripRepartition.Location = new System.Drawing.Point(0, 0);
            this.menuStripRepartition.Name = "menuStripRepartition";
            this.menuStripRepartition.Size = new System.Drawing.Size(733, 24);
            this.menuStripRepartition.TabIndex = 18;
            this.menuStripRepartition.Text = "menuStrip1";
            this.menuStripRepartition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripRepartition_MouseDown);
            this.menuStripRepartition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripRepartition_MouseMove);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(655, 0);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(78, 28);
            this.btnQuitter.TabIndex = 19;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(26, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Supprimer une répartition :";
            // 
            // cboDivisions
            // 
            this.cboDivisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboDivisions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDivisions.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDivisions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboDivisions.FormattingEnabled = true;
            this.cboDivisions.Location = new System.Drawing.Point(290, 197);
            this.cboDivisions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDivisions.Name = "cboDivisions";
            this.cboDivisions.Size = new System.Drawing.Size(168, 29);
            this.cboDivisions.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(350, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "/";
            // 
            // btnSupprimerRepartition
            // 
            this.btnSupprimerRepartition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnSupprimerRepartition.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerRepartition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnSupprimerRepartition.Location = new System.Drawing.Point(480, 197);
            this.btnSupprimerRepartition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupprimerRepartition.Name = "btnSupprimerRepartition";
            this.btnSupprimerRepartition.Size = new System.Drawing.Size(124, 29);
            this.btnSupprimerRepartition.TabIndex = 23;
            this.btnSupprimerRepartition.Text = "Supprimer";
            this.btnSupprimerRepartition.UseVisualStyleBackColor = false;
            this.btnSupprimerRepartition.Click += new System.EventHandler(this.btnSupprimerRepartition_Click);
            // 
            // FrmDivisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(733, 391);
            this.Controls.Add(this.btnSupprimerRepartition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDivisions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAjouterRepartition);
            this.Controls.Add(this.txtDivider);
            this.Controls.Add(this.txtDividend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStripRepartition);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripRepartition;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDivisions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterRepartition;
        private System.Windows.Forms.TextBox txtDivider;
        private System.Windows.Forms.TextBox txtDividend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreFenRepartition;
        private System.Windows.Forms.MenuStrip menuStripRepartition;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDivisions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupprimerRepartition;
    }
}