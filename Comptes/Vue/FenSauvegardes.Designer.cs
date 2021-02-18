namespace Comptes
{
    partial class FenSauvegardes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreFen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.cboAnnee = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataTableauMensuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomCompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depensesADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depensesBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBudgets)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableauMensuelBindingSource)).BeginInit();
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
            this.btnQuitter.Location = new System.Drawing.Point(822, 0);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(78, 31);
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
            this.nomCompteDataGridViewTextBoxColumn,
            this.depensesADataGridViewTextBoxColumn,
            this.depensesBDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.grdBudgets.DataSource = this.dataTableauMensuelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBudgets.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBudgets.EnableHeadersVisualStyles = false;
            this.grdBudgets.Location = new System.Drawing.Point(79, 230);
            this.grdBudgets.Name = "grdBudgets";
            this.grdBudgets.ReadOnly = true;
            this.grdBudgets.RowHeadersVisible = false;
            this.grdBudgets.RowHeadersWidth = 51;
            this.grdBudgets.RowTemplate.Height = 24;
            this.grdBudgets.Size = new System.Drawing.Size(682, 337);
            this.grdBudgets.TabIndex = 18;
            this.grdBudgets.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblTitreFen);
            this.panel1.Location = new System.Drawing.Point(0, 27);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(75, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Charger la sauvegarde de ";
            // 
            // cboMois
            // 
            this.cboMois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMois.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(350, 157);
            this.cboMois.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(168, 29);
            this.cboMois.TabIndex = 22;
            // 
            // cboAnnee
            // 
            this.cboAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnnee.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboAnnee.FormattingEnabled = true;
            this.cboAnnee.Location = new System.Drawing.Point(561, 157);
            this.cboAnnee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAnnee.Name = "cboAnnee";
            this.cboAnnee.Size = new System.Drawing.Size(85, 29);
            this.cboAnnee.TabIndex = 23;
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
            // dataTableauMensuelBindingSource
            // 
            this.dataTableauMensuelBindingSource.DataSource = typeof(Comptes.Model.DataTableauMensuel);
            // 
            // nomCompteDataGridViewTextBoxColumn
            // 
            this.nomCompteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nomCompteDataGridViewTextBoxColumn.DataPropertyName = "nomCompte";
            this.nomCompteDataGridViewTextBoxColumn.HeaderText = "nomCompte";
            this.nomCompteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCompteDataGridViewTextBoxColumn.Name = "nomCompteDataGridViewTextBoxColumn";
            this.nomCompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCompteDataGridViewTextBoxColumn.Width = 155;
            // 
            // depensesADataGridViewTextBoxColumn
            // 
            this.depensesADataGridViewTextBoxColumn.DataPropertyName = "depensesA";
            this.depensesADataGridViewTextBoxColumn.HeaderText = "depensesA";
            this.depensesADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depensesADataGridViewTextBoxColumn.Name = "depensesADataGridViewTextBoxColumn";
            this.depensesADataGridViewTextBoxColumn.ReadOnly = true;
            this.depensesADataGridViewTextBoxColumn.Width = 200;
            // 
            // depensesBDataGridViewTextBoxColumn
            // 
            this.depensesBDataGridViewTextBoxColumn.DataPropertyName = "depensesB";
            this.depensesBDataGridViewTextBoxColumn.HeaderText = "depensesB";
            this.depensesBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depensesBDataGridViewTextBoxColumn.Name = "depensesBDataGridViewTextBoxColumn";
            this.depensesBDataGridViewTextBoxColumn.ReadOnly = true;
            this.depensesBDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // FenSauvegardes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboAnnee);
            this.Controls.Add(this.cboMois);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdBudgets);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FenSauvegardes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBudgets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableauMensuelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView grdBudgets;
        private System.Windows.Forms.BindingSource dataTableauMensuelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreFen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.ComboBox cboAnnee;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}