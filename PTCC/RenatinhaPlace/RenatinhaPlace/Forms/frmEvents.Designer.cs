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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
            this.dbRenatinhaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRenatinhaDataSet = new RenatinhaPlace.dbRenatinhaDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dbRenatinhaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRenatinhaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dbRenatinhaDataSetBindingSource
            // 
            this.dbRenatinhaDataSetBindingSource.DataSource = this.dbRenatinhaDataSet;
            this.dbRenatinhaDataSetBindingSource.Position = 0;
            // 
            // dbRenatinhaDataSet
            // 
            this.dbRenatinhaDataSet.DataSetName = "dbRenatinhaDataSet";
            this.dbRenatinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbRenatinhaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRenatinhaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbRenatinhaDataSetBindingSource;
        private dbRenatinhaDataSet dbRenatinhaDataSet;
    }
}