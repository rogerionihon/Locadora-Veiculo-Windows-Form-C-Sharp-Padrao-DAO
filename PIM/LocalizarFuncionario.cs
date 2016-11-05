using CdbDao.ConnectionDataBase;
using CdbDao.ModelCliente;
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

        Funcionario funcionario = new Funcionario();
        public LocalizarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
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
        }

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
        }

        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("fun_nome LIKE '%{0}%'", txtPesqNome.Text); // compara o valor digitado no campo txtPesqNome com o valor que esta na coluna fun_nome
            dataGridView.DataSource = dv;
        }

        private void LocalizarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarGridView();
            txtCod.Enabled = false;
            txtDtaCad.Enabled = false;
        }

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

            }
            catch (Exception)
            {
                MessageBox.Show("escolha um campo", MessageBoxButtons.OK.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarFuncionario();
            CarregarGridView();
            LimparCampos();
        }

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
                    MessageBox.Show("A opcao ativo ou inativo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (!erro)
                {
                    Cdb.AtualizarFuncionario(funcionario);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Escolha algum campo para realizar a atualizacao", MessageBoxButtons.OK.ToString()); // exibe a mensagem caso nao seja escolhido algum campo para realizar a atualizacao
            }
        }
        

    }
}
