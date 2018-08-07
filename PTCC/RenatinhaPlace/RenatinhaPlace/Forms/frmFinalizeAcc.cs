using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenatinhaPlace.Forms
{
    public partial class frmFinalizeAcc : Form
    {
        public frmFinalizeAcc()
        {
            InitializeComponent();
        }

        private void frmFinalizeAcc_Load(object sender, EventArgs e)
        {
            lblFinalValue.Text = global.final.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
