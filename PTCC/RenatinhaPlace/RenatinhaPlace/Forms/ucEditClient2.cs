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
    public partial class ucEditClient2 : UserControl
    {
        public string sexoption;
        public DateTime a;
        public string b;

        public ucEditClient2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to update this register?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                EntitiesContext context = new EntitiesContext();
                ClientDAO cdao = new ClientDAO();
                a = DateTime.Parse(mdtBirthClient.Text);
                b = a.ToString("dd/MM/yyyy");

                if (rbMale.Checked)
                {
                    sexoption = rbMale.Text;
                }
                else
                {
                    sexoption = rbFemale.Text;

                }
                Client client = cdao.FindId(global.idcli);
                client.Cpf = txtCpfClient.Text;
                client.Name = txtNameClient.Text;
                client.Rg = txtRgClient.Text;
                client.BirthDt = DateTime.Parse(b);
                client.Tel = txtTelClient.Text;
                client.Sex = sexoption;
                cdao.Update();
                MetroMessageBox.Show(this, "Register Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to delete this register?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ClientDAO cdao = new ClientDAO();
                Client client = cdao.FindId(global.idcli);
                cdao.Remove(client);
                MetroMessageBox.Show(this, "Register Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }



        }
    }
}
