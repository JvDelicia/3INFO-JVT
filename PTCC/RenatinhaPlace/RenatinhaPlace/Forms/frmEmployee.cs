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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Employees;
            lblTitle.Text = Strings.Employees;
            lblBack.Text = Strings.Back;


        }

        private void pbxBack_Click(object sender, EventArgs e)
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.Show();
        }

        private void frmEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }
    }
}
