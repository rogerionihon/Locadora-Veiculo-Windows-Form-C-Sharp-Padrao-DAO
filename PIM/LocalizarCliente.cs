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
using CdbDao.Service;
using System.ServiceModel;


namespace PIM
{
    public partial class LocalizarCliente : Form
    {

        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Cliente novocliente = new Cliente(); // criacao do objeto do tipo Cliente

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Validacao validar = new Validacao(); // criacao do objeto do tipo validacao

        public LocalizarCliente()
        {
            InitializeComponent();
        }

        //Metodo responsavel por exibi todos os dados de pessoa fisica no datagridview
        public DataTable SelecionarPessoaFisica()
        {         
            try
            {
                dt =  Cdb.returnDataTablePf();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os clientes de pessoa fisica: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        } // fecha o metodo
      
        //Metodo responsavel por exibi todos os dados de pessoa juridica no datagridview
        public DataTable SelecionarPessoaJuridica()
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

        // Metodo responsavel por carregar o datagridview Pessoa fisica
        private void CarregarGridPessoaF()
        {
            datagrid.DataSource = SelecionarPessoaFisica(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            datagrid.Columns[0].Visible = false;
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
            datagrid.Columns[10].Width = 90;
            datagrid.Columns[11].Width = 260;
            datagrid.Columns[12].Width = 50;
            datagrid.Columns[13].Width = 140;
            datagrid.Columns[14].Width = 70;
            datagrid.Columns[15].Width = 230;
            datagrid.Columns[16].Width = 150;
            datagrid.Columns[17].Width = 90;
            datagrid.Columns[18].Width = 300;
            datagrid.Columns[19].Width = 50;
        }// fecha o metodo

        // Metodo responsavel por carregar o datagridview Pessoa juridica
        private void CarregarGridPessoaJ()
        {
            datagrid.DataSource = SelecionarPessoaJuridica(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            datagrid.Columns[0].Visible = false;
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
            datagrid.Columns[11].HeaderText = "Complemento";
            datagrid.Columns[12].HeaderText = "CEP";
            datagrid.Columns[13].HeaderText = "Cidade";
            datagrid.Columns[14].HeaderText = "Bairro";
            datagrid.Columns[15].HeaderText = "UF";
            datagrid.Columns[16].HeaderText = "Observacao";
            datagrid.Columns[17].HeaderText = "Ativo";

            //edita o tamanho das colunas do datagridview
            datagrid.Columns[0].Width = 50;
            datagrid.Columns[1].Width = 300;
            datagrid.Columns[2].Width = 120;
            datagrid.Columns[3].Width = 300;
            datagrid.Columns[4].Width = 90;
            datagrid.Columns[5].Width = 70;
            datagrid.Columns[6].Width = 220;
            datagrid.Columns[7].Width = 90;
            datagrid.Columns[8].Width = 90;
            datagrid.Columns[9].Width = 260;
            datagrid.Columns[10].Width = 50;
            datagrid.Columns[11].Width = 100;
            datagrid.Columns[12].Width = 70;
            datagrid.Columns[13].Width = 230;
            datagrid.Columns[14].Width = 150;
            datagrid.Columns[15].Width = 90;
            datagrid.Columns[16].Width = 300;
            datagrid.Columns[17].Width = 50;
        } // fecha o metodo

        //metodo responsavel por limpar os campos do formulario
        public void limparCampos()
        {
            // limpa os campos de pessoa fisica
            txtCodFis.Text = ""; 
            txtNome.Text = ""; 
            mskCpf.Text = ""; 
            txtRne.Text = ""; 
            mskCnh.Text = ""; 
            mskDtaNasc.Text = ""; 
            txtMailFis.Text = ""; 
            mskTelFis.Text =""; 
            mskCelFis.Text = ""; 
            cmbSexo.Text = ""; 
            cmbCivil.Text = ""; 
            txtEndFis.Text = ""; 
            txtNumFis.Text = ""; 
            txtComFis.Text = ""; 
            mskCepFis.Text = ""; 
            txtCidFis.Text = ""; 
            txtBairFis.Text = ""; 
            txtEstFis.Text = ""; 
            txtObsFis.Text = "";
            txtPesqNome.Text = "";
            txtPesqCpf.Text = "";

            // limpa os campos de pessoa juridica
            txtCodJur.Text = ""; 
            txtRazSoc.Text = ""; 
            mskCnpj.Text = ""; 
            txtNomFan.Text = ""; 
            mskInsEst.Text = ""; 
            mskInsMun.Text = ""; 
            txtMailJur.Text = ""; 
            mskTelJur.Text = ""; 
            mskCelJur.Text = ""; 
            txtEndJur.Text = ""; 
            txtNumJur.Text = ""; 
            txtComJur.Text = ""; 
            mskCepJur.Text = ""; 
            txtCidJur.Text = ""; 
            txtBaiJur.Text = ""; 
            txtEstJur.Text = "";
            txtObsJur.Text = "";
            txtPesqCnpj.Text = "";
        } // fecha o metodo

        //metodo loading
        private void LocalizarCliente_Load(object sender, EventArgs e)
        {
            CarregarGridPessoaF(); // chamando o metodo carregarGrid
            txtCodFis.Enabled = false; // deixa o campo codigo inativo
            txtCodJur.Enabled = false; // deixa o campo codigo inativo        
        } // fecha o metodo

        //caso rbtPessoaFisica esteja em check
        private void rbtPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGridPessoaF(); // chamando o metodo carregarGrid
            grbPessoaJ.Visible = false; // esconde o formulario de pessoa juridica
            grbPessoaF.Visible = true; // mostra o formulario de pessoa fisica
            txtCodFis.Enabled = false; // deixa o campo codigo inativo          
        } // fecha o metodo

        //caso rbtPessoJuridica esteja em check
        private void rbtPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGridPessoaJ(); // chamando o metodo carregarGrid
            grbPessoaF.Visible = false; // esconde o formulario de pessoa fisica
            grbPessoaJ.Visible = true; // mostra o formulario de pessoa juridica
            txtCodJur.Enabled = false;
        } // fecha o metodo

        //metodo responsavel por fechar a pagina
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

      /*  private void grbEmpresariais_Enter(object sender, EventArgs e)
        {

        } // fecha o metodo

        private void grbCidadej_Enter(object sender, EventArgs e)
        {
            
        } */

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
                    mskCnh.Text = selectedRow.Cells[4].Value.ToString();
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
                    txtEstFis.Text = selectedRow.Cells[17].Value.ToString();
                    txtObsFis.Text = selectedRow.Cells[18].Value.ToString();
                }// fecha o if rbtpessoafisica
                    else if (rbtPessoaJuridica.Checked == true) // caso a pessoa jurica esteja em check
	                {
                        
                        txtCodJur.Text = selectedRow.Cells[0].Value.ToString();
                        txtRazSoc.Text = selectedRow.Cells[1].Value.ToString();
                        mskCnpj.Text = selectedRow.Cells[2].Value.ToString();
                        txtNomFan.Text = selectedRow.Cells[3].Value.ToString();
                        mskInsEst.Text = selectedRow.Cells[4].Value.ToString();
                        mskInsMun.Text = selectedRow.Cells[5].Value.ToString();
                        txtMailJur.Text = selectedRow.Cells[6].Value.ToString();
                        mskTelJur.Text = selectedRow.Cells[7].Value.ToString();
                        mskCelJur.Text = selectedRow.Cells[8].Value.ToString();
                        txtEndJur.Text = selectedRow.Cells[9].Value.ToString();
                        txtNumJur.Text = selectedRow.Cells[10].Value.ToString();
                        txtComJur.Text = selectedRow.Cells[11].Value.ToString();
                        mskCepJur.Text = selectedRow.Cells[12].Value.ToString();
                        txtCidJur.Text = selectedRow.Cells[13].Value.ToString();
                        txtBaiJur.Text = selectedRow.Cells[14].Value.ToString();
                        txtEstJur.Text = selectedRow.Cells[15].Value.ToString();
                        txtObsJur.Text = selectedRow.Cells[16].Value.ToString();                      
	                }// fecha o if rbtpessoajuridica              
            }
            catch (Exception)
            {
                MessageBox.Show("Escolha um campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }//fecha o metodo cellclick

        //metodo responsavel por realizar a busca pelo nome
        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            if (rbtPessoaFisica.Checked == true)
            {
                
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("pf_nome LIKE '%{0}%'", txtPesqNome.Text); // compara o valor digitado no campo txtPesqNome com o valor que esta na coluna pf_nome
                datagrid.DataSource = dv;
            }// fecha o if
            else
            {
                MessageBox.Show("Escolha a opcao pessoa fisica!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }// fecha o else
        } // fecha o metodo

        //metodo responsavel por realizar a busca pelo cpf
        private void txtPesqCpf_TextChanged(object sender, EventArgs e)
        {
            if (rbtPessoaFisica.Checked == true)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("pf_cpf LIKE  '%{0}%'", txtPesqCpf.Text); // compara o valor digitado no campo txtPesqCpf com o valor que esta na coluna pf_cpf
                datagrid.DataSource = dv;
            }// fecha o if
            else
            {
                MessageBox.Show("Escolha a opcao pessoa fisica!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }// fecha o else
        } // fecha o metodo

        //metodo responsavel por realizar a busca pelo CNPJ
        private void txtPesqCnpj_TextChanged(object sender, EventArgs e)
        {
           
            if (rbtPessoaJuridica.Checked == true)
	        {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("pj_cnpj LIKE '%{0}%'", txtPesqCnpj.Text); // compara o valor digitado no campo txtPesqCnpj com o valor que esta na coluna pj_cnpj
                datagrid.DataSource = dv;
            }// fecha o if
            else
            {
                MessageBox.Show("Escolha a opcao pessoa juridica!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }// fecha o else
	    } // fecha o metodo

        //metodo responsavel por realizar a atualizacao dos dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtPessoaFisica.Checked == true)
                {
                    AtualizarPessoaFisica(); // chama o metodo atualizar pessoa fisica
                    CarregarGridPessoaF(); // carrega o datagridview com os dados ja atualizados
                    limparCampos(); // chama e metodo para limpar os campos
                }
                else if (rbtPessoaJuridica.Checked == true)
                {
                    AtualizarPessoaJuridica(); // chama o metodo atualizar pessoa juridica
                    CarregarGridPessoaJ(); // carrega o datagridview com os dados ja atualizados
                    limparCampos(); // chama e metodo para limpar os campos
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Escolha algum campo para realizar a atualizacao", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); // exibe a mensagem caso nao seja escolhido algum campo para realizar a atualizacao
            }
         } // fecha o metodo

        //metodo responsavel por gerenciar a atualizacao dos campos de acordo com o campo selecionado de pessoa fisica
        public void AtualizarPessoaFisica()
        {
            try
            {

                bool erro = false;

                novocliente.Id = Int16.Parse(txtCodFis.Text);
                novocliente.nome = txtNome.Text.ToString();
                novocliente.cpf = mskCpf.Text.ToString();
                novocliente.rne = txtRne.Text.ToString();
                novocliente.cnh = mskCnh.Text.ToString();
                novocliente.data_nascimento = mskDtaNasc.Text.ToString();
                novocliente.email = txtMailFis.Text.ToString();
                novocliente.telefone = mskTelFis.Text.ToString();
                novocliente.celular = mskCelFis.Text.ToString();
                novocliente.sexo = cmbSexo.Text.ToString();
                novocliente.Estado_civil = cmbCivil.Text.ToString();
                novocliente.endereco = txtEndFis.Text.ToString();
                novocliente.numero_casa = txtNumFis.Text.ToString();
                novocliente.complemento = txtComFis.Text.ToString();
                novocliente.cep = mskCepFis.Text.ToString();
                novocliente.cidade = txtCidFis.Text.ToString();
                novocliente.bairro = txtBairFis.Text.ToString();
                novocliente.estado = txtEstFis.Text.ToString();
                novocliente.observacoes = txtObsFis.Text.ToString();

                if (string.IsNullOrEmpty(txtNome.Text)) // valida campo nome
                {
                    erro = true;
                    MessageBox.Show("O nome deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(txtNome.Text, 5, 45)) { }
                else
                {
                    erro = true;
                    MessageBox.Show(" O nome deve conter no minimo 5 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// fecha a validacao nome

                if (string.IsNullOrEmpty(cmbSexo.Text)) // valida campo sexo
                {
                    erro = true;
                    MessageBox.Show("O sexo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao sexo

                if (string.IsNullOrEmpty(mskCpf.Text)) // valida campo cpf
                {
                    erro = true;
                    MessageBox.Show(" O numero do CPF deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.validaCPF(mskCpf.Text)) { } 
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do CPF informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// fecha a validacao cpf

                if (string.IsNullOrEmpty(cmbCivil.Text)) // valida campo estado civil
                {
                    erro = true;
                    MessageBox.Show("O estado civil deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao estado civil

                if (string.IsNullOrEmpty(mskDtaNasc.Text)) // valida campo data nascimento
                {
                    erro = true;
                    MessageBox.Show(" A data de nascimento deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao data de nascimento

                if (string.IsNullOrEmpty(mskTelFis.Text)) // valida campo telefon
                {
                    erro = true;
                    MessageBox.Show("O numero do telefone deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidaTelefone(mskTelFis.Text)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do telefone informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao telefone

                if (string.IsNullOrEmpty(mskCelFis.Text)) // valida campo celular
                {
                    erro = true;
                    MessageBox.Show("O numero do celular deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidarCelular(mskCelFis.Text)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do celular informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao celular

                if (string.IsNullOrEmpty(mskCnh.Text)) // valida o campo cnh
                {
                    erro = true;
                    MessageBox.Show(" O numero da cnh deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.isLimitCaract(mskCnh.Text, 11, 12)) { } 
                else
                {
                    erro = true;
                    MessageBox.Show("A CNH informada deve conter 11 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao cnh

                if (validar.ValidarEmail(txtMailFis.Text)) { } // valida campo email
                else
                {
                    erro = true;
                    MessageBox.Show("O Email informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// fecha a validacao email
            
                if (string.IsNullOrEmpty(mskCepFis.Text)) // valida campo cep
                {
                    erro = true;
                    MessageBox.Show("O numero do CEP deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidaCEP(mskCepFis.Text)) { } 
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do CEP informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao cep

                if (string.IsNullOrEmpty(txtBairFis.Text)) // valida campo bairro
                {
                    erro = true;
                    MessageBox.Show("O nome do bairro deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao bairro

                if (string.IsNullOrEmpty(txtNumFis.Text)) // valida campo numero
                {
                    erro = true;
                    MessageBox.Show("O numero do imovel deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao numero 

                if (string.IsNullOrEmpty(txtEndFis.Text)) // valida campo endereco
                {
                    erro = true;
                    MessageBox.Show("O endereco deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// fecha a validacao endereco

                if (string.IsNullOrEmpty(txtCidFis.Text)) // valida campo cidade
                {
                    erro = true;
                    MessageBox.Show("O nome da cidade deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao cidade

                if (string.IsNullOrEmpty(txtEstFis.Text)) // valida campo estado
                {
                    erro = true;
                    MessageBox.Show("O nome do estado deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao estado

                if(!erro)
                {
                    Cdb.UpdatePessoaFisica(novocliente); // chama o metodo DAO atualizar pessoa fisica 
                }
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel realizar a atualizacao, verifique e tente novamamente!", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // exibe a mensagem caso nao seja realizado a atualizacao
            }
        } // fecha o metodo

        //metodo responsavel por gerenciar a atualizacao dos campos de acordo com o campo selecionado de pessoa juridica
        public void AtualizarPessoaJuridica()
        {
            try
            {
                bool erro = false;

                novocliente.Id = Int16.Parse(txtCodJur.Text);
                novocliente.razao_social = txtRazSoc.Text.ToString();
                novocliente.cnpj = mskCnpj.Text.ToString();
                novocliente.nome_fantasia = txtNomFan.Text.ToString();
                novocliente.insc_estadual = mskInsEst.Text.ToString();
                novocliente.insc_municipal = mskInsMun.Text.ToString();
                novocliente.email = txtMailJur.Text.ToString();
                novocliente.telefone = mskTelJur.Text.ToString();
                novocliente.celular = mskCelJur.Text.ToString();
                novocliente.endereco = txtEndJur.Text.ToString();
                novocliente.numero_casa = txtNumJur.Text.ToString();
                novocliente.complemento = txtComJur.Text.ToString();
                novocliente.cep = mskCepJur.Text.ToString();
                novocliente.cidade = txtCidJur.Text.ToString();
                novocliente.bairro = txtBaiJur.Text.ToString();
                novocliente.estado = txtEstJur.Text.ToString();
                novocliente.observacoes = txtObsJur.Text.ToString();

                if (string.IsNullOrEmpty(txtRazSoc.Text)) // valida campo razao social
                {
                    erro = true;
                    MessageBox.Show("A razao social deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao da razao social

                if (validar.isLimitCaract(mskInsEst.Text, 12, 13)) { } // valida campo inscricao estadual
                else
                {
                    erro = true;
                    MessageBox.Show("A inscricao estadual informada deve conter 12 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao da inscricao estadual

                if (string.IsNullOrEmpty(txtNomFan.Text)) // valida campo nome fantasia
                {
                    erro = true;
                    MessageBox.Show("O nome fantasia deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do nome fantasia

                if (validar.isLimitCaract(mskInsMun.Text, 8, 9)) { } // valida campo inscricao municipal
                else
                {
                    erro = true;
                    MessageBox.Show("A inscricao municipal informada deve conter 8 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao da inscricao municipal

                if (string.IsNullOrEmpty(mskCnpj.Text)) // valida campo cnpj
                {
                    erro = true;
                    MessageBox.Show("O numero do CNPJ deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidaCNPJ(mskCnpj.Text)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do CNPJ informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do cnpj

                if (string.IsNullOrEmpty(mskTelJur.Text)) // valida campo telefone
                {
                    erro = true;
                    MessageBox.Show("O numero do telefone deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidaTelefone(mskTelJur.Text)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do telefone informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do telefone

                if (string.IsNullOrEmpty(mskCelJur.Text)) // valida campo celular
                {
                    erro = true;
                    MessageBox.Show("O numero do celular deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidarCelular(mskCelJur.Text)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do celular informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do celular

                if (validar.ValidarEmail(txtMailJur.Text)) { } // valida campo email
                else
                {
                    erro = true;
                    MessageBox.Show("O Email informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// fecha a validacao do  email

                if (string.IsNullOrEmpty(mskCepJur.Text)) // valida campo cep
                {
                    erro = true;
                    MessageBox.Show("O numero do CEP deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validar.ValidaCEP(mskCepJur.Text)) { }
                else
                {
                    erro = true;
                    MessageBox.Show("O numero do CEP informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do cep

                if (string.IsNullOrEmpty(txtBaiJur.Text)) // valida campo bairro
                {
                    erro = true;
                    MessageBox.Show("O nome do bairro deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do bairro

                if (string.IsNullOrEmpty(txtNumJur.Text)) // valida campo numero
                {
                    erro = true;
                    MessageBox.Show("O numero do imovel deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do numero

                if (string.IsNullOrEmpty(txtEndJur.Text)) // valida campo endereco
                {
                    erro = true;
                    MessageBox.Show("O endereco deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// fecha a validacao do endereco

                if (string.IsNullOrEmpty(txtCidJur.Text)) // valida campo cidade
                {
                    erro = true;
                    MessageBox.Show("O nome da cidade deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao da cidade

                if (string.IsNullOrEmpty(txtEstJur.Text)) // valida campo estado
                {
                    erro = true;
                    MessageBox.Show("O nome do estado deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } // fecha a validacao do ESTADO

                if (!erro)
                {
                    Cdb.UpdatePessoaJuridica(novocliente);//chama o metodo DAO atualizar pessoa juridica
                }
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel realizar a atualizacao, verifique e tente novamamente!", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // exibe a mensagem caso nao seja realizado a atualizacao
            }   
        }

        // metodo responsavel por consultar o CEP de pessoa juridica
        private void btnConsultJur_Click(object sender, EventArgs e)
        {
            ServiceCorreios.AtendeClienteClient consulta = new ServiceCorreios.AtendeClienteClient("AtendeClientePort");

            try
            {
                if (rbtPessoaJuridica.Checked == true)
                {
                    var resultado = consulta.consultaCEP(mskCepJur.Text);

                    if (resultado != null)
                    {
                        txtEndJur.Text = resultado.end;
                        txtComJur.Text = resultado.complemento;
                        txtBaiJur.Text = resultado.bairro;
                        txtCidJur.Text = resultado.cidade;
                        txtEstJur.Text = resultado.uf;
                        txtNumJur.Text = "";
                    } // fecha o if
                } // fecga o rbtPessoaJur    
            } // fecha o try
            catch (FaultException)
            {
                MessageBox.Show("CEP não foi encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCepJur.Focus();
            }
            catch (CommunicationException)
            {
                MessageBox.Show("Não foi possivel realizar a operação. Verifique sua conexão com a internet!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCepJur.Focus();
            }
        }// fecha o metodo

        // metodo responsavel por consultar o CEP de pessoa fisica
        private void btnConsultFis_Click(object sender, EventArgs e)
        {
            ServiceCorreios.AtendeClienteClient consulta = new ServiceCorreios.AtendeClienteClient("AtendeClientePort");

            try
            {
                if (rbtPessoaFisica.Checked == true)
                {
                    var resultado = consulta.consultaCEP(mskCepFis.Text);

                    if (resultado != null)
                    {
                        txtEndFis.Text = resultado.end;
                        txtComFis.Text = resultado.complemento;
                        txtBairFis.Text = resultado.bairro;
                        txtCidFis.Text = resultado.cidade;
                        txtEstFis.Text = resultado.uf;
                        txtNumFis.Text = "";

                    } // fecha o if
                } // fecha o if rbtPessoaFis
            } // fecha o try
            catch (FaultException)
            {
                MessageBox.Show("CEP não foi encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCepFis.Focus();
            }
            catch (CommunicationException)
            {
                MessageBox.Show("Não foi possivel realizar a operação. Verifique sua conexão com a internet!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCepFis.Focus();
            }
        } // fecha o metodo
    } // final da clase
} // final do namespace