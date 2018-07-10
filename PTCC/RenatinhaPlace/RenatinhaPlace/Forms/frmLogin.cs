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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void frmLogin_Load(object sender, EventArgs e)
        {
            lblErro.Text = Strings.Incorrect_PassUser;
            lblVersion.Text = Strings.Version;
            txtUser.Focus();
            btnLogIn.Text = Strings.LoginButton;
            btnLogOut.Text = Strings.LogoutButton;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfLeave, Strings.QuestLeave, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                Application.Exit();
            } else {
                txtUser.Focus();
            }
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                btnLogIn_Click(sender, e);
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtPass.Text;
            if (usuario == "adm" && senha == "123")
            {
                this.Close();
                frmHome Menu = new frmHome();
                Menu.Show();
               // Menu.lblConectUser.Text = "Conectado: " + txtUser.Text;

            }
            else
            {
                lblErro.Visible = true;
                pbxBasePass.BackColor = Color.FromArgb(220, 0, 0);
                pbxBaseUser.BackColor = Color.FromArgb(220, 0, 0);

                txtUser.Focus();
                txtPass.Clear();
            }
        }


        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e) {
            if(txtUser.Text == "Username") {
                txtPass.ForeColor = Color.FromArgb(250, 250, 250);
                txtUser.Clear();
            }
        }

        private void txtUser_Leave(object sender, EventArgs e) {
            if(txtUser.Text == "" || txtUser.Text == null) {
                txtPass.ForeColor = Color.FromArgb(120, 120, 120);
                txtUser.Text = "Username";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e) {
            if (txtPass.Text == "Password") {
                txtPass.ForeColor = Color.FromArgb(250, 250, 250);
                txtPass.UseSystemPasswordChar = true;
                txtPass.Clear();
            }
        }

        private void txtPass_Leave(object sender, EventArgs e) {
            if (txtPass.Text == "" || txtPass.Text == null) {
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.FromArgb(120, 120, 120);
                txtPass.Text = "Password";
            }
        }
    }
}
