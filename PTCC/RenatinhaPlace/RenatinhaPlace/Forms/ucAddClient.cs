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

namespace RenatinhaPlace.Forms
{
    public partial class ucAddClient : UserControl
    {
        public ucAddClient()
        {
            InitializeComponent();
        }

        private void ucAddClient_Load(object sender, EventArgs e)
        {
            lblCpfClient.Text = Strings.Cpf;
            lblNameClient.Text = Strings.Full_Name;
            lblRgClient.Text = Strings.Rg;
            lblTelClient.Text = Strings.Telephone;
            lblBirthClient.Text = Strings.Birth;
            lblSexClient.Text = Strings.Sex;
            mrbMale.Text = Strings.Male;
            mrbFemale.Text = Strings.Female;
            btnRegistrer.Text = Strings.Register;
            btnClear.Text = Strings.ClearFields;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCpfClient.Clear();
            txtNameClient.Clear();
            txtRgClient.Clear();
            txtTelClient.Clear();
            mrbMale.Checked = false;
            mrbFemale.Checked = false;

        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfRegister, Strings.Register, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

            }
        }


        //ARRUMAR
        private void mrbMale_CheckedChanged(object sender, EventArgs e)
        {
            //if (mrbMale.Checked)
            //{
            //    mrbFemale.Checked = false;
            //}
            //else
            //{
            //    mrbFemale.Checked = true;

            //}
        }

        //ARRUMAR
        private void mrbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if (mrbFemale.Checked)
            //{
            //    mrbMale.Checked = false;
            //}
            //else
            //{
            //    mrbMale.Checked = true;

            //}
        }
    }
}
