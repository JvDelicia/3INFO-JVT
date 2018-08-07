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
            this.mdtDateBegin = new MetroFramework.Controls.MetroDateTime();
            this.lblBeginEvent = new System.Windows.Forms.Label();
            this.lblEndEvent = new System.Windows.Forms.Label();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.lblTimeBegin = new System.Windows.Forms.Label();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.lblArtEvent = new System.Windows.Forms.Label();
            this.mcbArtEvent = new MetroFramework.Controls.MetroComboBox();
            this.mcbMenuEvent = new MetroFramework.Controls.MetroComboBox();
            this.lblMenuEvent = new System.Windows.Forms.Label();
            this.txtTimeBegin = new System.Windows.Forms.MaskedTextBox();
            this.txtTimeEnd = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dbDragonNightDataSet = new RenatinhaPlace.dbDragonNightDataSet();
            this.dbDragonNightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.mdtDateEnd = new MetroFramework.Controls.MetroDateTime();
            this.btnAddTicket = new System.Windows.Forms.Button();
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
            // mdtDateBegin
            // 
            this.mdtDateBegin.CalendarForeColor = System.Drawing.Color.Silver;
            this.mdtDateBegin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mdtDateBegin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.mdtDateBegin.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.mdtDateBegin.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.mdtDateBegin.Location = new System.Drawing.Point(200, 400);
            this.mdtDateBegin.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDateBegin.Name = "mdtDateBegin";
            this.mdtDateBegin.Size = new System.Drawing.Size(307, 29);
            this.mdtDateBegin.TabIndex = 4;
            // 
            // lblBeginEvent
            // 
            this.lblBeginEvent.AutoSize = true;
            this.lblBeginEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblBeginEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblBeginEvent.Location = new System.Drawing.Point(144, 364);
            this.lblBeginEvent.Name = "lblBeginEvent";
            this.lblBeginEvent.Size = new System.Drawing.Size(61, 21);
            this.lblBeginEvent.TabIndex = 108;
            this.lblBeginEvent.Text = "Begin";
            // 
            // lblEndEvent
            // 
            this.lblEndEvent.AutoSize = true;
            this.lblEndEvent.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblEndEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblEndEvent.Location = new System.Drawing.Point(667, 366);
            this.lblEndEvent.Name = "lblEndEvent";
            this.lblEndEvent.Size = new System.Drawing.Size(45, 21);
            this.lblEndEvent.TabIndex = 109;
            this.lblEndEvent.Text = "End";
            // 
            // pbx3
            // 
            this.pbx3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx3.Location = new System.Drawing.Point(200, 459);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(57, 2);
            this.pbx3.TabIndex = 111;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.lblDateBegin.ForeColor = System.Drawing.Color.Silver;
            this.lblDateBegin.Location = new System.Drawing.Point(145, 406);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(45, 20);
            this.lblDateBegin.TabIndex = 112;
            this.lblDateBegin.Text = "Date";
            // 
            // lblTimeBegin
            // 
            this.lblTimeBegin.AutoSize = true;
            this.lblTimeBegin.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.lblTimeBegin.ForeColor = System.Drawing.Color.Silver;
            this.lblTimeBegin.Location = new System.Drawing.Point(145, 441);
            this.lblTimeBegin.Name = "lblTimeBegin";
            this.lblTimeBegin.Size = new System.Drawing.Size(49, 20);
            this.lblTimeBegin.TabIndex = 113;
            this.lblTimeBegin.Text = "Time";
            // 
            // pbx4
            // 
            this.pbx4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx4.Location = new System.Drawing.Point(722, 460);
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
            this.mcbMenuEvent.Location = new System.Drawing.Point(671, 279);
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
            this.lblMenuEvent.Location = new System.Drawing.Point(667, 239);
            this.lblMenuEvent.Name = "lblMenuEvent";
            this.lblMenuEvent.Size = new System.Drawing.Size(60, 21);
            this.lblMenuEvent.TabIndex = 122;
            this.lblMenuEvent.Text = "Menu";
            // 
            // txtTimeBegin
            // 
            this.txtTimeBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtTimeBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeBegin.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.txtTimeBegin.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeBegin.Location = new System.Drawing.Point(200, 441);
            this.txtTimeBegin.Mask = "00:00";
            this.txtTimeBegin.Name = "txtTimeBegin";
            this.txtTimeBegin.Size = new System.Drawing.Size(57, 20);
            this.txtTimeBegin.TabIndex = 5;
            this.txtTimeBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeBegin.ValidatingType = typeof(System.DateTime);
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeEnd.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.txtTimeEnd.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeEnd.Location = new System.Drawing.Point(722, 441);
            this.txtTimeEnd.Mask = "00:00";
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(57, 20);
            this.txtTimeEnd.TabIndex = 7;
            this.txtTimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeEnd.ValidatingType = typeof(System.DateTime);
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
            this.btnRegistrer.Location = new System.Drawing.Point(385, 510);
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
            this.btnClear.Location = new System.Drawing.Point(534, 510);
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
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.lblTimeEnd.ForeColor = System.Drawing.Color.Silver;
            this.lblTimeEnd.Location = new System.Drawing.Point(667, 441);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(49, 20);
            this.lblTimeEnd.TabIndex = 124;
            this.lblTimeEnd.Text = "Time";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.lblDateEnd.ForeColor = System.Drawing.Color.Silver;
            this.lblDateEnd.Location = new System.Drawing.Point(667, 406);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(45, 20);
            this.lblDateEnd.TabIndex = 123;
            this.lblDateEnd.Text = "Date";
            // 
            // mdtDateEnd
            // 
            this.mdtDateEnd.CalendarForeColor = System.Drawing.Color.Silver;
            this.mdtDateEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.mdtDateEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.mdtDateEnd.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.mdtDateEnd.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.mdtDateEnd.Location = new System.Drawing.Point(722, 401);
            this.mdtDateEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDateEnd.Name = "mdtDateEnd";
            this.mdtDateEnd.Size = new System.Drawing.Size(307, 29);
            this.mdtDateEnd.TabIndex = 6;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTicket.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddTicket.FlatAppearance.BorderSize = 3;
            this.btnAddTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAddTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTicket.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnAddTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnAddTicket.Location = new System.Drawing.Point(887, 21);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(225, 81);
            this.btnAddTicket.TabIndex = 125;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseMnemonic = false;
            this.btnAddTicket.UseVisualStyleBackColor = true;
            // 
            // ucAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.mdtDateEnd);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegistrer);
            this.Controls.Add(this.mcbArtEvent);
            this.Controls.Add(this.lblArtEvent);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.lblTimeBegin);
            this.Controls.Add(this.lblDateBegin);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.lblEndEvent);
            this.Controls.Add(this.lblBeginEvent);
            this.Controls.Add(this.mdtDateBegin);
            this.Controls.Add(this.lblDescEvent);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.txtDescEvent);
            this.Controls.Add(this.lblNameEvent);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.txtNameEvent);
            this.Controls.Add(this.txtTimeBegin);
            this.Controls.Add(this.txtTimeEnd);
            this.Controls.Add(this.lblMenuEvent);
            this.Controls.Add(this.mcbMenuEvent);
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
        private MetroFramework.Controls.MetroDateTime mdtDateBegin;
        private System.Windows.Forms.Label lblBeginEvent;
        private System.Windows.Forms.Label lblEndEvent;
        public System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.Label lblTimeBegin;
        public System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Label lblArtEvent;
        private MetroFramework.Controls.MetroComboBox mcbArtEvent;
        private MetroFramework.Controls.MetroComboBox mcbMenuEvent;
        private System.Windows.Forms.Label lblMenuEvent;
        private System.Windows.Forms.MaskedTextBox txtTimeBegin;
        private System.Windows.Forms.MaskedTextBox txtTimeEnd;
        public System.Windows.Forms.Button btnRegistrer;
        public System.Windows.Forms.Button btnClear;
        private dbDragonNightDataSet dbDragonNightDataSet;
        private System.Windows.Forms.BindingSource dbDragonNightDataSetBindingSource;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblDateEnd;
        private MetroFramework.Controls.MetroDateTime mdtDateEnd;
        public System.Windows.Forms.Button btnAddTicket;
    }
}
