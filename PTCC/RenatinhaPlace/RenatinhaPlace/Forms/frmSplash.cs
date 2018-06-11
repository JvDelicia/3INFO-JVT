using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace RenatinhaPlace {
    public partial class frmSplash : MetroFramework.Forms.MetroForm {
        public frmSplash() {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e) {

            lblSplash.Text = Strings.Rights;
        }

        private void lblSplash_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb1.Value < 100)
            {
                pb1.Value = pb1.Value + 15;
            }
            else
            {

                timer1.Stop();
                timer1.Enabled = false;
                this.Hide();
                
                

            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
