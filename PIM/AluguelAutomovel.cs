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

namespace PIM
{
    public partial class AluguelAutomovel : Form
    {
        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Cliente novocliente = new Cliente(); // criacao do objeto do tipo Cliente

        Veiculo novoveiculo = new Veiculo(); // criacao do objeto do tipo veiculo

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Locacao alugar = new Locacao();

        public AluguelAutomovel()
        {
            InitializeComponent();
        }

        private void BtnCancelaAluguelAutomovel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRealizarCheckin_Click(object sender, EventArgs e)
        {
            Checkin checkin = new Checkin();
            checkin.StartPosition = FormStartPosition.CenterScreen;
            checkin.Show();
        }

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

            //Limpa os campos da locacao
            cmbFormLoc.Text = "";
            cmbFormPag.Text = "";
            dtpLocacao.Text = "";
            txtValorServ.Text = "";
        }
        public void ChamaVeiculo()
        {
            cmbVeiculo.DisplayMember = "car_modelo";
           // cmbVeiculo.SelectedValue = "car_id";
            cmbVeiculo.SelectedValue = "car_id";
            cmbVeiculo.DataSource = ListarCar(); 
        }

        //public DataTable ListarCar()
        //{
        //    try
        //    {
        //        dt = Cdb.listarVeiculo();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
        //    }
        //    return dt; // retorno do datatable
        //}

        public DataTable ListarCar()
        {
            try
            {
                dt = Cdb.ChamaCarroCheckin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        }

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
            return dt;
        }

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
            return dt;
        }

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
            gridView.Columns[18].HeaderText = "Observacao";
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
        }// fecha o metodo

        private void CarregarGridPessoaJ()
        {
            gridView.DataSource = ListarPessoaJ(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            gridView.Columns[0].Visible = false;
            gridView.Columns[0].HeaderText = "ID";
            gridView.Columns[1].HeaderText = "Razao Social";
            gridView.Columns[2].HeaderText = "CNPJ";
            gridView.Columns[3].HeaderText = "Nome Fantasia";
            gridView.Columns[4].HeaderText = "Inscricao estadual";
            gridView.Columns[5].HeaderText = "inscricao municipal";
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
            gridView.Columns[16].HeaderText = "Observacao";
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
        private void rbtPessoaF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaF.Checked == true)
            {
                rbtPessoaJ.Checked = false;

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
            }           
        }

        private void rbtPessoaJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaJ.Checked == true)
            {
                rbtPessoaF.Checked = false;

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
            }    
        }

        private void AluguelAutomovel_Load(object sender, EventArgs e)
        {
            ChamaVeiculo();
            CarregarGridPessoaF();
          
            txtCodFis.Enabled = false;
            txtCodJur.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool erro = false;
                if (rbtPessoaF.Checked == true)
                {
                    
                    alugar.data_locacao = DateTime.Parse(dtpLocacao.Text.ToString());
                    alugar.data_devolucao = DateTime.Parse(dtpDevolucao.Text.ToString());
                    alugar.tipo_locacao = cmbFormLoc.Text.ToString();
                    alugar.forma_pagamento = cmbFormPag.Text.ToString();
                    alugar.valor_locacao = txtValorServ.Text.ToString();
                    alugar.car_id = cmbVeiculo.SelectedIndex.ToString();
                    alugar.ckn_id = cmbVeiculo.SelectedIndex.ToString();
                    alugar.pf_id = txtCodFis.Text.ToString();

                    if (string.IsNullOrEmpty(cmbFormLoc.Text))
                    {
                        erro = true;
                        MessageBox.Show("A forma de locacao deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(cmbFormPag.Text))
                    {
                        erro = true;
                        MessageBox.Show("A forma de pagamento deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(txtValorServ.Text))
                    {
                        erro = true;
                        MessageBox.Show("O valor da locacao deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(txtCodFis.Text))
                    {
                        erro = true;
                        MessageBox.Show("Escolha um cliente para realizar a locacao! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (cmbVeiculo.SelectedIndex == 0)
                    {
                        erro = true;
                        MessageBox.Show("Realize o checkin, e depois escolha o veiculo! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (cmbVeiculo.SelectedIndex == -1)
                    {
                        erro = true;
                        MessageBox.Show("Escolha o veiculo! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (!erro)
                    {
                        Cdb.RealizarLocacao(alugar);
                        LimparCampos();
                    }
                }
                else if (rbtPessoaJ.Checked == true)
                {
                    alugar.data_locacao = DateTime.Parse(dtpLocacao.Text.ToString());
                    alugar.data_devolucao = DateTime.Parse(dtpDevolucao.Text.ToString());
                    alugar.tipo_locacao = cmbFormLoc.Text.ToString();
                    alugar.forma_pagamento = cmbFormPag.Text.ToString();
                    alugar.valor_locacao = txtValorServ.Text.ToString();
                   // alugar.car_id = cmbVeiculo.SelectedValue.ToString();
                    alugar.ckn_id = cmbVeiculo.SelectedValue.ToString();
                    alugar.pj_id = txtCodJur.Text.ToString();

                    if (string.IsNullOrEmpty(cmbFormLoc.Text))
                    {
                        erro = true;
                        MessageBox.Show("A forma de locacao deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(cmbFormPag.Text))
                    {
                        erro = true;
                        MessageBox.Show("A forma de pagamento deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(txtValorServ.Text))
                    {
                        erro = true;
                        MessageBox.Show("O valor da locacao deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (string.IsNullOrEmpty(txtCodJur.Text))
                    {
                        erro = true;
                        MessageBox.Show("Escolha um cliente para realizar a locacao! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (!erro)
                    {
                        Cdb.RealizarLocacao(alugar);
                        LimparCampos();
                    }
                    
                }
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar a locacao, verifique e tente novamente!", MessageBoxButtons.OK.ToString());
            }

        } // fecha o metodo

        // metodo responsavel por calcular o valor da locacao
        public long CalculoValor(System.DateTime DataInicial, System.DateTime DataFinal)
        {
            long data;
            System.TimeSpan ts = new TimeSpan(DataFinal.Ticks - DataInicial.Ticks);
            data = (long)(ts.Days / 1);
            return data;
        }

        // acao do botao calcular,
        private void Calcular_Click(object sender, EventArgs e)
        {
            
            DateTime dataInicioL = dtpLocacao.Value;
            DateTime dataFinalL = dtpDevolucao.Value;
            
            txtValorServ.Text = CalculoValor(dataInicioL, dataFinalL).ToString();

            try
            {
                if (txtValorServ.Text == "1" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 50,00";
                }
                else if (txtValorServ.Text == "1" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 30,00";               
                }


                else if (txtValorServ.Text == "2" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 80,00";
                }
                else if (txtValorServ.Text == "2" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 60,00";
                }

                else if (txtValorServ.Text == "3" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 110,00";
                }
                else if (txtValorServ.Text == "3" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 90,00";
                }


                else if (txtValorServ.Text == "4" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 140,00";
                }
                else if (txtValorServ.Text == "4" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 120,00";
                }

                else if (txtValorServ.Text == "5" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 170,00";
                }
                else if (txtValorServ.Text == "5" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 150,00";
                }

                else if (txtValorServ.Text == "6" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 200,00";
                }
                else if (txtValorServ.Text == "6" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 180,00";
                }

                else if (txtValorServ.Text == "7" && cmbFormLoc.Text == "KM Livre")
                {
                    txtValorServ.Text = "R$ 230,00";
                }
                else if (txtValorServ.Text == "7" && cmbFormLoc.Text == "KM Determinada")
                {
                    txtValorServ.Text = "R$ 210,00";
                }
                //else if (txtValorServ.Text == "0")
                //{
                //    MessageBox.Show("escola loc");
                //}
                else
                {
                    txtValorServ.Text = "0";
                    MessageBox.Show("A locacao so pode ser realizado no maximo 7 dias");
                }
               
            }
            catch (Exception)
            {
                throw;
            
            }
          
            //else if (txtValorServ.Text == "3")
            //{
            //    txtValorServ.Text = "R$ 90,00";
            //}
            //else if (txtValorServ.Text == "4")
            //{
            //    txtValorServ.Text = "R$ 120,00";
            //}
            //else if (txtValorServ.Text == "5")
            //{
            //    txtValorServ.Text = "R$ 150,00";
            //}
            //else if (txtValorServ.Text == "6")
            //{
            //    txtValorServ.Text = "R$ 180,00";
            //}
            //else if (txtValorServ.Text == "7")
            //{
            //    txtValorServ.Text = "R$ 210,00";
            //} 
            
           
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = gridView.Rows[index];

            try
            {
                if (rbtPessoaF.Checked == true)
                {
                    txtCodFis.Text = selectedRow.Cells[0].Value.ToString();
                    txtNome.Text = selectedRow.Cells[1].Value.ToString();
                    txtCpf.Text = selectedRow.Cells[2].Value.ToString();
                }
                else if (rbtPessoaJ.Checked == true)
                {
                    txtCodJur.Text = selectedRow.Cells[0].Value.ToString();
                    txtRazSoc.Text = selectedRow.Cells[1].Value.ToString();
                    txtCnpj.Text = selectedRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("escolha um campo", MessageBoxButtons.OK.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }














    }
}
