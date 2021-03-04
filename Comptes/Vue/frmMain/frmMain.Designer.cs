namespace Comptes
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtAmountUserA = new System.Windows.Forms.TextBox();
            this.txtBudgetName = new System.Windows.Forms.TextBox();
            this.gpbAjoutBudget = new System.Windows.Forms.GroupBox();
            this.btnResetBudget = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOKBudgets = new System.Windows.Forms.Button();
            this.lstBudgets = new System.Windows.Forms.ListBox();
            this.cboDivisions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserB = new System.Windows.Forms.TextBox();
            this.txtUserA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbComptes = new System.Windows.Forms.GroupBox();
            this.btnResetComptes = new System.Windows.Forms.Button();
            this.txtAmountUserB = new System.Windows.Forms.TextBox();
            this.lblUserB = new System.Windows.Forms.Label();
            this.lblUserA = new System.Windows.Forms.Label();
            this.btnOKAccount = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.btnCloture = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblTotalUserB = new System.Windows.Forms.Label();
            this.lblTotalUserA = new System.Windows.Forms.Label();
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
            this.analyseToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChargerAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreApp = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.evolutionDesDépensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbAjoutBudget.SuspendLayout();
            this.gpbComptes.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmountUserA
            // 
            this.txtAmountUserA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtAmountUserA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtAmountUserA.Location = new System.Drawing.Point(148, 60);
            this.txtAmountUserA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmountUserA.Name = "txtAmountUserA";
            this.txtAmountUserA.Size = new System.Drawing.Size(184, 28);
            this.txtAmountUserA.TabIndex = 2;
            // 
            // txtBudgetName
            // 
            this.txtBudgetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtBudgetName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudgetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtBudgetName.Location = new System.Drawing.Point(160, 55);
            this.txtBudgetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBudgetName.Name = "txtBudgetName";
            this.txtBudgetName.Size = new System.Drawing.Size(168, 28);
            this.txtBudgetName.TabIndex = 1;
            // 
            // gpbAjoutBudget
            // 
            this.gpbAjoutBudget.Controls.Add(this.btnResetBudget);
            this.gpbAjoutBudget.Controls.Add(this.btnEdit);
            this.gpbAjoutBudget.Controls.Add(this.btnOKBudgets);
            this.gpbAjoutBudget.Controls.Add(this.lstBudgets);
            this.gpbAjoutBudget.Controls.Add(this.cboDivisions);
            this.gpbAjoutBudget.Controls.Add(this.label2);
            this.gpbAjoutBudget.Controls.Add(this.label1);
            this.gpbAjoutBudget.Controls.Add(this.txtBudgetName);
            this.gpbAjoutBudget.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAjoutBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbAjoutBudget.Location = new System.Drawing.Point(50, 222);
            this.gpbAjoutBudget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbAjoutBudget.Name = "gpbAjoutBudget";
            this.gpbAjoutBudget.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbAjoutBudget.Size = new System.Drawing.Size(350, 574);
            this.gpbAjoutBudget.TabIndex = 7;
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
            // cboDivisions
            // 
            this.cboDivisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboDivisions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDivisions.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDivisions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboDivisions.FormattingEnabled = true;
            this.cboDivisions.Location = new System.Drawing.Point(160, 98);
            this.cboDivisions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDivisions.Name = "cboDivisions";
            this.cboDivisions.Size = new System.Drawing.Size(168, 29);
            this.cboDivisions.TabIndex = 3;
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
            this.gpbComptes.Controls.Add(this.txtAmountUserB);
            this.gpbComptes.Controls.Add(this.lblUserB);
            this.gpbComptes.Controls.Add(this.lblUserA);
            this.gpbComptes.Controls.Add(this.btnOKAccount);
            this.gpbComptes.Controls.Add(this.lstAccounts);
            this.gpbComptes.Controls.Add(this.txtAmountUserA);
            this.gpbComptes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbComptes.Location = new System.Drawing.Point(450, 222);
            this.gpbComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbComptes.Name = "gpbComptes";
            this.gpbComptes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbComptes.Size = new System.Drawing.Size(350, 574);
            this.gpbComptes.TabIndex = 8;
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
            this.btnResetComptes.Click += new System.EventHandler(this.btnResetAccounts_Click);
            // 
            // txtAmountUserB
            // 
            this.txtAmountUserB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtAmountUserB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtAmountUserB.Location = new System.Drawing.Point(148, 102);
            this.txtAmountUserB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmountUserB.Name = "txtAmountUserB";
            this.txtAmountUserB.Size = new System.Drawing.Size(184, 28);
            this.txtAmountUserB.TabIndex = 4;
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
            // btnOKAccount
            // 
            this.btnOKAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOKAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.btnOKAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOKAccount.Location = new System.Drawing.Point(16, 195);
            this.btnOKAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOKAccount.Name = "btnOKAccount";
            this.btnOKAccount.Size = new System.Drawing.Size(316, 35);
            this.btnOKAccount.TabIndex = 6;
            this.btnOKAccount.Text = "Valider";
            this.btnOKAccount.UseVisualStyleBackColor = false;
            this.btnOKAccount.Click += new System.EventHandler(this.btnOKComptes_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.lstAccounts.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 21;
            this.lstAccounts.Location = new System.Drawing.Point(16, 236);
            this.lstAccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(316, 277);
            this.lstAccounts.TabIndex = 7;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstComptes_SelectedIndexChanged);
            this.lstAccounts.DoubleClick += new System.EventHandler(this.lstComptes_DoubleClick);
            this.lstAccounts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstComptes_KeyUp);
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
            this.gpbTotal.Controls.Add(this.lblResults);
            this.gpbTotal.Controls.Add(this.lblTotalUserB);
            this.gpbTotal.Controls.Add(this.lblTotalUserA);
            this.gpbTotal.Controls.Add(this.lblNomTotalUserB);
            this.gpbTotal.Controls.Add(this.lblNomTotalUserA);
            this.gpbTotal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbTotal.Location = new System.Drawing.Point(850, 222);
            this.gpbTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbTotal.Size = new System.Drawing.Size(350, 574);
            this.gpbTotal.TabIndex = 9;
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
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(8, 362);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(75, 31);
            this.lblResults.TabIndex = 11;
            this.lblResults.Text = "Total";
            // 
            // lblTotalUserB
            // 
            this.lblTotalUserB.AutoSize = true;
            this.lblTotalUserB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUserB.Location = new System.Drawing.Point(8, 249);
            this.lblTotalUserB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalUserB.Name = "lblTotalUserB";
            this.lblTotalUserB.Size = new System.Drawing.Size(29, 31);
            this.lblTotalUserB.TabIndex = 10;
            this.lblTotalUserB.Text = "0";
            // 
            // lblTotalUserA
            // 
            this.lblTotalUserA.AutoSize = true;
            this.lblTotalUserA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUserA.Location = new System.Drawing.Point(8, 109);
            this.lblTotalUserA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalUserA.Name = "lblTotalUserA";
            this.lblTotalUserA.Size = new System.Drawing.Size(29, 31);
            this.lblTotalUserA.TabIndex = 9;
            this.lblTotalUserA.Text = "0";
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
            this.menuSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuSauvegarder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuSauvegarder.Name = "menuSauvegarder";
            this.menuSauvegarder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSauvegarder.Size = new System.Drawing.Size(255, 26);
            this.menuSauvegarder.Text = "Sauvegarder";
            this.menuSauvegarder.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuReinitialiser
            // 
            this.menuReinitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuReinitialiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuReinitialiser.Name = "menuReinitialiser";
            this.menuReinitialiser.Size = new System.Drawing.Size(255, 26);
            this.menuReinitialiser.Text = "Réinitialiser l\'application";
            this.menuReinitialiser.Click += new System.EventHandler(this.menuResetApp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.affichageToolStripMenuItem,
            this.menuRepartition,
            this.analyseToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 10;
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
            this.menuResetAffichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuResetAffichage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuResetAffichage.Name = "menuResetAffichage";
            this.menuResetAffichage.Size = new System.Drawing.Size(242, 26);
            this.menuResetAffichage.Text = "Réinitialiser l\'affichage";
            this.menuResetAffichage.Click += new System.EventHandler(this.menuResetDisplay_Click);
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
            this.menuAjouterRepartition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuAjouterRepartition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuAjouterRepartition.Name = "menuAjouterRepartition";
            this.menuAjouterRepartition.Size = new System.Drawing.Size(233, 26);
            this.menuAjouterRepartition.Text = "Editer une répartition";
            this.menuAjouterRepartition.Click += new System.EventHandler(this.menuEditDivisions_Click);
            // 
            // analyseToolStripMenu
            // 
            this.analyseToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChargerAnalyse,
            this.evolutionDesDépensesToolStripMenuItem});
            this.analyseToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.analyseToolStripMenu.Name = "analyseToolStripMenu";
            this.analyseToolStripMenu.Size = new System.Drawing.Size(74, 24);
            this.analyseToolStripMenu.Text = "Analyse";
            // 
            // menuChargerAnalyse
            // 
            this.menuChargerAnalyse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuChargerAnalyse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuChargerAnalyse.Name = "menuChargerAnalyse";
            this.menuChargerAnalyse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuChargerAnalyse.Size = new System.Drawing.Size(376, 26);
            this.menuChargerAnalyse.Text = "Charger une sauvegarde mensuelle";
            this.menuChargerAnalyse.Click += new System.EventHandler(this.menuMonthlySaves_Click);
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
            this.btnQuitter.TabIndex = 12;
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
            this.label5.TabIndex = 4;
            this.label5.Text = "du mois de ";
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(655, 160);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(168, 29);
            this.cboMonth.TabIndex = 5;
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(831, 159);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(85, 29);
            this.cboYear.TabIndex = 6;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1087, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(78, 31);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // evolutionDesDépensesToolStripMenuItem
            // 
            this.evolutionDesDépensesToolStripMenuItem.Name = "evolutionDesDépensesToolStripMenuItem";
            this.evolutionDesDépensesToolStripMenuItem.Size = new System.Drawing.Size(376, 26);
            this.evolutionDesDépensesToolStripMenuItem.Text = "Evolution des dépenses";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1250, 850);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1250, 1000);
            this.Name = "frmMain";
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
        private System.Windows.Forms.TextBox txtAmountUserA;
        private System.Windows.Forms.TextBox txtBudgetName;
        private System.Windows.Forms.GroupBox gpbAjoutBudget;
        private System.Windows.Forms.ListBox lstBudgets;
        private System.Windows.Forms.ComboBox cboDivisions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbComptes;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Button btnOKAccount;
        private System.Windows.Forms.Button btnOKBudgets;
        private System.Windows.Forms.TextBox txtUserB;
        private System.Windows.Forms.TextBox txtUserA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountUserB;
        private System.Windows.Forms.Label lblUserB;
        private System.Windows.Forms.Label lblUserA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.Label lblNomTotalUserB;
        private System.Windows.Forms.Label lblNomTotalUserA;
        private System.Windows.Forms.Label lblTotalUserB;
        private System.Windows.Forms.Label lblTotalUserA;
        private System.Windows.Forms.Label lblResults;
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
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuChargerAnalyse;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuResetAffichage;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem evolutionDesDépensesToolStripMenuItem;
    }
}

