using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.Forms
{
    public partial class ucQueryClient : UserControl
    {
        public ucQueryClient()
        {
            InitializeComponent();
        }

        private void ucQueryClient_Load(object sender, EventArgs e)
        {
            ClientDAO clients = new ClientDAO();
            BindingSource bi = new BindingSource();
            var bindingList = new BindingList<Client>(clients.List());
            var source = new BindingSource(bindingList, null);
            bi.DataSource = source;
            //foreach ( var p in clients.List())
            //{
            //    dgvClients. = p.Name
            //}
        }

    }
}
