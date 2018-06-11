using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUU_Project
{
    public partial class frmLogout : Form
    {
        public frmLogout()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrar Atualizar = new frmCadastrar();
            frmAtualizar Cadastrar = new frmAtualizar();
            frmConsultar Consultar = new frmConsultar();
            frmConfiguracoes Configuracoes = new frmConfiguracoes();
            frmMenu Menu = new frmMenu();
            frmSair Sair = new frmSair();
            frmFaixa Faixa = new frmFaixa();
            Atualizar.Close();
            Cadastrar.Close();
            Consultar.Close();
            Configuracoes.Close();
            Menu.Close();
            Faixa.Close();
            Sair.Close();
                      
            frmLogin Login = new frmLogin();
            Login.Show();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
