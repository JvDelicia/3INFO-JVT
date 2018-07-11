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

            }
            else
            {
                lblErro.Visible = true;
                pbxBasePass.BackColor = Color.FromArgb(220, 0, 0);
                pbxBaseUser.BackColor = Color.FromArgb(220, 0, 0);
                txtPass.Clear();
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.FromArgb(120, 120, 120);
                txtPass.Text = "Password";
                if (txtUser.Text == "Username")
                {
                    txtUser.Focus();
                }
                else
                {
                    txtPass.Focus();
                }

            }
        }


        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "Password")
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
        }

        private void txtUser_Enter(object sender, EventArgs e) {
            if(txtUser.Text == "Username") {
                txtUser.Clear();
                txtUser.ForeColor = Color.FromArgb(240, 240, 240);

            }
        }

        private void txtUser_Leave(object sender, EventArgs e) {
            if(txtUser.Text == "" || txtUser.Text == null) {
                txtUser.ForeColor = Color.FromArgb(120, 120, 120);
                txtUser.Text = "Username";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e) {
            if (txtPass.Text == "Password") {
                txtPass.Clear();
                txtPass.ForeColor = Color.FromArgb(240, 240, 240);
                txtPass.UseSystemPasswordChar = true;
 
            }
        }

        private void txtPass_Leave(object sender, EventArgs e) {
            if (txtPass.Text == "" || txtPass.Text == null) {
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.FromArgb(120, 120, 120);
                txtPass.Text = "Password";
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
