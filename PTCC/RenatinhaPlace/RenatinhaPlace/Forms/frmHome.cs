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
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            mt1.Text = Strings.Events;
            mt2.Text = Strings.Cashier;
            mt3.Text = Strings.Employees;
            mt4.Text = Strings.Clients;
            lblWelcome.Text = Strings.Welcome;
            Func user = new Func();
            lblConnectedUser.Text = Strings.ConnectedUser + " " +user.Name;
            this.Text = Strings.TitleSplah;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEvents events = new frmEvents();
            events.Show();

        }
        private void mt2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCashier cashier = new frmCashier();
            cashier.Show();
        }

        private void mt3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEmployees employees = new frmEmployees();
            employees.Show();
        }

        private void mt4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClients clients = new frmClients();
            clients.Show();
        }


    }
}
 