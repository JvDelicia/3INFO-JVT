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
    public partial class ucEditEvent2 : UserControl
    {
        public DateTime aBeg;
        public string bBeg;
        public string cBeg;
        public DateTime aEnd;
        public string bEnd;
        public string cEnd;
        public int idart;
        public int idmenu;
        public ucEditEvent2()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to delete this register?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                EventDAO edao = new EventDAO();
                Event eve = edao.FindId(global.ideve);
                edao.Remove(eve);
                MetroMessageBox.Show(this, "Register Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to update this register?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Tratamento das Datas
                EntitiesContext context = new EntitiesContext();
                EventDAO edao = new EventDAO();
                aBeg = DateTime.Parse(mdtDateBegin.Text);
                bBeg = aBeg.ToString("dd/MM/yyyy");
                cBeg = bBeg + " " + txtTimeBegin.Text;
                aEnd = DateTime.Parse(mdtDateEnd.Text);
                bEnd = aEnd.ToString("dd/MM/yyyy");
                cEnd = bEnd + " " + txtTimeEnd.Text;

                //Tratamento da Combo Box Artista
                ArtistDAO adao = new ArtistDAO();
                idart = adao.FindIdByCb(mcbArtEvent.Text);

                //Tratamento da Combo Box Menu
                MenuDAO mdao = new MenuDAO();
                idmenu = mdao.FindIdByCb(mcbMenuEvent.Text);

                Event eve = edao.FindId(global.ideve);
                eve.Name = txtNameEvent.Text;
                eve.Desc = txtDescEvent.Text;
                eve.TimeBegin = DateTime.Parse(cBeg);
                eve.TimeEnd = DateTime.Parse(cEnd);
                eve.ArtistId = idart;
                eve.MenuId = idmenu;
                edao.Update();
                MetroMessageBox.Show(this, "Register Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            }
        }
    }
}
