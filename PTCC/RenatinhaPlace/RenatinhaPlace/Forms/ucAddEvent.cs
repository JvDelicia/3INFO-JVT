using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using RenatinhaPlace.DAO;
using RenatinhaPlace.Entity;


namespace RenatinhaPlace.Forms
{
    public partial class ucAddEvent : UserControl
    {
        public DateTime aBeg;
        public string bBeg;
        public string cBeg;
        public DateTime aEnd;
        public string bEnd;
        public string cEnd;


        public ucAddEvent()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ucAddEvent_Load(object sender, EventArgs e)
        {
            lblNameEvent.Text = Strings.EventName;
            lblDescEvent.Text = Strings.Desc;
            lblArtEvent.Text = Strings.Artist;
            lblMenuEvent.Text = Strings.Menu;
            lblBeginEvent.Text = Strings.Date;
            lblEndEvent.Text = Strings.Time;
            btnRegistrer.Text = Strings.Register;
            btnClear.Text = Strings.ClearFields;

            ArtistDAO adao = new ArtistDAO();
            foreach (var a in adao.List())
            {
                mcbArtEvent.Items.Add(a.Id + " - " + a.Name);
            }

            MenuDAO mdao = new MenuDAO();
            foreach (var m in mdao.List())
            {
                mcbMenuEvent.Items.Add(m.Id + " - " + m.Name);

            }
        }

        private void lblNameEvent_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameEvent.Clear();
            txtDescEvent.Clear();
            mcbArtEvent.SelectedItem = "";
            mcbMenuEvent.SelectedItem = "";
            mdtDateBegin.Text = DateTime.Now.ToString();
            mdtDateEnd.Text = DateTime.Now.ToString();
            txtTimeBegin.Clear();
            txtTimeEnd.Clear();
            txtNameEvent.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfRegister, Strings.Register, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                EntitiesContext context = new EntitiesContext();
                EventDAO edao = new EventDAO();

                aBeg = DateTime.Parse(mdtDateBegin.Text);
                bBeg = aBeg.ToString("dd/MM/yyyy");
                cBeg = bBeg + " " + txtTimeBegin.Text;
                aEnd = DateTime.Parse(mdtDateEnd.Text);
                bEnd = aEnd.ToString("dd/MM/yyyy");
                cEnd = bEnd + " " + txtTimeEnd.Text;

                Event even = new Event()
                {
                    Name = txtNameEvent.Text,
                    Desc = txtDescEvent.Text,
                    TimeBegin = DateTime.Parse(cBeg),
                    TimeEnd = DateTime.Parse(cEnd),
                    ArtistId = int.Parse(mcbArtEvent.Text),
                    MenuId = int.Parse(mcbMenuEvent.Text)

                };
                edao.Add(even);
                MetroMessageBox.Show(this, Strings.SuccessRegistered, Strings.Registered, MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            }
        }


    }
}
