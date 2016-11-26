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

namespace PIM
{
    public partial class Checkin : Form
    {
        Dao cdb = new Dao(); // criacao do objeto do tipo dao

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        CheckinCheckout checkin = new CheckinCheckout(); // criacao do objeto do tipo chechinChechout
        public Checkin()
        {
            InitializeComponent();
        }

        // metodo para sair do checkin
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        // metodo para limpar os campos do formulario
        public void limparCampos()
        {
            ckbParachoqueDiant.Checked = false;
            ckbParachoqueTras.Checked = false;
            ckbParabrisaDiant.Checked = false;
            ckbParabrisaTras.Checked = false;
            ckbVidroDiant.Checked = false;
            ckbVidroTras.Checked = false;
            ckbVidroDiantDir.Checked = false;
            ckbVidroDiantEsq.Checked = false;
            ckbVidroTrasDir.Checked = false;
            ckbVidroTrasEsq.Checked = false;
            ckbPortDiantDir.Checked = false;
            ckbPortDiantEsq.Checked = false;
            ckbPortTrasDir.Checked = false;
            ckbPortTrasEsq.Checked = false;
            ckbRodDiantDir.Checked = false;
            ckbRodDiantEsq.Checked = false;
            ckbRodTrasDir.Checked = false;
            ckbRodTrasEsq.Checked = false;
            ckbPneuDiantDir.Checked = false;
            ckbPneuDiantEsq.Checked = false;
            ckbPneuTrasDir.Checked = false;
            ckbPneuTrasEsq.Checked = false;
        } // fecha o metodo

        // metodo que limpa os campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        } // fecha o metodo

        // metodo que salva os valores do formulario
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                checkin.parabrisa_diant = ckbParabrisaDiant.Checked;
                checkin.parabrisa_tras = ckbParabrisaTras.Checked;
                checkin.vidro_dianteiro = ckbVidroDiant.Checked;
                checkin.vidro_traseiro = ckbVidroTras.Checked;
                checkin.vidro_diant_esq = ckbVidroDiantEsq.Checked;
                checkin.vidro_diant_dir = ckbVidroDiantDir.Checked;
                checkin.vidro_tras_esq = ckbVidroTrasEsq.Checked;
                checkin.vidro_tras_dir = ckbVidroTrasDir.Checked;
                checkin.port_diant_esq = ckbPortDiantEsq.Checked;
                checkin.port_diant_dir = ckbPortDiantDir.Checked;
                checkin.port_tras_esq = ckbPortTrasEsq.Checked;
                checkin.port_tras_dir = ckbPortTrasDir.Checked;
                checkin.parachoque_diant = ckbParabrisaDiant.Checked;
                checkin.parachoque_tras = ckbParachoqueTras.Checked;
                checkin.roda_diant_esq = ckbRodDiantEsq.Checked;
                checkin.roda_diant_dir = ckbRodDiantDir.Checked;
                checkin.roda_tras_esq = ckbRodTrasEsq.Checked;
                checkin.roda_tras_dir = ckbRodTrasDir.Checked;
                checkin.pneu_diant_esq = ckbPneuDiantEsq.Checked;
                checkin.pneu_diant_dir = ckbPneuDiantDir.Checked;
                checkin.pneu_tras_esq = ckbPneuTrasEsq.Checked;
                checkin.pneu_tras_dir = ckbPneuTrasDir.Checked;
                checkin.car_id = cmbVeiculo.SelectedIndex.ToString();

                if (rbtDisponivel.Checked == true)
                {
                    checkin.status = "Disponivel";
                }
                else if (rbtIndisponivel.Checked == true)
                {
                    checkin.status = "Indisponivel";
                }

                cdb.RealizarCheckin(checkin);
                limparCampos();
                this.Close();  
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar o checkin, verifique os campos e tente novamente: ", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // exibe a mensagem caso nao seja possivel realizar o checkin
            }    
        } // fecha o metodo

        // metodo que retorna lista de veiculos
        public DataTable ListarCar()
        {
            try
            {
                dt = cdb.listarVeiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo

        // metodo que ao iniciar carrega a lista de veiculo no combo box
        private void Checkin_Load(object sender, EventArgs e)
        {
            cmbVeiculo.DisplayMember = "car_modelo";
            cmbVeiculo.SelectedValue = "car_id";
            cmbVeiculo.DataSource = ListarCar();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
