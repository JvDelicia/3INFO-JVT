using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RenatinhaPlace.DAO;
using RenatinhaPlace.Entity;
using MetroFramework;

namespace RenatinhaPlace.Forms
{

    public partial class NewAcc : UserControl
    {
        public string cpfcli;
        public string nameevent;
        public int idticket;




        public NewAcc()
        {
            InitializeComponent();
        }

        private void NewAcc_Load(object sender, EventArgs e)
        {
            txtClientAcc.Focus();

            ClientDAO cdao = new ClientDAO();
            var bindingList = new BindingList<Client>(cdao.List());
            var source = new BindingSource(bindingList, null);
            dgvClients.DataSource = source;
            dgvClients.Columns[0].HeaderText = "Client ID";
            dgvClients.Columns[1].HeaderText = "CPF";
            dgvClients.Columns[2].HeaderText = "Full Name";
            dgvClients.Columns[3].HeaderText = "Birth Date";
            dgvClients.Columns[4].HeaderText = "RG";
            dgvClients.Columns[5].HeaderText = "Sex";
            dgvClients.Columns[6].HeaderText = "Cell Phone";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cpfcli = txtClientAcc.Text.ToString();
            ClientDAO cdao = new ClientDAO();
            var bindingList = new BindingList<Client>(cdao.FindCpf(cpfcli));
            var source = new BindingSource(bindingList, null);
            dgvClients.DataSource = source;
            dgvClients.Columns[0].HeaderText = "Client ID";
            dgvClients.Columns[1].HeaderText = "CPF";
            dgvClients.Columns[2].HeaderText = "Full Name";
            dgvClients.Columns[3].HeaderText = "Birth Date";
            dgvClients.Columns[4].HeaderText = "RG";
            dgvClients.Columns[5].HeaderText = "Sex";
            dgvClients.Columns[6].HeaderText = "Cell Phone";
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            lblClientId.Text = dgvClients.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            nameevent = txtEvent.Text;
            TicketDAO tdao = new TicketDAO();
            var ticket = tdao.FindTicketByEvent(nameevent);
            foreach (var t in ticket)
            {
                mcbTicket.Items.Add(t.Id + "-" + t.Name);
            }
        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfRegister, Strings.Register, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                AccountDAO adao = new AccountDAO();

                //Tratamento da Combo Box Tickets
                TicketDAO tdao = new TicketDAO();
                idticket = tdao.FindIdByCb(mcbTicket.Text);

                Account account = new Account()
                {
                    ClientId = int.Parse(lblClientId.Text),
                    Status = "Ativo",
                    TicketId = idticket
                };
                adao.Add(account);
                MetroMessageBox.Show(this, Strings.SuccessRegistered, Strings.Registered, MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                this.Visible = false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientAcc.Text = "";
            lblClientId.Text =
            txtEvent.Text = "";
            mcbTicket.Items.Clear();
            txtClientAcc.Focus();

            ClientDAO cdao = new ClientDAO();
            var bindingList = new BindingList<Client>(cdao.List());
            var source = new BindingSource(bindingList, null);
            dgvClients.DataSource = source;
            dgvClients.Columns[0].HeaderText = "Client ID";
            dgvClients.Columns[1].HeaderText = "CPF";
            dgvClients.Columns[2].HeaderText = "Full Name";
            dgvClients.Columns[3].HeaderText = "Birth Date";
            dgvClients.Columns[4].HeaderText = "RG";
            dgvClients.Columns[5].HeaderText = "Sex";
            dgvClients.Columns[6].HeaderText = "Cell Phone";
        }


    }
}
