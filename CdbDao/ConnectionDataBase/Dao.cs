using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CdbDao.ModelCliente;
using CdbDao.ModelVeiculo;
using System.Windows.Forms;
using System.Configuration;

namespace CdbDao.ConnectionDataBase
{
    public class Dao
    {
        //inserir dados pessoa fisica
        public void InserirPessoaFisica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString;

            string queryInserirCliente = "INSERT INTO pessoafisica (pf_nome, pf_cpf, pf_rne, pf_cnh, pf_dta_nasc, pf_mail, pf_telefone, pf_celular, pf_sexo, pf_est_civil, pf_endereco, pf_num_casa, pf_complemento, pf_cep, pf_cidade, pf_bairro, pf_uf, pf_obs, pf_idf_ativo) values (@pf_nome, @pf_cpf, @pf_rne, @pf_cnh, @pf_dta_nasc, @pf_mail, @pf_telefone, @pf_celular, @pf_sexo, @pf_est_civil, @pf_endereco, @pf_num_casa, @pf_complemento, @pf_cep, @pf_cidade, @pf_bairro, @pf_uf, @pf_obs, @pf_idf_ativo)";

            MySqlConnection connectionInsertCliente = new MySqlConnection(connectionString);
            try
            {

                connectionInsertCliente.Open();
                MySqlCommand commandInserir = new MySqlCommand(queryInserirCliente, connectionInsertCliente);
                commandInserir.Prepare();
              
                commandInserir.Parameters.Add(new MySqlParameter("pf_nome", cliente.nome));
                commandInserir.Parameters.Add(new MySqlParameter("pf_cpf", cliente.cpf));
                commandInserir.Parameters.Add(new MySqlParameter("pf_rne", cliente.rne));
                commandInserir.Parameters.Add(new MySqlParameter("pf_cnh", cliente.cnh));
                commandInserir.Parameters.Add(new MySqlParameter("pf_dta_nasc", cliente.data_nascimento));
                commandInserir.Parameters.Add(new MySqlParameter("pf_mail", cliente.email));
                commandInserir.Parameters.Add(new MySqlParameter("pf_telefone", cliente.telefone));
                commandInserir.Parameters.Add(new MySqlParameter("pf_celular", cliente.celular));
                commandInserir.Parameters.Add(new MySqlParameter("pf_sexo", cliente.sexo));
                commandInserir.Parameters.Add(new MySqlParameter("pf_est_civil", cliente.Estado_civil));
                commandInserir.Parameters.Add(new MySqlParameter("pf_endereco", cliente.endereco));
                commandInserir.Parameters.Add(new MySqlParameter("pf_num_casa", cliente.numero_casa));
                commandInserir.Parameters.Add(new MySqlParameter("pf_complemento", cliente.complemento));
                commandInserir.Parameters.Add(new MySqlParameter("pf_cep", cliente.cep));
                commandInserir.Parameters.Add(new MySqlParameter("pf_cidade", cliente.cidade));
                commandInserir.Parameters.Add(new MySqlParameter("pf_bairro", cliente.bairro));
                commandInserir.Parameters.Add(new MySqlParameter("pf_uf", cliente.estado));
                commandInserir.Parameters.Add(new MySqlParameter("pf_obs", cliente.observacoes));
                commandInserir.Parameters.Add(new MySqlParameter("pf_idf_ativo", cliente.idf_ativo));
                
                commandInserir.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                connectionInsertCliente.Close();

            }

        }

        //Inserir pessoa juridica
        public void InserirPessoaJuridica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString;

            string queryInserirPessoaJ = "INSERT INTO pessoajuridica (pj_raz_soc, pj_cnpj, pj_nom_fan, pj_insc_est, pj_insc_mun, pj_mail, pj_telefone, pj_celular, pj_endereco, pj_num_casa, pj_complemento, pj_cep, pj_cidade, pj_bairro, pj_uf, pj_obs, pj_idf_ativo ) values (@pj_raz_soc, @pj_cnpj, @pj_nom_fan, @pj_insc_est, @pj_insc_mun, @pj_mail, @pj_telefone, @pj_celular, @pj_endereco, @pj_num_casa, @pj_complemento, @pj_cep, @pj_cidade, @pj_bairro, @pj_uf, pj_obs, @pj_idf_ativo)";

            MySqlConnection connectionInsertPessoaJ = new MySqlConnection(connectionString);

            try
            {
                connectionInsertPessoaJ.Open();
                MySqlCommand commandInserir = new MySqlCommand(queryInserirPessoaJ, connectionInsertPessoaJ);
                commandInserir.Prepare();
                commandInserir.Parameters.Add(new MySqlParameter("pj_raz_soc", cliente.razao_social));
                commandInserir.Parameters.Add(new MySqlParameter("pj_cnpj", cliente.cnpj));
                commandInserir.Parameters.Add(new MySqlParameter("pj_nom_fan", cliente.nome_fantasia));
                commandInserir.Parameters.Add(new MySqlParameter("pj_insc_est", cliente.insc_estadual));
                commandInserir.Parameters.Add(new MySqlParameter("pj_insc_mun", cliente.insc_municipal));
                commandInserir.Parameters.Add(new MySqlParameter("pj_mail", cliente.email));
                commandInserir.Parameters.Add(new MySqlParameter("pj_telefone", cliente.telefone));
                commandInserir.Parameters.Add(new MySqlParameter("pj_celular", cliente.celular));
                commandInserir.Parameters.Add(new MySqlParameter("pj_endereco", cliente.endereco));
                commandInserir.Parameters.Add(new MySqlParameter("pj_num_casa", cliente.numero_casa));
                commandInserir.Parameters.Add(new MySqlParameter("pj_complemento" ,cliente.complemento));
                commandInserir.Parameters.Add(new MySqlParameter("pj_cep", cliente.cep));
                commandInserir.Parameters.Add(new MySqlParameter("pj_cidade", cliente.cidade));
                commandInserir.Parameters.Add(new MySqlParameter("pj_bairro", cliente.bairro));
                commandInserir.Parameters.Add(new MySqlParameter("pj_uf", cliente.estado));
                commandInserir.Parameters.Add(new MySqlParameter("pj_obs", cliente.observacoes));
                commandInserir.Parameters.Add(new MySqlParameter("pj_idf_ativo", cliente.idf_ativo));

                
                commandInserir.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                connectionInsertPessoaJ.Close();
            }
        }


        // inserir veiculo
        public void InsertVeiculo(Veiculo veiculo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString;
            
            string InserirVeiculo = "INSERT INTO veiculo(vid, vplaca, vano_fabricacao, vano_modelo, vchassi, vrenavam, vmarca, vmodelo, vcor, vcombustivel, vportas, vquilometragem, vtipo, vcidade, vuf, vobservacao) values (@vid, @vplaca, @vano_fabricacao, @vano_modelo, @vchassi, @vrenavam, @vmarca, @vmodelo, @vcor, @vcombustivel, @vportas, @vquilometragem, @vtipo, @vcidade, @vuf, @vobservacao)";

            MySqlConnection connectionInsertVeiculo = new MySqlConnection(connectionString);

            try
            {
                connectionInsertVeiculo.Open();
                MySqlCommand commandInserirVeiculo = new MySqlCommand(InserirVeiculo, connectionInsertVeiculo);
                commandInserirVeiculo.Prepare();
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vplaca", veiculo.placa));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vano_fabricacao", veiculo.ano_fabricacao));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vano_modelo", veiculo.ano_modelo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vchassi", veiculo.chassi));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vrenavam", veiculo.renavam));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vmarca", veiculo.marca));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vmodelo", veiculo.modelo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vcor", veiculo.cor));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vcombustivel", veiculo.combustivel));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vportas", veiculo.portas));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vquilometragem", veiculo.quilometragem));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vtipo", veiculo.tipo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vcidade", veiculo.cidade));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vuf", veiculo.uf));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("vobservacao", veiculo.observacao));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                connectionInsertVeiculo.Close();
            }


        }

    }
}
