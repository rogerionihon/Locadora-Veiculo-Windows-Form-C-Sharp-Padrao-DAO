using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CdbDao.ConnectionDataBase;
using CdbDao.ModelCliente;
using CdbDao.Service;

namespace PIM
{
    public partial class FrmLogin : Form
    {

        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Funcionario funcionario = new Funcionario(); // criacao do objeto do tipo Funcionario

        Validacao validacao = new Validacao(); // criacao do objeto do tipo validacao

        frmMenu menu = new frmMenu(); // criacao da instancia do menu
        public FrmLogin()
        {
            InitializeComponent();
        }

        // metodo que fecha o sistema
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja Sair do Sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        // metodo que recebe o login e senha para acessar aplicacao
        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                bool erro = false;
                funcionario.login = txtLogin.Text.ToString();
                funcionario.senha = txtSenha.Text.ToString();

                if (string.IsNullOrEmpty(txtLogin.Text)) // valida campo login
                {
                    erro = true;
                    MessageBox.Show(" O login deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validacao.isLimitCaract(txtLogin.Text, 5, 10)) { }
                else
                {
                    erro = true;
                    MessageBox.Show(" O login deve conter de 5 a 10 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao login

                if (string.IsNullOrEmpty(txtSenha.Text)) // valida campo senha
                {
                    erro = true;
                    MessageBox.Show(" A senha deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validacao.isLimitCaract(txtSenha.Text, 5, 10)) { }
                else
                {
                    erro = true;
                    MessageBox.Show(" A senha deve conter de 5 a 10 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao senha

                if (!erro)
                {
                    if (Cdb.Login(funcionario)) // verifica se os dados sao persistente na base de dados
                    {
                        this.Hide();
                        menu.Show(); // abre a aplicacao
                    }
                    else
                    {
                        MessageBox.Show("Usuario nao encontrado!");
                    }
                    
                } // fecha o if !erro
            } // fecha o try
            catch (Exception )
            {
                MessageBox.Show("Nao foi possivel efetuar o login, verifique os campos e tente novamente: ", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // exibe a mensagem caso nao seja possivel realizar o login  
            }
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
