using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CdbDao.ModelCliente;
using System.Windows.Forms;
using System.Configuration;
using System.Data;



namespace CdbDao.ConnectionDataBase
{
    public class Dao
    {

        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader leitor;
        private MySqlCommandBuilder cb;

        //Metodo responsavel pela insercao dos dados da pessoa fisica no banco de dados
        public void InserirPessoaFisica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config

            string queryInserirCliente = "INSERT INTO pessoafisica (pf_nome, pf_cpf, pf_rne, pf_cnh, pf_dta_nasc, pf_mail, pf_telefone, pf_celular, pf_sexo, pf_est_civil, pf_endereco, pf_num_casa, pf_complemento, pf_cep, pf_cidade, pf_bairro, pf_uf, pf_obs, pf_idf_ativo) values (@pf_nome, @pf_cpf, @pf_rne, @pf_cnh, @pf_dta_nasc, @pf_mail, @pf_telefone, @pf_celular, @pf_sexo, @pf_est_civil, @pf_endereco, @pf_num_casa, @pf_complemento, @pf_cep, @pf_cidade, @pf_bairro, @pf_uf, @pf_obs, @pf_idf_ativo)";

            MySqlConnection connectionInsertCliente = new MySqlConnection(connectionString);
            try
            {

                connectionInsertCliente.Open(); // abre a conexao
                MySqlCommand commandInserir = new MySqlCommand(queryInserirCliente, connectionInsertCliente); //  cria o comando inserir, aonde recebe como parametro a query e a string de conexao
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

                MessageBox.Show("Cadastro realizado com sucesso");// exibe a mensagem quando a operacao de cadastro é realizado com sucesso
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());// exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionInsertCliente.Close(); // fecha a conexao 

            }

        }
   
        //Metodo responsavel pela exibicao dos dados da pessoa fisica
        public DataTable returnDataTablePf()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT pf_id, pf_nome, pf_cpf, pf_rne, pf_cnh, pf_dta_nasc, pf_mail, pf_telefone, pf_celular, pf_sexo, pf_est_civil, pf_endereco, pf_num_casa, pf_complemento, pf_cep, pf_cidade, pf_bairro, pf_uf, pf_obs, pf_idf_ativo FROM pessoafisica";
            MySqlConnection connectionExibirTodos = new MySqlConnection(connectionString);
            data = new DataTable();

            try
            {
                connectionExibirTodos.Open(); // abre a conexao

                da = new MySqlDataAdapter(queryExibirTodos, connectionExibirTodos);
                

                cb = new MySqlCommandBuilder(da);
                da.Fill(data);

                return data; // returno do datatable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
            
        }

        //Metodo responsavel pela exibicao dos dados da pessoa juridica
        public DataTable returnDataTablePj()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT pj_id, pj_raz_soc, pj_cnpj, pj_nom_fan, pj_insc_est, pj_insc_mun, pj_mail, pj_telefone, pj_celular, pj_endereco, pj_num_casa, pj_complemento, pj_cep, pj_cidade, pj_bairro, pj_uf, pj_obs, pj_idf_ativo FROM pessoajuridica";
            MySqlConnection connectionExibirTodos = new MySqlConnection(connectionString);
            data = new DataTable();

            try
            {
                connectionExibirTodos.Open(); // abre a conexao

                da = new MySqlDataAdapter(queryExibirTodos, connectionExibirTodos);


                cb = new MySqlCommandBuilder(da);
                da.Fill(data);

                return data; // returno do datatable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }

        }

        public MySqlDataReader returnDataReader()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString;

            MySqlCommand comando = new MySqlCommand();// passar a query e a conneccao do banco aqui entre os parentes depois
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }
  
        //Metodo responsavel pela insercao dos dados da pessoa juridica no banco de dados
        public void InserirPessoaJuridica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config

            string queryInserirPessoaJ = "INSERT INTO pessoajuridica (pj_raz_soc, pj_cnpj, pj_nom_fan, pj_insc_est, pj_insc_mun, pj_mail, pj_telefone, pj_celular, pj_endereco, pj_num_casa, pj_complemento, pj_cep, pj_cidade, pj_bairro, pj_uf, pj_obs, pj_idf_ativo ) values (@pj_raz_soc, @pj_cnpj, @pj_nom_fan, @pj_insc_est, @pj_insc_mun, @pj_mail, @pj_telefone, @pj_celular, @pj_endereco, @pj_num_casa, @pj_complemento, @pj_cep, @pj_cidade, @pj_bairro, @pj_uf, pj_obs, @pj_idf_ativo)";

            MySqlConnection connectionInsertPessoaJ = new MySqlConnection(connectionString);

            try
            {
                connectionInsertPessoaJ.Open(); // abre a conexao
                MySqlCommand commandInserir = new MySqlCommand(queryInserirPessoaJ, connectionInsertPessoaJ); //  cria o comando inserir, aonde recebe como parametro a query e a string de connexao
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
                connectionInsertPessoaJ.Close(); //fecha a conexao 
            }
        }

        //Metodo responsavel pela insercao dos dados da dos veiculos no banco de dados
        public void InsertVeiculo(Veiculo veiculo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config

            string InserirVeiculo = "INSERT INTO carro(car_placa, car_ano_fab, car_ano_mod, car_chassi, car_renavan, car_marca, car_modelo, car_tipo, car_cor, car_num_portas, car_combustivel, car_cidade, car_uf, car_km, car_idf_ativo, car_obs) values (@car_placa, @car_ano_fab, @car_ano_mod, @car_chassi, @car_renavan, @car_marca, @car_modelo, @car_tipo, @car_cor, @car_num_portas, @car_combustivel, @car_cidade, @car_uf, @car_km, @car_idf_ativo, @car_obs)";

            MySqlConnection connectionInsertVeiculo = new MySqlConnection(connectionString);

            try
            {
                connectionInsertVeiculo.Open(); // abre a conexao
                MySqlCommand commandInserirVeiculo = new MySqlCommand(InserirVeiculo, connectionInsertVeiculo); //  cria o comando inserir, aonde recebe como parametro a query e a string de connexao
                commandInserirVeiculo.Prepare();
              
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_placa", veiculo.placa));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_ano_fab", veiculo.ano_fabricacao));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_ano_mod", veiculo.ano_modelo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_chassi", veiculo.chassi));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_renavan", veiculo.renavam));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_marca", veiculo.marca));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_modelo", veiculo.modelo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_tipo", veiculo.tipo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_cor", veiculo.cor));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_num_portas", veiculo.num_portas));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_combustivel", veiculo.combustivel));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_cidade", veiculo.cidade));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_uf", veiculo.uf));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_km", veiculo.km));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_idf_ativo", veiculo.idf_ativo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_obs", veiculo.observacao));

                commandInserirVeiculo.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                connectionInsertVeiculo.Close(); // fecha a conexao 
            }


        }

    }
}
