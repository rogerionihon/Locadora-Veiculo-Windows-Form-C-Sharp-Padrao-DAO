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

        Funcionario funcionario = new Funcionario();

        Validacao validar = new Validacao();
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void BtnCancelaFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = Convert.ToString(DateTime.Now);
        }

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
                    
                    if (rbtAtivo.Checked == true)
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
                        MessageBox.Show("O status do funcionario deve ser informado! ");
                    }

                    if (funcionario.senha == funcionario.confirmarSenha){}
                    else
                    {
                        erro = true;
                        MessageBox.Show("As senhas nao conferem!");
                    }

                    if (string.IsNullOrEmpty(txtNome.Text)) // valida campo NOME
                    {
                        erro = true;
                        MessageBox.Show("O nome deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.isLimitCaract(txtNome.Text, 5, 45)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O nome deve conter no minimo 5 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validar NOME
                    if (validar.validaCPF(mskCpf.Text)) { } // valida campo CPF
                    else if (string.IsNullOrEmpty(mskCpf.Text))
                    {
                        erro = true;
                        MessageBox.Show("O CPF deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O CPF informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validar CPF
                    if (validar.isLimitCaract(txtLogin.Text, 5, 10)) { } // valida campo LOGIN
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O login deve conter de 5 a 10 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validar LOGIN    
                    if (validar.isLimitCaract(txtSenha.Text, 5, 10)) { }// valida campo SENHA
                    else
                    {
                        erro = true;
                        MessageBox.Show(" A senha deve conter de 5 a 10 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validar SENHA 
                    if (validar.isLimitCaract(txtConfirmaSenha.Text, 5, 10)) { }// valida campo CONFIRMAR SENHA
                    else
                    {
                        erro = true;
                        MessageBox.Show(" As senhas nao conferem! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validar CONFIRMAR SENHA
                    if (validar.ValidarEmail(txtEmail.Text)) { } // valida campo EMAIL
                    else if (string.IsNullOrEmpty(txtEmail.Text))
                    {
                        erro = true;
                        MessageBox.Show("O email deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O email informado nao é valido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao de EMAIL
                    if (validar.ValidaTelefone(mskTel.Text)) { } // valida campo TELEFONE
                    else if (string.IsNullOrEmpty(mskTel.Text))
                    {
                        erro = true;
                        MessageBox.Show("O telefone deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O telefone informado nao é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do TELEFONE
                    if (validar.ValidarCelular(mskCel.Text)) { } // valida campo CELULAR
                    else if (string.IsNullOrEmpty(mskCel.Text))
                    {
                        erro = true;
                        MessageBox.Show("O celular deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O celular informado nao é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do CELULAR

                    if (!erro)
                    {
                        Cdb.InserirFuncionario(funcionario);
                        LimparCampos();
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel Cadastrar esses funcionario");
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ReceberDados();
        }

    }
}
