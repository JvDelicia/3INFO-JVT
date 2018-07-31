namespace RenatinhaPlace.Forms
{
    partial class ucCashierMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFIlterBy = new System.Windows.Forms.Label();
            this.mcbFilterBy = new MetroFramework.Controls.MetroComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvItemMenu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFIlterBy
            // 
            this.lblFIlterBy.AutoSize = true;
            this.lblFIlterBy.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblFIlterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFIlterBy.Location = new System.Drawing.Point(503, -1);
            this.lblFIlterBy.Name = "lblFIlterBy";
            this.lblFIlterBy.Size = new System.Drawing.Size(84, 21);
            this.lblFIlterBy.TabIndex = 156;
            this.lblFIlterBy.Text = "Filter By";
            // 
            // mcbFilterBy
            // 
            this.mcbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mcbFilterBy.ForeColor = System.Drawing.Color.Silver;
            this.mcbFilterBy.FormattingEnabled = true;
            this.mcbFilterBy.ItemHeight = 23;
            this.mcbFilterBy.Items.AddRange(new object[] {
            "Product ID",
            "Name"});
            this.mcbFilterBy.Location = new System.Drawing.Point(507, 33);
            this.mcbFilterBy.Name = "mcbFilterBy";
            this.mcbFilterBy.Size = new System.Drawing.Size(217, 29);
            this.mcbFilterBy.TabIndex = 155;
            this.mcbFilterBy.UseSelectable = true;
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
            this.btnFilter.Location = new System.Drawing.Point(858, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(145, 59);
            this.btnFilter.TabIndex = 152;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseMnemonic = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFilter.Location = new System.Drawing.Point(11, -1);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 21);
            this.lblFilter.TabIndex = 154;
            this.lblFilter.Text = "Filter";
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx2.Location = new System.Drawing.Point(15, 52);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(351, 2);
            this.pbx2.TabIndex = 153;
            this.pbx2.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Silver;
            this.txtFilter.Location = new System.Drawing.Point(15, 33);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(350, 20);
            this.txtFilter.TabIndex = 151;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.WordWrap = false;
            // 
            // dgvItemMenu
            // 
            this.dgvItemMenu.AllowUserToAddRows = false;
            this.dgvItemMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvItemMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemMenu.EnableHeadersVisualStyles = false;
            this.dgvItemMenu.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvItemMenu.Location = new System.Drawing.Point(0, 87);
            this.dgvItemMenu.Name = "dgvItemMenu";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemMenu.Size = new System.Drawing.Size(1003, 170);
            this.dgvItemMenu.TabIndex = 150;
            // 
            // ucCashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblFIlterBy);
            this.Controls.Add(this.mcbFilterBy);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvItemMenu);
            this.Name = "ucCashierMenu";
            this.Size = new System.Drawing.Size(1001, 255);
            this.Load += new System.EventHandler(this.ucCashierMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFIlterBy;
        private MetroFramework.Controls.MetroComboBox mcbFilterBy;
        public System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        public System.Windows.Forms.PictureBox pbx2;
        public System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.DataGridView dgvItemMenu;
    }
}
