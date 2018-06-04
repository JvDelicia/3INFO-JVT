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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lblSplash = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx1
            // 
            this.pbx1.Image = global::RenatinhaPlace.Properties.Resources.RDourado;
            this.pbx1.Location = new System.Drawing.Point(128, 12);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(245, 186);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // lblSplash
            // 
            this.lblSplash.AutoSize = true;
            this.lblSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSplash.Location = new System.Drawing.Point(0, 354);
            this.lblSplash.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblSplash.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(500, 13);
            this.lblSplash.TabIndex = 1;
            this.lblSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RenatinhaPlace.Properties.Resources.Load;
            this.pictureBox1.Location = new System.Drawing.Point(128, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(500, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.pbx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.Text = "Renatinha Place";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

