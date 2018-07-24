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
using RenatinhaPlace.Entity;
using RenatinhaPlace.DAO;

namespace RenatinhaPlace.Forms
{
    public partial class ucAddClient : UserControl
    {
        public string sexoption;
        public DateTime a;
        public string b;
        public string c;


        public ucAddClient()
        {
            InitializeComponent();
        }

        private void ucAddClient_Load(object sender, EventArgs e)
        {
            lblCpfClient.Text = Strings.Cpf;
            lblNameClient.Text = Strings.Full_Name;
            lblRgClient.Text = Strings.Rg;
            lblTelClient.Text = Strings.Cellphone;
            lblBirthClient.Text = Strings.Birth;
            lblSexClient.Text = Strings.Sex;
            rbMale.Text = Strings.Male;
            rbFemale.Text = Strings.Female;
            btnRegistrer.Text = Strings.Register;
            btnClear.Text = Strings.ClearFields;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCpfClient.Clear();
            txtNameClient.Clear();
            txtRgClient.Clear();
            txtTelClient.Clear();
            mdtBirthClient.Text = DateTime.Now.ToString();
            rbMale.Checked = false;
            rbFemale.Checked = false;

        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfRegister, Strings.Register, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                EntitiesContext context = new EntitiesContext();
                ClientDAO cdao = new ClientDAO();
                a = DateTime.Parse(mdtBirthClient.Text);
                b = a.ToString("dd/MM/yyyy");
                c = b.Substring(0, 10);
                
                if (rbMale.Checked)
                {
                    sexoption = rbMale.Text;
                }
                else
                {
                   sexoption = rbFemale.Text;

                }
                Client client = new Client()
                {

                    Cpf = txtCpfClient.Text,
                    Name = txtNameClient.Text,
                    Rg = txtRgClient.Text,
                    DueDt = DateTime.Parse(c),
                    Tel = txtTelClient.Text,
                    Sex = sexoption

                };
                cdao.Add(client);
                MetroMessageBox.Show(this, Strings.ClientRegistered, Strings.Registered, MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }


    }
}
