namespace RenatinhaPlace.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbxMuuLogin = new System.Windows.Forms.PictureBox();
            this.pbxBaseUser = new System.Windows.Forms.PictureBox();
            this.pbxBasePass = new System.Windows.Forms.PictureBox();
            this.pbxPass = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMuuLogin
            // 
            this.pbxMuuLogin.Image = global::RenatinhaPlace.Properties.Resources.dragon__1_;
            this.pbxMuuLogin.Location = new System.Drawing.Point(85, 10);
            this.pbxMuuLogin.Name = "pbxMuuLogin";
            this.pbxMuuLogin.Size = new System.Drawing.Size(162, 140);
            this.pbxMuuLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMuuLogin.TabIndex = 98;
            this.pbxMuuLogin.TabStop = false;
            // 
            // pbxBaseUser
            // 
            this.pbxBaseUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pbxBaseUser.Location = new System.Drawing.Point(52, 183);
            this.pbxBaseUser.Name = "pbxBaseUser";
            this.pbxBaseUser.Size = new System.Drawing.Size(250, 2);
            this.pbxBaseUser.TabIndex = 96;
            this.pbxBaseUser.TabStop = false;
            // 
            // pbxBasePass
            // 
            this.pbxBasePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pbxBasePass.Location = new System.Drawing.Point(52, 236);
            this.pbxBasePass.Name = "pbxBasePass";
            this.pbxBasePass.Size = new System.Drawing.Size(250, 2);
            this.pbxBasePass.TabIndex = 95;
            this.pbxBasePass.TabStop = false;
            // 
            // pbxPass
            // 
            this.pbxPass.Image = global::RenatinhaPlace.Properties.Resources.pass;
            this.pbxPass.Location = new System.Drawing.Point(12, 218);
            this.pbxPass.Name = "pbxPass";
            this.pbxPass.Size = new System.Drawing.Size(30, 30);
            this.pbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPass.TabIndex = 94;
            this.pbxPass.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.Image = global::RenatinhaPlace.Properties.Resources.user;
            this.pbxUser.Location = new System.Drawing.Point(12, 165);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(30, 30);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 93;
            this.pbxUser.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnLogOut.FlatAppearance.BorderSize = 3;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLogOut.Location = new System.Drawing.Point(171, 280);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(106, 52);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.UseMnemonic = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtPass.Location = new System.Drawing.Point(54, 218);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(213, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtUser.Location = new System.Drawing.Point(55, 165);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(247, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Username";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLogIn.FlatAppearance.BorderSize = 3;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLogIn.Location = new System.Drawing.Point(45, 280);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(106, 52);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.UseMnemonic = false;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblErro.Location = new System.Drawing.Point(54, 249);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 18);
            this.lblErro.TabIndex = 97;
            this.lblErro.Visible = false;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackgroundImage = global::RenatinhaPlace.Properties.Resources.eyes;
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.btnShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnShowPass.Location = new System.Drawing.Point(273, 211);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(29, 21);
            this.btnShowPass.TabIndex = 3;
            this.btnShowPass.UseMnemonic = false;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblVersion.Location = new System.Drawing.Point(4, 350);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RenatinhaPlace.Properties.Resources.Aang_Solutions___White_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(287, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(327, 367);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.pbxMuuLogin);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.pbxBaseUser);
            this.Controls.Add(this.pbxBasePass);
            this.Controls.Add(this.pbxPass);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxMuuLogin;
        public System.Windows.Forms.PictureBox pbxBaseUser;
        public System.Windows.Forms.PictureBox pbxBasePass;
        public System.Windows.Forms.PictureBox pbxPass;
        public System.Windows.Forms.PictureBox pbxUser;
        public System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Button btnLogIn;
        public System.Windows.Forms.Label lblErro;
        public System.Windows.Forms.Button btnShowPass;
        public System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}