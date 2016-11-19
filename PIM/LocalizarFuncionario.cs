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
    public partial class LocalizarFuncionario : Form
    {
        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Funcionario funcionario = new Funcionario(); // criacao do objeto do tipo funcionario

        Validacao validar = new Validacao(); // criacao do objeto do tipo validacao
        public LocalizarFuncionario()
        {
            InitializeComponent();
        }

        // metodo para fechar o formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        //Metodo responsavel por exibi todos os dados dos funcionarios no datagridview
        public DataTable SelecionarFuncionario()
        {
            try
            {
                dt = Cdb.returnDataTableFuncionario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os funcionarios: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; //retorno do datatable
        } // fecha o metodo

        // metodo responsavel por carregar os dados no datagridview
        public void CarregarGridView()
        {
            dataGridView.DataSource = SelecionarFuncionario();

            // edita o cabecalho do datagridwiew
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[0].HeaderText = "Codigo";
            dataGridView.Columns[1].HeaderText = "Nome";
            dataGridView.Columns[2].HeaderText = "CPF";
            dataGridView.Columns[3].HeaderText = "Login";
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[4].HeaderText = "Senha";
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[5].HeaderText = "Confirmar Senha";
            dataGridView.Columns[6].HeaderText = "Data de Cadastro";
            dataGridView.Columns[7].HeaderText = "E-mail ";
            dataGridView.Columns[8].HeaderText = "Telefone";
            dataGridView.Columns[9].HeaderText = "Celular";
            dataGridView.Columns[10].HeaderText = "Status";

            //edita o tamanho das colunas do datagridview
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 250;
            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 90;
            dataGridView.Columns[5].Width = 90;
            dataGridView.Columns[6].Width = 100;
            dataGridView.Columns[7].Width = 200;
            dataGridView.Columns[8].Width = 100;
            dataGridView.Columns[9].Width = 100;
            dataGridView.Columns[10].Width = 50;
        } // fecha o metodo

        // metodo para limpar os campos do formulario
        public void LimparCampos()
        {
            txtCod.Text = "";
            txtNome.Text = "";
            mskCpf.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
            txtDtaCad.Text = "";
            txtEmail.Text = "";
            mskTel.Text = "";
            mskCel.Text = "";
        } // fecha o metodo

        // metodo responsavel por realizar a busca pelo nome
        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("fun_nome LIKE '%{0}%'", txtPesqNome.Text); // compara o valor digitado no campo txtPesqNome com o valor que esta na coluna fun_nome
            dataGridView.DataSource = dv;
        } // fecha o metodo

        // metodo loading
        private void LocalizarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarGridView(); // chama o metodo carregarGridView
            txtCod.Enabled = false; // deixa o campo inativo
            txtDtaCad.Enabled = false; // deixa o campo inativo
        } // fecha o metodo

        //metodo responsavel por preencher o formulario de acordo com a linha selecionada no datagridview
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[index];

                txtCod.Text = selectedRow.Cells[0].Value.ToString();
                txtNome.Text = selectedRow.Cells[1].Value.ToString();
                mskCpf.Text = selectedRow.Cells[2].Value.ToString();
                txtLogin.Text = selectedRow.Cells[3].Value.ToString();
                txtSenha.Text = selectedRow.Cells[4].Value.ToString();
                txtConfSenha.Text = selectedRow.Cells[5].Value.ToString();
                txtDtaCad.Text = selectedRow.Cells[6].Value.ToString();
                txtEmail.Text = selectedRow.Cells[7].Value.ToString();
                mskTel.Text = selectedRow.Cells[8].Value.ToString();
                mskCel.Text = selectedRow.Cells[9].Value.ToString();
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("escolha um campo", MessageBoxButtons.OK.ToString());
            }
        } // fecha o metodo

        // metodo responsavel por atualizar os dados com a fonte de dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarFuncionario(); // chama o metodo para atualizar os dados
            CarregarGridView(); // atualiza o datagridview com os novos dados
            LimparCampos(); // limpa os campos do formulario
        } // fecha o metodo

        // metodo responsavel por atualizar os dados do formulario
        public void AtualizarFuncionario()
        {
            try
            {
                bool erro = false;

                funcionario.id = Int32.Parse(txtCod.Text);
                funcionario.nome = txtNome.Text.ToString();
                funcionario.cpf = mskCpf.Text.ToString();
                funcionario.login = txtLogin.Text.ToString();
                funcionario.senha = txtSenha.Text.ToString();
                funcionario.confirmarSenha = txtConfSenha.Text.ToString();
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


                if (string.IsNullOrEmpty(txtEmail.Text))  // valida campo EMAIL
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
                } // fecha a validacao senha

                if (string.IsNullOrEmpty(txtConfSenha.Text)) // valida campo confirmar senha
                {
                    erro = true;
                    MessageBox.Show(" A confirmacao da senha deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(txtConfSenha.Text, 5, 10)) { }
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
                    MessageBox.Show("A opcao ativo ou inativo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao status

                if (!erro)
                {
                    Cdb.AtualizarFuncionario(funcionario);
                }

            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Escolha algum campo para realizar a atualizacao", MessageBoxButtons.OK.ToString()); // exibe a mensagem caso nao seja escolhido algum campo para realizar a atualizacao
            }
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
