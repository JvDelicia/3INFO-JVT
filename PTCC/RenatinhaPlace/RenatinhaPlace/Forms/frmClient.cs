using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace RenatinhaPlace.Forms
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Clients;
            lblTitle.Text = Strings.Clients;
            lblBack.Text = Strings.Back;


        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.Show();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.Show();
        }

        private void frmClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfLeave, Strings.QuestLeave, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
