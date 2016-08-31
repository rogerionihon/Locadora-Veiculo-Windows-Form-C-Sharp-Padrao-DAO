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

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            //Abre cadastro de cliente
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.StartPosition = FormStartPosition.CenterScreen;
            cadastrocliente.Show();
        }

        private void btnAutomovel_Click(object sender, EventArgs e)
        {
            //Abre cadastro de carro
            CadastroAutomovel cadastroautomovel = new CadastroAutomovel();
            cadastroautomovel.StartPosition = FormStartPosition.CenterScreen;
            cadastroautomovel.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            //Abre cadastro de funcionario
            CadastroFuncionario cadastrofuncionario = new CadastroFuncionario();
            cadastrofuncionario.StartPosition = FormStartPosition.CenterScreen;
            cadastrofuncionario.Show();
        }

        private void BtnSairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
