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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMuuLogin
            // 
            this.pbxMuuLogin.Image = global::RenatinhaPlace.Properties.Resources.dragon__1_;
            this.pbxMuuLogin.Location = new System.Drawing.Point(85, 12);
            this.pbxMuuLogin.Name = "pbxMuuLogin";
            this.pbxMuuLogin.Size = new System.Drawing.Size(162, 140);
            this.pbxMuuLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMuuLogin.TabIndex = 98;
            this.pbxMuuLogin.TabStop = false;
            // 
            // pbxBaseUser
            // 
            this.pbxBaseUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pbxBaseUser.Location = new System.Drawing.Point(45, 179);
            this.pbxBaseUser.Name = "pbxBaseUser";
            this.pbxBaseUser.Size = new System.Drawing.Size(250, 2);
            this.pbxBaseUser.TabIndex = 96;
            this.pbxBaseUser.TabStop = false;
            // 
            // pbxBasePass
            // 
            this.pbxBasePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pbxBasePass.Location = new System.Drawing.Point(45, 232);
            this.pbxBasePass.Name = "pbxBasePass";
            this.pbxBasePass.Size = new System.Drawing.Size(250, 2);
            this.pbxBasePass.TabIndex = 95;
            this.pbxBasePass.TabStop = false;
            // 
            // pbxPass
            // 
            this.pbxPass.Image = ((System.Drawing.Image)(resources.GetObject("pbxPass.Image")));
            this.pbxPass.Location = new System.Drawing.Point(13, 209);
            this.pbxPass.Name = "pbxPass";
            this.pbxPass.Size = new System.Drawing.Size(25, 25);
            this.pbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPass.TabIndex = 94;
            this.pbxPass.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.Image = ((System.Drawing.Image)(resources.GetObject("pbxUser.Image")));
            this.pbxUser.Location = new System.Drawing.Point(13, 155);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(25, 25);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 93;
            this.pbxUser.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnSair.Location = new System.Drawing.Point(171, 286);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 52);
            this.btnSair.TabIndex = 91;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseMnemonic = false;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(47, 207);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(300, 23);
            this.txtPass.TabIndex = 89;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(47, 155);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 22);
            this.txtUser.TabIndex = 88;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEntrar.Location = new System.Drawing.Point(45, 286);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(106, 52);
            this.btnEntrar.TabIndex = 90;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseMnemonic = false;
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F);
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblErro.Location = new System.Drawing.Point(54, 249);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(209, 18);
            this.lblErro.TabIndex = 97;
            this.lblErro.Text = "Usuário ou senha incorretos!";
            this.lblErro.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(327, 367);
            this.Controls.Add(this.pbxMuuLogin);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.pbxBaseUser);
            this.Controls.Add(this.pbxBasePass);
            this.Controls.Add(this.pbxPass);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuuLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxMuuLogin;
        public System.Windows.Forms.PictureBox pbxBaseUser;
        public System.Windows.Forms.PictureBox pbxBasePass;
        public System.Windows.Forms.PictureBox pbxPass;
        public System.Windows.Forms.PictureBox pbxUser;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Button btnEntrar;
        public System.Windows.Forms.Label lblErro;
    }
}