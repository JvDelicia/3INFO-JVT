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
    public partial class frmCashier : Form
    {
        public frmCashier()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {
            this.Text = Strings.Cashier;
        }
    }
}
