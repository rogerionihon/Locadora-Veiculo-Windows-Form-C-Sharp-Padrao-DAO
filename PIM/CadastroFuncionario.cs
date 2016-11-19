using CdbDao.ConnectionDataBase;
using CdbDao.ModelCliente;
using CdbDao.Service;
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
    public partial class CadastroFuncionario : Form
    {
        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Funcionario funcionario = new Funcionario(); // criacao do objeto do tipo funcionario

        Validacao validar = new Validacao(); // criacao do objeto do tipo validacao
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        //metodo para sair do formulario
        private void BtnCancelaFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //metodo para limpar os campos preenchidos
        public void LimparCampos()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
            mskCpf.Text = "";
            mskTel.Text = "";
            mskCel.Text = "";            
        }

        // metodo para limpar os campos do formulario
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // metodo que se carrega ao abrir o formulario
        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = Convert.ToString(DateTime.Now);
        }

        // metodo que recebe os dados do formulario preenchido
        public void ReceberDados()
        {
            try
            {
                    bool erro = false;
 
                    funcionario.nome = txtNome.Text.ToString();
                    funcionario.cpf = mskCpf.Text.ToString();
                    funcionario.login = txtLogin.Text.ToString();
                    funcionario.senha = txtSenha.Text.ToString();
                    funcionario.confirmarSenha = txtConfirmaSenha.Text.ToString();
                    funcionario.dataCadastro = DateTime.Parse(mskDataCadastro.Text.ToString());
                    funcionario.email = txtEmail.Text.ToString();
                    funcionario.telefone = mskTel.Text.ToString();
                    funcionario.celular = mskCel.Text.ToString();        

                    if (string.IsNullOrEmpty(txtNome.Text)) // valida campo nome
                    {
                        erro = true;
                        MessageBox.Show("O nome deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.isLimitCaract(txtNome.Text, 5, 45)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O nome deve conter no minimo 5 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao nome

                    if (string.IsNullOrEmpty(txtEmail.Text)) // valida campo email
                    {
                        erro = true;
                        MessageBox.Show("O email deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } 
                    else if (validar.ValidarEmail(txtEmail.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O email informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao de email

                    
                    if (string.IsNullOrEmpty(mskTel.Text)) // valida campo telefone
                    {
                        erro = true;
                        MessageBox.Show("O numero do telefone deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidaTelefone(mskTel.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do telefone informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do telefone

                    if (string.IsNullOrEmpty(mskCel.Text)) // valida campo celular
                    {
                        erro = true;
                        MessageBox.Show("O numero do celular deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidarCelular(mskCel.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do celular informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do celular

                    if (string.IsNullOrEmpty(mskCpf.Text)) // valida campo cpf
                    {
                        erro = true;
                        MessageBox.Show("O numero do CPF deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.validaCPF(mskCpf.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do CPF informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao cpf

                    if (string.IsNullOrEmpty(txtLogin.Text)) // valida campo login
                    {
                        erro = true;
                        MessageBox.Show(" O login deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }    
                    else if (validar.isLimitCaract(txtLogin.Text, 5, 10)) { } 
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
                    else if (validar.isLimitCaract(txtSenha.Text, 5, 10)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" A senha deve conter de 5 a 10 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao SENHA 

                    if (string.IsNullOrEmpty(txtConfirmaSenha.Text)) // valida campo confirmar senha
                    {
                        erro = true;
                        MessageBox.Show(" A senha de confirmacao deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.isLimitCaract(txtConfirmaSenha.Text, 5, 10)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" A senha de confirmacao deve conter de 5 a 10 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao confirmar senha

                    if (funcionario.senha == funcionario.confirmarSenha) { } // valida campo senha e confirmar senha
                    else
                    {
                        erro = true;
                        MessageBox.Show("As senhas nao conferem!");
                    } // fecha a validacao senha e confirmar senha

                    if (rbtAtivo.Checked == true) // valida campo status
                    {
                        funcionario.status = "Ativo";
                    }
                    else if (rbtInativo.Checked == true)
                    {
                        funcionario.status = "Inativo";
                    }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O status do funcionario deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao status

                    if (!erro)
                    {
                        Cdb.InserirFuncionario(funcionario); // chama o dao de cadastro de funcionario
                        LimparCampos(); // chama o metodo limpar campos
                    }
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar o cadastro, verifique os campos e tente novamente: ", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // exibe a mensagem caso nao seja possivel realizar o cadastro
            }
        } // fecha o metodo

        //metodo que grava as informacoes preenchidas no formulario 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ReceberDados(); // chama o metodo receberDados
        }

    } // fecha a classe
} // fecha o namespace
