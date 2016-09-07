using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        //Abre cadastro de cliente
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.StartPosition = FormStartPosition.CenterScreen;
            cadastrocliente.Show();
        }

        //Abre cadastro de carro
        private void btnAutomovel_Click(object sender, EventArgs e)
        {
            CadastroAutomovel cadastroautomovel = new CadastroAutomovel();
            cadastroautomovel.StartPosition = FormStartPosition.CenterScreen;
            cadastroautomovel.Show();
        }

        //Abre cadastro de funcionario
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastrofuncionario = new CadastroFuncionario();
            cadastrofuncionario.StartPosition = FormStartPosition.CenterScreen;
            cadastrofuncionario.Show();
        }

        //sair do cadastro
        private void BtnSairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
