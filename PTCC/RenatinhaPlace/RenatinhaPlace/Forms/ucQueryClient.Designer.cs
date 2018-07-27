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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dbDragonNightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDragonNightDataSet = new RenatinhaPlace.dbDragonNightDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.DataSource = this.dbDragonNightDataSetBindingSource;
            this.dgvClients.Location = new System.Drawing.Point(60, 39);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(1045, 505);
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
            // ucQueryClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.dgvClients);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucQueryClient";
            this.Size = new System.Drawing.Size(1142, 571);
            this.Load += new System.EventHandler(this.ucQueryClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.BindingSource dbDragonNightDataSetBindingSource;
        private dbDragonNightDataSet dbDragonNightDataSet;
    }
}
