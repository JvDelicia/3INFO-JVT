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
        public string cpfcli;
        public string nameevent;
        public int idticket;
        public int idprod;
        public string nameprod;
        public int prodacc;
        public int idprodia;
        public int idaccia;
        public int amount;
        public decimal total;

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
            panelAddAcc.Visible = false;
            lblTitle.Visible = true;
            lblTitle2.Visible = true;
            lblTitle3.Visible = false;

            ProdDAO pdao = new ProdDAO();
            idacc = 0;
            var bindinglist = pdao.FindProdsByAccount(idacc);
            var source = new BindingSource(bindinglist, null);
            dgvItemMenu.DataSource = source;
            dgvItemMenu.Columns.Remove("ItemMenus");
            dgvItemMenu.Columns.Remove("ItemAccs");
            dgvItemMenu.Columns[0].HeaderText = "Product ID";
            dgvItemMenu.Columns[1].HeaderText = "Name";
            dgvItemMenu.Columns[2].HeaderText = "Description";
            dgvItemMenu.Columns[3].HeaderText = "Unit Price";

            cpfcli = "";
            ClientDAO cdao = new ClientDAO();
            var bindingList2 = new BindingList<Client>(cdao.FindCpf(cpfcli));
            var source2 = new BindingSource(bindingList2, null);
            dgvClients.DataSource = source2;
            dgvClients.Columns[0].HeaderText = "Client ID";
            dgvClients.Columns[1].HeaderText = "CPF";
            dgvClients.Columns[2].HeaderText = "Full Name";
            dgvClients.Columns[3].HeaderText = "Birth Date";
            dgvClients.Columns[4].HeaderText = "RG";
            dgvClients.Columns[5].HeaderText = "Sex";
            dgvClients.Columns[6].HeaderText = "Cell Phone";

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
            try
            {
                ProdDAO pdao = new ProdDAO();
                idacc = int.Parse(txtEnterAccount.Text);
                var bindinglist3 = pdao.FindProdsByAccount(idacc);
                var source3 = new BindingSource(bindinglist3, null);
                dgvItemMenu.DataSource = source3;
                dgvItemMenu.Columns.Remove("ItemMenus");
                dgvItemMenu.Columns.Remove("ItemAccs");
                dgvItemMenu.Columns[0].HeaderText = "Product ID";
                dgvItemMenu.Columns[1].HeaderText = "Name";
                dgvItemMenu.Columns[2].HeaderText = "Description";
                dgvItemMenu.Columns[3].HeaderText = "Unit Price";

                EntitiesContext context = new EntitiesContext();
                var busca = from p in context.Products
                            join ia in context.ItemAccs on p.Id equals ia.ProductId
                            join a in context.Accounts on ia.AccountId equals a.Id
                            join c in context.Clients on a.ClientId equals c.Id
                            where ia.AccountId == idacc
                            select new
                            {
                                productid = p.Id,
                                productname = p.Name,
                                qnt = ia.Qnt
                            };
                var source9 = new BindingSource(busca.ToList(), null);
                dgvAccount.DataSource = source9;

                dgvAccount.Columns[0].HeaderText = "Product ID";
                dgvAccount.Columns[1].HeaderText = "Product Name";
                dgvAccount.Columns[2].HeaderText = "Amount";


                //INFORMAÇÕES SOBRE O CLIENTE
                var infocli = from c in context.Clients
                            join a in context.Accounts on c.Id equals a.ClientId
                            join t in context.Tickets on a.TicketId equals t.Id
                            where a.Id == idacc
                            select new
                            {
                                client = c.Name,
                                ticket = t.Name
                            };

                foreach (var c in infocli)
                {
                    lblData1.Text = idacc.ToString();
                    lblbData2.Text = c.client;
                    lblData3.Text = c.ticket;

                }
            }

            catch (FormatException)
            {
                if (MetroMessageBox.Show(this, "This account does not exist. Would you like to open a new account?", "Account Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    panelAddAcc.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                if (MetroMessageBox.Show(this, "This account does not exist. Would you like to open a new account?", "Account Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    panelAddAcc.Visible = true;

                }

            }
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
            panelAddAcc.Visible = true;
            lblTitle.Visible = false;
            lblTitle2.Visible = false;
            lblTitle3.Visible = true;
        }

        private void btnSerach2_Click(object sender, EventArgs e)
        {
            cpfcli = txtClientAcc.Text.ToString();
            ClientDAO cdao = new ClientDAO();
            var bindingList4 = new BindingList<Client>(cdao.FindCpf(cpfcli));
            var source4 = new BindingSource(bindingList4, null);
            dgvClients.DataSource = source4;
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

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            mcbTicket.Items.Clear();
            nameevent = txtEvent.Text;
            TicketDAO tdao = new TicketDAO();
            var ticket = tdao.FindTicketByEvent(nameevent);
            foreach (var t in ticket)
            {
                mcbTicket.Items.Add(t.Id + "-" + t.Name);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientAcc.Text = "";
            lblClientId.Text =
            txtEvent.Text = "";
            cpfcli = "";
            mcbTicket.Items.Clear();
            txtClientAcc.Focus();


            ClientDAO cdao = new ClientDAO();
            var bindingList5 = new BindingList<Client>(cdao.FindCpf(cpfcli));
            var source5 = new BindingSource(bindingList5, null);
            dgvClients.DataSource = source5;
            dgvClients.Columns[0].HeaderText = "Client ID";
            dgvClients.Columns[1].HeaderText = "CPF";
            dgvClients.Columns[2].HeaderText = "Full Name";
            dgvClients.Columns[3].HeaderText = "Birth Date";
            dgvClients.Columns[4].HeaderText = "RG";
            dgvClients.Columns[5].HeaderText = "Sex";
            dgvClients.Columns[6].HeaderText = "Cell Phone";
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
                txtEnterAccount.Text = lblClientId.Text;
                btnSearch_Click(sender,e);
                panelAddAcc.Visible = false;
                lblTitle.Visible = true;
                lblTitle2.Visible = true;
                lblTitle3.Visible = false;


            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (mcbFilterBy.SelectedIndex == 0)
                {
                    idprod = int.Parse(txtFilterProd.Text);
                    nameprod = null;
                }
                if (mcbFilterBy.SelectedIndex == 1)
                {
                    nameprod = txtFilterProd.Text;
                    idprod = 0;
                }

                ProdDAO pdao = new ProdDAO(); ;
                var bindinglist6 = pdao.Filter(idacc, idprod, nameprod);
                var source6 = new BindingSource(bindinglist6, null);
                dgvItemMenu.DataSource = source6;
                dgvItemMenu.Columns.Remove("ItemMenus");
                dgvItemMenu.Columns.Remove("ItemAccs");
                dgvItemMenu.Columns[0].HeaderText = "Product ID";
                dgvItemMenu.Columns[1].HeaderText = "Name";
                dgvItemMenu.Columns[2].HeaderText = "Description";
                dgvItemMenu.Columns[3].HeaderText = "Unit Price";
            }
            catch (FormatException)
            {
                ProdDAO pdao = new ProdDAO();
                if (idacc == 0) { }
                else
                {
                    var bindinglist7 = pdao.FindProdsByAccount(idacc);
                    var source7 = new BindingSource(bindinglist7, null);
                    dgvItemMenu.DataSource = source7;
                    dgvItemMenu.Columns.Remove("ItemMenus");
                    dgvItemMenu.Columns.Remove("ItemAccs");
                    dgvItemMenu.Columns[0].HeaderText = "Product ID";
                    dgvItemMenu.Columns[1].HeaderText = "Name";
                    dgvItemMenu.Columns[2].HeaderText = "Description";
                    dgvItemMenu.Columns[3].HeaderText = "Unit Price";
                }

            }

        }

        private void btnaddProd_Click(object sender, EventArgs e)
        {
            prodacc = int.Parse(dgvItemMenu.CurrentRow.Cells[0].Value.ToString());
            ItemAccDAO iadao = new ItemAccDAO();
            ItemAcc itemacc = new ItemAcc()
            {
                ProductId = prodacc,
                AccountId = idacc,
                Qnt = 1
            };
            iadao.Add(itemacc);

            EntitiesContext context = new EntitiesContext();
            var busca = from p in context.Products
                        join ia in context.ItemAccs on p.Id equals ia.ProductId
                        join a in context.Accounts on ia.AccountId equals a.Id
                        join c in context.Clients on a.ClientId equals c.Id
                        where ia.AccountId == idacc
                        select new
                        {
                            productid = p.Id,
                            productname = p.Name,
                            qnt = ia.Qnt
                        };
            var source9 = new BindingSource(busca.ToList(), null);
            dgvAccount.DataSource = source9;

            dgvAccount.Columns[0].HeaderText = "Product ID";
            dgvAccount.Columns[1].HeaderText = "Product Name";
            dgvAccount.Columns[2].HeaderText = "Amount";
        }

        private void panelAccData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccData_Click(object sender, EventArgs e)
        {
            panelAccData.Visible = true;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            panelAccData.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAddAcc.Visible = false;
        }

        private void btnRemoveProd_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to delete this register?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                idprodia = int.Parse(dgvAccount.CurrentRow.Cells[0].Value.ToString());
                ItemAccDAO iadao = new ItemAccDAO();
                var items  = iadao.SearchItemAcc(idacc,idprodia);
                iadao.Remove(items);

                EntitiesContext context = new EntitiesContext();
                var busca = from p in context.Products
                            join ia in context.ItemAccs on p.Id equals ia.ProductId
                            join a in context.Accounts on ia.AccountId equals a.Id
                            join c in context.Clients on a.ClientId equals c.Id
                            where ia.AccountId == idacc
                            select new
                            {
                                productid = p.Id,
                                productname = p.Name,
                                qnt = ia.Qnt
                            };
                var source9 = new BindingSource(busca.ToList(), null);
                dgvAccount.DataSource = source9;

                dgvAccount.Columns[0].HeaderText = "Product ID";
                dgvAccount.Columns[1].HeaderText = "Product Name";
                dgvAccount.Columns[2].HeaderText = "Amount";
            }

        }

        private void btnFilter2_Click(object sender, EventArgs e)
        {
            amount = int.Parse(txtAmount.Text);
            
            ItemAccDAO iadao = new ItemAccDAO();
            
            var items = iadao.SearchItemAcc(idacc,idprodia);
            items.Qnt = amount;
            iadao.Update();
            idprodia = 0;
            txtAmount.Clear();

            EntitiesContext context = new EntitiesContext();
            var busca = from p in context.Products
                        join ia in context.ItemAccs on p.Id equals ia.ProductId
                        join a in context.Accounts on ia.AccountId equals a.Id
                        join c in context.Clients on a.ClientId equals c.Id
                        where ia.AccountId == idacc
                        select new
                        {
                            productid = p.Id,
                            productname = p.Name,
                            qnt = ia.Qnt
                        };
            var source9 = new BindingSource(busca.ToList(), null);
            dgvAccount.DataSource = source9;

            dgvAccount.Columns[0].HeaderText = "Product ID";
            dgvAccount.Columns[1].HeaderText = "Product Name";
            dgvAccount.Columns[2].HeaderText = "Amount";
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAmount.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            idprodia = int.Parse(dgvAccount.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnFinalizeAcc_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to finalize this Account?", "Finalize Account", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                EntitiesContext context = new EntitiesContext();

                AccountDAO adao = new AccountDAO();
                ItemAccDAO iadao = new ItemAccDAO();
                ProdDAO pdao = new ProdDAO();

                var busca = from ia in context.ItemAccs
                            join p in context.Products on ia.ProductId equals p.Id
                            where ia.AccountId == idacc
                            select new
                            {
                                Qnt = ia.Qnt,
                                Price = p.PriceUni
                            };

                decimal total = 0;

                foreach(var i in busca)
                {
                        total = total + (i.Qnt * i.Price);
                }
                
                global.final = total;

                frmFinalizeAcc facc = new frmFinalizeAcc();
                facc.Show();
            }

        }

    }
}
