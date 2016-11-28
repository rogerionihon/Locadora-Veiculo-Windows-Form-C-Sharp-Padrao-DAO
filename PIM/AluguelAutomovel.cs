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
using System.Configuration;
using CdbDao.Relatorio;

namespace PIM
{
    public partial class AluguelAutomovel : Form
    {
        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Cliente novocliente = new Cliente(); // criacao do objeto do tipo Cliente

        Veiculo novoveiculo = new Veiculo(); // criacao do objeto do tipo veiculo

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Locacao alugar = new Locacao(); //criacao do objeto do tipo locacao

        CheckinCheckout checkin = new CheckinCheckout(); // criacao do objeto de tipo checkinChechout

        public AluguelAutomovel()
        {
            InitializeComponent();
        }

        // metodo para sair da locacao
        private void BtnCancelaAluguelAutomovel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        // metodo que chama o formulario de checkin
        private void btnRealizarCheckin_Click(object sender, EventArgs e)
        {
            Checkin checkin = new Checkin();
            checkin.StartPosition = FormStartPosition.CenterScreen;
            checkin.Show();
        } // fecha o metodo

        // metodo para limpar os campos
        public void LimparCampos()
        {
            // Limpa os campos de pessoa fisica
            txtCodFis.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";

            //Limpa os campos de pessoa juridica
            txtCodJur.Text = "";
            txtRazSoc.Text = "";
            txtCnpj.Text = "";

            //Limpa os campos de veiculo
            txtCodCheckin.Text = "";
            txtPlaca.Text = "";
            txtModelo.Text = "";
            cmbStatus.Text = "";

            //Limpa os campos da locacao
            cmbFormLoc.Text = "";
            cmbFormPag.Text = "";
            dtpLocacao.Text = "";
            txtValorServ.Text = "";
        } // fecha o metodo
     
        // metodo que retorna o data tablede pessoa fisica
        public DataTable ListarPessoaF()
        {
            try
            {
                dt = Cdb.returnDataTablePf();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os clientes de pessoa fisica: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo

        // metodo que retorna o datatable de pesso juridica
        public DataTable ListarPessoaJ()
        {
            try
            {
                dt = Cdb.returnDataTablePj();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os clientes de pessoa juridica: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo

        // metodo que retorna o datatable de checkin
        public DataTable ListarVeiculoCheckin()
        {
            try
            {
                dt = Cdb.returnDatatableCheckin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veículos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo

        // metodo que configura o datagridview de pessoa fisica
        private void CarregarGridPessoaF()
        {
            gridView.DataSource = ListarPessoaF(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            gridView.Columns[0].Visible = false;
            gridView.Columns[0].HeaderText = "Codigo";
            gridView.Columns[1].HeaderText = "Nome";
            gridView.Columns[2].HeaderText = "CPF";
            gridView.Columns[3].HeaderText = "RNE";
            gridView.Columns[4].HeaderText = "CNH";
            gridView.Columns[5].HeaderText = "Data de Nascimento";
            gridView.Columns[6].HeaderText = "E-mail";
            gridView.Columns[7].HeaderText = "Telefone";
            gridView.Columns[8].HeaderText = "Celular";
            gridView.Columns[9].HeaderText = "Sexo";
            gridView.Columns[10].HeaderText = "Estado Civil";
            gridView.Columns[11].HeaderText = "Endereco";
            gridView.Columns[12].HeaderText = "Numero";
            gridView.Columns[13].HeaderText = "Complemento";
            gridView.Columns[14].HeaderText = "CEP";
            gridView.Columns[15].HeaderText = "Cidade";
            gridView.Columns[16].HeaderText = "Bairro";
            gridView.Columns[17].HeaderText = "UF";
            gridView.Columns[18].HeaderText = "Observação";
            gridView.Columns[19].HeaderText = "Ativo";

            //edita o tamanho das colunas do datagridview
            gridView.Columns[0].Width = 50;
            gridView.Columns[1].Width = 240;
            gridView.Columns[2].Width = 120;
            gridView.Columns[3].Width = 110;
            gridView.Columns[4].Width = 120;
            gridView.Columns[5].Width = 90;
            gridView.Columns[6].Width = 220;
            gridView.Columns[7].Width = 120;
            gridView.Columns[8].Width = 120;
            gridView.Columns[9].Width = 80;
            gridView.Columns[10].Width = 100;
            gridView.Columns[11].Width = 260;
            gridView.Columns[12].Width = 80;
            gridView.Columns[13].Width = 100;
            gridView.Columns[14].Width = 100;
            gridView.Columns[15].Width = 230;
            gridView.Columns[16].Width = 150;
            gridView.Columns[17].Width = 120;
            gridView.Columns[18].Width = 300;
            gridView.Columns[19].Width = 50;
        } // fecha o metodo

        // metodo que configura o datagridview de pessoa juridica
        private void CarregarGridPessoaJ()
        {
            gridView.DataSource = ListarPessoaJ(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            gridView.Columns[0].Visible = false;
            gridView.Columns[0].HeaderText = "ID";
            gridView.Columns[1].HeaderText = "Razao Social";
            gridView.Columns[2].HeaderText = "CNPJ";
            gridView.Columns[3].HeaderText = "Nome Fantasia";
            gridView.Columns[4].HeaderText = "Inscrição estadual";
            gridView.Columns[5].HeaderText = "Inscrição municipal";
            gridView.Columns[6].HeaderText = "E-mail";
            gridView.Columns[7].HeaderText = "Telefone";
            gridView.Columns[8].HeaderText = "Celular";
            gridView.Columns[9].HeaderText = "Endereco";
            gridView.Columns[10].HeaderText = "Numero";
            gridView.Columns[11].HeaderText = "Complemento";
            gridView.Columns[12].HeaderText = "CEP";
            gridView.Columns[13].HeaderText = "Cidade";
            gridView.Columns[14].HeaderText = "Bairro";
            gridView.Columns[15].HeaderText = "UF";
            gridView.Columns[16].HeaderText = "Observação";
            gridView.Columns[17].HeaderText = "Ativo";

            //edita o tamanho das colunas do datagridview
            gridView.Columns[0].Width = 50;
            gridView.Columns[1].Width = 250;
            gridView.Columns[2].Width = 150;
            gridView.Columns[3].Width = 250;
            gridView.Columns[4].Width = 120;
            gridView.Columns[5].Width = 100;
            gridView.Columns[6].Width = 220;
            gridView.Columns[7].Width = 120;
            gridView.Columns[8].Width = 120;
            gridView.Columns[9].Width = 260;
            gridView.Columns[10].Width = 80;
            gridView.Columns[11].Width = 100;
            gridView.Columns[12].Width = 100;
            gridView.Columns[13].Width = 230;
            gridView.Columns[14].Width = 150;
            gridView.Columns[15].Width = 90;
            gridView.Columns[16].Width = 300;
            gridView.Columns[17].Width = 50;
           
        } // fecha o metodo

        // metodo que configura o datagridview do checkin
        private void CarregarGridCheckin()
        {
            gridView.DataSource = ListarVeiculoCheckin(); // chama o metodo datatable para listar todos os veiculos com checkin

            // edita o cabecalho do datagridwiew
            gridView.Columns[0].Visible = false;
            gridView.Columns[0].HeaderText = "Código";
            gridView.Columns[1].HeaderText = "Placa";
            gridView.Columns[2].HeaderText = "Modelo";
            gridView.Columns[3].HeaderText = "Status";           

            //edita o tamanho das colunas do datagridview
            gridView.Columns[0].Width = 80;
            gridView.Columns[1].Width = 100;
            gridView.Columns[2].Width = 500;
            gridView.Columns[3].Width = 160;          
        } // fecha o metodo

        // metodo que configura a visibilidade do formulario
        private void rbtPessoaF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaF.Checked == true)
            {
                rbtPessoaJ.Checked = false;
                rbtVeiculo.Checked = false;

                //torna os campos invisiveis
                grbPessoaJ.Visible = false;
                txtCodJur.Visible = false;
                txtRazSoc.Visible = false;
                txtCnpj.Visible = false;

                //torna os campos visiveis
                grbPessoaF.Visible = true;
                txtCodFis.Visible = true;
                txtNome.Visible = true;
                txtCpf.Visible = true;

                CarregarGridPessoaF();
            } // fecha o if          
        } // fecha o metodo

        // metodo que configura a visibilidade do formulario
        private void rbtPessoaJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaJ.Checked == true)
            {
                rbtPessoaF.Checked = false;
                rbtVeiculo.Checked = false;

                //torna os campos invisiveis
                grbPessoaF.Visible = false;
                txtCodFis.Visible = false;
                txtNome.Visible = false;
                txtCpf.Visible = false;

                //torna os campos visiveis
                grbPessoaJ.Visible = true;
                txtCodJur.Visible = true;
                txtRazSoc.Visible = true;
                txtCnpj.Visible = true;

                CarregarGridPessoaJ();
            } // fecha o if   
        } // fecha o metodo

        // metodo que deixa os campos inativo
        public void EnableCampos()
        {
            // inativa o formulario com os dados de pessoa fisica
            txtCodFis.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;

            // inativa o formulario com os dados de pessoa fisica
            txtCodJur.Enabled = false;
            txtRazSoc.Enabled = false;
            txtCnpj.Enabled = false;

            // inativa o formulario com os dados do veiculo
            txtCodCheckin.Enabled = false;
            txtPlaca.Enabled = false;
            txtModelo.Enabled = false;
            cmbStatus.Enabled = false;

        }// fecha o metodo

        // metodo loading
        private void AluguelAutomovel_Load(object sender, EventArgs e)
        {       
            CarregarGridCheckin();
            EnableCampos();          
        } // fecha o metodo

        // metodo que recebe os valores dos formularios e envia para a base de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool erro = false;
                if (rbtPessoaF.Checked == true)
                {
                    // limpa os valores dos campos
                    txtCodJur.Text = "";
                    txtRazSoc.Text = "";
                    txtCnpj.Text = "";

                    alugar.data_locacao = DateTime.Parse(dtpLocacao.Text.ToString());
                    alugar.data_devolucao = DateTime.Parse(dtpDevolucao.Text.ToString());
                    alugar.tipo_locacao = cmbFormLoc.Text.ToString();
                    alugar.forma_pagamento = cmbFormPag.Text.ToString();
                    alugar.valor_locacao = txtValorServ.Text.ToString(); 
                    alugar.ckn_id = txtCodCheckin.Text.ToString();
                    alugar.pf_id = txtCodFis.Text.ToString();
                    alugar.status = cmbStatus.Text.ToString();

                    if (string.IsNullOrEmpty(txtCodFis.Text)) // valida campo codigo
                    {
                        erro = true;
                        MessageBox.Show("O código do cliente deve ser preenchido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao codigo

                    if (string.IsNullOrEmpty(txtNome.Text)) // valida campo nome
                    {
                        erro = true;
                        MessageBox.Show("O nome cliente deve ser preenchido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao nome

                    if (string.IsNullOrEmpty(txtCpf.Text)) // valida campo cpf
                    {
                        erro = true;
                        MessageBox.Show("O cpf do cliente deve ser preenchido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao cpf

                    if (string.IsNullOrEmpty(cmbFormPag.Text)) // valida campo forma pagamento
                    {
                        erro = true;
                        MessageBox.Show("A forma de pagamento deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao forma de pagamento

                    if (string.IsNullOrEmpty(cmbFormLoc.Text)) // valida campo forma locacao
                    {
                        erro = true;
                        MessageBox.Show("A forma de locacao deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao forma locacao

                    if (string.IsNullOrEmpty(txtValorServ.Text)) // valida campo valor
                    {
                        erro = true;
                        MessageBox.Show("O valor da locacao deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao valor

                    if (string.IsNullOrEmpty(txtCodCheckin.Text)) // valida campo codigo checkin
                    {
                        erro = true;
                        MessageBox.Show("O veículo do veículo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao codigo checkin

                    if (string.IsNullOrEmpty(txtPlaca.Text)) // valida campo codigo placa
                    {
                        erro = true;
                        MessageBox.Show("A placa do veículo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao placa

                    if (string.IsNullOrEmpty(txtModelo.Text)) // valida campo modelo
                    {
                        erro = true;
                        MessageBox.Show("O modelo veículo do veículo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao modelo

                    if (cmbStatus.Text == "Indisponivel") // valida campo status
                    {
                        erro = true;
                        MessageBox.Show("Este veículo já esta alugado, por favor escolha outro! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao campo status
                  
                    if (!erro)
                    {
                        alugar.status = "Alugado";
                        Cdb.RealizarLocacao(alugar); // atualiza na tabela locacao o status da locacao
                    }

                    if (!erro)
                    {
                        checkin.status = "Indisponivel";
                        checkin.id = Int32.Parse(txtCodCheckin.Text);
                        Cdb.UpdateCheckin(checkin); // atualiza na tabela checkin o status do veiculo
                        LimparCampos();
                    } 
                } // fecha o primeiro if
                else if (rbtPessoaJ.Checked == true)
                {
                    // limpa os valores dos campos
                    txtCodFis.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";

                    alugar.data_locacao = DateTime.Parse(dtpLocacao.Text.ToString());
                    alugar.data_devolucao = DateTime.Parse(dtpDevolucao.Text.ToString());
                    alugar.tipo_locacao = cmbFormLoc.Text.ToString();
                    alugar.forma_pagamento = cmbFormPag.Text.ToString();
                    alugar.valor_locacao = txtValorServ.Text.ToString();
                    alugar.ckn_id = txtCodCheckin.Text.ToString();
                    alugar.pj_id = txtCodJur.Text.ToString();
                    alugar.status = cmbStatus.Text.ToString();

                    if (string.IsNullOrEmpty(txtCodJur.Text)) // valida campo codigo
                    {
                        erro = true;
                        MessageBox.Show("O código do cliente deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao codigo

                    if (string.IsNullOrEmpty(txtRazSoc.Text)) // valida campo razao social
                    {
                        erro = true;
                        MessageBox.Show("A razão social do cliente deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao razao social

                    if (string.IsNullOrEmpty(txtCnpj.Text)) // valida campo cnpj
                    {
                        erro = true;
                        MessageBox.Show("O cnpj do cliente deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao cnpj

                    if (string.IsNullOrEmpty(cmbFormPag.Text)) // valida campo forma pagamento
                    {
                        erro = true;
                        MessageBox.Show("A forma de pagamento deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao forma pagamento

                    if (string.IsNullOrEmpty(cmbFormLoc.Text)) // valida campo forma locacao
                    {
                        erro = true;
                        MessageBox.Show("A forma de locacao deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao forma locacao

                    if (string.IsNullOrEmpty(dtpLocacao.Text)) // valida campo data locacao
                    {
                        erro = true;
                        MessageBox.Show("A data de locação deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao data locacao

                    if (string.IsNullOrEmpty(dtpDevolucao.Text)) // valida campo data devolucao
                    {
                        erro = true;
                        MessageBox.Show("A data de devolução deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao data devolucao

                    if (string.IsNullOrEmpty(txtValorServ.Text)) // valida campo valor
                    {
                        erro = true;
                        MessageBox.Show("O valor da locacao deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao valor
 
                    if (cmbStatus.Text == "Indisponivel") // valida campo status
                    {
                        erro = true;
                        MessageBox.Show("Este veículo já esta alugado, por favor escolha outro! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha validacao status
                    
                    if (!erro)
                    {
                        alugar.status = "Alugado";
                        Cdb.RealizarLocacao(alugar); // atualiza na tabela locacao o status da locacao 
                    }

                    if (!erro)
                    {
                        checkin.status = "Indisponivel";
                        checkin.id = Int32.Parse(txtCodCheckin.Text); // atualiza na tabela checkin o status do veiculo
                        Cdb.UpdateCheckin(checkin);
                        LimparCampos();
                    } 
                } // fecha o else if
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar a locacao, verifique e tente novamente!", MessageBoxButtons.OK.ToString());
            }
        } // fecha o metodo

        // metodo responsavel por calcular o tempo da locacao
        public long CalculoValor(System.DateTime DataInicial, System.DateTime DataFinal)
        {
            long data;
            System.TimeSpan ts = new TimeSpan(DataFinal.Ticks - DataInicial.Ticks);
            data = (long)(ts.Days / 1);
            return data;
        } // fecha o metodo

        // metodo responsavel por calcular o valor da locacao
        private void Calcular_Click(object sender, EventArgs e)
        {
            
            DateTime dataInicioL = dtpLocacao.Value;
            DateTime dataFinalL = dtpDevolucao.Value;
            
            txtValorServ.Text = CalculoValor(dataInicioL, dataFinalL).ToString();

            try
            {

                if (string.IsNullOrEmpty(cmbFormLoc.Text)) // valida campo forma locacao
                {
                    MessageBox.Show("Escolha a forma de locação !", "Validaçào de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha validacao forma locacao

                if (txtValorServ.Text == "1" && cmbFormLoc.Text == "KM Livre") // locacao equivalente a 1 dia
                {
                    txtValorServ.Text = "R$ 50,00";
                }
                else if (txtValorServ.Text == "1" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 30,00";               
                } // fecha locacao equivalente a 1 dia

                if (txtValorServ.Text == "2" && cmbFormLoc.Text == "KM Livre") // // locacao equivalente a 2 dia
                {
                    txtValorServ.Text = "R$ 80,00";
                }
                else if (txtValorServ.Text == "2" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 60,00";
                } // fecha locacao equivalente a 2 dia

                if (txtValorServ.Text == "3" && cmbFormLoc.Text == "KM Livre") // locacao equivalente a 3 dia
                {
                    txtValorServ.Text = "R$ 110,00";
                }
                else if (txtValorServ.Text == "3" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 90,00";
                } // fecha locacao equivalente a 3 dia

                if (txtValorServ.Text == "4" && cmbFormLoc.Text == "KM Livre") // locacao equivalente a 4 dia
                {
                    txtValorServ.Text = "R$ 140,00";
                }
                else if (txtValorServ.Text == "4" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 120,00";
                } // fecha locacao equivalente a 4 dia

                if (txtValorServ.Text == "5" && cmbFormLoc.Text == "KM Livre") // locacao equivalente a 5 dia
                {
                    txtValorServ.Text = "R$ 170,00";
                }
                else if (txtValorServ.Text == "5" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 150,00";
                } // fecha locacao equivalente a 5 dia

                if (txtValorServ.Text == "6" && cmbFormLoc.Text == "KM Livre") // locacao equivalente a 6 dia
                {
                    txtValorServ.Text = "R$ 200,00";
                }
                else if (txtValorServ.Text == "6" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 180,00";
                } // fecha locacao equivalente a 6 dia

                if (txtValorServ.Text == "7" && cmbFormLoc.Text == "KM Livre") // locacao equivalente a 7 dia
                {
                    txtValorServ.Text = "R$ 230,00";
                }
                else if (txtValorServ.Text == "7" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 210,00";
                } // fecha locacao equivalente a 7 dia        

                if (dataFinalL <= dataInicioL == true) // valida a diferenca das datas
                {
                    MessageBox.Show("A data de entrega nao pode ser menor que a data de locacao");
                } //fecha validacao das datas
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Falha ao realizar o calculo do valor da locacação","Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        } // fecha o metodo

        // metodo responsavel por carregar no formulario o campo selecionado do datagridview
        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = gridView.Rows[index];

                if (rbtPessoaF.Checked == true) // dados pessoa fisica
                {
                    txtCodFis.Text = selectedRow.Cells[0].Value.ToString();
                    txtNome.Text = selectedRow.Cells[1].Value.ToString();
                    txtCpf.Text = selectedRow.Cells[2].Value.ToString();
                }
                else if (rbtPessoaJ.Checked == true) // dados pessoa juridica
                {
                    txtCodJur.Text = selectedRow.Cells[0].Value.ToString();
                    txtRazSoc.Text = selectedRow.Cells[1].Value.ToString();
                    txtCnpj.Text = selectedRow.Cells[2].Value.ToString();
                }
                else if (rbtVeiculo.Checked == true) // dados do veiculo
                {
                    txtCodCheckin.Text = selectedRow.Cells[0].Value.ToString();
                    txtPlaca.Text = selectedRow.Cells[1].Value.ToString();
                    txtModelo.Text = selectedRow.Cells[2].Value.ToString();
                    cmbStatus.Text = selectedRow.Cells[3].Value.ToString();
                }
            } //fecha o try
            catch (Exception)
            {
                MessageBox.Show("Escolha um campo","Aviso" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // fecha o metodo

        // metodo responsavel por limpar os campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        } // fecha o metodo

        // test gridcheckin
        private void rbtVeiculo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtVeiculo.Checked == true)
            {
                rbtPessoaF.Checked = false;
                rbtPessoaJ.Checked = false;

                CarregarGridCheckin();
            }
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
