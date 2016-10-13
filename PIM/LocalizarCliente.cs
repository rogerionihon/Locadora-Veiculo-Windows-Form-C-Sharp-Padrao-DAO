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
    public partial class LocalizarCliente : Form
    {

        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Cliente novocliente = new Cliente(); // criacao do objeto do tipo Cliente

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        public LocalizarCliente()
        {
            InitializeComponent();
        }

        //Funcao responsavel por chamar o metodo que exibi todos os dados de pessoa fisica no datagridview
        public DataTable SelecionarPessoaFisica()
        {
           // DataTable dt = new DataTable();

            try
            {
                dt =  Cdb.returnDataTablePf();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os clientes: " + ex.Message);
            }
            return dt; // retorno do datatable
        }
      
        //Funcao responsavel por chamar o metodo que exibi os dados de pessoa juridica no datagridview
        public DataTable SelecionarPessoaJuridica()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Cdb.returnDataTablePj();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os clientes: " + ex.Message);
            }
            return dt; // retorno do datatable
        }

        // Metodo responsavel por carregar o datagridview Pessoa fisica
        private void CarregarGridPessoaF()
        {
            datagrid.DataSource = SelecionarPessoaFisica(); // chama o meto dao para listar todos os clientes

            // edita o cabecalho do datagridwiew
            datagrid.Columns[0].HeaderText = "Codigo";
            datagrid.Columns[1].HeaderText = "Nome";
            datagrid.Columns[2].HeaderText = "CPF";
            datagrid.Columns[3].HeaderText = "RNE";
            datagrid.Columns[4].HeaderText = "CNH";
            datagrid.Columns[5].HeaderText = "Data de Nascimento";
            datagrid.Columns[6].HeaderText = "E-mail";
            datagrid.Columns[7].HeaderText = "Telefone";
            datagrid.Columns[8].HeaderText = "Celular";
            datagrid.Columns[9].HeaderText = "Sexo";
            datagrid.Columns[10].HeaderText = "Estado Civil";
            datagrid.Columns[11].HeaderText = "Endereco";
            datagrid.Columns[12].HeaderText = "Numero";
            datagrid.Columns[13].HeaderText = "Complemento";
            datagrid.Columns[14].HeaderText = "CEP";
            datagrid.Columns[15].HeaderText = "Cidade";
            datagrid.Columns[16].HeaderText = "Bairro";
            datagrid.Columns[17].HeaderText = "UF";
            datagrid.Columns[18].HeaderText = "Observacao";
            datagrid.Columns[19].HeaderText = "Ativo";

            //edita o tamanho das colunas do datagridview
            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 300;
            datagrid.Columns[2].Width = 90;
            datagrid.Columns[3].Width = 90;
            datagrid.Columns[4].Width = 90;
            datagrid.Columns[5].Width = 70;
            datagrid.Columns[6].Width = 220;
            datagrid.Columns[7].Width = 90;
            datagrid.Columns[8].Width = 90;
            datagrid.Columns[9].Width = 80;
            datagrid.Columns[10].Width = 70;
            datagrid.Columns[11].Width = 260;
            datagrid.Columns[12].Width = 50;
            datagrid.Columns[13].Width = 100;
            datagrid.Columns[14].Width = 70;
            datagrid.Columns[15].Width = 230;
            datagrid.Columns[16].Width = 150;
            datagrid.Columns[17].Width = 90;
            datagrid.Columns[18].Width = 300;
            datagrid.Columns[19].Width = 50;
        }

        // Metodo responsavel por carregar o datagridview Pessoa juridica
        private void CarregarGridPessoaJ()
        {
            datagrid.DataSource = SelecionarPessoaJuridica(); // chama o meto dao para listar todos os clientes

            // edita o cabecalho do datagridwiew
            datagrid.Columns[0].HeaderText = "ID";
            datagrid.Columns[1].HeaderText = "Razao Social";
            datagrid.Columns[2].HeaderText = "CNPJ";
            datagrid.Columns[3].HeaderText = "Nome Fantasia";
            datagrid.Columns[4].HeaderText = "Inscricao estadual";
            datagrid.Columns[5].HeaderText = "inscricao municipal";
            datagrid.Columns[6].HeaderText = "E-mail";
            datagrid.Columns[7].HeaderText = "Telefone";
            datagrid.Columns[8].HeaderText = "Celular";
            datagrid.Columns[9].HeaderText = "Endereco";
            datagrid.Columns[10].HeaderText = "Numero";
            datagrid.Columns[11].HeaderText = "`Complemetnto";
            datagrid.Columns[12].HeaderText = "CEP";
            datagrid.Columns[13].HeaderText = "Cidade";
            datagrid.Columns[14].HeaderText = "Bairro";
            datagrid.Columns[15].HeaderText = "UF";
            datagrid.Columns[16].HeaderText = "Observacao";


            //edita o tamanho das colunas do datagridview
            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 300;
            datagrid.Columns[2].Width = 90;
            datagrid.Columns[3].Width = 90;
            datagrid.Columns[4].Width = 90;
            datagrid.Columns[5].Width = 70;
            datagrid.Columns[6].Width = 150;
            datagrid.Columns[7].Width = 90;
            datagrid.Columns[8].Width = 90;
            datagrid.Columns[9].Width = 80;
            datagrid.Columns[10].Width = 70;
            datagrid.Columns[11].Width = 150;
            datagrid.Columns[12].Width = 85;
            datagrid.Columns[13].Width = 100;
            datagrid.Columns[14].Width = 70;
            datagrid.Columns[15].Width = 85;
            datagrid.Columns[16].Width = 150;

        }
        
        //metodo loading
        private void LocalizarCliente_Load(object sender, EventArgs e)
        {
            CarregarGridPessoaF(); // chamando o metodo carregarGrid
            
        }

        //caso rbtPessoaFisica esteja em check
        private void rbtPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGridPessoaF(); // chamando o metodo carregarGrid
            grbPessoaJ.Visible = false; // esconde o formulario de pessoa juridica
            grbPessoaF.Visible = true; // mostra o formulario de pessoa fisica
        }

        //caso rbtPessoJuridica esteja em check
        private void rbtPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGridPessoaJ(); // chamando o metodo carregarGrid
            grbPessoaF.Visible = false; // esconde o formulario de pessoa fisica
            grbPessoaJ.Visible = true; // mostra o formulario de pessoa juridica
        }

        //metodo responsavel por fechar a pagina
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbEmpresariais_Enter(object sender, EventArgs e)
        {

        }

        private void grbCidadej_Enter(object sender, EventArgs e)
        {
            
        }

        //metodo responsavel por preencher o formulario de acordo com a linha selecionada no datagridview
        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = datagrid.Rows[index];
                if (rbtPessoaFisica.Checked == true) // caso pessoa fisica esteja em check
                {
                    
                    txtCodFis.Text = selectedRow.Cells[0].Value.ToString();
                    txtNome.Text = selectedRow.Cells[1].Value.ToString();
                    mskCpf.Text = selectedRow.Cells[2].Value.ToString();
                    txtRne.Text = selectedRow.Cells[3].Value.ToString();
                    txtCnh.Text = selectedRow.Cells[4].Value.ToString();
                    mskDtaNasc.Text = selectedRow.Cells[5].Value.ToString();
                    txtMailFis.Text = selectedRow.Cells[6].Value.ToString();
                    mskTelFis.Text = selectedRow.Cells[7].Value.ToString();
                    mskCelFis.Text = selectedRow.Cells[8].Value.ToString();
                    cmbSexo.Text = selectedRow.Cells[9].Value.ToString();
                    cmbCivil.Text = selectedRow.Cells[10].Value.ToString();
                    txtEndFis.Text = selectedRow.Cells[11].Value.ToString();
                    txtNumFis.Text = selectedRow.Cells[12].Value.ToString();
                    txtComFis.Text = selectedRow.Cells[13].Value.ToString();
                    mskCepFis.Text = selectedRow.Cells[14].Value.ToString();
                    txtCidFis.Text = selectedRow.Cells[15].Value.ToString();
                    txtBairFis.Text = selectedRow.Cells[16].Value.ToString();
                    cmbEstFis.Text = selectedRow.Cells[17].Value.ToString();
                    txtObsFis.Text = selectedRow.Cells[18].Value.ToString();
                }
                    else if (rbtPessoaJuridica.Checked == true) // caso a pessoa jurica esteja em check
	                {
                        
                        txtCodJur.Text = selectedRow.Cells[0].Value.ToString();
                        txtRazSoc.Text = selectedRow.Cells[1].Value.ToString();
                        txtNomFan.Text = selectedRow.Cells[2].Value.ToString();
                        mskInsEst.Text = selectedRow.Cells[3].Value.ToString();
                        mskInsMun.Text = selectedRow.Cells[4].Value.ToString();
                        mskCnpj.Text = selectedRow.Cells[5].Value.ToString();
                        mskTelJur.Text = selectedRow.Cells[6].Value.ToString();
                        mskCelJur.Text = selectedRow.Cells[7].Value.ToString();
                        txtMailJur.Text = selectedRow.Cells[8].Value.ToString();
                        mskCepJur.Text = selectedRow.Cells[9].Value.ToString();
                        txtBaiJur.Text = selectedRow.Cells[10].Value.ToString();
                        txtNumJur.Text = selectedRow.Cells[11].Value.ToString();
                        txtEndJur.Text = selectedRow.Cells[12].Value.ToString();
                        txtComJur.Text = selectedRow.Cells[13].Value.ToString();
                        txtCidJur.Text = selectedRow.Cells[14].Value.ToString();
                        cmbEstJur.Text = selectedRow.Cells[15].Value.ToString();
                        txtObsJur.Text = selectedRow.Cells[16].Value.ToString();
	                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("escolha um campo", ex.Message);
            }
        }

        //metodo responsavel por realizar a busca pelo NOME
        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("pf_nome LIKE '%{0}%'", txtPesqNome.Text);
            datagrid.DataSource = dv;
        }

        //metodo responsavel por realizar a busca pelo CPF
        private void txtPesqCpf_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("pf_cpf LIKE  '%{0}%'", txtPesqCpf.Text);
            datagrid.DataSource = dv;
        }

        //metodo responsavel por realizar a busca pelo CNPJ
        private void txtPesqCnpj_TextChanged(object sender, EventArgs e)
        {
            if (rbtPessoaJuridica.Checked)
	        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("pj_cnpj LIKE '%{0}%'", txtPesqCnpj.Text);
            datagrid.DataSource = dv;
            }
	    }

        
    }
}