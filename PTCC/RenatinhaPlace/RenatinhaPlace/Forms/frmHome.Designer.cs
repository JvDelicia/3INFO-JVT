namespace RenatinhaPlace.Forms
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.mt1 = new MetroFramework.Controls.MetroTile();
            this.mt3 = new MetroFramework.Controls.MetroTile();
            this.mt2 = new MetroFramework.Controls.MetroTile();
            this.mt4 = new MetroFramework.Controls.MetroTile();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblConnectedUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mt1
            // 
            this.mt1.ActiveControl = null;
            this.mt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt1.Location = new System.Drawing.Point(268, 136);
            this.mt1.Name = "mt1";
            this.mt1.Size = new System.Drawing.Size(409, 205);
            this.mt1.Style = MetroFramework.MetroColorStyle.Red;
            this.mt1.TabIndex = 0;
            this.mt1.TileImage = global::RenatinhaPlace.Properties.Resources.Event;
            this.mt1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt1.UseSelectable = true;
            this.mt1.UseStyleColors = true;
            this.mt1.UseTileImage = true;
            this.mt1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mt3
            // 
            this.mt3.ActiveControl = null;
            this.mt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt3.Location = new System.Drawing.Point(490, 362);
            this.mt3.Name = "mt3";
            this.mt3.Size = new System.Drawing.Size(187, 286);
            this.mt3.Style = MetroFramework.MetroColorStyle.Red;
            this.mt3.TabIndex = 1;
            this.mt3.TileImage = global::RenatinhaPlace.Properties.Resources.Employee;
            this.mt3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt3.UseSelectable = true;
            this.mt3.UseStyleColors = true;
            this.mt3.UseTileImage = true;
            this.mt3.Click += new System.EventHandler(this.mt3_Click);
            // 
            // mt2
            // 
            this.mt2.ActiveControl = null;
            this.mt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt2.Location = new System.Drawing.Point(697, 136);
            this.mt2.Name = "mt2";
            this.mt2.Size = new System.Drawing.Size(206, 330);
            this.mt2.Style = MetroFramework.MetroColorStyle.Red;
            this.mt2.TabIndex = 2;
            this.mt2.TileImage = global::RenatinhaPlace.Properties.Resources.Payment;
            this.mt2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt2.UseSelectable = true;
            this.mt2.UseStyleColors = true;
            this.mt2.UseTileImage = true;
            this.mt2.Click += new System.EventHandler(this.mt2_Click);
            // 
            // mt4
            // 
            this.mt4.ActiveControl = null;
            this.mt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mt4.Location = new System.Drawing.Point(697, 487);
            this.mt4.Name = "mt4";
            this.mt4.Size = new System.Drawing.Size(427, 161);
            this.mt4.Style = MetroFramework.MetroColorStyle.Red;
            this.mt4.TabIndex = 3;
            this.mt4.TileImage = global::RenatinhaPlace.Properties.Resources.Client;
            this.mt4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt4.UseSelectable = true;
            this.mt4.UseStyleColors = true;
            this.mt4.UseTileImage = true;
            this.mt4.Click += new System.EventHandler(this.mt4_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblWelcome.Location = new System.Drawing.Point(477, 56);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 39);
            this.lblWelcome.TabIndex = 5;
            // 
            // lblConnectedUser
            // 
            this.lblConnectedUser.AutoSize = true;
            this.lblConnectedUser.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectedUser.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.lblConnectedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblConnectedUser.Location = new System.Drawing.Point(35, 667);
            this.lblConnectedUser.Name = "lblConnectedUser";
            this.lblConnectedUser.Size = new System.Drawing.Size(0, 24);
            this.lblConnectedUser.TabIndex = 6;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.lblConnectedUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mt4);
            this.Controls.Add(this.mt2);
            this.Controls.Add(this.mt3);
            this.Controls.Add(this.mt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mt1;
        private MetroFramework.Controls.MetroTile mt3;
        private MetroFramework.Controls.MetroTile mt2;
        private MetroFramework.Controls.MetroTile mt4;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblConnectedUser;
    }
}