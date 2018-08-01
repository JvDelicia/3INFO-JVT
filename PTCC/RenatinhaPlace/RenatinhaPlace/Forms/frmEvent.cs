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
    public partial class frmEvent : Form
    {
        public string subdatebegin;
        public string subdateend;
        public string subtimebegin1;
        public string subtimebegin2;
        public string subtimebeginf;
        public string subtimeend1;
        public string subtimeend2;
        public string subtimeendf;
        public string art;
        public string men;




        public string subtimeend;


        public frmEvent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Events;
            lblBack.Text = Strings.Back;
            mt1.Text = Strings.Add;
            mt2.Text = Strings.Query;
            mt3.Text = Strings.Edit;
            lblTitle.Text = Strings.Event_Query;

            ucQueryEvent1.Visible = true;

            EventDAO edao = new EventDAO();
            var bindingList = new BindingList<Event>(edao.List());
            var source = new BindingSource(bindingList, null);
            ucQueryEvent1.dgvEvents.DataSource = source;
            ucQueryEvent1.dgvEvents.Columns.Remove("Artist");
            ucQueryEvent1.dgvEvents.Columns.Remove("Menu");
            ucQueryEvent1.dgvEvents.Columns.Remove("Tickets");
            ucQueryEvent1.dgvEvents.Columns[0].HeaderText = "Event ID";
            ucQueryEvent1.dgvEvents.Columns[1].HeaderText = "Name";
            ucQueryEvent1.dgvEvents.Columns[2].HeaderText = "Description";
            ucQueryEvent1.dgvEvents.Columns[3].HeaderText = "Begin";
            ucQueryEvent1.dgvEvents.Columns[4].HeaderText = "End";
            ucQueryEvent1.dgvEvents.Columns[5].HeaderText = "Artist ID";
            ucQueryEvent1.dgvEvents.Columns[6].HeaderText = "Menu ID";

            ucEditEvent1.dgvEvents.DataSource = source;
            ucEditEvent1.dgvEvents.Columns.Remove("Artist");
            ucEditEvent1.dgvEvents.Columns.Remove("Menu");
            ucEditEvent1.dgvEvents.Columns.Remove("Tickets");
            ucEditEvent1.dgvEvents.Columns[0].HeaderText = "Event ID";
            ucEditEvent1.dgvEvents.Columns[1].HeaderText = "Name";
            ucEditEvent1.dgvEvents.Columns[2].HeaderText = "Description";
            ucEditEvent1.dgvEvents.Columns[3].HeaderText = "Begin";
            ucEditEvent1.dgvEvents.Columns[4].HeaderText = "End";
            ucEditEvent1.dgvEvents.Columns[5].HeaderText = "Artist ID";
            ucEditEvent1.dgvEvents.Columns[6].HeaderText = "Menu ID";


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome h = new frmHome();
            h.Show();
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

        private void mt1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Event_Add;
            ucAddEvent1.Visible = true;
            ucQueryEvent1.Visible = false;
            ucAddEvent1.txtNameEvent.Focus();
            ucEditEvent1.Visible = false;

        }

        private void mt3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Event_Edit;
            ucAddEvent1.Visible = false;
            ucQueryEvent1.Visible = false;
            ucEditEvent1.Visible = true;
            ucEditEvent21.Visible = false;


            EventDAO edao = new EventDAO();
            var bindingList = new BindingList<Event>(edao.List());
            var source = new BindingSource(bindingList, null);
            ucEditEvent1.dgvEvents.DataSource = source;
            ucEditEvent1.dgvEvents.Columns.Remove("Artist");
            ucEditEvent1.dgvEvents.Columns.Remove("Menu");
            ucEditEvent1.dgvEvents.Columns.Remove("Tickets");
            ucEditEvent1.dgvEvents.Columns[0].HeaderText = "Event ID";
            ucEditEvent1.dgvEvents.Columns[1].HeaderText = "Name";
            ucEditEvent1.dgvEvents.Columns[2].HeaderText = "Description";
            ucEditEvent1.dgvEvents.Columns[3].HeaderText = "Begin";
            ucEditEvent1.dgvEvents.Columns[4].HeaderText = "End";
            ucEditEvent1.dgvEvents.Columns[5].HeaderText = "Artist ID";
            ucEditEvent1.dgvEvents.Columns[6].HeaderText = "Menu ID";

        }

        private void mt2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Strings.Event_Query;
            ucAddEvent1.Visible = false;
            ucQueryEvent1.Visible = true;
            ucEditEvent1.Visible = false;

            EventDAO edao = new EventDAO();
            var bindingList = new BindingList<Event>(edao.List());
            var source = new BindingSource(bindingList, null);
            ucQueryEvent1.dgvEvents.DataSource = source;
            ucQueryEvent1.dgvEvents.Columns.Remove("Artist");
            ucQueryEvent1.dgvEvents.Columns.Remove("Menu");
            ucQueryEvent1.dgvEvents.Columns.Remove("Tickets");
            ucQueryEvent1.dgvEvents.Columns[0].HeaderText = "Event ID";
            ucQueryEvent1.dgvEvents.Columns[1].HeaderText = "Name";
            ucQueryEvent1.dgvEvents.Columns[2].HeaderText = "Description";
            ucQueryEvent1.dgvEvents.Columns[3].HeaderText = "Begin";
            ucQueryEvent1.dgvEvents.Columns[4].HeaderText = "End";
            ucQueryEvent1.dgvEvents.Columns[5].HeaderText = "Artist ID";
            ucQueryEvent1.dgvEvents.Columns[6].HeaderText = "Menu ID";

        }


        private void frmEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();

        }

        private void ucEditEvent1_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                ucEditEvent21.Visible = true;

                ucEditEvent21.mcbArtEvent.Items.Clear();
                ucEditEvent21.mcbMenuEvent.Items.Clear();

                ArtistDAO adao = new ArtistDAO();
                foreach (var a in adao.List())
                {
                    ucEditEvent21.mcbArtEvent.Items.Add(a.Id + "-" + a.Name);
                }
                Artist artista = adao.FindId(int.Parse(global.idarteve));
                art = artista.Id.ToString() + "-" + artista.Name.ToString();

                MenuDAO mdao = new MenuDAO();
                foreach (var m in mdao.List())
                {
                    ucEditEvent21.mcbMenuEvent.Items.Add(m.Id + "-" + m.Name);

                }
                Entity.Menu menu = mdao.FindId(int.Parse(global.idmenueve));
                men = menu.Id.ToString() + "-" + menu.Name.ToString();


                subdatebegin = global.begineve.Substring(0, 10);
                subdateend = global.endeve.Substring(0, 10);
                subtimebegin1 = global.begineve.Substring(11, 2);
                subtimebegin2 = global.begineve.Substring(13, 3);
                subtimebeginf = subtimebegin1 + subtimebegin2;
                subtimeend1 = global.endeve.Substring(11, 2);
                subtimeend2 = global.endeve.Substring(13, 3);
                subtimeendf = subtimeend1 + subtimeend2;

                ucEditEvent21.txtNameEvent.Text = global.nameeve;
                ucEditEvent21.txtDescEvent.Text = global.desceve;
                ucEditEvent21.mdtDateBegin.Text = subdatebegin;
                ucEditEvent21.mdtDateEnd.Text = subdateend;
                ucEditEvent21.txtTimeBegin.Text = subtimebeginf;
                ucEditEvent21.txtTimeEnd.Text = subtimeendf;
                ucEditEvent21.mcbArtEvent.SelectedItem = art;
                ucEditEvent21.mcbMenuEvent.SelectedItem = men;


            }
            catch (NullReferenceException)
            {
                ucEditEvent21.Visible = false;
            }
            catch (ArgumentNullException)
            {
                ucEditEvent21.Visible = false;
            }


        }
    }
}
