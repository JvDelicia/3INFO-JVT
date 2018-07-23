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

namespace RenatinhaPlace.Forms
{
    public partial class frmBar : Form
    {
        public frmBar()
        {
            InitializeComponent();
        }

        private void frmBar_Load(object sender, EventArgs e)
        {
            lblBack.Text = Strings.Back;
            lblTitle.Text = Strings.Bar;
        }

        private void frmBar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfLeave, Strings.QuestLeave, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
