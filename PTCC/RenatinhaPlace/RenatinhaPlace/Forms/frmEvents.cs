using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenatinhaPlace.Forms
{
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Events;
            lblBack.Text = Strings.Back;
            mt1.Text = Strings.Add;
            mt2.Text = Strings.Query;
            mt3.Text = Strings.Edit;
            lblTitle.Text = Strings.Event_Query;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.Show();
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

        private void mt1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Event_Add;
        }

        private void mt3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Event_Edit;
        }

        private void mt2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Event_Query;

        }
    }
}
