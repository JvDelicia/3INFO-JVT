namespace RenatinhaPlace.Forms
{
    partial class ucQueryClient
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dbDragonNightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDragonNightDataSet = new RenatinhaPlace.dbDragonNightDataSet();
            this.dbDragonNightDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.mcbFilterBy = new MetroFramework.Controls.MetroComboBox();
            this.lblFIlterBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvClients.Location = new System.Drawing.Point(60, 88);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.Size = new System.Drawing.Size(1045, 460);
            this.dgvClients.TabIndex = 0;
            // 
            // dbDragonNightDataSetBindingSource
            // 
            this.dbDragonNightDataSetBindingSource.DataSource = this.dbDragonNightDataSet;
            this.dbDragonNightDataSetBindingSource.Position = 0;
            // 
            // dbDragonNightDataSet
            // 
            this.dbDragonNightDataSet.DataSetName = "dbDragonNightDataSet";
            this.dbDragonNightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDragonNightDataSetBindingSource1
            // 
            this.dbDragonNightDataSetBindingSource1.DataSource = this.dbDragonNightDataSet;
            this.dbDragonNightDataSetBindingSource1.Position = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFilter.FlatAppearance.BorderSize = 3;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnFilter.Location = new System.Drawing.Point(960, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(145, 59);
            this.btnFilter.TabIndex = 138;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseMnemonic = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFilter.Location = new System.Drawing.Point(56, 1);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 21);
            this.lblFilter.TabIndex = 140;
            this.lblFilter.Text = "Filter";
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx2.Location = new System.Drawing.Point(60, 62);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(469, 2);
            this.pbx2.TabIndex = 139;
            this.pbx2.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Silver;
            this.txtFilter.Location = new System.Drawing.Point(60, 43);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(468, 20);
            this.txtFilter.TabIndex = 136;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.WordWrap = false;
            // 
            // mcbFilterBy
            // 
            this.mcbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mcbFilterBy.ForeColor = System.Drawing.Color.Silver;
            this.mcbFilterBy.FormattingEnabled = true;
            this.mcbFilterBy.ItemHeight = 23;
            this.mcbFilterBy.Items.AddRange(new object[] {
            "Client ID",
            "Name",
            ""});
            this.mcbFilterBy.Location = new System.Drawing.Point(586, 34);
            this.mcbFilterBy.Name = "mcbFilterBy";
            this.mcbFilterBy.Size = new System.Drawing.Size(217, 29);
            this.mcbFilterBy.TabIndex = 141;
            this.mcbFilterBy.UseSelectable = true;
            // 
            // lblFIlterBy
            // 
            this.lblFIlterBy.AutoSize = true;
            this.lblFIlterBy.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblFIlterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFIlterBy.Location = new System.Drawing.Point(582, 0);
            this.lblFIlterBy.Name = "lblFIlterBy";
            this.lblFIlterBy.Size = new System.Drawing.Size(84, 21);
            this.lblFIlterBy.TabIndex = 142;
            this.lblFIlterBy.Text = "Filter By";
            // 
            // ucQueryClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.lblFIlterBy);
            this.Controls.Add(this.mcbFilterBy);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvClients);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucQueryClient";
            this.Size = new System.Drawing.Size(1142, 571);
            this.Load += new System.EventHandler(this.ucQueryClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dbDragonNightDataSetBindingSource;
        private dbDragonNightDataSet dbDragonNightDataSet;
        private System.Windows.Forms.BindingSource dbDragonNightDataSetBindingSource1;
        public System.Windows.Forms.DataGridView dgvClients;
        public System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        public System.Windows.Forms.PictureBox pbx2;
        public System.Windows.Forms.TextBox txtFilter;
        private MetroFramework.Controls.MetroComboBox mcbFilterBy;
        private System.Windows.Forms.Label lblFIlterBy;
    }
}
