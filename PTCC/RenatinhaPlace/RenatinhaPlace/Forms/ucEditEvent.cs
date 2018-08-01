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
    public partial class ucEditEvent : UserControl
    {
        public int idevent;
        public string nameevent;
        public ucEditEvent()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (mcbFilterBy.SelectedIndex == 0)
            {
                idevent = int.Parse(txtFilter.Text);
                nameevent = null;
            }
            if (mcbFilterBy.SelectedIndex == 1)
            {
                nameevent = txtFilter.Text;
                idevent = 0;
            }

            EventDAO edao = new EventDAO();
            var bindingList = new BindingList<Event>(edao.Filter(idevent, nameevent));
            var source = new BindingSource(bindingList, null);
            dgvEvents.DataSource = source;
            dgvEvents.Columns.Remove("Artist");
            dgvEvents.Columns.Remove("Menu");
            dgvEvents.Columns.Remove("Tickets");
            dgvEvents.Columns[0].HeaderText = "Event ID";
            dgvEvents.Columns[1].HeaderText = "Name";
            dgvEvents.Columns[2].HeaderText = "Description";
            dgvEvents.Columns[3].HeaderText = "Begin";
            dgvEvents.Columns[4].HeaderText = "End";
            dgvEvents.Columns[5].HeaderText = "Artist ID";
            dgvEvents.Columns[6].HeaderText = "Menu ID";
        }

        private void dgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            global.ideve = int.Parse(dgvEvents.CurrentRow.Cells[0].Value.ToString());
            global.nameeve = dgvEvents.CurrentRow.Cells[1].Value.ToString();
            global.desceve = dgvEvents.CurrentRow.Cells[2].Value.ToString();
            global.begineve = dgvEvents.CurrentRow.Cells[3].Value.ToString();
            global.endeve = dgvEvents.CurrentRow.Cells[4].Value.ToString();
            global.idarteve = dgvEvents.CurrentRow.Cells[5].Value.ToString();
            global.idmenueve = dgvEvents.CurrentRow.Cells[6].Value.ToString();
            this.Visible = false;

        }


    }
}
