using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUU_Project
{
    public partial class frmLogin : Form
    {     
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtPass.Text;
            if (usuario == "adm" && senha == "123")
            {       
                this.Hide();
                //frmMenu Menu = new frmMenu();
               // Menu.Show();
                //Menu.lblConectUser.Text = "Conectado: " + txtUser.Text;
        
    }
            else
            {
                lblErro.Visible = true;
                pbxBasePass.BackColor = Color.FromArgb(255, 0, 0);
                pbxBaseUser.BackColor = Color.FromArgb(255, 0, 0);

                txtUser.Focus();
                txtPass.Clear();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //frmSair Sair = new frmSair();
            //Sair.Show();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }
          
        }
     
        private void btnLogout_Click(object sender, EventArgs e)
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
}
