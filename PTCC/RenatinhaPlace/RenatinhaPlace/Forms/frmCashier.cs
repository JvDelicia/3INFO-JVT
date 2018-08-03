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
using RenatinhaPlace.DAO;
using RenatinhaPlace.Entity;


namespace RenatinhaPlace.Forms
{
    public partial class frmCashier : Form
    {
        public int idacc;
        public frmCashier()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Cashier;
            lblBack.Text = Strings.Back;
            txtEnterAccount.Focus();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void frmCashier_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProdDAO pdao = new ProdDAO();
            idacc = int.Parse(txtEnterAccount.Text);
            var accprodsbusca = pdao.FindProdsByAccount(idacc);
            if(accprodsbusca == null)
            {
                if (MetroMessageBox.Show(this, "This account does not exist. Would you like to open a new account?", "Account Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                }

            }

            var source = new BindingSource(accprodsbusca, null);
            dgvItemMenu.DataSource = source;
            dgvItemMenu.Columns.Remove("ItemMenus");
            dgvItemMenu.Columns.Remove("ItemAccs");
            dgvItemMenu.Columns[0].HeaderText = "Product ID";
            dgvItemMenu.Columns[1].HeaderText = "Name";
            dgvItemMenu.Columns[2].HeaderText = "Description";
            dgvItemMenu.Columns[3].HeaderText = "Unit Price";
     


        }

        private void txtEnterAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSearch_Click(sender, e);
            }

        }

        private void btnOpenAcc_Click(object sender, EventArgs e)
        {
            //ucAddAccount1.Visible = true;
        }
    }
}
