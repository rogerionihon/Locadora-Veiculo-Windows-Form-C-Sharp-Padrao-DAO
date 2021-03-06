﻿using System;
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
using CdbDao.Service;

namespace PIM
{
    public partial class LocalizarVeiculo : Form
    {
        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Veiculo novoveiculo = new Veiculo(); // criacao do objeto do tipo veiculo

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Validacao validar = new Validacao(); // criacao do objeto do tipo validacao     
       
        public LocalizarVeiculo()
        {
            InitializeComponent();
        }

        //Metodo responsavel por exibi todos os dados de veiculo no datagridview
        public DataTable SelecionarVeiculo()
        {
            try
            {
                dt = Cdb.returnDatatableVeiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; //retorno do datatable
        } // fecha o metodo

        // Metodo responsavel por carregar o datagridview Pessoa fisica
        public void carregarGridVeiculo()
        {

            datagrid.DataSource = SelecionarVeiculo(); // chama o metodo datatable para listar os dados
            // edita o cabecalho do datagridwiew
            datagrid.Columns[0].Visible = false;
            datagrid.Columns[0].HeaderText = "Codigo";
            datagrid.Columns[1].HeaderText = "Placa";
            datagrid.Columns[2].HeaderText = "Modelo";
            datagrid.Columns[3].HeaderText = "Marca";
            datagrid.Columns[4].HeaderText = "Renavam";
            datagrid.Columns[5].HeaderText = "Chassi";
            datagrid.Columns[6].HeaderText = "Ano Fabricacao";
            datagrid.Columns[7].HeaderText = "Ano Modelo";
            datagrid.Columns[8].HeaderText = "Tipo";
            datagrid.Columns[9].HeaderText = "Cor";
            datagrid.Columns[10].HeaderText = "Portas";
            datagrid.Columns[11].HeaderText = "Combustivel";
            datagrid.Columns[12].HeaderText = "Kilometragem";
            datagrid.Columns[13].HeaderText = "Cidade";
            datagrid.Columns[14].HeaderText = "Estado";
            datagrid.Columns[15].HeaderText = "Observacoes";
            datagrid.Columns[16].HeaderText = "Ativo";
             
            //edita o tamanho das colunas do datagridview
            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 90;
            datagrid.Columns[2].Width = 220;
            datagrid.Columns[3].Width = 120;
            datagrid.Columns[4].Width = 90;
            datagrid.Columns[5].Width = 120;
            datagrid.Columns[6].Width = 80;
            datagrid.Columns[7].Width = 80;
            datagrid.Columns[8].Width = 50;
            datagrid.Columns[9].Width = 120;
            datagrid.Columns[10].Width = 50;
            datagrid.Columns[11].Width = 90;
            datagrid.Columns[12].Width = 90;
            datagrid.Columns[13].Width = 200;
            datagrid.Columns[14].Width = 90;
            datagrid.Columns[15].Width = 300;
            datagrid.Columns[16].Width = 50;
            
        }// fecha o metodo

        //metodo responsavel por limpar os campos do formulario
        public void limparCampos()
        {
            txtCod.Text = "";
            mskPlaca.Text = "";
            mskChassi.Text = "";
            mskRenavam.Text = "";
            cmbAnoF.Text = "";
            cmbAnoM.Text = "";
            cmbCombustivel.Text = "";
            cmbCor.Text = "";
            cmbEstado.Text = "";
            cmbMarca.Text = "";
            cmbPortas.Text = "";
            cmbTipo.Text = "";
            txtCidade.Text = "";
            txtKm.Text = "";
            txtModelo.Text = "";
            txtObs.Text = "";
            txtPesqModel.Text = "";
            txtPesqPlaca.Text = "";
            txtPesqRenavam.Text = "";
        }// fecha o metodo limpar campos

        // metodo loading
        private void LocalizarVeiculo_Load(object sender, EventArgs e)
        {
            carregarGridVeiculo(); // chama o metodo carregargridveiculo
            txtCod.Enabled = false;
        }// fecha o metodo load

        //metodo resposanvel por fecha a pagina
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        //metodo responsavel por realizar a busca pela placa
        private void txtPesqPlaca_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("car_placa LIKE '%{0}%'", txtPesqPlaca.Text); // compara o valor digitado no campo txtPesqNome com o valor que esta na coluna car_placa
            datagrid.DataSource = dv;
        } // fecha o metodo

        //metodo responsavel por realizar a busca pelo renavam
        private void txtPesqRenavam_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("car_renavam LIKE '%{0}%'", txtPesqRenavam.Text); // compara o valor digitado no campo txtPesqNome com o valor que esta na coluna car_renavam
            datagrid.DataSource = dv;
        } // fecha o metodo

        //metodo responsavel por realizar a busca pelo modelo
        private void txtPesqModel_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("car_modelo LIKE '%{0}%'", txtPesqModel.Text); // compara o valor digitado no campo txtPesqNome com o valor que esta na coluna car_modelo
            datagrid.DataSource = dv;
        } // fecha o metodo

        //metodo responsavel por realizar a atualizacao dos dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtVeiculo.Checked == true)
                {
                    atualizarVeiculo(); // chama o metodo atualizar veiculo
                    carregarGridVeiculo(); // carrega o datagridview com os dados ja atualizados
                    limparCampos(); // chama o metodo para limpar os campos
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Escolha algum campo para realizar a atualizacao", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); // exibe a mensagem caso nao seja escolhido algum campo para realizar a atualizacao
            }
        } // fecha o metodo

        //metodo responsavel por gerenciar a atualizacao dos campos de acordo com o campo selecionado
        public void atualizarVeiculo()
        {
            try
            {
                bool erro = false;

                novoveiculo.id = Int16.Parse(txtCod.Text);
                novoveiculo.placa = mskPlaca.Text.ToString();
                novoveiculo.modelo = txtModelo.Text.ToString();
                novoveiculo.marca = cmbMarca.Text.ToString();
                novoveiculo.renavam = mskRenavam.Text.ToString();
                novoveiculo.chassi = mskChassi.Text.ToString();
                novoveiculo.ano_fabricacao = cmbAnoF.Text.ToString();
                novoveiculo.ano_modelo = cmbAnoM.Text.ToString();
                novoveiculo.tipo = cmbTipo.Text.ToString();
                novoveiculo.cor = cmbCor.Text.ToString();
                novoveiculo.num_portas = cmbPortas.Text.ToString();
                novoveiculo.combustivel = cmbCombustivel.Text.ToString();
                novoveiculo.km = txtKm.Text.ToString();
                novoveiculo.cidade = txtCidade.Text.ToString();
                novoveiculo.uf = cmbEstado.Text.ToString();
                novoveiculo.observacao = txtObs.Text.ToString();

                if (string.IsNullOrEmpty(txtModelo.Text)) // valida campo modelo
                {
                    erro = true;
                    MessageBox.Show("O modelo do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao modelo

                if (string.IsNullOrEmpty(cmbAnoF.Text)) // valida campo ano fabricacao
                {
                    erro = true;
                    MessageBox.Show("O ano de fabricacao deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao ano fabricacao

                if (string.IsNullOrEmpty(cmbMarca.Text)) // valida campo marca
                {
                    erro = true;
                    MessageBox.Show("A marca do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao marca

                if (string.IsNullOrEmpty(cmbAnoM.Text)) // valida campo ano modelo
                {
                    erro = true;
                    MessageBox.Show("O ano do modelo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao ano modelo

                if (string.IsNullOrEmpty(mskPlaca.Text)) // valida campo placa
                {
                    erro = true;
                    MessageBox.Show("A placa do veiculo deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha validacao placa

                if (string.IsNullOrEmpty(mskChassi.Text)) // valida campo chassi
                {
                    erro = true;
                    MessageBox.Show("O numero do chassi deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(mskChassi.Text, 17, 18)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do chassi informado deve conter 17 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao chassi

                if (string.IsNullOrEmpty(cmbPortas.Text)) // valida campo numero de portas
                {
                    erro = true;
                    MessageBox.Show("O numero de portas do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao numero de portas

                if (string.IsNullOrEmpty(cmbCombustivel.Text)) // valida campo combustivel
                {
                    erro = true;
                    MessageBox.Show("O tipo do combustivel do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao combustivel

                if (string.IsNullOrEmpty(txtKm.Text)) // valida campo km
                {
                    erro = true;
                    MessageBox.Show("A  kilometragem do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao km

                if (string.IsNullOrEmpty(cmbTipo.Text)) // valida campo tipo
                {
                    erro = true;
                    MessageBox.Show("O tipo do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao tipo

                if (string.IsNullOrEmpty(cmbCor.Text)) // valida campo cor
                {
                    erro = true;
                    MessageBox.Show("A cor do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao cor

                if (string.IsNullOrEmpty(mskRenavam.Text)) // valida campo renavam
                {
                    erro = true;
                    MessageBox.Show("O numero do renavam deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(mskRenavam.Text, 11, 12)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do renavam deve conter 11 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha validacao renavam

                if (string.IsNullOrEmpty(txtCidade.Text)) // valida campo cidade
                {
                    erro = true;
                    MessageBox.Show("O nome da cidade deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao cidade

                if (string.IsNullOrEmpty(cmbEstado.Text)) // valida campo estado
                {
                    erro = true;
                    MessageBox.Show("O nome do estado deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao estado
               
                if (!erro)
                {
                    Cdb.UpdateVeiculo(novoveiculo); // chama o metodo DAO update veiculo
                }
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Escolha algum campo para realizar a atualizacao", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); // exibe a mensagem caso nao seja escolhido algum campo para realizar a atualizacao
            }
        } // fecha o metodo

        //metodo responsavel por preencher o formulario de acordo com a linha selecionada no datagridview
        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = datagrid.Rows[index];
                if (rbtVeiculo.Checked == true)
                {
                    txtCod.Text = selectRow.Cells[0].Value.ToString();
                    mskPlaca.Text = selectRow.Cells[1].Value.ToString();
                    txtModelo.Text = selectRow.Cells[2].Value.ToString();
                    cmbMarca.Text = selectRow.Cells[3].Value.ToString();
                    mskRenavam.Text = selectRow.Cells[4].Value.ToString();
                    mskChassi.Text = selectRow.Cells[5].Value.ToString();
                    cmbAnoF.Text = selectRow.Cells[6].Value.ToString();
                    cmbAnoM.Text = selectRow.Cells[7].Value.ToString();
                    cmbTipo.Text = selectRow.Cells[8].Value.ToString();
                    cmbCor.Text = selectRow.Cells[9].Value.ToString();
                    cmbPortas.Text = selectRow.Cells[10].Value.ToString();
                    cmbCombustivel.Text = selectRow.Cells[11].Value.ToString();
                    txtKm.Text = selectRow.Cells[12].Value.ToString();
                    txtCidade.Text = selectRow.Cells[13].Value.ToString();
                    cmbEstado.Text = selectRow.Cells[14].Value.ToString();
                    txtObs.Text = selectRow.Cells[15].Value.ToString();
                }// fecha o if
            }// fecha o try
            catch (Exception)
            {
                MessageBox.Show("Escolha um campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }// fecha o metodo

        //caso rbtveiculo esteja em check 
        private void rbtVeiculo_CheckedChanged(object sender, EventArgs e)
        {
            carregarGridVeiculo(); // chama o metodo carregargrid
            txtCod.Enabled = false; // deixa o campo codigo inativo
        }//fecha o metodo
        
    }// final da classe
}// final do namespace
