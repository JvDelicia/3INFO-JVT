namespace RenatinhaPlace.Forms
{
    partial class frmCashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashier));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxBasePass = new System.Windows.Forms.PictureBox();
            this.panelProd = new System.Windows.Forms.Panel();
            this.btnaddProd = new System.Windows.Forms.Button();
            this.lblFIlterBy = new System.Windows.Forms.Label();
            this.mcbFilterBy = new MetroFramework.Controls.MetroComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvItemMenu = new System.Windows.Forms.DataGridView();
            this.panelEnter = new System.Windows.Forms.Panel();
            this.btnOpenAcc = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEnterAccount = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.txtEnterAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAcc = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRemoveProd = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnFinalizeAcc = new System.Windows.Forms.Button();
            this.btnFilter2 = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).BeginInit();
            this.panelProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMenu)).BeginInit();
            this.panelEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.panelAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(390, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 36);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "Products";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.pbxBack);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(34, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 33);
            this.panel1.TabIndex = 99;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Rockwell", 15F);
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblBack.Location = new System.Drawing.Point(27, 4);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(0, 22);
            this.lblBack.TabIndex = 10;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.BackColor = System.Drawing.Color.Transparent;
            this.pbxBack.Image = global::RenatinhaPlace.Properties.Resources.Left_Arrow;
            this.pbxBack.Location = new System.Drawing.Point(0, 0);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(37, 33);
            this.pbxBack.TabIndex = 9;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxBasePass
            // 
            this.pbxBasePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbxBasePass.Location = new System.Drawing.Point(0, 34);
            this.pbxBasePass.Name = "pbxBasePass";
            this.pbxBasePass.Size = new System.Drawing.Size(1382, 12);
            this.pbxBasePass.TabIndex = 101;
            this.pbxBasePass.TabStop = false;
            // 
            // panelProd
            // 
            this.panelProd.Controls.Add(this.btnaddProd);
            this.panelProd.Controls.Add(this.lblFIlterBy);
            this.panelProd.Controls.Add(this.mcbFilterBy);
            this.panelProd.Controls.Add(this.btnFilter);
            this.panelProd.Controls.Add(this.lblFilter);
            this.panelProd.Controls.Add(this.pbx2);
            this.panelProd.Controls.Add(this.txtFilter);
            this.panelProd.Controls.Add(this.dgvItemMenu);
            this.panelProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelProd.Location = new System.Drawing.Point(20, 75);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(514, 613);
            this.panelProd.TabIndex = 103;
            // 
            // btnaddProd
            // 
            this.btnaddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddProd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnaddProd.FlatAppearance.BorderSize = 3;
            this.btnaddProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnaddProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnaddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddProd.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnaddProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnaddProd.Location = new System.Drawing.Point(1, 551);
            this.btnaddProd.Name = "btnaddProd";
            this.btnaddProd.Size = new System.Drawing.Size(510, 59);
            this.btnaddProd.TabIndex = 161;
            this.btnaddProd.Text = "Add To Account";
            this.btnaddProd.UseMnemonic = false;
            this.btnaddProd.UseVisualStyleBackColor = true;
            // 
            // lblFIlterBy
            // 
            this.lblFIlterBy.AutoSize = true;
            this.lblFIlterBy.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblFIlterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFIlterBy.Location = new System.Drawing.Point(234, 14);
            this.lblFIlterBy.Name = "lblFIlterBy";
            this.lblFIlterBy.Size = new System.Drawing.Size(84, 21);
            this.lblFIlterBy.TabIndex = 164;
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
            this.mcbFilterBy.Location = new System.Drawing.Point(238, 48);
            this.mcbFilterBy.Name = "mcbFilterBy";
            this.mcbFilterBy.Size = new System.Drawing.Size(165, 29);
            this.mcbFilterBy.TabIndex = 158;
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
            this.btnFilter.Location = new System.Drawing.Point(426, 25);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 59);
            this.btnFilter.TabIndex = 159;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseMnemonic = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFilter.Location = new System.Drawing.Point(1, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 21);
            this.lblFilter.TabIndex = 163;
            this.lblFilter.Text = "Filter";
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx2.Location = new System.Drawing.Point(5, 65);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(215, 2);
            this.pbx2.TabIndex = 162;
            this.pbx2.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Silver;
            this.txtFilter.Location = new System.Drawing.Point(5, 46);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(214, 20);
            this.txtFilter.TabIndex = 157;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.WordWrap = false;
            // 
            // dgvItemMenu
            // 
            this.dgvItemMenu.AllowUserToAddRows = false;
            this.dgvItemMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvItemMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvItemMenu.EnableHeadersVisualStyles = false;
            this.dgvItemMenu.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvItemMenu.Location = new System.Drawing.Point(0, 100);
            this.dgvItemMenu.Name = "dgvItemMenu";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemMenu.Size = new System.Drawing.Size(511, 447);
            this.dgvItemMenu.TabIndex = 160;
            // 
            // panelEnter
            // 
            this.panelEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEnter.Controls.Add(this.btnOpenAcc);
            this.panelEnter.Controls.Add(this.btnSearch);
            this.panelEnter.Controls.Add(this.lblEnterAccount);
            this.panelEnter.Controls.Add(this.pbx1);
            this.panelEnter.Controls.Add(this.txtEnterAccount);
            this.panelEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelEnter.Location = new System.Drawing.Point(569, 75);
            this.panelEnter.Name = "panelEnter";
            this.panelEnter.Size = new System.Drawing.Size(227, 547);
            this.panelEnter.TabIndex = 104;
            // 
            // btnOpenAcc
            // 
            this.btnOpenAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenAcc.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnOpenAcc.FlatAppearance.BorderSize = 3;
            this.btnOpenAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnOpenAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnOpenAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAcc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnOpenAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnOpenAcc.Location = new System.Drawing.Point(40, 385);
            this.btnOpenAcc.Name = "btnOpenAcc";
            this.btnOpenAcc.Size = new System.Drawing.Size(145, 106);
            this.btnOpenAcc.TabIndex = 137;
            this.btnOpenAcc.Text = "Open Account";
            this.btnOpenAcc.UseMnemonic = false;
            this.btnOpenAcc.UseVisualStyleBackColor = true;
            this.btnOpenAcc.Click += new System.EventHandler(this.btnOpenAcc_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(40, 313);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 60);
            this.btnSearch.TabIndex = 136;
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
            this.lblEnterAccount.Location = new System.Drawing.Point(2, 190);
            this.lblEnterAccount.Name = "lblEnterAccount";
            this.lblEnterAccount.Size = new System.Drawing.Size(222, 31);
            this.lblEnterAccount.TabIndex = 135;
            this.lblEnterAccount.Text = "Enter Account ID";
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbx1.Location = new System.Drawing.Point(27, 278);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(174, 2);
            this.pbx1.TabIndex = 134;
            this.pbx1.TabStop = false;
            // 
            // txtEnterAccount
            // 
            this.txtEnterAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.txtEnterAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnterAccount.Font = new System.Drawing.Font("Rockwell", 20F);
            this.txtEnterAccount.ForeColor = System.Drawing.Color.Silver;
            this.txtEnterAccount.Location = new System.Drawing.Point(27, 248);
            this.txtEnterAccount.MaxLength = 6;
            this.txtEnterAccount.Name = "txtEnterAccount";
            this.txtEnterAccount.Size = new System.Drawing.Size(174, 32);
            this.txtEnterAccount.TabIndex = 133;
            this.txtEnterAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnterAccount.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(683, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(827, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 106;
            this.label2.Text = "Account";
            // 
            // panelAcc
            // 
            this.panelAcc.Controls.Add(this.pictureBox1);
            this.panelAcc.Controls.Add(this.textBox1);
            this.panelAcc.Controls.Add(this.btnRemoveProd);
            this.panelAcc.Controls.Add(this.lblQtd);
            this.panelAcc.Controls.Add(this.btnFinalizeAcc);
            this.panelAcc.Controls.Add(this.btnFilter2);
            this.panelAcc.Controls.Add(this.dgvAccount);
            this.panelAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAcc.Location = new System.Drawing.Point(833, 75);
            this.panelAcc.Name = "panelAcc";
            this.panelAcc.Size = new System.Drawing.Size(514, 613);
            this.panelAcc.TabIndex = 107;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pictureBox1.Location = new System.Drawing.Point(5, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 2);
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 20F);
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(5, 45);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 32);
            this.textBox1.TabIndex = 169;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // btnRemoveProd
            // 
            this.btnRemoveProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnRemoveProd.FlatAppearance.BorderSize = 3;
            this.btnRemoveProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnRemoveProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnRemoveProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProd.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F);
            this.btnRemoveProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnRemoveProd.Location = new System.Drawing.Point(336, 25);
            this.btnRemoveProd.Name = "btnRemoveProd";
            this.btnRemoveProd.Size = new System.Drawing.Size(175, 58);
            this.btnRemoveProd.TabIndex = 168;
            this.btnRemoveProd.Text = "Remove Item";
            this.btnRemoveProd.UseMnemonic = false;
            this.btnRemoveProd.UseVisualStyleBackColor = true;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblQtd.Location = new System.Drawing.Point(1, 14);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(78, 21);
            this.lblQtd.TabIndex = 167;
            this.lblQtd.Text = "Amount";
            // 
            // btnFinalizeAcc
            // 
            this.btnFinalizeAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizeAcc.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFinalizeAcc.FlatAppearance.BorderSize = 3;
            this.btnFinalizeAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFinalizeAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFinalizeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeAcc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F);
            this.btnFinalizeAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnFinalizeAcc.Location = new System.Drawing.Point(1, 551);
            this.btnFinalizeAcc.Name = "btnFinalizeAcc";
            this.btnFinalizeAcc.Size = new System.Drawing.Size(510, 59);
            this.btnFinalizeAcc.TabIndex = 161;
            this.btnFinalizeAcc.Text = "Finalize Account";
            this.btnFinalizeAcc.UseMnemonic = false;
            this.btnFinalizeAcc.UseVisualStyleBackColor = true;
            // 
            // btnFilter2
            // 
            this.btnFilter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFilter2.FlatAppearance.BorderSize = 3;
            this.btnFilter2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFilter2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFilter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F);
            this.btnFilter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnFilter2.Location = new System.Drawing.Point(120, 26);
            this.btnFilter2.Name = "btnFilter2";
            this.btnFilter2.Size = new System.Drawing.Size(181, 56);
            this.btnFilter2.TabIndex = 159;
            this.btnFilter2.Text = "Confirm Amount";
            this.btnFilter2.UseMnemonic = false;
            this.btnFilter2.UseVisualStyleBackColor = true;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvAccount.Location = new System.Drawing.Point(0, 100);
            this.dgvAccount.Name = "dgvAccount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.Size = new System.Drawing.Size(511, 447);
            this.dgvAccount.TabIndex = 160;
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1366, 477);
            this.Controls.Add(this.panelAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxBasePass);
            this.Controls.Add(this.panelEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCashier_FormClosing);
            this.Load += new System.EventHandler(this.frmCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).EndInit();
            this.panelProd.ResumeLayout(false);
            this.panelProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMenu)).EndInit();
            this.panelEnter.ResumeLayout(false);
            this.panelEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.panelAcc.ResumeLayout(false);
            this.panelAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.PictureBox pbxBack;
        public System.Windows.Forms.PictureBox pbxBasePass;
        private System.Windows.Forms.Panel panelProd;
        public System.Windows.Forms.Button btnaddProd;
        private System.Windows.Forms.Label lblFIlterBy;
        private MetroFramework.Controls.MetroComboBox mcbFilterBy;
        public System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        public System.Windows.Forms.PictureBox pbx2;
        public System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.DataGridView dgvItemMenu;
        private System.Windows.Forms.Panel panelEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAcc;
        public System.Windows.Forms.Button btnFinalizeAcc;
        public System.Windows.Forms.Button btnFilter2;
        public System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label lblQtd;
        public System.Windows.Forms.Button btnRemoveProd;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnOpenAcc;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEnterAccount;
        public System.Windows.Forms.PictureBox pbx1;
        public System.Windows.Forms.TextBox txtEnterAccount;
    }
}