﻿using System;
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
using RenatinhaPlace.DAO;

namespace RenatinhaPlace.Forms
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Clients;
            lblTitle.Text = Strings.Clients;
            lblBack.Text = Strings.Back;
            mt1.Text = Strings.Add;
            mt2.Text = Strings.Query;
            mt3.Text = Strings.Edit;

            lblTitle.Text = Strings.Client_Query;
            ucAddClient1.Visible = false;
            ClientDAO clients = new ClientDAO();
            var bindingList = new BindingList<Client>(clients.List());
            var source = new BindingSource(bindingList, null);
            ucQueryClient1.dgvClients.DataSource = source;
            ucQueryClient1.dgvClients.Columns[0].HeaderText = "Client ID";
            ucQueryClient1.dgvClients.Columns[1].HeaderText = "CPF";
            ucQueryClient1.dgvClients.Columns[2].HeaderText = "Full Name";
            ucQueryClient1.dgvClients.Columns[3].HeaderText = "Birth Date";
            ucQueryClient1.dgvClients.Columns[4].HeaderText = "RG";
            ucQueryClient1.dgvClients.Columns[5].HeaderText = "Sex";
            ucQueryClient1.dgvClients.Columns[6].HeaderText = "Cell Phone";




            ucQueryClient1.Visible = true;


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

        private void frmClients_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void mt1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Client_Add;
            ucAddClient1.Visible = true;
            ucAddClient1.txtCpfClient.Focus();
            ucQueryClient1.Visible = false;

        }

        private void mt2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Client_Query;
            ucAddClient1.Visible = false;
            ClientDAO clients = new ClientDAO();
            var bindingList = new BindingList<Client>(clients.List());
            var source = new BindingSource(bindingList, null);
            ucQueryClient1.dgvClients.DataSource = source;
            ucQueryClient1.Visible = true;


        }

        private void mt3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Client_Edit;
            ucAddClient1.Visible = false;
            ucQueryClient1.Visible = false;

        }

        private void ucAddClient1_Load(object sender, EventArgs e)
        {

        }

        private void ucQueryClient1_Load(object sender, EventArgs e)
        {

        }
    }
}
