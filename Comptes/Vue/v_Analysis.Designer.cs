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
            this.panDates = new System.Windows.Forms.Panel();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.grdBudgets = new System.Windows.Forms.DataGridView();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.chkMonthRef = new System.Windows.Forms.CheckBox();
            this.dtpDateRef = new System.Windows.Forms.DateTimePicker();
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
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
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
            this.btnQuitter.Location = new System.Drawing.Point(897, 0);
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
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 95);
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
            "Année précise",
            "Depuis toujours"});
            this.cboAnalysisMode.Location = new System.Drawing.Point(266, 202);
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
            this.label3.Location = new System.Drawing.Point(87, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mode d\'analyse :";
            // 
            // panDates
            // 
            this.panDates.Controls.Add(this.dtpDateEnd);
            this.panDates.Controls.Add(this.dtpDateStart);
            this.panDates.Controls.Add(this.lblEnd);
            this.panDates.Controls.Add(this.lblStart);
            this.panDates.Location = new System.Drawing.Point(468, 186);
            this.panDates.Name = "panDates";
            this.panDates.Size = new System.Drawing.Size(387, 116);
            this.panDates.TabIndex = 42;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDateEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.dtpDateEnd.CustomFormat = "MMMM yyyy";
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtpDateEnd.Location = new System.Drawing.Point(64, 72);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.ShowUpDown = true;
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 28);
            this.dtpDateEnd.TabIndex = 51;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDateStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.dtpDateStart.CustomFormat = "MMMM yyyy";
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateStart.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtpDateStart.Location = new System.Drawing.Point(64, 17);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.ShowUpDown = true;
            this.dtpDateStart.Size = new System.Drawing.Size(200, 28);
            this.dtpDateStart.TabIndex = 50;
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
            // dtpYear
            // 
            this.dtpYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpYear.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpYear.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtpYear.Location = new System.Drawing.Point(472, 203);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.ShowUpDown = true;
            this.dtpYear.Size = new System.Drawing.Size(106, 28);
            this.dtpYear.TabIndex = 52;
            this.dtpYear.Visible = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBudgets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBudgets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budget,
            this.expenses,
            this.expensesRef,
            this.average,
            this.evolution,
            this.proportion});
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
            this.grdBudgets.Location = new System.Drawing.Point(66, 326);
            this.grdBudgets.Name = "grdBudgets";
            this.grdBudgets.ReadOnly = true;
            this.grdBudgets.RowHeadersVisible = false;
            this.grdBudgets.RowHeadersWidth = 51;
            this.grdBudgets.RowTemplate.Height = 24;
            this.grdBudgets.Size = new System.Drawing.Size(817, 312);
            this.grdBudgets.TabIndex = 43;
            this.grdBudgets.Visible = false;
            // 
            // budget
            // 
            this.budget.DataPropertyName = "budget";
            this.budget.HeaderText = "Budget";
            this.budget.MinimumWidth = 6;
            this.budget.Name = "budget";
            this.budget.ReadOnly = true;
            this.budget.Width = 125;
            // 
            // expenses
            // 
            this.expenses.DataPropertyName = "total";
            this.expenses.HeaderText = "Total dépenses";
            this.expenses.MinimumWidth = 6;
            this.expenses.Name = "expenses";
            this.expenses.ReadOnly = true;
            this.expenses.Width = 125;
            // 
            // expensesRef
            // 
            this.expensesRef.DataPropertyName = "expensesRef";
            this.expensesRef.HeaderText = "Dépenses mois de ref.";
            this.expensesRef.MinimumWidth = 6;
            this.expensesRef.Name = "expensesRef";
            this.expensesRef.ReadOnly = true;
            this.expensesRef.Width = 130;
            // 
            // average
            // 
            this.average.DataPropertyName = "average";
            this.average.HeaderText = "Moyenne";
            this.average.MinimumWidth = 6;
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Width = 125;
            // 
            // evolution
            // 
            this.evolution.DataPropertyName = "evolution";
            this.evolution.HeaderText = "Ecart avec la moyenne";
            this.evolution.MinimumWidth = 6;
            this.evolution.Name = "evolution";
            this.evolution.ReadOnly = true;
            this.evolution.Width = 130;
            // 
            // proportion
            // 
            this.proportion.DataPropertyName = "proportion";
            this.proportion.HeaderText = "Part du budget";
            this.proportion.MinimumWidth = 6;
            this.proportion.Name = "proportion";
            this.proportion.ReadOnly = true;
            this.proportion.Width = 125;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOK.Location = new System.Drawing.Point(266, 237);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 31);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkMonthRef
            // 
            this.chkMonthRef.AutoSize = true;
            this.chkMonthRef.Checked = true;
            this.chkMonthRef.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonthRef.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkMonthRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkMonthRef.Location = new System.Drawing.Point(66, 143);
            this.chkMonthRef.Name = "chkMonthRef";
            this.chkMonthRef.Size = new System.Drawing.Size(193, 25);
            this.chkMonthRef.TabIndex = 49;
            this.chkMonthRef.Text = "Mois de référence :";
            this.chkMonthRef.UseVisualStyleBackColor = true;
            this.chkMonthRef.CheckedChanged += new System.EventHandler(this.chkMonthRef_CheckedChanged);
            // 
            // dtpDateRef
            // 
            this.dtpDateRef.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDateRef.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.dtpDateRef.CustomFormat = "MMMM yyyy";
            this.dtpDateRef.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateRef.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtpDateRef.Location = new System.Drawing.Point(266, 138);
            this.dtpDateRef.Name = "dtpDateRef";
            this.dtpDateRef.ShowUpDown = true;
            this.dtpDateRef.Size = new System.Drawing.Size(200, 28);
            this.dtpDateRef.TabIndex = 52;
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(976, 650);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.dtpDateRef);
            this.Controls.Add(this.chkMonthRef);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grdBudgets);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panDates;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DataGridView grdBudgets;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource dataAnalysisBindingSource;
        private System.Windows.Forms.CheckBox chkMonthRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proportionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn average;
        private System.Windows.Forms.DataGridViewTextBoxColumn evolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn proportion;
    }
}