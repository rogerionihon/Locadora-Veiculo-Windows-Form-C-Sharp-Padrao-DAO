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

namespace PIM
{
    public partial class CadastroAutomovel : Form
    {
        Dao cdb = new Dao();
        Veiculo veiculo = new Veiculo();
        public CadastroAutomovel()
        {
            InitializeComponent();
        }

        private void BtnCancelaAutomovel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CadastroAutomovel_Load(object sender, EventArgs e)
        {

        }

        public void LimparCampos()
        {
            mskPlaca.Text = "";
            mskRenavam.Text = "";
            mskChassi.Text = "";
            cmbFabric.Text = "";
            cbAnoModelo.Text = "";
            cmbModelo.Text = "";
            cbMarca.Text = "";
            cbCombustivel.Text = "";
            cbCor.Text = "";
            cbPortas.Text = "";
            cbTipo.Text = "";
            txtKM.Text = "";
            txtCidade.Text = "";
            cbUF.Text = "";
            txtObs.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             MySqlConnection con = null;

             try
             {
                 //string de conneccao centralizada
                string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString;
                
                con = new MySqlConnection(connectionString);
                con.Open();//abre a conneccao com o banco de dados

                veiculo.placa = (mskPlaca.Text).ToString();
                veiculo.renavam = (mskRenavam.Text).ToString();
                veiculo.chassi = (mskChassi.Text).ToString();
                veiculo.ano_fabricacao = (cmbFabric.Text).ToString();
                veiculo.ano_modelo = (cbAnoModelo.Text).ToString();
                veiculo.modelo = (cmbModelo.Text).ToString();
                veiculo.marca = (cbMarca.Text).ToString();
                veiculo.combustivel = (cbCombustivel.Text).ToString();
                veiculo.cor = (cbCor.Text).ToString();
                veiculo.num_portas = (cbPortas.Text).ToString();
                veiculo.tipo = (cbTipo.Text).ToString();
                veiculo.km = (txtKM.Text).ToString();
                veiculo.cidade = (txtCidade.Text).ToString();
                veiculo.uf = (cbUF.Text).ToString();
                veiculo.observacao = (txtObs.Text).ToString();
                cdb.InsertVeiculo(veiculo);
                LimparCampos();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Cadastro nao realizado", ex.Message);
             }
             finally
             {
                 con.Close();
             }     

                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
