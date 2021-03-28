namespace Comptes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreFen = new System.Windows.Forms.Label();
            this.cboAnalysisMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.panDates = new System.Windows.Forms.Panel();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.cboStartingYear = new System.Windows.Forms.ComboBox();
            this.cboStartingMonth = new System.Windows.Forms.ComboBox();
            this.cboEndingYear = new System.Windows.Forms.ComboBox();
            this.cboEndingMonth = new System.Windows.Forms.ComboBox();
            this.grdBudgets = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboYearRef = new System.Windows.Forms.ComboBox();
            this.cboMonthRef = new System.Windows.Forms.ComboBox();
            this.chkMonthRef = new System.Windows.Forms.CheckBox();
            this.expensesRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proportionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnalysisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
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
            this.btnQuitter.Size = new System.Drawing.Size(78, 32);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblTitreFen);
            this.panel1.Location = new System.Drawing.Point(0, 26);
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
            this.lblTitreFen.Location = new System.Drawing.Point(367, 6);
            this.lblTitreFen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreFen.Name = "lblTitreFen";
            this.lblTitreFen.Size = new System.Drawing.Size(255, 81);
            this.lblTitreFen.TabIndex = 0;
            this.lblTitreFen.Text = "Analyse";
            // 
            // cboAnalysisMode
            // 
            this.cboAnalysisMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboAnalysisMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnalysisMode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnalysisMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboAnalysisMode.FormattingEnabled = true;
            this.cboAnalysisMode.Items.AddRange(new object[] {
            "Entre 2 dates",
            "Année en cours",
            "Depuis toujours"});
            this.cboAnalysisMode.Location = new System.Drawing.Point(230, 202);
            this.cboAnalysisMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAnalysisMode.Name = "cboAnalysisMode";
            this.cboAnalysisMode.Size = new System.Drawing.Size(168, 29);
            this.cboAnalysisMode.TabIndex = 4;
            this.cboAnalysisMode.SelectedIndexChanged += new System.EventHandler(this.cboAnalysisMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(51, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mode d\'analyse :";
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(432, 202);
            this.cboYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(85, 29);
            this.cboYear.TabIndex = 30;
            this.cboYear.Visible = false;
            // 
            // panDates
            // 
            this.panDates.Controls.Add(this.lblEnd);
            this.panDates.Controls.Add(this.lblStart);
            this.panDates.Controls.Add(this.cboStartingYear);
            this.panDates.Controls.Add(this.cboStartingMonth);
            this.panDates.Controls.Add(this.cboEndingYear);
            this.panDates.Controls.Add(this.cboEndingMonth);
            this.panDates.Location = new System.Drawing.Point(432, 186);
            this.panDates.Name = "panDates";
            this.panDates.Size = new System.Drawing.Size(387, 116);
            this.panDates.TabIndex = 42;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEnd.Location = new System.Drawing.Point(12, 78);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(33, 21);
            this.lblEnd.TabIndex = 47;
            this.lblEnd.Text = "À :";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStart.Location = new System.Drawing.Point(12, 20);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 21);
            this.lblStart.TabIndex = 46;
            this.lblStart.Text = "De :";
            // 
            // cboStartingYear
            // 
            this.cboStartingYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboStartingYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartingYear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStartingYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboStartingYear.FormattingEnabled = true;
            this.cboStartingYear.Location = new System.Drawing.Point(289, 17);
            this.cboStartingYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStartingYear.Name = "cboStartingYear";
            this.cboStartingYear.Size = new System.Drawing.Size(85, 29);
            this.cboStartingYear.TabIndex = 45;
            // 
            // cboStartingMonth
            // 
            this.cboStartingMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboStartingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartingMonth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStartingMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboStartingMonth.FormattingEnabled = true;
            this.cboStartingMonth.Location = new System.Drawing.Point(78, 17);
            this.cboStartingMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStartingMonth.Name = "cboStartingMonth";
            this.cboStartingMonth.Size = new System.Drawing.Size(168, 29);
            this.cboStartingMonth.TabIndex = 44;
            // 
            // cboEndingYear
            // 
            this.cboEndingYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboEndingYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndingYear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEndingYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboEndingYear.FormattingEnabled = true;
            this.cboEndingYear.Location = new System.Drawing.Point(289, 75);
            this.cboEndingYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEndingYear.Name = "cboEndingYear";
            this.cboEndingYear.Size = new System.Drawing.Size(85, 29);
            this.cboEndingYear.TabIndex = 43;
            // 
            // cboEndingMonth
            // 
            this.cboEndingMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboEndingMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndingMonth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEndingMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboEndingMonth.FormattingEnabled = true;
            this.cboEndingMonth.Location = new System.Drawing.Point(78, 75);
            this.cboEndingMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEndingMonth.Name = "cboEndingMonth";
            this.cboEndingMonth.Size = new System.Drawing.Size(168, 29);
            this.cboEndingMonth.TabIndex = 42;
            // 
            // grdBudgets
            // 
            this.grdBudgets.AllowUserToAddRows = false;
            this.grdBudgets.AllowUserToDeleteRows = false;
            this.grdBudgets.AllowUserToResizeColumns = false;
            this.grdBudgets.AllowUserToResizeRows = false;
            this.grdBudgets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdBudgets.AutoGenerateColumns = false;
            this.grdBudgets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.grdBudgets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBudgets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBudgets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBudgets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.expensesRef,
            this.averageDataGridViewTextBoxColumn,
            this.evolution,
            this.proportionDataGridViewTextBoxColumn});
            this.grdBudgets.DataSource = this.dataAnalysisBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBudgets.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBudgets.EnableHeadersVisualStyles = false;
            this.grdBudgets.Location = new System.Drawing.Point(86, 321);
            this.grdBudgets.Name = "grdBudgets";
            this.grdBudgets.ReadOnly = true;
            this.grdBudgets.RowHeadersVisible = false;
            this.grdBudgets.RowHeadersWidth = 51;
            this.grdBudgets.RowTemplate.Height = 24;
            this.grdBudgets.Size = new System.Drawing.Size(861, 312);
            this.grdBudgets.TabIndex = 43;
            this.grdBudgets.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOK.Location = new System.Drawing.Point(230, 237);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 31);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboYearRef
            // 
            this.cboYearRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboYearRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearRef.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYearRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboYearRef.FormattingEnabled = true;
            this.cboYearRef.Location = new System.Drawing.Point(432, 139);
            this.cboYearRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboYearRef.Name = "cboYearRef";
            this.cboYearRef.Size = new System.Drawing.Size(85, 29);
            this.cboYearRef.TabIndex = 46;
            // 
            // cboMonthRef
            // 
            this.cboMonthRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboMonthRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonthRef.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonthRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboMonthRef.FormattingEnabled = true;
            this.cboMonthRef.Location = new System.Drawing.Point(230, 139);
            this.cboMonthRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMonthRef.Name = "cboMonthRef";
            this.cboMonthRef.Size = new System.Drawing.Size(168, 29);
            this.cboMonthRef.TabIndex = 48;
            // 
            // chkMonthRef
            // 
            this.chkMonthRef.AutoSize = true;
            this.chkMonthRef.Checked = true;
            this.chkMonthRef.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonthRef.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkMonthRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkMonthRef.Location = new System.Drawing.Point(30, 143);
            this.chkMonthRef.Name = "chkMonthRef";
            this.chkMonthRef.Size = new System.Drawing.Size(193, 25);
            this.chkMonthRef.TabIndex = 49;
            this.chkMonthRef.Text = "Mois de référence :";
            this.chkMonthRef.UseVisualStyleBackColor = true;
            this.chkMonthRef.CheckedChanged += new System.EventHandler(this.chkMonthRef_CheckedChanged);
            // 
            // expensesRef
            // 
            this.expensesRef.DataPropertyName = "expensesRef";
            this.expensesRef.HeaderText = "Dépenses mois de ref.";
            this.expensesRef.MinimumWidth = 6;
            this.expensesRef.Name = "expensesRef";
            this.expensesRef.ReadOnly = true;
            this.expensesRef.Width = 125;
            // 
            // evolution
            // 
            this.evolution.DataPropertyName = "evolution";
            this.evolution.HeaderText = "Evolution";
            this.evolution.MinimumWidth = 6;
            this.evolution.Name = "evolution";
            this.evolution.ReadOnly = true;
            this.evolution.Width = 125;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.ReadOnly = true;
            this.budgetDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Dépenses Totales";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Moyenne du budget";
            this.averageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            this.averageDataGridViewTextBoxColumn.ReadOnly = true;
            this.averageDataGridViewTextBoxColumn.Width = 125;
            // 
            // proportionDataGridViewTextBoxColumn
            // 
            this.proportionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.proportionDataGridViewTextBoxColumn.DataPropertyName = "proportion";
            this.proportionDataGridViewTextBoxColumn.HeaderText = "% des dépenses";
            this.proportionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proportionDataGridViewTextBoxColumn.Name = "proportionDataGridViewTextBoxColumn";
            this.proportionDataGridViewTextBoxColumn.ReadOnly = true;
            this.proportionDataGridViewTextBoxColumn.Width = 175;
            // 
            // dataAnalysisBindingSource
            // 
            this.dataAnalysisBindingSource.DataSource = typeof(Comptes.Model.DataAnalysis);
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.chkMonthRef);
            this.Controls.Add(this.cboMonthRef);
            this.Controls.Add(this.cboYearRef);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grdBudgets);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAnalysisMode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panDates);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnalysis";
            this.Text = "frmAnalysis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panDates.ResumeLayout(false);
            this.panDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnalysisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreFen;
        private System.Windows.Forms.ComboBox cboAnalysisMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Panel panDates;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cboStartingYear;
        private System.Windows.Forms.ComboBox cboStartingMonth;
        private System.Windows.Forms.ComboBox cboEndingYear;
        private System.Windows.Forms.ComboBox cboEndingMonth;
        private System.Windows.Forms.DataGridView grdBudgets;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource dataAnalysisBindingSource;
        private System.Windows.Forms.ComboBox cboYearRef;
        private System.Windows.Forms.ComboBox cboMonthRef;
        private System.Windows.Forms.CheckBox chkMonthRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn proportionDataGridViewTextBoxColumn;
    }
}