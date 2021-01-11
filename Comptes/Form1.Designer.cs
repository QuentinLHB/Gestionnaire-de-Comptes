namespace Comptes
{
    partial class frmComptes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMontantPersA = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.gpbAjoutBudget = new System.Windows.Forms.GroupBox();
            this.btnOKBudgets = new System.Windows.Forms.Button();
            this.lstBudgets = new System.Windows.Forms.ListBox();
            this.cboRepartition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersB = new System.Windows.Forms.TextBox();
            this.txtPersA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbComptes = new System.Windows.Forms.GroupBox();
            this.txtMontantPersB = new System.Windows.Forms.TextBox();
            this.lblPersB = new System.Windows.Forms.Label();
            this.lblPersA = new System.Windows.Forms.Label();
            this.btnOKComptes = new System.Windows.Forms.Button();
            this.lstComptes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblTotalPersB = new System.Windows.Forms.Label();
            this.lblTotalPersA = new System.Windows.Forms.Label();
            this.lblNomTotalPersB = new System.Windows.Forms.Label();
            this.lblNomTotalPersA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDividende = new System.Windows.Forms.TextBox();
            this.txtDiviseur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOKRepartition = new System.Windows.Forms.Button();
            this.gpbAjoutBudget.SuspendLayout();
            this.gpbComptes.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMontantPersA
            // 
            this.txtMontantPersA.Location = new System.Drawing.Point(88, 48);
            this.txtMontantPersA.Name = "txtMontantPersA";
            this.txtMontantPersA.Size = new System.Drawing.Size(127, 22);
            this.txtMontantPersA.TabIndex = 2;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(125, 47);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(140, 22);
            this.txtBudget.TabIndex = 1;
            // 
            // gpbAjoutBudget
            // 
            this.gpbAjoutBudget.Controls.Add(this.btnOKBudgets);
            this.gpbAjoutBudget.Controls.Add(this.lstBudgets);
            this.gpbAjoutBudget.Controls.Add(this.cboRepartition);
            this.gpbAjoutBudget.Controls.Add(this.label2);
            this.gpbAjoutBudget.Controls.Add(this.label1);
            this.gpbAjoutBudget.Controls.Add(this.txtBudget);
            this.gpbAjoutBudget.Location = new System.Drawing.Point(12, 64);
            this.gpbAjoutBudget.Name = "gpbAjoutBudget";
            this.gpbAjoutBudget.Size = new System.Drawing.Size(290, 551);
            this.gpbAjoutBudget.TabIndex = 5;
            this.gpbAjoutBudget.TabStop = false;
            this.gpbAjoutBudget.Text = "Ajouter un budget";
            // 
            // btnOKBudgets
            // 
            this.btnOKBudgets.Location = new System.Drawing.Point(91, 147);
            this.btnOKBudgets.Name = "btnOKBudgets";
            this.btnOKBudgets.Size = new System.Drawing.Size(75, 32);
            this.btnOKBudgets.TabIndex = 3;
            this.btnOKBudgets.Text = "OK";
            this.btnOKBudgets.UseVisualStyleBackColor = true;
            this.btnOKBudgets.Click += new System.EventHandler(this.btnOKBudgets_Click);
            // 
            // lstBudgets
            // 
            this.lstBudgets.FormattingEnabled = true;
            this.lstBudgets.ItemHeight = 16;
            this.lstBudgets.Location = new System.Drawing.Point(18, 195);
            this.lstBudgets.Name = "lstBudgets";
            this.lstBudgets.Size = new System.Drawing.Size(245, 308);
            this.lstBudgets.TabIndex = 4;
            this.lstBudgets.SelectedIndexChanged += new System.EventHandler(this.lstBudgets_SelectedIndexChanged);
            this.lstBudgets.DoubleClick += new System.EventHandler(this.lstBudgets_DoubleClick);
            // 
            // cboRepartition
            // 
            this.cboRepartition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepartition.FormattingEnabled = true;
            this.cboRepartition.Location = new System.Drawing.Point(125, 90);
            this.cboRepartition.Name = "cboRepartition";
            this.cboRepartition.Size = new System.Drawing.Size(140, 24);
            this.cboRepartition.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Répartition :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du budget :";
            // 
            // txtPersB
            // 
            this.txtPersB.Location = new System.Drawing.Point(262, 14);
            this.txtPersB.Name = "txtPersB";
            this.txtPersB.Size = new System.Drawing.Size(88, 22);
            this.txtPersB.TabIndex = 3;
            this.txtPersB.TextChanged += new System.EventHandler(this.txtPersB_TextChanged);
            // 
            // txtPersA
            // 
            this.txtPersA.Location = new System.Drawing.Point(127, 14);
            this.txtPersA.Name = "txtPersA";
            this.txtPersA.Size = new System.Drawing.Size(88, 22);
            this.txtPersA.TabIndex = 1;
            this.txtPersA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPersA_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comptes de :";
            // 
            // gpbComptes
            // 
            this.gpbComptes.Controls.Add(this.txtMontantPersB);
            this.gpbComptes.Controls.Add(this.lblPersB);
            this.gpbComptes.Controls.Add(this.lblPersA);
            this.gpbComptes.Controls.Add(this.btnOKComptes);
            this.gpbComptes.Controls.Add(this.lstComptes);
            this.gpbComptes.Controls.Add(this.txtMontantPersA);
            this.gpbComptes.Enabled = false;
            this.gpbComptes.Location = new System.Drawing.Point(321, 64);
            this.gpbComptes.Name = "gpbComptes";
            this.gpbComptes.Size = new System.Drawing.Size(278, 551);
            this.gpbComptes.TabIndex = 6;
            this.gpbComptes.TabStop = false;
            this.gpbComptes.Text = "Comptes du mois";
            // 
            // txtMontantPersB
            // 
            this.txtMontantPersB.Location = new System.Drawing.Point(88, 90);
            this.txtMontantPersB.Name = "txtMontantPersB";
            this.txtMontantPersB.Size = new System.Drawing.Size(127, 22);
            this.txtMontantPersB.TabIndex = 4;
            // 
            // lblPersB
            // 
            this.lblPersB.AutoSize = true;
            this.lblPersB.Location = new System.Drawing.Point(6, 93);
            this.lblPersB.Name = "lblPersB";
            this.lblPersB.Size = new System.Drawing.Size(53, 17);
            this.lblPersB.TabIndex = 3;
            this.lblPersB.Text = "Laura :";
            // 
            // lblPersA
            // 
            this.lblPersA.AutoSize = true;
            this.lblPersA.Location = new System.Drawing.Point(6, 48);
            this.lblPersA.Name = "lblPersA";
            this.lblPersA.Size = new System.Drawing.Size(66, 17);
            this.lblPersA.TabIndex = 1;
            this.lblPersA.Text = "Quentin :";
            // 
            // btnOKComptes
            // 
            this.btnOKComptes.Location = new System.Drawing.Point(99, 144);
            this.btnOKComptes.Name = "btnOKComptes";
            this.btnOKComptes.Size = new System.Drawing.Size(75, 35);
            this.btnOKComptes.TabIndex = 6;
            this.btnOKComptes.Text = "OK";
            this.btnOKComptes.UseVisualStyleBackColor = true;
            this.btnOKComptes.Click += new System.EventHandler(this.btnOKComptes_Click);
            // 
            // lstComptes
            // 
            this.lstComptes.FormattingEnabled = true;
            this.lstComptes.ItemHeight = 16;
            this.lstComptes.Location = new System.Drawing.Point(0, 195);
            this.lstComptes.Name = "lstComptes";
            this.lstComptes.Size = new System.Drawing.Size(272, 308);
            this.lstComptes.TabIndex = 7;
            this.lstComptes.SelectedIndexChanged += new System.EventHandler(this.lstComptes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "et";
            // 
            // gpbTotal
            // 
            this.gpbTotal.Controls.Add(this.lblResultat);
            this.gpbTotal.Controls.Add(this.lblTotalPersB);
            this.gpbTotal.Controls.Add(this.lblTotalPersA);
            this.gpbTotal.Controls.Add(this.lblNomTotalPersB);
            this.gpbTotal.Controls.Add(this.lblNomTotalPersA);
            this.gpbTotal.Location = new System.Drawing.Point(631, 64);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(268, 434);
            this.gpbTotal.TabIndex = 7;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total :";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(10, 270);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(56, 25);
            this.lblResultat.TabIndex = 11;
            this.lblResultat.Text = "Total";
            // 
            // lblTotalPersB
            // 
            this.lblTotalPersB.AutoSize = true;
            this.lblTotalPersB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersB.Location = new System.Drawing.Point(8, 182);
            this.lblTotalPersB.Name = "lblTotalPersB";
            this.lblTotalPersB.Size = new System.Drawing.Size(23, 25);
            this.lblTotalPersB.TabIndex = 10;
            this.lblTotalPersB.Text = "0";
            // 
            // lblTotalPersA
            // 
            this.lblTotalPersA.AutoSize = true;
            this.lblTotalPersA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersA.Location = new System.Drawing.Point(8, 85);
            this.lblTotalPersA.Name = "lblTotalPersA";
            this.lblTotalPersA.Size = new System.Drawing.Size(23, 25);
            this.lblTotalPersA.TabIndex = 9;
            this.lblTotalPersA.Text = "0";
            // 
            // lblNomTotalPersB
            // 
            this.lblNomTotalPersB.AutoSize = true;
            this.lblNomTotalPersB.Location = new System.Drawing.Point(6, 144);
            this.lblNomTotalPersB.Name = "lblNomTotalPersB";
            this.lblNomTotalPersB.Size = new System.Drawing.Size(168, 17);
            this.lblNomTotalPersB.TabIndex = 8;
            this.lblNomTotalPersB.Text = "Total dettes personne B :";
            // 
            // lblNomTotalPersA
            // 
            this.lblNomTotalPersA.AutoSize = true;
            this.lblNomTotalPersA.Location = new System.Drawing.Point(6, 47);
            this.lblNomTotalPersA.Name = "lblNomTotalPersA";
            this.lblNomTotalPersA.Size = new System.Drawing.Size(172, 17);
            this.lblNomTotalPersA.TabIndex = 0;
            this.lblNomTotalPersA.Text = "Total  dettes personne A :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ajouter une répartition :";
            // 
            // txtDividende
            // 
            this.txtDividende.Location = new System.Drawing.Point(580, 9);
            this.txtDividende.Name = "txtDividende";
            this.txtDividende.Size = new System.Drawing.Size(42, 22);
            this.txtDividende.TabIndex = 9;
            this.txtDividende.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDividende_KeyPress);
            this.txtDividende.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDividende_KeyUp);
            // 
            // txtDiviseur
            // 
            this.txtDiviseur.Enabled = false;
            this.txtDiviseur.Location = new System.Drawing.Point(644, 9);
            this.txtDiviseur.Name = "txtDiviseur";
            this.txtDiviseur.Size = new System.Drawing.Size(42, 22);
            this.txtDiviseur.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // btnOKRepartition
            // 
            this.btnOKRepartition.Location = new System.Drawing.Point(706, 8);
            this.btnOKRepartition.Name = "btnOKRepartition";
            this.btnOKRepartition.Size = new System.Drawing.Size(44, 23);
            this.btnOKRepartition.TabIndex = 12;
            this.btnOKRepartition.Text = "OK";
            this.btnOKRepartition.UseVisualStyleBackColor = true;
            this.btnOKRepartition.Click += new System.EventHandler(this.btnOKRepartition_Click);
            // 
            // frmComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 653);
            this.Controls.Add(this.btnOKRepartition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiviseur);
            this.Controls.Add(this.txtDividende);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpbComptes);
            this.Controls.Add(this.txtPersB);
            this.Controls.Add(this.txtPersA);
            this.Controls.Add(this.gpbAjoutBudget);
            this.Controls.Add(this.label3);
            this.Name = "frmComptes";
            this.Text = "Gestion des comptes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbAjoutBudget.ResumeLayout(false);
            this.gpbAjoutBudget.PerformLayout();
            this.gpbComptes.ResumeLayout(false);
            this.gpbComptes.PerformLayout();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMontantPersA;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.GroupBox gpbAjoutBudget;
        private System.Windows.Forms.ListBox lstBudgets;
        private System.Windows.Forms.ComboBox cboRepartition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbComptes;
        private System.Windows.Forms.ListBox lstComptes;
        private System.Windows.Forms.Button btnOKComptes;
        private System.Windows.Forms.Button btnOKBudgets;
        private System.Windows.Forms.TextBox txtPersB;
        private System.Windows.Forms.TextBox txtPersA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontantPersB;
        private System.Windows.Forms.Label lblPersB;
        private System.Windows.Forms.Label lblPersA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.Label lblNomTotalPersB;
        private System.Windows.Forms.Label lblNomTotalPersA;
        private System.Windows.Forms.Label lblTotalPersB;
        private System.Windows.Forms.Label lblTotalPersA;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDividende;
        private System.Windows.Forms.TextBox txtDiviseur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOKRepartition;
    }
}

