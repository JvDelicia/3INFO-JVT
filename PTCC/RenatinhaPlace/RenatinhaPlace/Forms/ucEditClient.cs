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

namespace RenatinhaPlace.Forms
{
    public partial class ucEditClient : UserControl
    {
        public int idcli;
        public string namecli;
        public ucEditClient()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (mcbFilterBy.SelectedIndex == 0)
            {
                idcli = int.Parse(txtFilter.Text);
                namecli = null;
            }
            if (mcbFilterBy.SelectedIndex == 1)
            {
                namecli = txtFilter.Text;
                idcli = 0;
            }

            ClientDAO cdao = new ClientDAO();
            var bindingList = new BindingList<Client>(cdao.Filter(idcli, namecli));
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

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClient cli = new frmClient();
            ucEditClient2 editcli = new ucEditClient2();
            editcli.txtCpfClient.Text = dgvClients.CurrentRow.Cells[0].Value.ToString();
            cli.ucEditClient1.Visible = false;
            cli.ucEditClient21.Visible = true;
        }
    }
}
