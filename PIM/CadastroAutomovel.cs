using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CdbDao.ConnectionDataBase;
using CdbDao.ModelCliente;
using MySql.Data.MySqlClient;
using System.Configuration;
using CdbDao.Service;

namespace PIM
{
    public partial class CadastroAutomovel : Form
    {
        Dao cdb = new Dao(); //cria objeto do tipo Dao

        Veiculo veiculo = new Veiculo(); //cria objeto do tipo Veiculo

        Validacao validar = new Validacao(); //cria objeto do tipo Validacao
        public CadastroAutomovel()
        {
            InitializeComponent();
        }

        //metodo responsavel por fechar a pagina
        private void BtnCancelaAutomovel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        /*  private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
          {

          }*/

        // metodo responsavel por limpar os campos
        public void LimparCampos()
        {
            mskPlaca.Text = "";
            mskRenavam.Text = "";
            mskChassi.Text = "";
            cmbAnoFabric.Text = "";
            cmbAnoModelo.Text = "";
            txtModelo.Text = "";
            cmbMarca.Text = "";
            cmbCombustivel.Text = "";
            cmbCor.Text = "";
            cmbPortas.Text = "";
            cmbTipo.Text = "";
            txtKM.Text = "";
            txtCidade.Text = "";
            cmbEstado.Text = "";
            txtObs.Text = "";
        } // fecha o metodo

        // metodo responsavel por salvar os dados de cadastro
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                bool erro = false;

                veiculo.placa = (mskPlaca.Text).ToString();
                veiculo.renavam = (mskRenavam.Text).ToString();
                veiculo.chassi = (mskChassi.Text).ToString();
                veiculo.ano_fabricacao = (cmbAnoFabric.Text).ToString();
                veiculo.ano_modelo = (cmbAnoModelo.Text).ToString();
                veiculo.modelo = (txtModelo.Text).ToString();
                veiculo.marca = (cmbMarca.Text).ToString();
                veiculo.combustivel = (cmbCombustivel.Text).ToString();
                veiculo.cor = (cmbCor.Text).ToString();
                veiculo.num_portas = (cmbPortas.Text).ToString();
                veiculo.tipo = (cmbTipo.Text).ToString();
                veiculo.km = (txtKM.Text).ToString();
                veiculo.cidade = (txtCidade.Text).ToString();
                veiculo.uf = (cmbEstado.Text).ToString();
                veiculo.observacao = (txtObs.Text).ToString();

                if (string.IsNullOrEmpty(mskPlaca.Text)) // valida campo PLACA
                {
                    erro = true;
                    MessageBox.Show("A placa do veiculo deve ser informada! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(mskPlaca.Text, 7, 8)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("A placa do veiculo deve conter 7 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }  // fecha valicao PLACA

                if (string.IsNullOrEmpty(mskRenavam.Text)) // valida campo RENAVAM
                {
                    erro = true;
                    MessageBox.Show("O numero do renavam deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(mskRenavam.Text, 11, 12)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O renavam informado nao possui 11 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha validacao RENAVAM

                if (string.IsNullOrEmpty(mskChassi.Text)) // valida campo CHASSI
                {
                    erro = true;
                    MessageBox.Show("O numero do chassi deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(mskChassi.Text, 17, 18)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O chassi informado nao possui 17 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao CHASSI

                if (string.IsNullOrEmpty(cmbAnoFabric.Text)) // valida campo ANO FABRICACAO
                {
                    erro = true;
                    MessageBox.Show("O ano de fabricacao deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao ANO FABRICACAO

                if (string.IsNullOrEmpty(cmbAnoModelo.Text)) // valida campo ANO MODELO
                {
                    erro = true;
                    MessageBox.Show("O ano do modelo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao ANO MODELO

                if (string.IsNullOrEmpty(txtModelo.Text)) // valida campo MODELO
                {
                    erro = true;
                    MessageBox.Show("O modelo do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao MODELO

                if (string.IsNullOrEmpty(cmbMarca.Text)) // valida campo MARCA
                {
                    erro = true;
                    MessageBox.Show("A marca do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao MARCA

                if (string.IsNullOrEmpty(cmbCombustivel.Text)) // valida campo COMBUSTIVEL
                {
                    erro = true;
                    MessageBox.Show("O tipo do combustivel do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao COMBUSTIVEL

                if (string.IsNullOrEmpty(cmbCor.Text)) // valida campo COR    
                {
                    erro = true;
                    MessageBox.Show("A cor do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao COR

                if (string.IsNullOrEmpty(cmbPortas.Text)) // valida campo PORTAS
                {
                    erro = true;
                    MessageBox.Show("O numero de portas do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao NUMERO DE PORTAS

                if (string.IsNullOrEmpty(cmbTipo.Text)) // valida campo TIPO
                {
                    erro = true;
                    MessageBox.Show("O tipo do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao TIPO

                if (string.IsNullOrEmpty(txtKM.Text)) // valida campo KM
                {
                    erro = true;
                    MessageBox.Show("A  kilometragem do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao KM

                if (string.IsNullOrEmpty(txtCidade.Text)) // valida campo CIDADE
                {
                    erro = true;
                    MessageBox.Show("O nome da cidade do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao CIDADE

                if (string.IsNullOrEmpty(cmbEstado.Text)) // valida campo ESTADO
                {
                    erro = true;
                    MessageBox.Show("O nome do estado do veiculo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao ESTADO
                
                if(!erro)
                {
                    cdb.InsertVeiculo(veiculo); // chama o metodo dao inserir veiculo
                    LimparCampos(); // chama o metodo limpar campos
                }
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o veiculo :", ex.Message); // mensagem caso ocorra algum erro na operacao
            }
        } // fecha o metodo

        //metodo responsavel por os dados do formulario
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); // chama o metodo para limpar os campos
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
