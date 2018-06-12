namespace RenatinhaPlace {
    partial class frmSplash {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblSplash = new System.Windows.Forms.Label();
            this.pb1 = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitleSplash = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new MetroFramework.Controls.MetroProgressBar();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSplash
            // 
            this.lblSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSplash.AutoSize = true;
            this.lblSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F);
            this.lblSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(101)))));
            this.lblSplash.Location = new System.Drawing.Point(0, 200);
            this.lblSplash.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblSplash.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(500, 13);
            this.lblSplash.TabIndex = 1;
            this.lblSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSplash.Click += new System.EventHandler(this.lblSplash_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(-1, 221);
            this.pb1.Maximum = 500;
            this.pb1.Name = "pb1";
            this.pb1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pb1.Size = new System.Drawing.Size(502, 30);
            this.pb1.Style = MetroFramework.MetroColorStyle.Red;
            this.pb1.TabIndex = 3;
            this.pb1.UseCustomBackColor = true;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitleSplash
            // 
            this.lblTitleSplash.AutoSize = true;
            this.lblTitleSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSplash.Font = new System.Drawing.Font("Impact", 43F);
            this.lblTitleSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblTitleSplash.Location = new System.Drawing.Point(149, 116);
            this.lblTitleSplash.Name = "lblTitleSplash";
            this.lblTitleSplash.Size = new System.Drawing.Size(0, 72);
            this.lblTitleSplash.TabIndex = 4;
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.Transparent;
            this.pbx1.Image = global::RenatinhaPlace.Properties.Resources.dragon__2_;
            this.pbx1.Location = new System.Drawing.Point(12, 36);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(185, 156);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 5;
            this.pbx1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(-1, -3);
            this.pb2.Maximum = 500;
            this.pb2.Name = "pb2";
            this.pb2.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pb2.Size = new System.Drawing.Size(502, 30);
            this.pb2.Style = MetroFramework.MetroColorStyle.Red;
            this.pb2.TabIndex = 6;
            this.pb2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pb2.UseCustomBackColor = true;
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.Transparent;
            this.pbx2.Image = global::RenatinhaPlace.Properties.Resources.Aang_Solutions___White_Logo;
            this.pbx2.Location = new System.Drawing.Point(182, 56);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(56, 55);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx2.TabIndex = 7;
            this.pbx2.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lblTitleSplash);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSplash;
        private MetroFramework.Controls.MetroProgressBar pb1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitleSplash;
        private System.Windows.Forms.PictureBox pbx1;
        private MetroFramework.Controls.MetroProgressBar pb2;
        private System.Windows.Forms.PictureBox pbx2;
    }
}

