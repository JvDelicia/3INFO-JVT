namespace RenatinhaPlace.Forms
{
    partial class ucCashierHome
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEnterAccount = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.txtEnterAccount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnSearch.Location = new System.Drawing.Point(59, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 60);
            this.btnSearch.TabIndex = 127;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEnterAccount
            // 
            this.lblEnterAccount.AutoSize = true;
            this.lblEnterAccount.Font = new System.Drawing.Font("Rockwell", 20F);
            this.lblEnterAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblEnterAccount.Location = new System.Drawing.Point(40, 25);
            this.lblEnterAccount.Name = "lblEnterAccount";
            this.lblEnterAccount.Size = new System.Drawing.Size(187, 31);
            this.lblEnterAccount.TabIndex = 126;
            this.lblEnterAccount.Text = "Enter Account";
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx1.Location = new System.Drawing.Point(46, 115);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(174, 2);
            this.pbx1.TabIndex = 125;
            this.pbx1.TabStop = false;
            // 
            // txtEnterAccount
            // 
            this.txtEnterAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtEnterAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnterAccount.Font = new System.Drawing.Font("Rockwell", 20F);
            this.txtEnterAccount.ForeColor = System.Drawing.Color.Silver;
            this.txtEnterAccount.Location = new System.Drawing.Point(46, 85);
            this.txtEnterAccount.MaxLength = 6;
            this.txtEnterAccount.Name = "txtEnterAccount";
            this.txtEnterAccount.Size = new System.Drawing.Size(174, 32);
            this.txtEnterAccount.TabIndex = 124;
            this.txtEnterAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnterAccount.WordWrap = false;
            this.txtEnterAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterAccount_KeyPress);
            // 
            // ucCashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnterAccount);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.txtEnterAccount);
            this.Name = "ucCashierHome";
            this.Size = new System.Drawing.Size(264, 240);
            this.Load += new System.EventHandler(this.ucCashierHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEnterAccount;
        public System.Windows.Forms.PictureBox pbx1;
        public System.Windows.Forms.TextBox txtEnterAccount;
    }
}
