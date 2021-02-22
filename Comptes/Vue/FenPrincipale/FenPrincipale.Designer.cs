namespace Comptes
{
    partial class frmPrincipal
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
            this.btnResetBudget = new System.Windows.Forms.Button();
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
            this.btnResetComptes = new System.Windows.Forms.Button();
            this.txtMontantUserB = new System.Windows.Forms.TextBox();
            this.lblUserB = new System.Windows.Forms.Label();
            this.lblUserA = new System.Windows.Forms.Label();
            this.btnOKComptes = new System.Windows.Forms.Button();
            this.lstComptes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.btnCloture = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblTotalPersB = new System.Windows.Forms.Label();
            this.lblTotalPersA = new System.Windows.Forms.Label();
            this.lblNomTotalUserB = new System.Windows.Forms.Label();
            this.lblNomTotalUserA = new System.Windows.Forms.Label();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSauvegarder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepartition = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterRepartition = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegardesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSauvegardes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreApp = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.cboAnnee = new System.Windows.Forms.ComboBox();
            this.gpbAjoutBudget.SuspendLayout();
            this.gpbComptes.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMontantUserA
            // 
            this.txtMontantUserA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtMontantUserA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtMontantUserA.Location = new System.Drawing.Point(148, 60);
            this.txtMontantUserA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontantUserA.Name = "txtMontantUserA";
            this.txtMontantUserA.Size = new System.Drawing.Size(184, 28);
            this.txtMontantUserA.TabIndex = 2;
            // 
            // txtNomBudget
            // 
            this.txtNomBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtNomBudget.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtNomBudget.Location = new System.Drawing.Point(160, 55);
            this.txtNomBudget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomBudget.Name = "txtNomBudget";
            this.txtNomBudget.Size = new System.Drawing.Size(168, 28);
            this.txtNomBudget.TabIndex = 1;
            // 
            // gpbAjoutBudget
            // 
            this.gpbAjoutBudget.Controls.Add(this.btnResetBudget);
            this.gpbAjoutBudget.Controls.Add(this.btnEdit);
            this.gpbAjoutBudget.Controls.Add(this.btnOKBudgets);
            this.gpbAjoutBudget.Controls.Add(this.lstBudgets);
            this.gpbAjoutBudget.Controls.Add(this.cboRepartition);
            this.gpbAjoutBudget.Controls.Add(this.label2);
            this.gpbAjoutBudget.Controls.Add(this.label1);
            this.gpbAjoutBudget.Controls.Add(this.txtNomBudget);
            this.gpbAjoutBudget.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAjoutBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbAjoutBudget.Location = new System.Drawing.Point(50, 222);
            this.gpbAjoutBudget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbAjoutBudget.Name = "gpbAjoutBudget";
            this.gpbAjoutBudget.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbAjoutBudget.Size = new System.Drawing.Size(350, 574);
            this.gpbAjoutBudget.TabIndex = 5;
            this.gpbAjoutBudget.TabStop = false;
            this.gpbAjoutBudget.Text = "Ajouter un budget";
            // 
            // btnResetBudget
            // 
            this.btnResetBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnResetBudget.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnResetBudget.Location = new System.Drawing.Point(255, 527);
            this.btnResetBudget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResetBudget.Name = "btnResetBudget";
            this.btnResetBudget.Size = new System.Drawing.Size(81, 31);
            this.btnResetBudget.TabIndex = 7;
            this.btnResetBudget.Text = "Vider";
            this.btnResetBudget.UseVisualStyleBackColor = false;
            this.btnResetBudget.Click += new System.EventHandler(this.btnResetBudget_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnEdit.Location = new System.Drawing.Point(16, 195);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(320, 31);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editer";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOKBudgets
            // 
            this.btnOKBudgets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOKBudgets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKBudgets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOKBudgets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOKBudgets.Location = new System.Drawing.Point(16, 195);
            this.btnOKBudgets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOKBudgets.Name = "btnOKBudgets";
            this.btnOKBudgets.Size = new System.Drawing.Size(320, 31);
            this.btnOKBudgets.TabIndex = 4;
            this.btnOKBudgets.Text = "Valider";
            this.btnOKBudgets.UseVisualStyleBackColor = false;
            this.btnOKBudgets.Click += new System.EventHandler(this.btnOKBudgets_Click);
            // 
            // lstBudgets
            // 
            this.lstBudgets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.lstBudgets.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBudgets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstBudgets.FormattingEnabled = true;
            this.lstBudgets.ItemHeight = 21;
            this.lstBudgets.Location = new System.Drawing.Point(16, 236);
            this.lstBudgets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBudgets.Name = "lstBudgets";
            this.lstBudgets.Size = new System.Drawing.Size(320, 277);
            this.lstBudgets.TabIndex = 6;
            this.lstBudgets.SelectedIndexChanged += new System.EventHandler(this.lstBudgets_SelectedIndexChanged);
            this.lstBudgets.DoubleClick += new System.EventHandler(this.lstBudgets_DoubleClick);
            this.lstBudgets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstBudgets_KeyUp);
            // 
            // cboRepartition
            // 
            this.cboRepartition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboRepartition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepartition.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRepartition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboRepartition.FormattingEnabled = true;
            this.cboRepartition.Location = new System.Drawing.Point(160, 98);
            this.cboRepartition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboRepartition.Name = "cboRepartition";
            this.cboRepartition.Size = new System.Drawing.Size(168, 29);
            this.cboRepartition.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Répartition :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du budget :";
            // 
            // txtUserB
            // 
            this.txtUserB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtUserB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtUserB.Location = new System.Drawing.Point(376, 160);
            this.txtUserB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserB.Name = "txtUserB";
            this.txtUserB.Size = new System.Drawing.Size(127, 28);
            this.txtUserB.TabIndex = 3;
            this.txtUserB.TextChanged += new System.EventHandler(this.txtUserB_TextChanged);
            this.txtUserB.Leave += new System.EventHandler(this.txtUserB_Leave);
            // 
            // txtUserA
            // 
            this.txtUserA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtUserA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtUserA.Location = new System.Drawing.Point(192, 160);
            this.txtUserA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserA.Name = "txtUserA";
            this.txtUserA.Size = new System.Drawing.Size(127, 28);
            this.txtUserA.TabIndex = 1;
            this.txtUserA.TextChanged += new System.EventHandler(this.txtUserA_TextChanged);
            this.txtUserA.Leave += new System.EventHandler(this.txtUserA_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(60, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comptes de :";
            // 
            // gpbComptes
            // 
            this.gpbComptes.Controls.Add(this.btnResetComptes);
            this.gpbComptes.Controls.Add(this.txtMontantUserB);
            this.gpbComptes.Controls.Add(this.lblUserB);
            this.gpbComptes.Controls.Add(this.lblUserA);
            this.gpbComptes.Controls.Add(this.btnOKComptes);
            this.gpbComptes.Controls.Add(this.lstComptes);
            this.gpbComptes.Controls.Add(this.txtMontantUserA);
            this.gpbComptes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbComptes.Location = new System.Drawing.Point(450, 222);
            this.gpbComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbComptes.Name = "gpbComptes";
            this.gpbComptes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbComptes.Size = new System.Drawing.Size(350, 574);
            this.gpbComptes.TabIndex = 6;
            this.gpbComptes.TabStop = false;
            this.gpbComptes.Text = "Comptes du mois";
            // 
            // btnResetComptes
            // 
            this.btnResetComptes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnResetComptes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnResetComptes.Location = new System.Drawing.Point(255, 527);
            this.btnResetComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResetComptes.Name = "btnResetComptes";
            this.btnResetComptes.Size = new System.Drawing.Size(81, 31);
            this.btnResetComptes.TabIndex = 8;
            this.btnResetComptes.Text = "Vider";
            this.btnResetComptes.UseVisualStyleBackColor = false;
            this.btnResetComptes.Click += new System.EventHandler(this.btnResetComptes_Click);
            // 
            // txtMontantUserB
            // 
            this.txtMontantUserB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtMontantUserB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtMontantUserB.Location = new System.Drawing.Point(148, 102);
            this.txtMontantUserB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontantUserB.Name = "txtMontantUserB";
            this.txtMontantUserB.Size = new System.Drawing.Size(184, 28);
            this.txtMontantUserB.TabIndex = 4;
            // 
            // lblUserB
            // 
            this.lblUserB.AutoSize = true;
            this.lblUserB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUserB.Location = new System.Drawing.Point(6, 104);
            this.lblUserB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserB.Name = "lblUserB";
            this.lblUserB.Size = new System.Drawing.Size(112, 21);
            this.lblUserB.TabIndex = 3;
            this.lblUserB.Text = "personne B :";
            // 
            // lblUserA
            // 
            this.lblUserA.AutoSize = true;
            this.lblUserA.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUserA.Location = new System.Drawing.Point(6, 59);
            this.lblUserA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserA.Name = "lblUserA";
            this.lblUserA.Size = new System.Drawing.Size(115, 21);
            this.lblUserA.TabIndex = 1;
            this.lblUserA.Text = "personne A :";
            // 
            // btnOKComptes
            // 
            this.btnOKComptes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOKComptes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnOKComptes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKComptes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOKComptes.Location = new System.Drawing.Point(16, 195);
            this.btnOKComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOKComptes.Name = "btnOKComptes";
            this.btnOKComptes.Size = new System.Drawing.Size(316, 35);
            this.btnOKComptes.TabIndex = 6;
            this.btnOKComptes.Text = "Valider";
            this.btnOKComptes.UseVisualStyleBackColor = false;
            this.btnOKComptes.Click += new System.EventHandler(this.btnOKComptes_Click);
            // 
            // lstComptes
            // 
            this.lstComptes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.lstComptes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstComptes.FormattingEnabled = true;
            this.lstComptes.ItemHeight = 21;
            this.lstComptes.Location = new System.Drawing.Point(16, 236);
            this.lstComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstComptes.Name = "lstComptes";
            this.lstComptes.Size = new System.Drawing.Size(316, 277);
            this.lstComptes.TabIndex = 7;
            this.lstComptes.SelectedIndexChanged += new System.EventHandler(this.lstComptes_SelectedIndexChanged);
            this.lstComptes.DoubleClick += new System.EventHandler(this.lstComptes_DoubleClick);
            this.lstComptes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstComptes_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(329, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "et";
            // 
            // gpbTotal
            // 
            this.gpbTotal.Controls.Add(this.btnCloture);
            this.gpbTotal.Controls.Add(this.lblResultat);
            this.gpbTotal.Controls.Add(this.lblTotalPersB);
            this.gpbTotal.Controls.Add(this.lblTotalPersA);
            this.gpbTotal.Controls.Add(this.lblNomTotalUserB);
            this.gpbTotal.Controls.Add(this.lblNomTotalUserA);
            this.gpbTotal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbTotal.Location = new System.Drawing.Point(850, 222);
            this.gpbTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbTotal.Size = new System.Drawing.Size(350, 574);
            this.gpbTotal.TabIndex = 7;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total";
            // 
            // btnCloture
            // 
            this.btnCloture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnCloture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnCloture.Location = new System.Drawing.Point(14, 523);
            this.btnCloture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloture.Name = "btnCloture";
            this.btnCloture.Size = new System.Drawing.Size(320, 31);
            this.btnCloture.TabIndex = 8;
            this.btnCloture.Text = "Clotûrer le mois";
            this.btnCloture.UseVisualStyleBackColor = false;
            this.btnCloture.Click += new System.EventHandler(this.btnCloture_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(8, 362);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(75, 31);
            this.lblResultat.TabIndex = 11;
            this.lblResultat.Text = "Total";
            // 
            // lblTotalPersB
            // 
            this.lblTotalPersB.AutoSize = true;
            this.lblTotalPersB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersB.Location = new System.Drawing.Point(8, 249);
            this.lblTotalPersB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPersB.Name = "lblTotalPersB";
            this.lblTotalPersB.Size = new System.Drawing.Size(29, 31);
            this.lblTotalPersB.TabIndex = 10;
            this.lblTotalPersB.Text = "0";
            // 
            // lblTotalPersA
            // 
            this.lblTotalPersA.AutoSize = true;
            this.lblTotalPersA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersA.Location = new System.Drawing.Point(8, 109);
            this.lblTotalPersA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPersA.Name = "lblTotalPersA";
            this.lblTotalPersA.Size = new System.Drawing.Size(29, 31);
            this.lblTotalPersA.TabIndex = 9;
            this.lblTotalPersA.Text = "0";
            // 
            // lblNomTotalUserB
            // 
            this.lblNomTotalUserB.AutoSize = true;
            this.lblNomTotalUserB.Location = new System.Drawing.Point(6, 211);
            this.lblNomTotalUserB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomTotalUserB.Name = "lblNomTotalUserB";
            this.lblNomTotalUserB.Size = new System.Drawing.Size(207, 19);
            this.lblNomTotalUserB.TabIndex = 8;
            this.lblNomTotalUserB.Text = "Total dettes personne B :";
            // 
            // lblNomTotalUserA
            // 
            this.lblNomTotalUserA.AutoSize = true;
            this.lblNomTotalUserA.Location = new System.Drawing.Point(6, 71);
            this.lblNomTotalUserA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomTotalUserA.Name = "lblNomTotalUserA";
            this.lblNomTotalUserA.Size = new System.Drawing.Size(215, 19);
            this.lblNomTotalUserA.TabIndex = 0;
            this.lblNomTotalUserA.Text = "Total  dettes personne A :";
            // 
            // menuFichier
            // 
            this.menuFichier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSauvegarder,
            this.menuReinitialiser});
            this.menuFichier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(66, 24);
            this.menuFichier.Text = "Fichier";
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.affichageToolStripMenuItem,
            this.menuRepartition,
            this.sauvegardesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResetAffichage});
            this.affichageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // menuResetAffichage
            // 
            this.menuResetAffichage.Name = "menuResetAffichage";
            this.menuResetAffichage.Size = new System.Drawing.Size(242, 26);
            this.menuResetAffichage.Text = "Réinitialiser l\'affichage";
            this.menuResetAffichage.Click += new System.EventHandler(this.menuResetAffichage_Click);
            // 
            // menuRepartition
            // 
            this.menuRepartition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjouterRepartition});
            this.menuRepartition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuRepartition.Name = "menuRepartition";
            this.menuRepartition.Size = new System.Drawing.Size(103, 24);
            this.menuRepartition.Text = "Répartitions";
            // 
            // menuAjouterRepartition
            // 
            this.menuAjouterRepartition.Name = "menuAjouterRepartition";
            this.menuAjouterRepartition.Size = new System.Drawing.Size(233, 26);
            this.menuAjouterRepartition.Text = "Editer une répartition";
            this.menuAjouterRepartition.Click += new System.EventHandler(this.menuAjouterRepartition_Click);
            // 
            // sauvegardesToolStripMenuItem
            // 
            this.sauvegardesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSauvegardes});
            this.sauvegardesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sauvegardesToolStripMenuItem.Name = "sauvegardesToolStripMenuItem";
            this.sauvegardesToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.sauvegardesToolStripMenuItem.Text = "Sauvegardes";
            // 
            // menuSauvegardes
            // 
            this.menuSauvegardes.Name = "menuSauvegardes";
            this.menuSauvegardes.Size = new System.Drawing.Size(323, 26);
            this.menuSauvegardes.Text = "Charger une sauvegarde mensuelle";
            this.menuSauvegardes.Click += new System.EventHandler(this.menuSauvegardes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblTitreApp);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 100);
            this.panel1.TabIndex = 15;
            // 
            // lblTitreApp
            // 
            this.lblTitreApp.AutoSize = true;
            this.lblTitreApp.Font = new System.Drawing.Font("Script MT Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreApp.Location = new System.Drawing.Point(364, 10);
            this.lblTitreApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreApp.Name = "lblTitreApp";
            this.lblTitreApp.Size = new System.Drawing.Size(525, 81);
            this.lblTitreApp.TabIndex = 0;
            this.lblTitreApp.Text = "Editeur de comptes";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(1172, 0);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(78, 31);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(526, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "du mois de ";
            // 
            // cboMois
            // 
            this.cboMois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMois.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(655, 160);
            this.cboMois.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(168, 29);
            this.cboMois.TabIndex = 8;
            // 
            // cboAnnee
            // 
            this.cboAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnnee.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboAnnee.FormattingEnabled = true;
            this.cboAnnee.Location = new System.Drawing.Point(831, 159);
            this.cboAnnee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAnnee.Name = "cboAnnee";
            this.cboAnnee.Size = new System.Drawing.Size(85, 29);
            this.cboAnnee.TabIndex = 18;
            // 
            // frmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1250, 850);
            this.Controls.Add(this.cboAnnee);
            this.Controls.Add(this.cboMois);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpbComptes);
            this.Controls.Add(this.txtUserB);
            this.Controls.Add(this.txtUserA);
            this.Controls.Add(this.gpbAjoutBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1250, 1000);
            this.Name = "frmPrincipal";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuSauvegarder;
        private System.Windows.Forms.ToolStripMenuItem menuReinitialiser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreApp;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnResetBudget;
        private System.Windows.Forms.Button btnResetComptes;
        private System.Windows.Forms.Button btnCloture;
        private System.Windows.Forms.ToolStripMenuItem menuRepartition;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterRepartition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.ComboBox cboAnnee;
        private System.Windows.Forms.ToolStripMenuItem sauvegardesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSauvegardes;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuResetAffichage;
    }
}

