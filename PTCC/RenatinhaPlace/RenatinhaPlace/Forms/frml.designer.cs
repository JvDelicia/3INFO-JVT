namespace MUU_Project
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.llblForgotPass = new System.Windows.Forms.LinkLabel();
            this.lblErro = new System.Windows.Forms.Label();
            this.pbxMuuLogoLogin = new System.Windows.Forms.PictureBox();
            this.pbxMuuLogin = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbxBaseUser = new System.Windows.Forms.PictureBox();
            this.pbxBasePass = new System.Windows.Forms.PictureBox();
            this.pbxPass = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxRodapeLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRodapeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEntrar.Location = new System.Drawing.Point(143, 300);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(106, 52);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseMnemonic = false;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnSair.Location = new System.Drawing.Point(270, 300);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 52);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseMnemonic = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(110, 128);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(110, 180);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(300, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // llblForgotPass
            // 
            this.llblForgotPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.llblForgotPass.AutoSize = true;
            this.llblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.llblForgotPass.Location = new System.Drawing.Point(107, 218);
            this.llblForgotPass.Name = "llblForgotPass";
            this.llblForgotPass.Size = new System.Drawing.Size(133, 15);
            this.llblForgotPass.TabIndex = 4;
            this.llblForgotPass.TabStop = true;
            this.llblForgotPass.Text = "Esqueceu a senha?";
            this.llblForgotPass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(238, 218);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(192, 15);
            this.lblErro.TabIndex = 15;
            this.lblErro.Text = "Usuário ou senha incorretos!";
            this.lblErro.Visible = false;
            this.lblErro.Click += new System.EventHandler(this.lblErro_Click);
            // 
            // pbxMuuLogoLogin
            // 
            this.pbxMuuLogoLogin.Location = new System.Drawing.Point(379, 25);
            this.pbxMuuLogoLogin.Name = "pbxMuuLogoLogin";
            this.pbxMuuLogoLogin.Size = new System.Drawing.Size(112, 80);
            this.pbxMuuLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMuuLogoLogin.TabIndex = 88;
            this.pbxMuuLogoLogin.TabStop = false;
            // 
            // pbxMuuLogin
            // 
            this.pbxMuuLogin.Location = new System.Drawing.Point(60, 25);
            this.pbxMuuLogin.Name = "pbxMuuLogin";
            this.pbxMuuLogin.Size = new System.Drawing.Size(320, 80);
            this.pbxMuuLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMuuLogin.TabIndex = 87;
            this.pbxMuuLogin.TabStop = false;
            this.pbxMuuLogin.Click += new System.EventHandler(this.pbxMuuLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(417, 181);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(29, 30);
            this.btnLogout.TabIndex = 86;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbxBaseUser
            // 
            this.pbxBaseUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.pbxBaseUser.Location = new System.Drawing.Point(110, 152);
            this.pbxBaseUser.Name = "pbxBaseUser";
            this.pbxBaseUser.Size = new System.Drawing.Size(300, 2);
            this.pbxBaseUser.TabIndex = 13;
            this.pbxBaseUser.TabStop = false;
            this.pbxBaseUser.Click += new System.EventHandler(this.pbxBaseUser_Click);
            // 
            // pbxBasePass
            // 
            this.pbxBasePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.pbxBasePass.Location = new System.Drawing.Point(110, 205);
            this.pbxBasePass.Name = "pbxBasePass";
            this.pbxBasePass.Size = new System.Drawing.Size(300, 2);
            this.pbxBasePass.TabIndex = 12;
            this.pbxBasePass.TabStop = false;
            this.pbxBasePass.Click += new System.EventHandler(this.pbxBasePass_Click);
            // 
            // pbxPass
            // 
            this.pbxPass.Image = ((System.Drawing.Image)(resources.GetObject("pbxPass.Image")));
            this.pbxPass.Location = new System.Drawing.Point(79, 182);
            this.pbxPass.Name = "pbxPass";
            this.pbxPass.Size = new System.Drawing.Size(25, 25);
            this.pbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPass.TabIndex = 11;
            this.pbxPass.TabStop = false;
            this.pbxPass.Click += new System.EventHandler(this.pbxPass_Click);
            // 
            // pbxUser
            // 
            this.pbxUser.Image = ((System.Drawing.Image)(resources.GetObject("pbxUser.Image")));
            this.pbxUser.Location = new System.Drawing.Point(79, 129);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(25, 25);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 10;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            // 
            // pbxRodapeLogin
            // 
            this.pbxRodapeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pbxRodapeLogin.Location = new System.Drawing.Point(0, 291);
            this.pbxRodapeLogin.Name = "pbxRodapeLogin";
            this.pbxRodapeLogin.Size = new System.Drawing.Size(520, 70);
            this.pbxRodapeLogin.TabIndex = 5;
            this.pbxRodapeLogin.TabStop = false;
            this.pbxRodapeLogin.Click += new System.EventHandler(this.pbxRodapeLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.pbxMuuLogin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.llblForgotPass);
            this.Controls.Add(this.pbxBaseUser);
            this.Controls.Add(this.pbxBasePass);
            this.Controls.Add(this.pbxPass);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pbxRodapeLogin);
            this.Controls.Add(this.pbxMuuLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRodapeLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEntrar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.PictureBox pbxRodapeLogin;
        public System.Windows.Forms.PictureBox pbxUser;
        public System.Windows.Forms.PictureBox pbxPass;
        public System.Windows.Forms.PictureBox pbxBasePass;
        public System.Windows.Forms.PictureBox pbxBaseUser;
        public System.Windows.Forms.LinkLabel llblForgotPass;
        public System.Windows.Forms.Label lblErro;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.PictureBox pbxMuuLogin;
        public System.Windows.Forms.PictureBox pbxMuuLogoLogin;
    }
}