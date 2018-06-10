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
            this.SuspendLayout();
            // 
            // lblSplash
            // 
            this.lblSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSplash.AutoSize = true;
            this.lblSplash.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSplash.Location = new System.Drawing.Point(95, 36);
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
            this.pb1.Location = new System.Drawing.Point(-1, -2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(700, 100);
            this.pb1.TabIndex = 3;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(700, 100);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.Text = "Renatinha Place";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSplash;
        private MetroFramework.Controls.MetroProgressBar pb1;
        private System.Windows.Forms.Timer timer1;
    }
}

