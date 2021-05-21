namespace Comptes
{
    partial class FrmMonthlySave
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grdBudgets = new System.Windows.Forms.DataGridView();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreFen = new System.Windows.Forms.Label();
            this.lblActionName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelMonthlyReport = new System.Windows.Forms.Button();
            this.btnToAnalysis = new System.Windows.Forms.Button();
            this.dtpMonthlySave = new System.Windows.Forms.DateTimePicker();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMonthlyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdBudgets)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonthlyReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitter.Location = new System.Drawing.Point(822, -3);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(78, 28);
            this.btnQuitter.TabIndex = 17;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBudgets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBudgets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountName,
            this.expensesA,
            this.expensesB,
            this.totalDataGridViewTextBoxColumn});
            this.grdBudgets.DataSource = this.dataMonthlyReportBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBudgets.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBudgets.EnableHeadersVisualStyles = false;
            this.grdBudgets.Location = new System.Drawing.Point(79, 245);
            this.grdBudgets.Name = "grdBudgets";
            this.grdBudgets.ReadOnly = true;
            this.grdBudgets.RowHeadersVisible = false;
            this.grdBudgets.RowHeadersWidth = 51;
            this.grdBudgets.RowTemplate.Height = 24;
            this.grdBudgets.Size = new System.Drawing.Size(682, 337);
            this.grdBudgets.TabIndex = 18;
            this.grdBudgets.Visible = false;
            // 
            // accountName
            // 
            this.accountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountName.DataPropertyName = "accountName";
            this.accountName.HeaderText = "Budget";
            this.accountName.MinimumWidth = 6;
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            this.accountName.Width = 104;
            // 
            // expensesA
            // 
            this.expensesA.DataPropertyName = "expensesA";
            this.expensesA.HeaderText = "Dépenses A";
            this.expensesA.MinimumWidth = 6;
            this.expensesA.Name = "expensesA";
            this.expensesA.ReadOnly = true;
            this.expensesA.Width = 170;
            // 
            // expensesB
            // 
            this.expensesB.DataPropertyName = "expensesB";
            this.expensesB.HeaderText = "Dépenses B";
            this.expensesB.MinimumWidth = 6;
            this.expensesB.Name = "expensesB";
            this.expensesB.ReadOnly = true;
            this.expensesB.Width = 170;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblTitreFen);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 95);
            this.panel1.TabIndex = 19;
            // 
            // lblTitreFen
            // 
            this.lblTitreFen.AutoSize = true;
            this.lblTitreFen.Font = new System.Drawing.Font("Script MT Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreFen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitreFen.Location = new System.Drawing.Point(226, 7);
            this.lblTitreFen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreFen.Name = "lblTitreFen";
            this.lblTitreFen.Size = new System.Drawing.Size(474, 81);
            this.lblTitreFen.TabIndex = 0;
            this.lblTitreFen.Text = "Récap\' Mensuel";
            // 
            // lblActionName
            // 
            this.lblActionName.AutoSize = true;
            this.lblActionName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblActionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblActionName.Location = new System.Drawing.Point(75, 159);
            this.lblActionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActionName.Name = "lblActionName";
            this.lblActionName.Size = new System.Drawing.Size(238, 21);
            this.lblActionName.TabIndex = 21;
            this.lblActionName.Text = "Charger la sauvegarde de ";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOK.Location = new System.Drawing.Point(679, 155);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 31);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelMonthlyReport
            // 
            this.btnDelMonthlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnDelMonthlyReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelMonthlyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnDelMonthlyReport.Location = new System.Drawing.Point(561, 199);
            this.btnDelMonthlyReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelMonthlyReport.Name = "btnDelMonthlyReport";
            this.btnDelMonthlyReport.Size = new System.Drawing.Size(199, 31);
            this.btnDelMonthlyReport.TabIndex = 25;
            this.btnDelMonthlyReport.Text = "Supprimer";
            this.btnDelMonthlyReport.UseVisualStyleBackColor = false;
            this.btnDelMonthlyReport.Click += new System.EventHandler(this.btnDelMonthlyReport_Click);
            // 
            // btnToAnalysis
            // 
            this.btnToAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnToAnalysis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnToAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnToAnalysis.Location = new System.Drawing.Point(630, 588);
            this.btnToAnalysis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToAnalysis.Name = "btnToAnalysis";
            this.btnToAnalysis.Size = new System.Drawing.Size(131, 31);
            this.btnToAnalysis.TabIndex = 26;
            this.btnToAnalysis.Text = "Analyse";
            this.btnToAnalysis.UseVisualStyleBackColor = false;
            this.btnToAnalysis.Click += new System.EventHandler(this.btnToAnalysis_Click);
            // 
            // dtpMonthlySave
            // 
            this.dtpMonthlySave.CustomFormat = "MMMM yyyy";
            this.dtpMonthlySave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthlySave.Location = new System.Drawing.Point(343, 158);
            this.dtpMonthlySave.Name = "dtpMonthlySave";
            this.dtpMonthlySave.ShowUpDown = true;
            this.dtpMonthlySave.Size = new System.Drawing.Size(200, 22);
            this.dtpMonthlySave.TabIndex = 27;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 170;
            // 
            // dataMonthlyReportBindingSource
            // 
            this.dataMonthlyReportBindingSource.DataSource = typeof(Comptes.Model.DataMonthlyReport);
            // 
            // FrmMonthlySave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.dtpMonthlySave);
            this.Controls.Add(this.btnToAnalysis);
            this.Controls.Add(this.btnDelMonthlyReport);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblActionName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdBudgets);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMonthlySave";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBudgets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonthlyReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView grdBudgets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreFen;
        private System.Windows.Forms.Label lblActionName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesBDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataMonthlyReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesA;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesB;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelMonthlyReport;
        private System.Windows.Forms.Button btnToAnalysis;
        private System.Windows.Forms.DateTimePicker dtpMonthlySave;
    }
}