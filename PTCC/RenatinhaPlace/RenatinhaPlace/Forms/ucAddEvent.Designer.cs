namespace RenatinhaPlace.Forms
{
    partial class ucAddEvent
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
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.txtNameEvent = new System.Windows.Forms.TextBox();
            this.lblNameEvent = new System.Windows.Forms.Label();
            this.lblDescEvent = new System.Windows.Forms.Label();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.txtDescEvent = new System.Windows.Forms.TextBox();
            this.mdtDateEvent = new MetroFramework.Controls.MetroDateTime();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblTimeEvent = new System.Windows.Forms.Label();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.lblArtEvent = new System.Windows.Forms.Label();
            this.mcbArtEvent = new MetroFramework.Controls.MetroComboBox();
            this.mcbMenuEvent = new MetroFramework.Controls.MetroComboBox();
            this.lblMenuEvent = new System.Windows.Forms.Label();
            this.txtTimeEvent1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTimeEvent2 = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dbDragonNightDataSet = new RenatinhaPlace.dbDragonNightDataSet();
            this.dbDragonNightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx1.Location = new System.Drawing.Point(147, 62);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(360, 2);
            this.pbx1.TabIndex = 98;
            this.pbx1.TabStop = false;
            // 
            // txtNameEvent
            // 
            this.txtNameEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtNameEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameEvent.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEvent.ForeColor = System.Drawing.Color.Silver;
            this.txtNameEvent.Location = new System.Drawing.Point(147, 43);
            this.txtNameEvent.MaxLength = 25;
            this.txtNameEvent.Name = "txtNameEvent";
            this.txtNameEvent.Size = new System.Drawing.Size(360, 20);
            this.txtNameEvent.TabIndex = 0;
            this.txtNameEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameEvent.WordWrap = false;
            // 
            // lblNameEvent
            // 
            this.lblNameEvent.AutoSize = true;
            this.lblNameEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblNameEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblNameEvent.Location = new System.Drawing.Point(144, 8);
            this.lblNameEvent.Name = "lblNameEvent";
            this.lblNameEvent.Size = new System.Drawing.Size(116, 21);
            this.lblNameEvent.TabIndex = 99;
            this.lblNameEvent.Text = "Event Name";
            this.lblNameEvent.Click += new System.EventHandler(this.lblNameEvent_Click);
            // 
            // lblDescEvent
            // 
            this.lblDescEvent.AutoSize = true;
            this.lblDescEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblDescEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDescEvent.Location = new System.Drawing.Point(144, 128);
            this.lblDescEvent.Name = "lblDescEvent";
            this.lblDescEvent.Size = new System.Drawing.Size(114, 21);
            this.lblDescEvent.TabIndex = 103;
            this.lblDescEvent.Text = "Description";
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx2.Location = new System.Drawing.Point(147, 183);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(600, 2);
            this.pbx2.TabIndex = 102;
            this.pbx2.TabStop = false;
            // 
            // txtDescEvent
            // 
            this.txtDescEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtDescEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescEvent.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescEvent.ForeColor = System.Drawing.Color.Silver;
            this.txtDescEvent.Location = new System.Drawing.Point(147, 164);
            this.txtDescEvent.MaxLength = 70;
            this.txtDescEvent.Name = "txtDescEvent";
            this.txtDescEvent.Size = new System.Drawing.Size(600, 20);
            this.txtDescEvent.TabIndex = 1;
            this.txtDescEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescEvent.WordWrap = false;
            // 
            // mdtDateEvent
            // 
            this.mdtDateEvent.CalendarForeColor = System.Drawing.Color.Silver;
            this.mdtDateEvent.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mdtDateEvent.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.mdtDateEvent.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.mdtDateEvent.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.mdtDateEvent.Location = new System.Drawing.Point(671, 279);
            this.mdtDateEvent.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDateEvent.Name = "mdtDateEvent";
            this.mdtDateEvent.Size = new System.Drawing.Size(252, 29);
            this.mdtDateEvent.TabIndex = 4;
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblDateEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDateEvent.Location = new System.Drawing.Point(667, 241);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(51, 21);
            this.lblDateEvent.TabIndex = 108;
            this.lblDateEvent.Text = "Date";
            // 
            // lblTimeEvent
            // 
            this.lblTimeEvent.AutoSize = true;
            this.lblTimeEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblTimeEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTimeEvent.Location = new System.Drawing.Point(667, 366);
            this.lblTimeEvent.Name = "lblTimeEvent";
            this.lblTimeEvent.Size = new System.Drawing.Size(54, 21);
            this.lblTimeEvent.TabIndex = 109;
            this.lblTimeEvent.Text = "Time";
            // 
            // pbx3
            // 
            this.pbx3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx3.Location = new System.Drawing.Point(735, 425);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(57, 2);
            this.pbx3.TabIndex = 111;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.lblFrom.ForeColor = System.Drawing.Color.Silver;
            this.lblFrom.Location = new System.Drawing.Point(668, 407);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 112;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.lblTo.ForeColor = System.Drawing.Color.Silver;
            this.lblTo.Location = new System.Drawing.Point(817, 407);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 20);
            this.lblTo.TabIndex = 113;
            this.lblTo.Text = "To";
            // 
            // pbx4
            // 
            this.pbx4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx4.Location = new System.Drawing.Point(866, 424);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(57, 2);
            this.pbx4.TabIndex = 115;
            this.pbx4.TabStop = false;
            // 
            // lblArtEvent
            // 
            this.lblArtEvent.AutoSize = true;
            this.lblArtEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblArtEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblArtEvent.Location = new System.Drawing.Point(144, 241);
            this.lblArtEvent.Name = "lblArtEvent";
            this.lblArtEvent.Size = new System.Drawing.Size(58, 21);
            this.lblArtEvent.TabIndex = 117;
            this.lblArtEvent.Text = "Artist";
            // 
            // mcbArtEvent
            // 
            this.mcbArtEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mcbArtEvent.ForeColor = System.Drawing.Color.Silver;
            this.mcbArtEvent.FormattingEnabled = true;
            this.mcbArtEvent.ItemHeight = 23;
            this.mcbArtEvent.Location = new System.Drawing.Point(148, 279);
            this.mcbArtEvent.Name = "mcbArtEvent";
            this.mcbArtEvent.Size = new System.Drawing.Size(217, 29);
            this.mcbArtEvent.TabIndex = 2;
            this.mcbArtEvent.UseSelectable = true;
            // 
            // mcbMenuEvent
            // 
            this.mcbMenuEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mcbMenuEvent.ForeColor = System.Drawing.Color.Silver;
            this.mcbMenuEvent.FormattingEnabled = true;
            this.mcbMenuEvent.ItemHeight = 23;
            this.mcbMenuEvent.Location = new System.Drawing.Point(148, 406);
            this.mcbMenuEvent.Name = "mcbMenuEvent";
            this.mcbMenuEvent.Size = new System.Drawing.Size(217, 29);
            this.mcbMenuEvent.TabIndex = 3;
            this.mcbMenuEvent.UseSelectable = true;
            // 
            // lblMenuEvent
            // 
            this.lblMenuEvent.AutoSize = true;
            this.lblMenuEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblMenuEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblMenuEvent.Location = new System.Drawing.Point(144, 366);
            this.lblMenuEvent.Name = "lblMenuEvent";
            this.lblMenuEvent.Size = new System.Drawing.Size(60, 21);
            this.lblMenuEvent.TabIndex = 122;
            this.lblMenuEvent.Text = "Menu";
            // 
            // txtTimeEvent1
            // 
            this.txtTimeEvent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtTimeEvent1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeEvent1.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.txtTimeEvent1.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeEvent1.Location = new System.Drawing.Point(734, 406);
            this.txtTimeEvent1.Mask = "00:00";
            this.txtTimeEvent1.Name = "txtTimeEvent1";
            this.txtTimeEvent1.Size = new System.Drawing.Size(57, 20);
            this.txtTimeEvent1.TabIndex = 5;
            this.txtTimeEvent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeEvent1.ValidatingType = typeof(System.DateTime);
            // 
            // txtTimeEvent2
            // 
            this.txtTimeEvent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtTimeEvent2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeEvent2.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.txtTimeEvent2.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeEvent2.Location = new System.Drawing.Point(866, 405);
            this.txtTimeEvent2.Mask = "00:00";
            this.txtTimeEvent2.Name = "txtTimeEvent2";
            this.txtTimeEvent2.Size = new System.Drawing.Size(57, 20);
            this.txtTimeEvent2.TabIndex = 6;
            this.txtTimeEvent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeEvent2.ValidatingType = typeof(System.DateTime);
            // 
            // btnRegistrer
            // 
            this.btnRegistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegistrer.FlatAppearance.BorderSize = 3;
            this.btnRegistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRegistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRegistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrer.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnRegistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnRegistrer.Location = new System.Drawing.Point(385, 464);
            this.btnRegistrer.Name = "btnRegistrer";
            this.btnRegistrer.Size = new System.Drawing.Size(145, 59);
            this.btnRegistrer.TabIndex = 7;
            this.btnRegistrer.Text = "Register";
            this.btnRegistrer.UseMnemonic = false;
            this.btnRegistrer.UseVisualStyleBackColor = true;
            this.btnRegistrer.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnClear.Location = new System.Drawing.Point(534, 464);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 59);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseMnemonic = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dbDragonNightDataSet
            // 
            this.dbDragonNightDataSet.DataSetName = "dbDragonNightDataSet";
            this.dbDragonNightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDragonNightDataSetBindingSource
            // 
            this.dbDragonNightDataSetBindingSource.DataSource = this.dbDragonNightDataSet;
            this.dbDragonNightDataSetBindingSource.Position = 0;
            // 
            // ucAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegistrer);
            this.Controls.Add(this.lblMenuEvent);
            this.Controls.Add(this.mcbMenuEvent);
            this.Controls.Add(this.mcbArtEvent);
            this.Controls.Add(this.lblArtEvent);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.lblTimeEvent);
            this.Controls.Add(this.lblDateEvent);
            this.Controls.Add(this.mdtDateEvent);
            this.Controls.Add(this.lblDescEvent);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.txtDescEvent);
            this.Controls.Add(this.lblNameEvent);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.txtNameEvent);
            this.Controls.Add(this.txtTimeEvent1);
            this.Controls.Add(this.txtTimeEvent2);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "ucAddEvent";
            this.Size = new System.Drawing.Size(1142, 571);
            this.Load += new System.EventHandler(this.ucAddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDragonNightDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbx1;
        public System.Windows.Forms.TextBox txtNameEvent;
        private System.Windows.Forms.Label lblNameEvent;
        private System.Windows.Forms.Label lblDescEvent;
        public System.Windows.Forms.PictureBox pbx2;
        public System.Windows.Forms.TextBox txtDescEvent;
        private MetroFramework.Controls.MetroDateTime mdtDateEvent;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.Label lblTimeEvent;
        public System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        public System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Label lblArtEvent;
        private MetroFramework.Controls.MetroComboBox mcbArtEvent;
        private MetroFramework.Controls.MetroComboBox mcbMenuEvent;
        private System.Windows.Forms.Label lblMenuEvent;
        private System.Windows.Forms.MaskedTextBox txtTimeEvent1;
        private System.Windows.Forms.MaskedTextBox txtTimeEvent2;
        public System.Windows.Forms.Button btnRegistrer;
        public System.Windows.Forms.Button btnClear;
        private dbDragonNightDataSet dbDragonNightDataSet;
        private System.Windows.Forms.BindingSource dbDragonNightDataSetBindingSource;
    }
}
