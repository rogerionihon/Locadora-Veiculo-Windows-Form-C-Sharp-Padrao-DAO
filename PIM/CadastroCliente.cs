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
    public partial class CadastroCliente : Form
    {
        Dao Cdb = new Dao(); // cria objeto do tipo Dao

        Cliente novocliente = new Cliente(); // cria objeto do tipo Cliente

        Validacao validar = new Validacao(); // cria objeto do tipo Validacao
        public CadastroCliente()
        {
            InitializeComponent();
        }

        //metodo para sair do formulario
        private void BtnCancelaCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } // fecha o metodo

        //metodo para limpar os campos preenchidos
        public void LimparCampos()
        {
            //limpa os campos de pessoa fisica
            txtNome.Text = "";
            mskCpf.Text = "";
            mskCnh.Text = "";
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

            // limpa os campos de pessoa juridica
            txtRazaosocial.Text = "";
            txtNomefantasia.Text = "";
            mskCnpj.Text = "";
            mskIncr_est.Text = "";
            mskInsc_mun.Text = "";
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
        } // fecha o metodo

        //metodo que limpa os dados do formulario
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); // chama o metodo para limpar os campos
        } // fecha o metodo

        //metodo que grava as informacoes preenchidas no formulario
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                bool erro = false;
                if (rbtPessoafis.Checked == true)  //caso pessoa fisica esteja em check
                {                   
                    novocliente.nome = (txtNome.Text).ToString();
                    novocliente.cpf = (mskCpf.Text).ToString();
                    novocliente.rne = (txtRne.Text).ToString();
                    novocliente.cnh = (mskCnh.Text).ToString();
                    novocliente.data_nascimento = (mskDta_nascf.Text).ToString();
                    novocliente.email = (txtEmailf.Text).ToString();
                    novocliente.telefone = (mskTelefonef.Text).ToString();
                    novocliente.celular = (mskCelularf.Text).ToString();
                    novocliente.sexo = (cmbSexof.Text).ToString();
                    novocliente.Estado_civil = (cmbEst_civilf.Text).ToString();
                    novocliente.endereco = (txtEndf.Text).ToString();
                    novocliente.numero_casa = (txtNumf.Text).ToString();
                    novocliente.complemento = (txtComplemf.Text).ToString();
                    novocliente.cep = (mskCepf.Text).ToString();
                    novocliente.cidade = (txtCidadef.Text).ToString();
                    novocliente.bairro = (txtBairrof.Text).ToString();
                    novocliente.estado = (cmbEstadof.Text).ToString();
                    novocliente.observacoes = (txtobsf.Text).ToString();

                    if (string.IsNullOrEmpty(txtNome.Text))// valida campo nome
                    {
                        erro = true;
                        MessageBox.Show("O nome deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.isLimitCaract(txtNome.Text, 5, 45)) {}
                    else
                    {
                        erro = true;
                        MessageBox.Show(" O nome deve conter no minimo 5 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }// fecha a validacao do nome

                    if (string.IsNullOrEmpty(mskCpf.Text)) // valida campo cpf
                    {
                        erro = true;
                        MessageBox.Show("O numero do CPF deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.validaCPF(mskCpf.Text)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do CPF informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }// fecha a validacao do cpf

                    if (string.IsNullOrEmpty(mskCnh.Text)) // valida o campo cnh
                    {
                        erro = true;
                        MessageBox.Show("O numero da CNH deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.isLimitCaract(mskCnh.Text, 11, 12)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero da  CNH informada deve conter 11 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao da cnh

                    if (string.IsNullOrEmpty(txtEmailf.Text)) { }  // valida campo email   
                    else if (validar.ValidarEmail(txtEmailf.Text)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("O Email informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }// fecha a validacao do  email

                    if (string.IsNullOrEmpty(mskDta_nascf.Text)) // valida data nascimento
                    {
                        erro = true;
                        MessageBox.Show("A data de nascimento deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao data de nascimento

                    if (string.IsNullOrEmpty(mskTelefonef.Text)) // valida campo telefone
                    {
                        erro = true;
                        MessageBox.Show("O numero do telefone deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidaTelefone(mskTelefonef.Text)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do telefone informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do telefone

                    if (string.IsNullOrEmpty(mskCelularf.Text)) // valida campo celular
                    {
                        erro = true;
                        MessageBox.Show("O numero do celular deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidarCelular(mskCelularf.Text)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do celular informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do celular

                    if (string.IsNullOrEmpty(cmbSexof.Text)) // valida campo sexo
                    {
                        erro = true;
                        MessageBox.Show("O sexo deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do sexo

                    if (string.IsNullOrEmpty(cmbEst_civilf.Text)) // valida campo estado civil
                    {
                        erro = true;
                        MessageBox.Show("O estado civil deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do estado civil

                    if (string.IsNullOrEmpty(txtEndf.Text)) // valida campo endereco
                    {
                        erro = true;
                        MessageBox.Show("O endereco deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }// fecha a validacao do endereco

                    if (string.IsNullOrEmpty(txtNumf.Text)) // valida campo numero
                    {
                        erro = true;
                        MessageBox.Show("O numero do imovel deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do numero

                    if (string.IsNullOrEmpty(mskCepf.Text)) // valida campo cep
                    {
                        erro = true;
                        MessageBox.Show("O numero do CEP deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidaCEP(mskCepf.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do CEP informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do cep

                    if (string.IsNullOrEmpty(txtCidadef.Text)) // valida campo cidade
                    {
                        erro = true;
                        MessageBox.Show("O nome da cidade deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao da cidade

                    if (string.IsNullOrEmpty(txtBairrof.Text)) // valida campo bairro
                    {
                        erro = true;
                        MessageBox.Show("O nome do bairro deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do bairro

                    if (string.IsNullOrEmpty(cmbEstadof.Text)) // valida campo estado
                    {
                        erro = true;
                        MessageBox.Show("O nome do estado deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do estado

                    if(!erro)
                    {
                        Cdb.InserirPessoaFisica(novocliente); // chama o dao de adicao do cliente fisico
                        LimparCampos(); // chama o metodo limpar campos
                    } 
                } // fecha o if rbtpessoaF.Checked

                else if (rbtPessoajur.Checked == true) //caso pessoa juridica esteja em check
                {
                    novocliente.razao_social = (txtRazaosocial.Text).ToString();
                    novocliente.cnpj = (mskCnpj.Text).ToString();
                    novocliente.nome_fantasia = (txtNomefantasia.Text).ToString();
                    novocliente.insc_estadual = (mskIncr_est.Text).ToString();
                    novocliente.insc_municipal = (mskInsc_mun.Text).ToString();
                    novocliente.email = (txtemailj.Text).ToString();
                    novocliente.telefone = (msktelefonej.Text).ToString();
                    novocliente.celular = (mskCelularj.Text).ToString();
                    novocliente.endereco = (txtEndjur.Text).ToString();
                    novocliente.numero_casa = (txtNumjur.Text).ToString();
                    novocliente.complemento = (txtComplemjur.Text).ToString();
                    novocliente.cep = (mskCepjur.Text).ToString();
                    novocliente.cidade = (txtCidadejur.Text).ToString();
                    novocliente.bairro = (txtBairrojur.Text).ToString();
                    novocliente.estado = (cmbEstadojur.Text).ToString();
                    novocliente.observacoes = (txtobsj.Text).ToString();

                    if (string.IsNullOrEmpty(txtRazaosocial.Text)) // valida campo razao social
                    {
                        erro = true;
                        MessageBox.Show("A razao social deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao da razao social
                    
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

                    if (string.IsNullOrEmpty(msktelefonej.Text)) // valida campo telefone
                    {
                        erro = true;
                        MessageBox.Show("O numero do telefone deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidaTelefone(msktelefonej.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do telefone informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do telefone

                    if (string.IsNullOrEmpty(txtNomefantasia.Text)) // valida campo nome fantasia
                    {
                        erro = true;
                        MessageBox.Show("O nome fantasia deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do nome fantasia

                    if (string.IsNullOrEmpty(mskIncr_est.Text)) { }// valida campo inscricao estadual
                    else if (validar.isLimitCaract(mskIncr_est.Text, 12, 13)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("A inscricao estadual informada deve conter 12 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao da inscricao estadual

                    if (string.IsNullOrEmpty(mskCelularj.Text)) // valida campo celular
                    {
                        erro = true;
                        MessageBox.Show("O numero do celular deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidarCelular(mskCelularj.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do celular informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do celular

                    if (string.IsNullOrEmpty(txtemailj.Text)) { } // valida campo email
                    else if (validar.ValidarEmail(txtemailj.Text)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("O Email informado é invalido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }// fecha a validacao do email

                    if (string.IsNullOrEmpty(mskInsc_mun.Text)) { } // valida campo inscricao municipal
                    else if (validar.isLimitCaract(mskInsc_mun.Text, 8, 9)) { } 
                    else
                    {
                        erro = true;
                        MessageBox.Show("A inscricao municipal informada deve conter 8 digitos! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao da inscricao municipal

                    if (string.IsNullOrEmpty(txtEndjur.Text)) // valida campo endereco
                    {
                        erro = true;
                        MessageBox.Show("O endereco deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }// fecha a validacao do endereco

                    if (string.IsNullOrEmpty(txtNumjur.Text)) // valida campo numero
                    {
                        erro = true;
                        MessageBox.Show("O numero do imovel deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do numero

                    if (string.IsNullOrEmpty(mskCepjur.Text)) // valida campo cep
                    {
                        erro = true;
                        MessageBox.Show("O numero do CEP deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (validar.ValidaCEP(mskCepjur.Text)) { }
                    else
                    {
                        erro = true;
                        MessageBox.Show("O numero do CEP informado é valido! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do cep

                    if (string.IsNullOrEmpty(txtCidadejur.Text)) // valida campo cidade
                    {
                        erro = true;
                        MessageBox.Show("O nome da cidade deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao da cidade

                    if (string.IsNullOrEmpty(txtBairrojur.Text)) // valida campo bairro
                    {
                        erro = true;
                        MessageBox.Show("O nome do bairro deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do bairro

                    if (string.IsNullOrEmpty(cmbEstadojur.Text)) // valida campo estado
                    {
                        erro = true;
                        MessageBox.Show("O nome do estado deve ser informado! ", "Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } // fecha a validacao do estado

                    if(!erro)
                    {
                        Cdb.InserirPessoaJuridica(novocliente); //chama o dao de adicao do cliente juridico
                        LimparCampos(); // chama o metodo limpar campos
                    }
                } // fecha o else if rbtPessoaJur                        
            } // fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar o cadastro, verifique os campos e tente novamente: ","Validacao de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // exibe a mensagem caso nao seja possivel realizar o cadastro   
            }
        } // fecha o metodo



        /*    private void RbtPessoaFChanged(object sender, EventArgs e)
            {
            
            }

        
            private void rbtPessoaj_CheckedChanged(object sender, EventArgs e)
            {
            
            
            }*/

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
                mskCnh.Visible = true;
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
                grbEnderecoF.Visible = true;
                grbInfof.Visible = true;
                btnConsultFis.Visible = true;

                //campos invisiveis de pessoa juridica
                txtRazaosocial.Visible = false;
                txtNomefantasia.Visible = false;
                mskCnpj.Visible = false;
                mskIncr_est.Visible = false;
                mskInsc_mun.Visible = false;
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
                grbEndj.Visible = false;
                grbInfoj.Visible = false;
                btnConsultarCep.Visible = false;
            } // fecha o if
        } // fecha o metodo

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
                mskCnpj.Visible = true;
                mskIncr_est.Visible = true;
                mskInsc_mun.Visible = true;
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
                btnConsultarCep.Visible = true;

                //campos invisiveis de pessoa fisica
                txtNome.Visible = false;
                mskCpf.Visible = false;
                mskCnh.Visible = false;
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
                grbEnderecoF.Visible = false;
                grbInfof.Visible = false;
                btnConsultFis.Visible = false;
            } // fecha o if          
        }

        // metodo responsavel por consultar o CEP de pessoa juridica
        private void btnConsultarCep_Click(object sender, EventArgs e)
        {
            ServiceCorreios.AtendeClienteClient consulta = new ServiceCorreios.AtendeClienteClient("AtendeClientePort");

            try
            { 
                if (rbtPessoajur.Checked == true)
                {
                    var resultado = consulta.consultaCEP(mskCepjur.Text);

                    if (resultado != null)
                    {
                        txtEndjur.Text = resultado.end;
                        txtBairrojur.Text = resultado.bairro;
                        txtComplemjur.Text = resultado.complemento;
                        txtCidadejur.Text = resultado.cidade;
                        cmbEstadojur.Text = resultado.uf;
                    } // fecha o if resultado
                } //fecha o if rbtPessoaJur
            } // fecha o try
            catch (FaultException)
            {
                MessageBox.Show("CEP não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCepjur.Focus();
            } 
            catch (CommunicationException)
            {
                MessageBox.Show("Não foi possivel realizar a operação. Verifique sua conexão com a internet!  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCepjur.Focus();
            }
        } // fecha o metodo

        // metodo responsavel por consultar o CEP de pessoa juridica
        private void btnConsultFis_Click(object sender, EventArgs e)
        {
            ServiceCorreios.AtendeClienteClient consulta = new ServiceCorreios.AtendeClienteClient("AtendeClientePort");

            try
            {
                if (rbtPessoafis.Checked == true)
                {
                    var resultado = consulta.consultaCEP(mskCepf.Text);

                    if (resultado != null)
                    {
                        txtEndf.Text = resultado.end;
                        txtBairrof.Text = resultado.bairro;
                        txtComplemf.Text = resultado.complemento;
                        txtCidadef.Text = resultado.cidade;
                        cmbEstadof.Text = resultado.uf;
                    } // fecha o if resultado
                } // fecha o if rbtPessoaFis
            } // fecha o try
            catch (FaultException)
            {
                MessageBox.Show("CEP não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCepf.Focus();
            }
            catch (CommunicationException)
            {
                MessageBox.Show("Não foi possivel realizar a operação. Verifique sua conexão com a internet!  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCepf.Focus();
            }
        } // fecha o metodo

    } // final da classe
} // final do namespace
