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

            MySqlConnection connectionInsertCliente = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            try
            {
                connectionInsertCliente.Open(); // abre a conexao
                MySqlCommand commandInserir = new MySqlCommand(queryInserirCliente, connectionInsertCliente); //  cria o comando inserir, aonde recebe como parametro a query e o objeto de conexao
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
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString());// exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionInsertCliente.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //Metodo responsavel pela atualizacao dos dados da pessoa fisica no banco de dados
        public void UpdatePessoaFisica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryUpdateCliente = "UPDATE pessoafisica set pf_nome = @pf_nome, pf_cpf = @pf_cpf, pf_rne = @pf_rne, pf_cnh = @pf_cnh, pf_dta_nasc = @pf_dta_nasc, pf_mail = @pf_mail, pf_telefone = @pf_telefone, pf_celular = @pf_celular, pf_sexo = @pf_sexo, pf_est_civil = @pf_est_civil, pf_endereco = @pf_endereco, pf_num_casa = @pf_num_casa, pf_complemento = @pf_complemento, pf_cep = @pf_cep, pf_cidade = @pf_cidade, pf_bairro = @pf_bairro, pf_uf = @pf_uf, pf_obs = @pf_obs, pf_idf_ativo = @pf_idf_ativo WHERE pf_id = @pf_id";

            MySqlConnection connectionUpdateCliente = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            try
            {
                connectionUpdateCliente.Open();// abre a conexao
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdateCliente, connectionUpdateCliente); //  cria o comando update, aonde recebe como parametro a query e o objeto de conexao
                commandUpdate.Prepare();

                commandUpdate.Parameters.Add(new MySqlParameter("pf_id", cliente.Id));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_nome", cliente.nome));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_cpf", cliente.cpf));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_rne", cliente.rne));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_cnh", cliente.cnh));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_dta_nasc", cliente.data_nascimento));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_mail", cliente.email));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_telefone", cliente.telefone));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_celular", cliente.celular));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_sexo", cliente.sexo));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_est_civil", cliente.Estado_civil));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_endereco", cliente.endereco));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_num_casa", cliente.numero_casa));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_complemento", cliente.complemento));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_cep", cliente.cep));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_cidade", cliente.cidade));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_bairro", cliente.bairro));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_uf", cliente.estado));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_obs", cliente.observacoes));
                commandUpdate.Parameters.Add(new MySqlParameter("pf_idf_ativo", cliente.idf_ativo));

                commandUpdate.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com sucesso");// exibe a mensagem quando a operacao de atualizacao é realizado com sucesso
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString());// exibe a mensagem quando a operacao de atualizacao nao é realizada com sucesso
            }
            finally
            {
                connectionUpdateCliente.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //Metodo responsavel pela exibicao dos dados da pessoa fisica
        public DataTable returnDataTablePf()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT pf_id, pf_nome, pf_cpf, pf_rne, pf_cnh, pf_dta_nasc, pf_mail, pf_telefone, pf_celular, pf_sexo, pf_est_civil, pf_endereco, pf_num_casa, pf_complemento, pf_cep, pf_cidade, pf_bairro, pf_uf, pf_obs, pf_idf_ativo FROM pessoafisica ORDER BY pf_nome ASC";
            MySqlConnection connectionExibirTodos = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            data = new DataTable(); // cria um objeto do tipo datatable

            try
            {
                connectionExibirTodos.Open(); // abre a conexao

                da = new MySqlDataAdapter(queryExibirTodos, connectionExibirTodos); // cria objeto do tipo dataAdapter que recebe como parametros a query e o objeto de connexao                
                cb = new MySqlCommandBuilder(da);
                da.Fill(data);

                return data; // returno do datatable
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de busca nao é realizada com sucesso
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //Metodo responsavel pela exibicao dos dados da pessoa juridica
        public DataTable returnDataTablePj()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT pj_id, pj_raz_soc, pj_cnpj, pj_nom_fan, pj_insc_est, pj_insc_mun, pj_mail, pj_telefone, pj_celular, pj_endereco, pj_num_casa, pj_complemento, pj_cep, pj_cidade, pj_bairro, pj_uf, pj_obs, pj_idf_ativo FROM pessoajuridica ORDER BY pj_raz_soc ASC";
            MySqlConnection connectionExibirTodos = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            data = new DataTable();

            try
            {
                connectionExibirTodos.Open(); // abre a conexao

                da = new MySqlDataAdapter(queryExibirTodos, connectionExibirTodos); // cria objeto do tipo dataAdapter que recebe como parametros a query e o objeto de connexao
                cb = new MySqlCommandBuilder(da);
                da.Fill(data);

                return data; // returno do datatable
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de busca nao é realizada com sucesso
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //metodo responsavel pela exibicao dos dados do veiculo
        public DataTable returnDatatableVeiculo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config
            string queryExibirVeiculo = "SELECT car_id, car_placa, car_modelo, car_marca, car_renavam, car_chassi, car_ano_fab, car_ano_mod, car_tipo, car_cor, car_num_portas, car_combustivel, car_km, car_cidade, car_uf, car_obs, car_idf_ativo FROM carro ORDER BY car_modelo ASC";

            MySqlConnection connectionExibirVeiculios = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            data = new DataTable();
            try
            {
                connectionExibirVeiculios.Open(); // abre a connexao
                da = new MySqlDataAdapter(queryExibirVeiculo, connectionExibirVeiculios);
                cb = new MySqlCommandBuilder(da);
                da.Fill(data);
                return data; // retorno do datatable
            }// fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de busca nao é realizada com sucesso
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirVeiculios.Close(); //fecha a connexao
            }
        }// Fecha o metodo

        public MySqlDataReader returnDataReader()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString;

            MySqlCommand comando = new MySqlCommand();// passar a query e a conneccao do banco aqui entre os parentes depois
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        } // fecha o metodo

        //Metodo responsavel pela insercao dos dados da pessoa juridica no banco de dados
        public void InserirPessoaJuridica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryInserirPessoaJ = "INSERT INTO pessoajuridica (pj_raz_soc, pj_cnpj, pj_nom_fan, pj_insc_est, pj_insc_mun, pj_mail, pj_telefone, pj_celular, pj_endereco, pj_num_casa, pj_complemento, pj_cep, pj_cidade, pj_bairro, pj_uf, pj_obs, pj_idf_ativo ) values (@pj_raz_soc, @pj_cnpj, @pj_nom_fan, @pj_insc_est, @pj_insc_mun, @pj_mail, @pj_telefone, @pj_celular, @pj_endereco, @pj_num_casa, @pj_complemento, @pj_cep, @pj_cidade, @pj_bairro, @pj_uf, pj_obs, @pj_idf_ativo)";

            MySqlConnection connectionInsertPessoaJ = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                connectionInsertPessoaJ.Open(); // abre a conexao
                MySqlCommand commandInserir = new MySqlCommand(queryInserirPessoaJ, connectionInsertPessoaJ); //  cria o comando inserir, aonde recebe como parametro a query e o objeto de connexao
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
                commandInserir.Parameters.Add(new MySqlParameter("pj_complemento", cliente.complemento));
                commandInserir.Parameters.Add(new MySqlParameter("pj_cep", cliente.cep));
                commandInserir.Parameters.Add(new MySqlParameter("pj_cidade", cliente.cidade));
                commandInserir.Parameters.Add(new MySqlParameter("pj_bairro", cliente.bairro));
                commandInserir.Parameters.Add(new MySqlParameter("pj_uf", cliente.estado));
                commandInserir.Parameters.Add(new MySqlParameter("pj_obs", cliente.observacoes));
                commandInserir.Parameters.Add(new MySqlParameter("pj_idf_ativo", cliente.idf_ativo));

                commandInserir.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");// exibe a mensagem quando a operacao de cadastro é realizado com sucesso
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionInsertPessoaJ.Close(); //fecha a conexao 
            }
        } // fecha o metodo

        //metodo responsavel pela atualizacao dos dados de pessoa juridica
        public void UpdatePessoaJuridica(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryUpdatePessoaJ = "UPDATE pessoajuridica set pj_raz_soc = @pj_raz_soc, pj_cnpj = @pj_cnpj, pj_nom_fan = @pj_nom_fan, pj_insc_est = @pj_insc_est, pj_insc_mun = @pj_insc_mun, pj_mail = @pj_mail, pj_telefone = @pj_telefone, pj_celular = @pj_celular, pj_endereco = @pj_endereco, pj_num_casa = @pj_num_casa, pj_complemento = @pj_complemento, pj_cep = @pj_cep, pj_cidade = @pj_cidade, pj_bairro = @pj_bairro, pj_uf = @pj_uf, pj_obs = @pj_obs, pj_idf_ativo = @pj_idf_ativo WHERE pj_id = @pj_id ";

            MySqlConnection connectionUpdatePessoaJ = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            try
            {
                connectionUpdatePessoaJ.Open(); // abre a conexao
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdatePessoaJ, connectionUpdatePessoaJ); //  cria o comando Update, aonde recebe como parametro a query e o objeto de connexao
                commandUpdate.Prepare();

                commandUpdate.Parameters.Add(new MySqlParameter("pj_id", cliente.Id));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_raz_soc", cliente.razao_social));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_cnpj", cliente.cnpj));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_nom_fan", cliente.nome_fantasia));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_insc_est", cliente.insc_estadual));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_insc_mun", cliente.insc_municipal));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_mail", cliente.email));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_telefone", cliente.telefone));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_celular", cliente.celular));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_endereco", cliente.endereco));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_num_casa", cliente.numero_casa));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_complemento", cliente.complemento));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_cep", cliente.cep));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_cidade", cliente.cidade));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_bairro", cliente.bairro));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_uf", cliente.estado));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_obs", cliente.observacoes));
                commandUpdate.Parameters.Add(new MySqlParameter("pj_idf_ativo", cliente.idf_ativo));

                commandUpdate.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com Sucesso!!");// exibe a mensagem quando a operacao de cadastro é realizado com sucesso
            } //fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionUpdatePessoaJ.Close(); //fecha a conexao 
            }
        } //fecha o metodo

        //Metodo responsavel pela insercao dos dados da dos veiculos no banco de dados
        public void InsertVeiculo(Veiculo veiculo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string InserirVeiculo = "INSERT INTO carro(car_placa, car_modelo, car_marca, car_renavam, car_chassi, car_ano_fab, car_ano_mod, car_tipo, car_cor, car_num_portas, car_combustivel, car_km, car_cidade, car_uf, car_obs, car_idf_ativo) values (@car_placa, @car_modelo, @car_marca, @car_renavam, @car_chassi, @car_ano_fab, @car_ano_mod, @car_tipo, @car_cor, @car_num_portas, @car_combustivel, @car_km, @car_cidade, @car_uf, @car_obs, @car_idf_ativo)";

            MySqlConnection connectionInsertVeiculo = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                connectionInsertVeiculo.Open(); // abre a conexao
                MySqlCommand commandInserirVeiculo = new MySqlCommand(InserirVeiculo, connectionInsertVeiculo); //  cria o comando inserir, aonde recebe como parametro a query e o objeto de connexao
                commandInserirVeiculo.Prepare();

                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_placa", veiculo.placa));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_modelo", veiculo.modelo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_marca", veiculo.marca));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_renavam", veiculo.renavam));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_chassi", veiculo.chassi));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_ano_fab", veiculo.ano_fabricacao));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_ano_mod", veiculo.ano_modelo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_tipo", veiculo.tipo));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_cor", veiculo.cor));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_num_portas", veiculo.num_portas));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_combustivel", veiculo.combustivel));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_km", veiculo.km));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_cidade", veiculo.cidade));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_uf", veiculo.uf));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_obs", veiculo.observacao));
                commandInserirVeiculo.Parameters.Add(new MySqlParameter("car_idf_ativo", veiculo.idf_ativo));

                commandInserirVeiculo.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!"); // exibe a mensagem quando a operacao de cadastro é realizado com sucesso

            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionInsertVeiculo.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //metodo responsavel pela atualizacao dos dados do veiculo
        public void UpdateVeiculo(Veiculo veiculo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string UpdateVeiculo = "UPDATE carro set car_placa = @car_placa, car_modelo = @car_modelo, car_marca = @car_marca, car_renavam = @car_renavam, car_chassi = @car_chassi, car_ano_fab = @car_ano_fab, car_ano_mod = @car_ano_mod, car_tipo = @car_tipo, car_cor = @car_cor, car_num_portas = @car_num_portas, car_combustivel = @car_combustivel, car_km = @car_km, car_cidade = @car_cidade, car_uf = @car_uf, car_obs = @car_obs, car_idf_ativo = @car_idf_ativo WHERE car_id = @car_id";

            MySqlConnection connectionUpdateVeiculo = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                connectionUpdateVeiculo.Open(); // abre a conexao
                MySqlCommand commandUpdateVeiculo = new MySqlCommand(UpdateVeiculo, connectionUpdateVeiculo); //  cria o comando update, aonde recebe como parametro a query e o objeto de connexao
                commandUpdateVeiculo.Prepare();

                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_id", veiculo.id));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_placa", veiculo.placa));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_modelo", veiculo.modelo));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_marca", veiculo.marca));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_renavam", veiculo.renavam));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_chassi", veiculo.chassi));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_ano_fab", veiculo.ano_fabricacao));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_ano_mod", veiculo.ano_modelo));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_tipo", veiculo.tipo));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_cor", veiculo.cor));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_num_portas", veiculo.num_portas));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_combustivel", veiculo.combustivel));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_km", veiculo.km));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_cidade", veiculo.cidade));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_uf", veiculo.uf));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_obs", veiculo.observacao));
                commandUpdateVeiculo.Parameters.Add(new MySqlParameter("car_idf_ativo", veiculo.idf_ativo));

                commandUpdateVeiculo.ExecuteNonQuery();

                MessageBox.Show("Atualizacao realizada com Sucesso!!"); // exibe a mensagem quando a operacao de atualizacao é realizado com sucesso

            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de atualizacao nao é realizada com sucesso
            }
            finally
            {
                connectionUpdateVeiculo.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //metodo responsavel pela insercao dos dados do checkin
        public void RealizarCheckin(CheckinCheckout checkin)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryRealizarCheckin = "INSERT INTO checkin(ckn_parabrisa_diant, ckn_parabrisa_tras, ckn_vidro_dianteiro, ckn_vidro_traseiro, ckn_vidro_diant_esq, ckn_vidro_diant_dir, ckn_vidro_tras_esq, ckn_vidro_tras_dir, ckn_port_diant_esq, ckn_port_diant_dir, ckn_port_tras_esq, ckn_port_tras_dir, ckn_parachoque_diant, ckn_parachoque_tras, ckn_roda_diant_esq, ckn_roda_diant_dir, ckn_roda_tras_esq, ckn_roda_tras_dir, ckn_pneu_diant_esq, ckn_pneu_diant_dir, ckn_pneu_tras_esq, ckn_pneu_tras_dir, car_id)values(@ckn_parabrisa_diant, @ckn_parabrisa_tras, @ckn_vidro_dianteiro, @ckn_vidro_traseiro, @ckn_vidro_diant_esq, @ckn_vidro_diant_dir, @ckn_vidro_tras_esq, @ckn_vidro_tras_dir, @ckn_port_diant_esq, @ckn_port_diant_dir, @ckn_port_tras_esq, @ckn_port_tras_dir, @ckn_parachoque_diant, @ckn_parachoque_tras, @ckn_roda_diant_esq, @ckn_roda_diant_dir, @ckn_roda_tras_esq, @ckn_roda_tras_dir, @ckn_pneu_diant_esq, @ckn_pneu_diant_dir, @ckn_pneu_tras_esq, @ckn_pneu_tras_dir, @car_id)";

            MySqlConnection connectionRealizarCheckin = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                connectionRealizarCheckin.Open(); // abre a conexao
                MySqlCommand commandCkeckin = new MySqlCommand(queryRealizarCheckin, connectionRealizarCheckin); //  cria o comando , aonde recebe como parametro a query e o objeto de connexao
                commandCkeckin.Prepare();

                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_parabrisa_diant", checkin.parabrisa_diant));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_parabrisa_tras", checkin.parabrisa_tras));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_vidro_dianteiro", checkin.vidro_dianteiro));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_vidro_traseiro", checkin.vidro_traseiro));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_vidro_diant_esq", checkin.vidro_diant_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_vidro_diant_dir", checkin.vidro_diant_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_vidro_tras_esq", checkin.vidro_tras_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_vidro_tras_dir", checkin.vidro_tras_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_port_diant_esq", checkin.port_diant_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_port_diant_dir", checkin.port_diant_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_port_tras_esq", checkin.port_tras_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_port_tras_dir", checkin.port_tras_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_parachoque_diant", checkin.parachoque_diant));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_parachoque_tras", checkin.parachoque_tras));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_roda_diant_esq", checkin.roda_diant_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_roda_diant_dir", checkin.roda_diant_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_roda_tras_esq", checkin.roda_tras_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_roda_tras_dir", checkin.roda_tras_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_pneu_diant_esq", checkin.pneu_diant_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_pneu_diant_dir", checkin.pneu_diant_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_pneu_tras_esq", checkin.pneu_tras_esq));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_pneu_tras_dir", checkin.pneu_tras_dir));
                commandCkeckin.Parameters.Add(new MySqlParameter("car_id", checkin.car_id));

                commandCkeckin.ExecuteNonQuery();
                MessageBox.Show("Checkin realizado com sucesso: "); // exibe a mensagem quando a operacao de checkin é realizado com sucesso
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar o checkin, tente novamente", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando a operacao de checkin nao é realizada com sucesso
            }
            finally
            {
                connectionRealizarCheckin.Close();// fecha a conexao
            }
        }// final do metodo


        public DataTable listarVeiculo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirVeiculo = "SELECT car_id, car_placa, car_modelo, car_marca, car_renavam, car_chassi, car_ano_fab, car_ano_mod, car_tipo, car_cor, car_num_portas, car_combustivel, car_km, car_cidade, car_uf, car_obs, car_idf_ativo FROM carro ORDER BY car_modelo ASC";

            MySqlConnection connectionExibirVeiculo = new MySqlConnection(connectionString);

            try
            {
                connectionExibirVeiculo.Open();
                MySqlCommand commandList = new MySqlCommand(queryExibirVeiculo, connectionExibirVeiculo);
                MySqlDataReader leitor = commandList.ExecuteReader();
                data = new DataTable();
                data.Load(leitor);

                DataRow row = data.NewRow();
                row["car_placa"] = "";
                row["car_modelo"] = "";
                row["car_marca"] = "";
                row["car_renavam"] = "";
                row["car_chassi"] = "";
                row["car_ano_fab"] = "";
                row["car_ano_mod"] = "";
                row["car_tipo"] = "";
                row["car_cor"] = "";
                row["car_num_portas"] = "";
                row["car_combustivel"] = "";
                row["car_km"] = "";
                row["car_cidade"] = "";
                row["car_uf"] = "";
                row["car_obs"] = "";
                // row["car_idf_ativo"] = "";
                data.Rows.InsertAt(row, 0);


                leitor.Close();
                leitor.Dispose();
                return data;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel carregar os dados: " + ex.ToString(), MessageBoxButtons.OK.ToString());
                return data;
            }
            finally
            {
                connectionExibirVeiculo.Close();
            }
        } // fecha o metodo datatable listarVeiculo

        public void InserirFuncionario(Funcionario funcionario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            String queryInserir = "INSERT INTO funcionario(fun_nome, fun_cpf, fun_login, fun_senha, fun_conf_senha, fun_dta_cadastro, fun_email, fun_telefone, fun_celular, fun_status)values(@fun_nome, @fun_cpf, @fun_login, @fun_senha, @fun_conf_senha, @fun_dta_cadastro, @fun_email, @fun_telefone, @fun_celular, @fun_status)";
            MySqlConnection connectionInsert = new MySqlConnection(connectionString);

            try
            {
                connectionInsert.Open(); // abre a conexao
                MySqlCommand commandInserir = new MySqlCommand(queryInserir, connectionInsert);
                commandInserir.Prepare();
                
                commandInserir.Parameters.Add(new MySqlParameter("fun_nome", funcionario.nome));
                commandInserir.Parameters.Add(new MySqlParameter("fun_cpf", funcionario.cpf));
                commandInserir.Parameters.Add(new MySqlParameter("fun_login", funcionario.login));
                commandInserir.Parameters.Add(new MySqlParameter("fun_senha", funcionario.senha));
                commandInserir.Parameters.Add(new MySqlParameter("fun_conf_senha", funcionario.confirmarSenha ));
                commandInserir.Parameters.Add(new MySqlParameter("fun_dta_cadastro", funcionario.dataCadastro));
                commandInserir.Parameters.Add(new MySqlParameter("fun_email", funcionario.email));
                commandInserir.Parameters.Add(new MySqlParameter("fun_telefone", funcionario.telefone));
                commandInserir.Parameters.Add(new MySqlParameter("fun_celular", funcionario.celular));
                commandInserir.Parameters.Add(new MySqlParameter("fun_status", funcionario.status));
                

                commandInserir.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso: "); // exibe a mensagem quando a operacao de cadastro é realizado com sucesso
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar o cadastro, tente novamente", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionInsert.Close(); // fecha a conexao
            }
        }


        public DataTable returnDataTableFuncionario()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT fun_id, fun_nome, fun_cpf, fun_login, fun_senha, fun_conf_senha, fun_dta_cadastro, fun_email, fun_telefone, fun_celular, fun_status from funcionario ORDER BY fun_nome ASC";
            MySqlConnection connectionExibirTodos = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao 
            data = new DataTable(); // cria um objeto do tipo datatable

            try
            {
                connectionExibirTodos.Open(); // abre a conexao

                da = new MySqlDataAdapter(queryExibirTodos, connectionExibirTodos); // cria objeto do tipo dataAdapter que recebe como parametros a query e o objeto de connexao                
                cb = new MySqlCommandBuilder(da);
                da.Fill(data);

                return data; // returno do datatable
            } // fecha o try
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados: " + ex.ToString()); // exibe a mensagem quando a operacao de busca nao é realizada com sucesso
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
        } // fecha o metodo


        public void AtualizarFuncionario(Funcionario funcionario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            String queryAtualizar = "UPDATE funcionario set fun_nome = @fun_nome, fun_cpf = @fun_cpf, fun_login = @fun_login, fun_senha = @fun_senha, fun_conf_senha = @fun_conf_senha, fun_dta_cadastro = @fun_dta_cadastro, fun_email = @fun_email, fun_telefone = @fun_telefone, fun_celular = @fun_celular, fun_status = @fun_status WHERE fun_id = @fun_id";
            MySqlConnection connectionUpdate  = new MySqlConnection(connectionString);

            try
            {
                connectionUpdate.Open(); // abre a conexao
                MySqlCommand commandAtualizar = new MySqlCommand(queryAtualizar, connectionUpdate);
                commandAtualizar.Prepare();
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_id", funcionario.id));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_nome", funcionario.nome));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_cpf", funcionario.cpf));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_login", funcionario.login));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_senha", funcionario.senha));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_conf_senha", funcionario.confirmarSenha));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_dta_cadastro", funcionario.dataCadastro));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_email", funcionario.email));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_telefone", funcionario.telefone));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_celular", funcionario.celular));
                commandAtualizar.Parameters.Add(new MySqlParameter("fun_status", funcionario.status));

                commandAtualizar.ExecuteNonQuery();
                MessageBox.Show("Atualizacao realizada com sucesso: "); // exibe a mensagem quando a operacao de atualizacao é realizado com sucesso
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel realizar a atualizacao, tente novamente", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando a operacao de cadastro nao é realizada com sucesso
            }
            finally
            {
                connectionUpdate.Close(); // fecha a conexao
            }
        }

        public void ExcluirFuncionario(Funcionario funcionario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config

            String queryExluir = "DELETE FROM funcionario WHERE fun_id = @fun_id";

            MySqlConnection connectionExluir = new MySqlConnection(connectionString);

            try
            {
                connectionExluir.Open();
                MySqlCommand commandExluir = new MySqlCommand(queryExluir, connectionExluir);
                commandExluir.Prepare();

                commandExluir.Parameters.Add(new MySqlParameter("fun_id", funcionario.id));
                commandExluir.Parameters.Add(new MySqlParameter("fun_dta_cadastro", funcionario.dataCadastro));
                commandExluir.Parameters.Add(new MySqlParameter("fun_nome", funcionario.nome));
                commandExluir.Parameters.Add(new MySqlParameter("fun_login", funcionario.login));
                commandExluir.Parameters.Add(new MySqlParameter("fun_senha", funcionario.senha));
                commandExluir.Parameters.Add(new MySqlParameter("fun_email", funcionario.email));
                commandExluir.Parameters.Add(new MySqlParameter("fun_cpf", funcionario.cpf));
                commandExluir.Parameters.Add(new MySqlParameter("fun_status", funcionario.status));
                commandExluir.ExecuteNonQuery();

                MessageBox.Show("Funcionario apagado com sucesso", MessageBoxButtons.OK.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel apagar o registro", MessageBoxButtons.OK.ToString());
            }
            finally
            {
                connectionExluir.Close();
            }
        }
            /*/metodo responsavel pela insercao dos dados do checkout
            public void RealizarCheckout(CheckinCheckout checkout)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString;
                string queryRealizarCheckout = "UPDATE ckeckin set ";

                MySqlConnection connectionRealizarCheckout = new MySqlConnection(connectionString);

                try
                {
                    connectionRealizarCheckout.Open();
                    MySqlCommand commandCheckout = new MySqlCommand(queryRealizarCheckout, connectionRealizarCheckout);
                    commandCheckout.Prepare();

                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));
                    commandCheckout.Parameters.Add(new MySqlParameter("", checkout.id));

                    commandCheckout.ExecuteNonQuery();
                    MessageBox.Show("Checkout realizado com sucesso: ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel realizar o checkout, tente novamente", MessageBoxButtons.OK.ToString());
                }
                finally
                {
                    connectionRealizarCheckout.Close();
                }
            
            }*/

            /*/metodo responvavel pela insercao dos dados da locacao
            public void RealizarLocacao(Locacao locacao)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString;
                string queryRealizarLocacao = "INSERT INTO LOCACAO()values()";

                MySqlConnection connectionRealizarLocacao = new MySqlConnection(connectionString);

                try
                {
                    connectionRealizarLocacao.Open();
                    MySqlCommand commandLocacao = new MySqlCommand(queryRealizarLocacao, connectionRealizarLocacao);
                    commandLocacao.Prepare();

                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));
                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));
                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));
                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));
                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));
                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));
                    commandLocacao.Parameters.Add(new MySqlParameter("",locacao. ));

                    commandLocacao.ExecuteNonQuery();
                    MessageBox.Show("Locacao realizada com sucesso: ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel realizar a locacao, tente novamente: ", MessageBoxButtons.OK.ToString());
                }
                finally
                {
                    connectionRealizarLocacao.Close();
                }
            }*/

            /*/metodo responsavel pela atualizacao dos dados da locacao
            public void RealizarDevolucao(Locacao devolucao)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString;
                string queryRealizarDevolucao = "UPDATE locacao set";

                MySqlConnection connectionRealizarDevolucao = new MySqlConnection(connectionString);

                try
                {
                    connectionRealizarDevolucao.Open();
                    MySqlCommand commandRealizarDevolucao = new MySqlCommand(queryRealizarDevolucao, connectionRealizarDevolucao);
                    commandRealizarDevolucao.Prepare();

                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("",devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));
                    commandRealizarDevolucao.Parameters.Add(new MySqlParameter("", devolucao.id));

                    commandRealizarDevolucao.ExecuteNonQuery();
                    MessageBox.Show("Devolucao efetuada com sucesso: ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel realizar a devolucao, tenta novamente", MessageBoxButtons.OK.ToString());
                }
                finally
                {
                    connectionRealizarDevolucao.Close();
                }
            }*/

        } // final da classe Dao
       } // final do namespace
        