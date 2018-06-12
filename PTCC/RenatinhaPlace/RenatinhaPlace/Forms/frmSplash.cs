using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Forms;
using System.Windows.Forms;

using MetroFramework.Controls;

namespace RenatinhaPlace {
    public partial class frmSplash : Form {
        public frmSplash() {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e) {

            lblSplash.Text = Strings.Rights;
            lblTitleSplash.Text = Strings.Title;
        }

        private void lblSplash_Click(object sender, EventArgs e)
        {

        }

        private void StartTimer()
        {
            timer1.Interval = 10;

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1.Increment(1);
            pb2.Increment(1);

            if (pb1.Value == pb1.Maximum)
            {

                timer1.Stop();
                timer1.Enabled = false;
                this.Close();
                frmLogin log = new frmLogin();
                log.Show();
  
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
