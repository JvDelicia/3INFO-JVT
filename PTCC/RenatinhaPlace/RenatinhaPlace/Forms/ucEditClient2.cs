using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenatinhaPlace.Forms
{
    public partial class ucEditClient2 : UserControl
    {
        public ucEditClient2()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmClient cli = new frmClient();
            cli.ucEditClient21.Visible = false;
            cli.ucEditClient1.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


    }
}
