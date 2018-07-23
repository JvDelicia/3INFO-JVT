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
using RenatinhaPlace.Entity;


namespace RenatinhaPlace.Forms
{
    public partial class frmHome: Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            mt1.Text = Strings.Events;
            mt2.Text = Strings.Cashier;
            mt3.Text = Strings.Employees;
            mt4.Text = Strings.Clients;
            mt5.Text = Strings.Artist;
            mt6.Text = Strings.Bar;
            lblWelcome.Text = Strings.Welcome;
            Func user = new Func();
            lblConnectedUser.Text = Strings.ConnectedUser + " " +user.Name;
            this.Text = Strings.TitleSplah;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEvent eve = new frmEvent();
            eve.Show();

        }
        private void mt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCashier cashier = new frmCashier();
            cashier.Show();
        }

        private void mt3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee employees = new frmEmployee();
            employees.Show();
        }

        private void mt4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient clients = new frmClient();
            clients.Show();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfLeave, Strings.QuestLeave, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
 