namespace RenatinhaPlace.Forms
{
    partial class frmEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
            this.mt1 = new MetroFramework.Controls.MetroTile();
            this.mt2 = new MetroFramework.Controls.MetroTile();
            this.mt3 = new MetroFramework.Controls.MetroTile();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxBasePass = new System.Windows.Forms.PictureBox();
            this.ucAddEvent1 = new RenatinhaPlace.Forms.ucAddEvent();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).BeginInit();
            this.SuspendLayout();
            // 
            // mt1
            // 
            this.mt1.ActiveControl = null;
            this.mt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt1.Location = new System.Drawing.Point(12, 193);
            this.mt1.Name = "mt1";
            this.mt1.Size = new System.Drawing.Size(134, 127);
            this.mt1.Style = MetroFramework.MetroColorStyle.Red;
            this.mt1.TabIndex = 2;
            this.mt1.TileImage = global::RenatinhaPlace.Properties.Resources.Add;
            this.mt1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt1.UseSelectable = true;
            this.mt1.UseStyleColors = true;
            this.mt1.UseTileImage = true;
            this.mt1.Click += new System.EventHandler(this.mt1_Click);
            // 
            // mt2
            // 
            this.mt2.ActiveControl = null;
            this.mt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt2.Location = new System.Drawing.Point(12, 343);
            this.mt2.Name = "mt2";
            this.mt2.Size = new System.Drawing.Size(134, 127);
            this.mt2.Style = MetroFramework.MetroColorStyle.Red;
            this.mt2.TabIndex = 1;
            this.mt2.TileImage = global::RenatinhaPlace.Properties.Resources.Search;
            this.mt2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt2.UseSelectable = true;
            this.mt2.UseStyleColors = true;
            this.mt2.UseTileImage = true;
            this.mt2.Click += new System.EventHandler(this.mt2_Click);
            // 
            // mt3
            // 
            this.mt3.ActiveControl = null;
            this.mt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt3.Location = new System.Drawing.Point(12, 493);
            this.mt3.Name = "mt3";
            this.mt3.Size = new System.Drawing.Size(134, 127);
            this.mt3.Style = MetroFramework.MetroColorStyle.Red;
            this.mt3.TabIndex = 3;
            this.mt3.TileImage = global::RenatinhaPlace.Properties.Resources.Edit;
            this.mt3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt3.UseSelectable = true;
            this.mt3.UseStyleColors = true;
            this.mt3.UseTileImage = true;
            this.mt3.Click += new System.EventHandler(this.mt3_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.pbxBack);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(34, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 33);
            this.panel1.TabIndex = 11;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(602, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 36);
            this.lblTitle.TabIndex = 97;
            // 
            // pbxBasePass
            // 
            this.pbxBasePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.pbxBasePass.Location = new System.Drawing.Point(0, 34);
            this.pbxBasePass.Name = "pbxBasePass";
            this.pbxBasePass.Size = new System.Drawing.Size(1382, 12);
            this.pbxBasePass.TabIndex = 98;
            this.pbxBasePass.TabStop = false;
            // 
            // ucAddEvent1
            // 
            this.ucAddEvent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ucAddEvent1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucAddEvent1.Location = new System.Drawing.Point(183, 90);
            this.ucAddEvent1.Name = "ucAddEvent1";
            this.ucAddEvent1.Size = new System.Drawing.Size(1142, 571);
            this.ucAddEvent1.TabIndex = 99;
            this.ucAddEvent1.Visible = false;
            this.ucAddEvent1.Load += new System.EventHandler(this.ucAddEvent1_Load);
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.ucAddEvent1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mt3);
            this.Controls.Add(this.mt2);
            this.Controls.Add(this.mt1);
            this.Controls.Add(this.pbxBasePass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBasePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mt1;
        private MetroFramework.Controls.MetroTile mt2;
        private MetroFramework.Controls.MetroTile mt3;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox pbxBasePass;
        private ucAddEvent ucAddEvent1;
    }
}