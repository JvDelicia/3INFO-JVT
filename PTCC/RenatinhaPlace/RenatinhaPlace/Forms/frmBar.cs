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
    public partial class frmBar : Form
    {
        public frmBar()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void frmBar_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Bar;
            lblBack.Text = Strings.Back;
            lblTitle.Text = Strings.Bar;
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

        private void frmBar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfLeave, Strings.QuestLeave, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
