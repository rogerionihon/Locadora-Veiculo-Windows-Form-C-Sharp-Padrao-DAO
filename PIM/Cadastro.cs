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

        //abre cadastro de cliente
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.StartPosition = FormStartPosition.CenterScreen;
            cadastrocliente.Show();
        } // fecha o metodo

        //abre cadastro de carro
        private void btnAutomovel_Click(object sender, EventArgs e)
        {
            CadastroAutomovel cadastroautomovel = new CadastroAutomovel();
            cadastroautomovel.StartPosition = FormStartPosition.CenterScreen;
            cadastroautomovel.Show();
        } // fecha o metodo

        //Abre cadastro de funcionario
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastrofuncionario = new CadastroFuncionario();
            cadastrofuncionario.StartPosition = FormStartPosition.CenterScreen;
            cadastrofuncionario.Show();
        } // fecha o metodo

        //metodo que fecha o formulario
        private void BtnSairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
