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
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PIM
{
    public partial class DevolucaoAutomovel : Form
    {
        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Cliente novocliente = new Cliente(); // criacao do objeto do tipo Cliente

        Veiculo novoveiculo = new Veiculo(); // criacao do objeto do tipo veiculo

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Locacao devolucao = new Locacao(); // criacao do objeto do tipo locacao

        CheckinCheckout checkout = new CheckinCheckout(); // criacao do objeto do tipo checkinChechout

        public DevolucaoAutomovel()
        {
            InitializeComponent();
        }

        // metodo responsavel por fechar a pagina
        private void BtnCancelaDevolucaoAutomovel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            } // fecha o if
        } // fecha o metodo

        // metodo responsavel por retornar um datatable das locacoes de Pessoa Fisica
        public DataTable ListarLocPessoaFisica()
        {
            try
            {
                dt = Cdb.ListarLocacaoPessoaFisica();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo

        // metodo responsavel por retornar um datatable das locacoes de Pessoa Juridica
        public DataTable ListarLocPessoaJuridica()
        {
            try
            {
                dt = Cdb.ListarLocacaoPessoaJuridica();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo

        // metodo responsavel por carregar o gridView com os dados da locacao de Pessoa Fisica
        private void CarregarGridLocPessoaF()
        {
            gridView.DataSource = ListarLocPessoaFisica(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            gridView.Columns[0].HeaderText = "Código";
            gridView.Columns[1].HeaderText = "Data Locação";
            gridView.Columns[2].HeaderText = "Data Devolução";
            gridView.Columns[3].HeaderText = "Tipo de Locação ";
            gridView.Columns[4].HeaderText = "Forma de Pagamento";
            gridView.Columns[5].HeaderText = "Valor da Locação";
            gridView.Columns[6].HeaderText = "Status";
            gridView.Columns[7].HeaderText = "Código Checkin";
            gridView.Columns[8].HeaderText = "Código Pessoa Fisica";
           
            //edita o tamanho das colunas do datagridview
            gridView.Columns[0].Width = 50;
            gridView.Columns[1].Width = 90;
            gridView.Columns[2].Width = 90;
            gridView.Columns[3].Width = 110;
            gridView.Columns[4].Width = 120;
            gridView.Columns[5].Width = 90;
            gridView.Columns[6].Width = 90;
            gridView.Columns[7].Width = 80;
            gridView.Columns[8].Width = 90;
        } // fecha o metodo

        // metodo responsavel por carregar o gridView com os dados da locacao de Pessoa juridica
        private void CarregarGridLocPessoaJ()
        {
            gridView.DataSource = ListarLocPessoaJuridica(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew     
            gridView.Columns[0].HeaderText = "Código";
            gridView.Columns[1].HeaderText = "Data Locação";
            gridView.Columns[2].HeaderText = "Data Devolução";
            gridView.Columns[3].HeaderText = "Tipo de Locação ";
            gridView.Columns[4].HeaderText = "Forma de Pagamento";
            gridView.Columns[5].HeaderText = "Valor da Locação";
            gridView.Columns[6].HeaderText = "Status";
            gridView.Columns[7].HeaderText = "Código Checkin";
            gridView.Columns[8].HeaderText = "Código Pessoa Juridica";

            //edita o tamanho das colunas do datagridview
            gridView.Columns[0].Width = 50;
            gridView.Columns[1].Width = 90;
            gridView.Columns[2].Width = 90;
            gridView.Columns[3].Width = 110;
            gridView.Columns[4].Width = 120;
            gridView.Columns[5].Width = 90;
            gridView.Columns[6].Width = 90;
            gridView.Columns[7].Width = 80;
            gridView.Columns[8].Width = 90;
        } // fecha o metodo

        // metodo loading
        private void DevolucaoAutomovel_Load(object sender, EventArgs e)
        {
            grbLocJuridico.Visible = false;
            grbLocFisico.Visible = true;
            CarregarGridLocPessoaF();
            EnableCampos();
        } // fecha o metodo

        // metodo que configura a visibilidade do formulario
        private void rbtPessoaFis_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaFis.Checked == true)
            { 
                //deixa os campos visible de pessoa fisica
                grbLocFisico.Visible = true;

                ////deixa os campos invisiveis de pessoa juridica
                grbLocJuridico.Visible = false;

                CarregarGridLocPessoaF();
            } // fecha o if
        } // fecha o metodo

        // metodo que carrega a visibilidade do formulario
        private void rbtPessoaJur_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaJur.Checked == true)
            {
                //deixa os campos invisible de pessoa fisica
                grbLocFisico.Visible = false;

                ////deixa os campos visiveis de pessoa juridica
                grbLocJuridico.Visible = true;

                CarregarGridLocPessoaJ();
            } // fecha o if
        } // fecha o metodo

        // metodo responsavel por preencher o formulario de acordo com o campos selecionado
        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = gridView.Rows[index];

                if (rbtPessoaFis.Checked == true) //dados de pessoa fisica
                {
                    txtCodFis.Text = selectRow.Cells[0].Value.ToString();
                    dtpDtaLocFis.Text = selectRow.Cells[1].Value.ToString();
                    dtpDtaDevFis.Text = selectRow.Cells[2].Value.ToString();
                    txtValorFis.Text = selectRow.Cells[5].Value.ToString();
                    txtStatusFis.Text = selectRow.Cells[6].Value.ToString();
                    txtCheckinFis.Text = selectRow.Cells[7].Value.ToString();
                }
                else if (rbtPessoaJur.Checked == true) // dados de pessoa juridica
                {
                    txtCodJur.Text = selectRow.Cells[0].Value.ToString();
                    dtpDtaLocJur.Text = selectRow.Cells[1].Value.ToString();
                    dtpDtaDevJur.Text = selectRow.Cells[2].Value.ToString();
                    txtValorJur.Text = selectRow.Cells[5].Value.ToString();
                    txtStatusJur.Text = selectRow.Cells[6].Value.ToString();
                    txtCheckinJur.Text = selectRow.Cells[7].Value.ToString();
                }
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Escolha um campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }// fecha o metodo

        // metodo para limpar os campos dos formularios
        public void LimparCampos()
        {
            //limpa os dados da locacao de pessoa fisica
            txtCodFis.Text = "";
            dtpDtaLocFis.Text = "";
            dtpDtaDevFis.Text = "";
            txtValorFis.Text = "";
            txtStatusFis.Text = "";
            txtCheckinFis.Text = "";

            //limpa os dados da locacao de pessoa juridica
            txtCodJur.Text = "";
            dtpDtaLocJur.Text = "";
            dtpDtaDevJur.Text = "";
            txtValorJur.Text = "";
            txtStatusJur.Text = "";
            txtCheckinJur.Text = "";
        } // fecha o metodo

        //metodo que inativa os campos
        public void EnableCampos()
        {
            // inativa o formulario com os dados de pessoa fisica
            txtCodFis.Enabled = false;
            dtpDtaLocFis.Enabled = false;
            dtpDtaDevFis.Enabled = false;
            txtValorFis.Enabled = false;
            txtStatusFis.Enabled = false;
            txtCheckinFis.Enabled = false;

            // inativa o formulario com os dados de pessoa juridica
            txtCodJur.Enabled = false;
            dtpDtaLocJur.Enabled = false;
            dtpDtaDevJur.Enabled = false;
            txtValorJur.Enabled = false;
            txtStatusJur.Enabled = false;
            txtCheckinJur.Enabled = false;
        } // fecha o metodo

        // metodo que limpa os campos preenchidos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        } // fecha o metodo

        // metodo responsavel por receber os valos do formulario e executar a operacao de devolucao
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool erro = false;
                if (rbtPessoaFis.Checked == true)
                {
                    
                    devolucao.id = Int32.Parse(txtCodFis.Text);
                    devolucao.data_locacao = DateTime.Parse(dtpDtaLocFis.Text.ToString());
                    devolucao.data_devolucao = DateTime.Parse(dtpDtaDevFis.Text.ToString());
                    devolucao.valor_locacao = txtValorFis.Text.ToString();
                    devolucao.status = txtStatusFis.Text.ToString();
                    devolucao.ckn_id = txtCheckinFis.Text.ToString();

                    if (string.IsNullOrEmpty(txtCodFis.Text)) // valida campo codigo
                    {
                        erro = true;
                        MessageBox.Show("O código da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do codigo

                    if (string.IsNullOrEmpty(dtpDtaLocFis.Text)) // valida campo data locacao
                    {
                        erro = true;
                        MessageBox.Show("A data da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao data locacao

                    if (string.IsNullOrEmpty(dtpDtaDevFis.Text)) // valida campo data devolucao
                    {
                        erro = true;
                        MessageBox.Show("A data da devolução deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao data devolucao

                    if (string.IsNullOrEmpty(txtValorFis.Text)) // valida campo valor
                    {
                        erro = true;
                        MessageBox.Show("O valor da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao valor

                    if (string.IsNullOrEmpty(txtStatusFis.Text)) // valida campo status
                    {
                        erro = true;
                        MessageBox.Show("O status da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao status

                    if (string.IsNullOrEmpty(txtCheckinFis.Text)) // valida campos codigo checkin
                    {
                        erro = true;
                        MessageBox.Show("O código do checkin deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao codigo checkin

                    if (txtStatusFis.Text == "Devolvido") // valida campo status ja devolvido
                    {
                        erro = true;
                        MessageBox.Show("Este veículo ja foi devolvido, por favor selecione outro para realizar a operação! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimparCampos();
                    } // fecha validacao status ja devolvido

                    if (!erro)
                    {
                        devolucao.status = "Devolvido";
                        Cdb.RealizarDevolucao(devolucao); // atualiza na tabela locacao o status da locacao
                        CarregarGridLocPessoaF();  
                    }

                    if (txtStatusFis.Text == "Alugado") // valida campo status ja alugado
                    {
                        checkout.status = "Disponivel";
                        checkout.id = Int32.Parse(txtCheckinFis.Text);
                        Cdb.UpdateCheckin(checkout); // atualiza na tabela checkin o status do veiculo
                        LimparCampos();
                    } // fecha validacao status ja alugado
                } // fecha o if rbtPessoaFis
                else if (rbtPessoaJur.Checked == true)
                {
                    devolucao.id = Int32.Parse(txtCodJur.Text);
                    devolucao.data_locacao = DateTime.Parse(dtpDtaLocJur.Text.ToString());
                    devolucao.data_devolucao = DateTime.Parse(dtpDtaDevJur.Text.ToString());
                    devolucao.valor_locacao = txtValorJur.Text.ToString();
                    devolucao.status = txtStatusJur.Text.ToString();
                    devolucao.ckn_id = txtCheckinJur.Text.ToString();

                    if (string.IsNullOrEmpty(txtCodJur.Text)) // valida campo codigo
                    {
                        erro = true;
                        MessageBox.Show("O código da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do codigo

                    if (string.IsNullOrEmpty(dtpDtaLocJur.Text)) // valida campo data locacao
                    {
                        erro = true;
                        MessageBox.Show("A data da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao data locacao

                    if (string.IsNullOrEmpty(dtpDtaDevJur.Text)) // valida campo data devolucao
                    {
                        erro = true;
                        MessageBox.Show("A data da devolução deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao data devolucao

                    if (string.IsNullOrEmpty(txtValorJur.Text)) // valida campo valor
                    {
                        erro = true;
                        MessageBox.Show("O valor da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao valor

                    if (string.IsNullOrEmpty(txtStatusJur.Text)) // valida campo status
                    {
                        erro = true;
                        MessageBox.Show("O status da locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao status

                    if (string.IsNullOrEmpty(txtCheckinJur.Text)) // valida campos codigo checkin
                    {
                        erro = true;
                        MessageBox.Show("O código do checkin deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao codigo checkin

                    if (txtStatusJur.Text == "Devolvido") // valida campo status ja devolvido
                    {
                        erro = true;
                        MessageBox.Show("Este veículo ja foi devolvido, por favor selecione outro para realizar a operação! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao status ja devolvido

                    if (!erro)
                    {
                        devolucao.status = "Devolvido";
                        Cdb.RealizarDevolucao(devolucao); // atualiza na locacao o status da locacao
                        CarregarGridLocPessoaJ(); 
                    }

                    if (txtStatusJur.Text == "Alugado")
                    {
                        checkout.status = "Disponivel";
                        checkout.id = Int32.Parse(txtCheckinJur.Text); // atualiza na tabela checkin o status do veiculo
                        Cdb.UpdateCheckin(checkout);
                        LimparCampos();
                    }
                } // fecha o if rbtPessoaJur
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Escolha uma opção para realizar a devolução!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // fecha o metodo

        private void txtBuscaCod_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "Convert(loc_id, 'System.String') LIKE '" + txtBuscaCod.Text + "%'"; // compara o valor digitado no campo txtBuscaCod com o valor que esta na coluna loc_id
            gridView.DataSource = dv;
        }// fecha o metodo
    } // fecha a classe
} // fecha o namespace
