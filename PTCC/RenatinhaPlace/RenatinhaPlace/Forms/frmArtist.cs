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
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void frmArtist_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Artist;
            lblBack.Text = Strings.Back;
            lblTitle.Text = Strings.Artist;
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

        private void frmArtist_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit();
        }
    }
}
