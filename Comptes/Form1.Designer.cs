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
            this.txtMontantUserA = new System.Windows.Forms.TextBox();
            this.txtNomBudget = new System.Windows.Forms.TextBox();
            this.gpbAjoutBudget = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOKBudgets = new System.Windows.Forms.Button();
            this.lstBudgets = new System.Windows.Forms.ListBox();
            this.cboRepartition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserB = new System.Windows.Forms.TextBox();
            this.txtUserA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbComptes = new System.Windows.Forms.GroupBox();
            this.txtMontantUserB = new System.Windows.Forms.TextBox();
            this.lblUserB = new System.Windows.Forms.Label();
            this.lblUserA = new System.Windows.Forms.Label();
            this.btnOKComptes = new System.Windows.Forms.Button();
            this.lstComptes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblTotalPersB = new System.Windows.Forms.Label();
            this.lblTotalPersA = new System.Windows.Forms.Label();
            this.lblNomTotalUserB = new System.Windows.Forms.Label();
            this.lblNomTotalUserA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDividende = new System.Windows.Forms.TextBox();
            this.txtDiviseur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOKRepartition = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSauvegarder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbAjoutBudget.SuspendLayout();
            this.gpbComptes.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMontantUserA
            // 
            this.txtMontantUserA.Location = new System.Drawing.Point(112, 73);
            this.txtMontantUserA.Name = "txtMontantUserA";
            this.txtMontantUserA.Size = new System.Drawing.Size(141, 22);
            this.txtMontantUserA.TabIndex = 2;
            // 
            // txtNomBudget
            // 
            this.txtNomBudget.Location = new System.Drawing.Point(125, 72);
            this.txtNomBudget.Name = "txtNomBudget";
            this.txtNomBudget.Size = new System.Drawing.Size(140, 22);
            this.txtNomBudget.TabIndex = 1;
            // 
            // gpbAjoutBudget
            // 
            this.gpbAjoutBudget.Controls.Add(this.btnEdit);
            this.gpbAjoutBudget.Controls.Add(this.btnOKBudgets);
            this.gpbAjoutBudget.Controls.Add(this.lstBudgets);
            this.gpbAjoutBudget.Controls.Add(this.cboRepartition);
            this.gpbAjoutBudget.Controls.Add(this.label2);
            this.gpbAjoutBudget.Controls.Add(this.label1);
            this.gpbAjoutBudget.Controls.Add(this.txtNomBudget);
            this.gpbAjoutBudget.Location = new System.Drawing.Point(12, 100);
            this.gpbAjoutBudget.Name = "gpbAjoutBudget";
            this.gpbAjoutBudget.Size = new System.Drawing.Size(290, 551);
            this.gpbAjoutBudget.TabIndex = 5;
            this.gpbAjoutBudget.TabStop = false;
            this.gpbAjoutBudget.Text = "Ajouter un budget";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(91, 172);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 32);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOKBudgets
            // 
            this.btnOKBudgets.Location = new System.Drawing.Point(91, 172);
            this.btnOKBudgets.Name = "btnOKBudgets";
            this.btnOKBudgets.Size = new System.Drawing.Size(75, 32);
            this.btnOKBudgets.TabIndex = 4;
            this.btnOKBudgets.Text = "OK";
            this.btnOKBudgets.UseVisualStyleBackColor = true;
            this.btnOKBudgets.Click += new System.EventHandler(this.btnOKBudgets_Click);
            // 
            // lstBudgets
            // 
            this.lstBudgets.FormattingEnabled = true;
            this.lstBudgets.ItemHeight = 16;
            this.lstBudgets.Location = new System.Drawing.Point(18, 220);
            this.lstBudgets.Name = "lstBudgets";
            this.lstBudgets.Size = new System.Drawing.Size(245, 308);
            this.lstBudgets.TabIndex = 6;
            this.lstBudgets.SelectedIndexChanged += new System.EventHandler(this.lstBudgets_SelectedIndexChanged);
            this.lstBudgets.DoubleClick += new System.EventHandler(this.lstBudgets_DoubleClick);
            this.lstBudgets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstBudgets_KeyUp);
            // 
            // cboRepartition
            // 
            this.cboRepartition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepartition.FormattingEnabled = true;
            this.cboRepartition.Location = new System.Drawing.Point(125, 115);
            this.cboRepartition.Name = "cboRepartition";
            this.cboRepartition.Size = new System.Drawing.Size(140, 24);
            this.cboRepartition.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Répartition :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du budget :";
            // 
            // txtUserB
            // 
            this.txtUserB.Location = new System.Drawing.Point(262, 46);
            this.txtUserB.Name = "txtUserB";
            this.txtUserB.Size = new System.Drawing.Size(88, 22);
            this.txtUserB.TabIndex = 3;
            this.txtUserB.TextChanged += new System.EventHandler(this.txtUserB_TextChanged);
            this.txtUserB.Leave += new System.EventHandler(this.txtUserB_Leave);
            // 
            // txtUserA
            // 
            this.txtUserA.Location = new System.Drawing.Point(127, 46);
            this.txtUserA.Name = "txtUserA";
            this.txtUserA.Size = new System.Drawing.Size(88, 22);
            this.txtUserA.TabIndex = 1;
            this.txtUserA.TextChanged += new System.EventHandler(this.txtUserA_TextChanged);
            this.txtUserA.Leave += new System.EventHandler(this.txtUserA_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comptes de :";
            // 
            // gpbComptes
            // 
            this.gpbComptes.Controls.Add(this.txtMontantUserB);
            this.gpbComptes.Controls.Add(this.lblUserB);
            this.gpbComptes.Controls.Add(this.lblUserA);
            this.gpbComptes.Controls.Add(this.btnOKComptes);
            this.gpbComptes.Controls.Add(this.lstComptes);
            this.gpbComptes.Controls.Add(this.txtMontantUserA);
            this.gpbComptes.Enabled = false;
            this.gpbComptes.Location = new System.Drawing.Point(321, 100);
            this.gpbComptes.Name = "gpbComptes";
            this.gpbComptes.Size = new System.Drawing.Size(278, 551);
            this.gpbComptes.TabIndex = 6;
            this.gpbComptes.TabStop = false;
            this.gpbComptes.Text = "Comptes du mois";
            // 
            // txtMontantUserB
            // 
            this.txtMontantUserB.Location = new System.Drawing.Point(112, 115);
            this.txtMontantUserB.Name = "txtMontantUserB";
            this.txtMontantUserB.Size = new System.Drawing.Size(141, 22);
            this.txtMontantUserB.TabIndex = 4;
            // 
            // lblUserB
            // 
            this.lblUserB.AutoSize = true;
            this.lblUserB.Location = new System.Drawing.Point(6, 118);
            this.lblUserB.Name = "lblUserB";
            this.lblUserB.Size = new System.Drawing.Size(89, 17);
            this.lblUserB.TabIndex = 3;
            this.lblUserB.Text = "personne B :";
            // 
            // lblUserA
            // 
            this.lblUserA.AutoSize = true;
            this.lblUserA.Location = new System.Drawing.Point(6, 73);
            this.lblUserA.Name = "lblUserA";
            this.lblUserA.Size = new System.Drawing.Size(89, 17);
            this.lblUserA.TabIndex = 1;
            this.lblUserA.Text = "personne A :";
            // 
            // btnOKComptes
            // 
            this.btnOKComptes.Location = new System.Drawing.Point(99, 169);
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
            this.lstComptes.Location = new System.Drawing.Point(0, 220);
            this.lstComptes.Name = "lstComptes";
            this.lstComptes.Size = new System.Drawing.Size(272, 308);
            this.lstComptes.TabIndex = 7;
            this.lstComptes.SelectedIndexChanged += new System.EventHandler(this.lstComptes_SelectedIndexChanged);
            this.lstComptes.DoubleClick += new System.EventHandler(this.lstComptes_DoubleClick);
            this.lstComptes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstComptes_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 49);
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
            this.gpbTotal.Controls.Add(this.lblNomTotalUserB);
            this.gpbTotal.Controls.Add(this.lblNomTotalUserA);
            this.gpbTotal.Location = new System.Drawing.Point(631, 100);
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
            this.lblResultat.Location = new System.Drawing.Point(10, 295);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(56, 25);
            this.lblResultat.TabIndex = 11;
            this.lblResultat.Text = "Total";
            // 
            // lblTotalPersB
            // 
            this.lblTotalPersB.AutoSize = true;
            this.lblTotalPersB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersB.Location = new System.Drawing.Point(8, 207);
            this.lblTotalPersB.Name = "lblTotalPersB";
            this.lblTotalPersB.Size = new System.Drawing.Size(23, 25);
            this.lblTotalPersB.TabIndex = 10;
            this.lblTotalPersB.Text = "0";
            // 
            // lblTotalPersA
            // 
            this.lblTotalPersA.AutoSize = true;
            this.lblTotalPersA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersA.Location = new System.Drawing.Point(8, 93);
            this.lblTotalPersA.Name = "lblTotalPersA";
            this.lblTotalPersA.Size = new System.Drawing.Size(23, 25);
            this.lblTotalPersA.TabIndex = 9;
            this.lblTotalPersA.Text = "0";
            // 
            // lblNomTotalUserB
            // 
            this.lblNomTotalUserB.AutoSize = true;
            this.lblNomTotalUserB.Location = new System.Drawing.Point(6, 169);
            this.lblNomTotalUserB.Name = "lblNomTotalUserB";
            this.lblNomTotalUserB.Size = new System.Drawing.Size(168, 17);
            this.lblNomTotalUserB.TabIndex = 8;
            this.lblNomTotalUserB.Text = "Total dettes personne B :";
            // 
            // lblNomTotalUserA
            // 
            this.lblNomTotalUserA.AutoSize = true;
            this.lblNomTotalUserA.Location = new System.Drawing.Point(6, 55);
            this.lblNomTotalUserA.Name = "lblNomTotalUserA";
            this.lblNomTotalUserA.Size = new System.Drawing.Size(172, 17);
            this.lblNomTotalUserA.TabIndex = 0;
            this.lblNomTotalUserA.Text = "Total  dettes personne A :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ajouter une répartition :";
            // 
            // txtDividende
            // 
            this.txtDividende.Location = new System.Drawing.Point(728, 48);
            this.txtDividende.Name = "txtDividende";
            this.txtDividende.Size = new System.Drawing.Size(42, 22);
            this.txtDividende.TabIndex = 9;
            this.txtDividende.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDividende_KeyPress);
            this.txtDividende.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDividende_KeyUp);
            // 
            // txtDiviseur
            // 
            this.txtDiviseur.Enabled = false;
            this.txtDiviseur.Location = new System.Drawing.Point(792, 48);
            this.txtDiviseur.Name = "txtDiviseur";
            this.txtDiviseur.Size = new System.Drawing.Size(42, 22);
            this.txtDiviseur.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // btnOKRepartition
            // 
            this.btnOKRepartition.Location = new System.Drawing.Point(854, 47);
            this.btnOKRepartition.Name = "btnOKRepartition";
            this.btnOKRepartition.Size = new System.Drawing.Size(44, 23);
            this.btnOKRepartition.TabIndex = 12;
            this.btnOKRepartition.Text = "OK";
            this.btnOKRepartition.UseVisualStyleBackColor = true;
            this.btnOKRepartition.Click += new System.EventHandler(this.btnOKRepartition_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSauvegarder,
            this.menuReinitialiser});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(66, 24);
            this.mainMenu.Text = "Fichier";
            // 
            // menuSauvegarder
            // 
            this.menuSauvegarder.Name = "menuSauvegarder";
            this.menuSauvegarder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSauvegarder.Size = new System.Drawing.Size(255, 26);
            this.menuSauvegarder.Text = "Sauvegarder";
            this.menuSauvegarder.Click += new System.EventHandler(this.menuSauvegarder_Click);
            // 
            // menuReinitialiser
            // 
            this.menuReinitialiser.Name = "menuReinitialiser";
            this.menuReinitialiser.Size = new System.Drawing.Size(255, 26);
            this.menuReinitialiser.Text = "Réinitialiser l\'application";
            this.menuReinitialiser.Click += new System.EventHandler(this.menuReinitialiser_Click);
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
            this.Controls.Add(this.txtUserB);
            this.Controls.Add(this.txtUserA);
            this.Controls.Add(this.gpbAjoutBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmComptes";
            this.Text = "Gestion des comptes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComptes_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbAjoutBudget.ResumeLayout(false);
            this.gpbAjoutBudget.PerformLayout();
            this.gpbComptes.ResumeLayout(false);
            this.gpbComptes.PerformLayout();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMontantUserA;
        private System.Windows.Forms.TextBox txtNomBudget;
        private System.Windows.Forms.GroupBox gpbAjoutBudget;
        private System.Windows.Forms.ListBox lstBudgets;
        private System.Windows.Forms.ComboBox cboRepartition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbComptes;
        private System.Windows.Forms.ListBox lstComptes;
        private System.Windows.Forms.Button btnOKComptes;
        private System.Windows.Forms.Button btnOKBudgets;
        private System.Windows.Forms.TextBox txtUserB;
        private System.Windows.Forms.TextBox txtUserA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontantUserB;
        private System.Windows.Forms.Label lblUserB;
        private System.Windows.Forms.Label lblUserA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.Label lblNomTotalUserB;
        private System.Windows.Forms.Label lblNomTotalUserA;
        private System.Windows.Forms.Label lblTotalPersB;
        private System.Windows.Forms.Label lblTotalPersA;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDividende;
        private System.Windows.Forms.TextBox txtDiviseur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOKRepartition;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuSauvegarder;
        private System.Windows.Forms.ToolStripMenuItem menuReinitialiser;
    }
}

