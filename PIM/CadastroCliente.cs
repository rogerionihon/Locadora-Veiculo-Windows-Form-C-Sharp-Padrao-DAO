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
    public partial class CadastroCliente : Form
    {
        Dao Cdb = new Dao();

        Cliente novocliente = new Cliente();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        //metodo para sair do formulario
        private void BtnCancelaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo para limpar os campos preenchidos
        public void LimparCampos()
        {
            //campos pessoa fisica
            txtNome.Text = "";
            mskCpf.Text = "";
            txtCnh.Text = "";
            txtRne.Text = "";
            mskCelularf.Text = "";
            mskTelefonef.Text = "";
            cmbSexof.Text = "";
            txtEmailf.Text = "";
            cmbEst_civilf.Text = "";
            mskDta_nascf.Text = "";
            txtEndf.Text = "";
            txtNumf.Text = "";
            txtComplemf.Text = "";
            txtCidadef.Text = "";
            cmbEstadof.Text = "";
            txtBairrof.Text = "";
            txtobsf.Text = "";
            mskCepf.Text = "";

            //campos pessoa juridica
            txtRazaosocial.Text = "";
            txtNomefantasia.Text = "";
            txtCnpj.Text = "";
            txtInsc_estadual.Text = "";
            txtInsc_municipal.Text = "";
            mskCelularj.Text = "";
            msktelefonej.Text = "";
            txtemailj.Text = "";
            mskCepjur.Text = "";
            txtComplemjur.Text = "";
            txtCidadejur.Text = "";
            cmbEstadojur.Text = "";
            txtobsj.Text = "";
            txtBairrojur.Text = "";
            txtEndjur.Text = "";
            txtNumjur.Text = "";
           
            
            

        }

        //metodo que limpa os dados do formulario
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //metodo que grava as informacoes preenchidas no formulario
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            try
            {
                //string de conneccao centralizada
                string connectionString = ConfigurationManager.ConnectionStrings["BancoLocadora"].ConnectionString;
                
                con = new MySqlConnection(connectionString);
                con.Open();//abre a conneccao com o banco de dados

                if (rbtPessoafis.Checked == true)  //caso pessoa fisica esteja em check
                {
                    novocliente.nome = (txtNome.Text).ToString();
                    novocliente.cpf = (mskCpf.Text).ToString();
                    novocliente.cnh = (txtCnh.Text).ToString();
                    novocliente.rne = (txtRne.Text).ToString();
                    novocliente.celular = (mskCelularf.Text).ToString();
                    novocliente.telefone = (mskTelefonef.Text).ToString();
                    novocliente.sexo = (cmbSexof.Text).ToString();
                    novocliente.email = (txtEmailf.Text).ToString();
                    novocliente.Estado_civil = (cmbEst_civilf.Text).ToString();
                    novocliente.data_nascimento = (mskDta_nascf.Text).ToString();
                    novocliente.cep = (mskCepf.Text).ToString();
                    novocliente.endereco = (txtEndf.Text).ToString();
                    novocliente.numero_casa = (txtNumf.Text).ToString();
                    novocliente.complemento = (txtComplemf.Text).ToString();
                    novocliente.cidade = (txtCidadef.Text).ToString();
                    novocliente.estado = (cmbEstadof.Text).ToString();
                    novocliente.observacoes = (txtobsf.Text).ToString();
                    novocliente.bairro = (txtBairrof.Text).ToString();
                    Cdb.InserirPessoaFisica(novocliente);
                    LimparCampos();
                }
                else if (rbtPessoajur.Checked == true) //caso pessoa juridica esteja em check
                {
                    novocliente.razao_social = (txtRazaosocial.Text).ToString();
                    novocliente.nome_fantasia = (txtNomefantasia.Text).ToString();
                    novocliente.cnpj = (txtCnpj.Text).ToString();
                    novocliente.insc_estadual = (txtInsc_estadual.Text).ToString();
                    novocliente.insc_municipal = (txtInsc_municipal.Text).ToString();
                    novocliente.celular = (mskCelularj.Text).ToString();
                    novocliente.telefone = (msktelefonej.Text).ToString();
                    novocliente.email = (txtemailj.Text).ToString();
                   // novocliente.data_nascimento = (mskNascimento.Text).ToString();
                    novocliente.cep = (mskCepjur.Text).ToString();
                    novocliente.endereco = (txtEndjur.Text).ToString();
                    novocliente.numero_casa = (txtNumjur.Text).ToString();
                    novocliente.complemento = (txtComplemjur.Text).ToString();
                    novocliente.cidade = (txtCidadejur.Text).ToString();
                    novocliente.estado = (cmbEstadojur.Text).ToString();
                    novocliente.observacoes = (txtobsj.Text).ToString();
                    novocliente.bairro = (txtBairrojur.Text).ToString();
                    //fazer o dao de adicao do cliente fisico
                }       
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                if (txtNome.Text == "")
                {
                    MessageBox.Show("O nome deve ser informado", MessageBoxButtons.OK.ToString());
                        txtNome.Focus();
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }

      
    /*    private void RbtPessoaFChanged(object sender, EventArgs e)
        {
            
        }

        
        private void rbtPessoaj_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
*/
        // deixa visible os campos pessoa fisica quando selecionado
        private void rbtPessoaf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoafis.Checked == true)
            {
                // chama o metedo para limpar os campos
                LimparCampos();

                //campos visiveis de pessoa fisica
                txtNome.Visible = true;
                mskCpf.Visible = true;
                txtCnh.Visible = true;
                txtRne.Visible = true;
                mskCelularf.Visible = true;
                mskTelefonef.Visible = true;
                cmbSexof.Visible = true;
                txtEmailf.Visible = true;
                cmbEst_civilf.Visible = true;
                mskDta_nascf.Visible = true;
                mskCepf.Visible = true;
                txtEndf.Visible = true;
                txtNumf.Visible = true;
                txtComplemf.Visible = true;
                txtCidadef.Visible = true;
                cmbEstadof.Visible = true;
                txtobsf.Visible = true;
                txtBairrof.Visible = true;
                grbDadospessoais.Visible = true;
                grbEnderecof.Visible = true;
                grbInfof.Visible = true;
               
                
                //campos invisiveis de pessoa juridica
                txtRazaosocial.Visible = false;
                txtNomefantasia.Visible = false;
                txtCnpj.Visible = false;
                txtInsc_estadual.Visible = false;
                txtInsc_municipal.Visible = false;
                txtemailj.Visible = false;
                msktelefonej.Visible = false;
                mskCelularj.Visible = false;
                txtEndjur.Visible = false;
                txtNumjur.Visible = false;
                txtComplemjur.Visible = false;
                mskCepjur.Visible = false;
                txtCidadejur.Visible = false;
                txtBairrojur.Visible = false;
                cmbEstadojur.Visible = false;
                txtobsj.Visible = false;
                grbEmpresariais.Visible = false;
                rbtPessoajur.Checked = false;
                grbEndj.Visible= false;
                grbInfoj.Visible = false;

             
            }
        }

        // deixa visible os campos pessoa juridica quando selecionado
        private void rbtPessoaj_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtPessoajur.Checked == true)
            {
                // chama o metedo para limpar os campos
            LimparCampos();

            //campos visiveis de pessoa juridica
            txtRazaosocial.Visible = true;
            txtNomefantasia.Visible = true;
            txtCnpj.Visible = true;
            txtInsc_estadual.Visible = true;
            txtInsc_municipal.Visible = true;
            txtemailj.Visible = true;
            msktelefonej.Visible = true;
            mskCelularj.Visible = true;
            txtEndjur.Visible = true;
            txtNumjur.Visible = true;
            txtComplemjur.Visible = true;
            mskCepjur.Visible = true;
            txtCidadejur.Visible = true;
            txtBairrojur.Visible = true;
            cmbEstadojur.Visible = true;
            txtobsj.Visible = true;
            grbEmpresariais.Visible = true;
            grbEndj.Visible = true;
            grbInfoj.Visible = true;

            //campos invisiveis de pessoa fisica
            txtNome.Visible = false;
            mskCpf.Visible = false;
            txtCnh.Visible = false;
            txtRne.Visible = false;
            mskCelularf.Visible = false;
            mskTelefonef.Visible = false;
            cmbSexof.Visible = false;
            txtEmailf.Visible = false;
            cmbEst_civilf.Visible = false;
            mskDta_nascf.Visible = false;
            mskCepf.Visible = false;
            txtEndf.Visible = false;
            txtNumf.Visible = false;
            txtComplemf.Visible = false;
            txtCidadef.Visible = false;
            cmbEstadof.Visible = false;
            txtobsf.Visible = false;
            txtBairrof.Visible = false;
            grbDadospessoais.Visible = false;
            rbtPessoafis.Checked = false;
            grbDadospessoais.Visible = false;
            grbEnderecof.Visible = false;
            grbInfof.Visible = false;

            }
          
        }

    }
}
