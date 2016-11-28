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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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

            MySqlConnection connectionExibirVeiculos = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            data = new DataTable();
            try
            {
                connectionExibirVeiculos.Open(); // abre a connexao
                da = new MySqlDataAdapter(queryExibirVeiculo, connectionExibirVeiculos);
                cb = new MySqlCommandBuilder(da);
                da.Fill(data);
                return data; // retorno do datatable
            }// fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirVeiculos.Close(); //fecha a connexao
            }
        }// Fecha o metodo

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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionUpdatePessoaJ.Close(); //fecha a conexao 
            }
        } //fecha o metodo

        //Metodo responsavel pela insercao dos dados da dos veiculos 
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
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
            string queryRealizarCheckin = "INSERT INTO checkin(ckn_parabrisa_diant, ckn_parabrisa_tras, ckn_vidro_dianteiro, ckn_vidro_traseiro, ckn_vidro_diant_esq, ckn_vidro_diant_dir, ckn_vidro_tras_esq, ckn_vidro_tras_dir, ckn_port_diant_esq, ckn_port_diant_dir, ckn_port_tras_esq, ckn_port_tras_dir, ckn_parachoque_diant, ckn_parachoque_tras, ckn_roda_diant_esq, ckn_roda_diant_dir, ckn_roda_tras_esq, ckn_roda_tras_dir, ckn_pneu_diant_esq, ckn_pneu_diant_dir, ckn_pneu_tras_esq, ckn_pneu_tras_dir, ckn_status, car_id )values(@ckn_parabrisa_diant, @ckn_parabrisa_tras, @ckn_vidro_dianteiro, @ckn_vidro_traseiro, @ckn_vidro_diant_esq, @ckn_vidro_diant_dir, @ckn_vidro_tras_esq, @ckn_vidro_tras_dir, @ckn_port_diant_esq, @ckn_port_diant_dir, @ckn_port_tras_esq, @ckn_port_tras_dir, @ckn_parachoque_diant, @ckn_parachoque_tras, @ckn_roda_diant_esq, @ckn_roda_diant_dir, @ckn_roda_tras_esq, @ckn_roda_tras_dir, @ckn_pneu_diant_esq, @ckn_pneu_diant_dir, @ckn_pneu_tras_esq, @ckn_pneu_tras_dir, @ckn_status, @car_id )";

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
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_status", checkin.status));
                commandCkeckin.Parameters.Add(new MySqlParameter("car_id", checkin.car_id));
                commandCkeckin.ExecuteNonQuery();

                MessageBox.Show("Checkin realizado com sucesso: "); // exibe a mensagem quando a operacao de checkin é realizado com sucesso
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionRealizarCheckin.Close();// fecha a conexao
            }
        }// final do metodo

        // metodo responsavel pelo update do checkin
        public void UpdateCheckin(CheckinCheckout checkin)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryAtualizarCheckin = "UPDATE checkin set ckn_status = @ckn_status WHERE ckn_id = @ckn_id";

            MySqlConnection connectionAtualizarCheckin = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                connectionAtualizarCheckin.Open(); // abre a conexao
                MySqlCommand commandCkeckin = new MySqlCommand(queryAtualizarCheckin, connectionAtualizarCheckin); //  cria o comando , aonde recebe como parametro a query e o objeto de connexao
                commandCkeckin.Prepare();

                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_id", checkin.id));
                commandCkeckin.Parameters.Add(new MySqlParameter("ckn_status", checkin.status));
                
                commandCkeckin.ExecuteNonQuery();

                MessageBox.Show("Dados atualizado com sucesso: "); // exibe a mensagem quando a operacao de checkin é realizado com sucesso
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionAtualizarCheckin.Close();// fecha a conexao
            }
        }// final do metodo

        // metodo responsavel pelo retorno do veiculo que foram realizados o checkin
        public DataTable returnDatatableCheckin()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config
            string queryExibirVeiculo = "select checkin.ckn_id, carro.car_placa, carro.car_modelo, checkin.ckn_status from carro join checkin on checkin.car_id = carro.car_id order by checkin.ckn_id";

            MySqlConnection connectionExibirVeiculos = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao
            data = new DataTable();
            try
            {
                connectionExibirVeiculos.Open(); // abre a connexao
                da = new MySqlDataAdapter(queryExibirVeiculo, connectionExibirVeiculos);
                cb = new MySqlCommandBuilder(da);
                da.Fill(data);
                return data; // retorno do datatable
            }// fecha o try
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirVeiculos.Close(); //fecha a connexao
            }
        }// Fecha o metodo

        // metodo responsavel por listar veiculo em combo box
        public DataTable listarVeiculo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirVeiculo = "SELECT car_id, car_placa, car_modelo, car_marca, car_renavam, car_chassi, car_ano_fab, car_ano_mod, car_tipo, car_cor, car_num_portas, car_combustivel, car_km, car_cidade, car_uf, car_obs, car_idf_ativo FROM carro";

            MySqlConnection connectionExibirVeiculo = new MySqlConnection(connectionString);

            try
            {
                connectionExibirVeiculo.Open(); // abre a conexao
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
                data.Rows.InsertAt(row, 0);

                leitor.Close();
                leitor.Dispose();
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return data;
            }
            finally
            {
                connectionExibirVeiculo.Close(); // fecha a conexao
            }
        } // fecha o metodo datatable listarVeiculo

        // metodo responsavel por inserir os dados de funcionario
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
                commandInserir.Parameters.Add(new MySqlParameter("fun_conf_senha", funcionario.confirmarSenha));
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
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionInsert.Close(); // fecha a conexao
            }
        } // fecha o metodo

        // metodo responsavel por listar todos os funcionarios
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //metodo responsavel por realizar o login
        public Boolean Login(Funcionario funcionario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryLogin = "SELECT * from FUNCIONARIO WHERE fun_login = @fun_login AND fun_senha = @fun_senha";

            MySqlConnection connection = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {

                using (MySqlCommand command = new MySqlCommand(queryLogin, connection)) //  cria o comando update, aonde recebe como parametro a query e o objeto de connexao)
                {
                    connection.Open(); // abre a conexao
                  
                    command.Parameters.Add(new MySqlParameter("@fun_login", funcionario.login));
                    command.Parameters.Add(new MySqlParameter("@fun_senha", funcionario.senha));

                    leitor = command.ExecuteReader();
                    while (leitor.Read())
                    {
                        Funcionario fun = new Funcionario();
                        fun.id = Int32.Parse(leitor["fun_id"].ToString());
                        fun.nome = leitor["fun_nome"].ToString();
                        fun.cpf = leitor["fun_cpf"].ToString();
                        fun.login = leitor["fun_login"].ToString();
                        fun.senha = leitor["fun_senha"].ToString();
                        fun.confirmarSenha = leitor["fun_conf_senha"].ToString();
                        fun.dataCadastro = DateTime.Parse(leitor["fun_dta_cadastro"].ToString());
                        fun.email = leitor["fun_email"].ToString();
                        fun.telefone = leitor["fun_telefone"].ToString();
                        fun.celular = leitor["fun_celular"].ToString();
                        fun.status = leitor["fun_status"].ToString();
                        return true;
                    }
                    return false;                  
                } // fecha o using
            } // fecha o try
            catch (MySqlException)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return false;
            }
            finally
            {
                connection.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responsavel por atualizar os dados de funcionario
        public void AtualizarFuncionario(Funcionario funcionario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            String queryAtualizar = "UPDATE funcionario set fun_nome = @fun_nome, fun_cpf = @fun_cpf, fun_login = @fun_login, fun_senha = @fun_senha, fun_conf_senha = @fun_conf_senha, fun_dta_cadastro = @fun_dta_cadastro, fun_email = @fun_email, fun_telefone = @fun_telefone, fun_celular = @fun_celular, fun_status = @fun_status WHERE fun_id = @fun_id";
            MySqlConnection connectionUpdate = new MySqlConnection(connectionString);

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
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionUpdate.Close(); // fecha a conexao
            }
        } // fecha o metodo

        // metodo responsavel pela geracao do relatorio do veiculo
        public List<Veiculo> ExibiRelatorioVeiculo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirVeiculo = "SELECT car_id, car_placa, car_modelo, car_marca, car_renavam, car_chassi, car_ano_fab, car_ano_mod, car_tipo, car_cor, car_num_portas, car_combustivel, car_km, car_cidade, car_uf, car_obs, car_idf_ativo FROM carro ORDER BY car_modelo ASC";

            MySqlConnection connection = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                List<Veiculo> carro = new List<Veiculo>();

                using (MySqlCommand command = new MySqlCommand(queryExibirVeiculo, connection)) //  cria o comando update, aonde recebe como parametro a query e o objeto de connexao)
                {
                    connection.Open(); // abre a conexao
                    leitor = command.ExecuteReader();

                    while (leitor.Read())
                    {
                        Veiculo veiculo = new Veiculo();
                        veiculo.id = Int32.Parse(leitor["car_id"].ToString());
                        veiculo.placa = leitor["car_placa"].ToString();
                        veiculo.modelo = leitor["car_modelo"].ToString();
                        veiculo.marca = leitor["car_marca"].ToString();
                        veiculo.renavam = leitor["car_renavam"].ToString();
                        veiculo.chassi = leitor["car_chassi"].ToString();
                        veiculo.ano_fabricacao = leitor["car_ano_fab"].ToString();
                        veiculo.ano_modelo = leitor["car_ano_mod"].ToString();
                        veiculo.tipo = leitor["car_tipo"].ToString();
                        veiculo.cor = leitor["car_cor"].ToString();
                        veiculo.num_portas = leitor["car_num_portas"].ToString();
                        veiculo.combustivel = leitor["car_combustivel"].ToString();
                        veiculo.km = leitor["car_km"].ToString();
                        veiculo.cidade = leitor["car_cidade"].ToString();
                        veiculo.uf = leitor["car_uf"].ToString();
                        veiculo.observacao = leitor["car_obs"].ToString();
                        veiculo.idf_ativo = leitor["car_idf_ativo"].ToString();

                        carro.Add(veiculo);
                    }
                    return carro;
                }
            } // fecha o try
            catch (MySqlException) 
            {
                throw;
            }
            finally
            {
                connection.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responsavel pela geracao do relatorio de pessoa fisica
        public List<Cliente> ExibiRelatorioClienteFisico()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirPessoaF = "SELECT pf_id, pf_nome, pf_cpf, pf_rne, pf_cnh, pf_dta_nasc, pf_mail, pf_telefone, pf_celular, pf_sexo, pf_est_civil, pf_endereco, pf_num_casa, pf_complemento, pf_cep, pf_cidade, pf_bairro, pf_uf, pf_obs, pf_idf_ativo FROM pessoafisica ORDER BY pf_nome ASC";

            MySqlConnection connection = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                List<Cliente> pessoafisica = new List<Cliente>();

                using (MySqlCommand command = new MySqlCommand(queryExibirPessoaF, connection)) //  cria o comando, aonde recebe como parametro a query e o objeto de connexao)
                {
                    connection.Open(); // abre a conexao
                    leitor = command.ExecuteReader();

                    while (leitor.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Id = Int32.Parse(leitor["pf_id"].ToString());
                        cliente.nome = leitor["pf_nome"].ToString();
                        cliente.cpf = leitor["pf_cpf"].ToString();
                        cliente.rne = leitor["pf_rne"].ToString();
                        cliente.cnh = leitor["pf_cnh"].ToString();
                        cliente.data_nascimento = leitor["pf_dta_nasc"].ToString();
                        cliente.email = leitor["pf_mail"].ToString();
                        cliente.telefone = leitor["pf_telefone"].ToString();
                        cliente.celular = leitor["pf_celular"].ToString();
                        cliente.sexo = leitor["pf_sexo"].ToString();
                        cliente.Estado_civil = leitor["pf_est_civil"].ToString();
                        cliente.endereco = leitor["pf_endereco"].ToString();
                        cliente.numero_casa = leitor["pf_num_casa"].ToString();
                        cliente.complemento = leitor["pf_complemento"].ToString();
                        cliente.cep = leitor["pf_cep"].ToString();
                        cliente.cidade = leitor["pf_cidade"].ToString();
                        cliente.bairro = leitor["pf_bairro"].ToString();
                        cliente.estado = leitor["pf_uf"].ToString();
                        cliente.observacoes = leitor["pf_obs"].ToString();
                        cliente.idf_ativo = bool.Parse(leitor["pf_idf_ativo"].ToString());

                        pessoafisica.Add(cliente);
                    }
                    return pessoafisica;
                }
            } // fecha o try
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responsavel pela geracao do relatorio de pessoa fisica
        public List<Cliente> ExibiRelatorioClienteJuridico()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirPessoaJ = "SELECT pj_id, pj_raz_soc, pj_cnpj, pj_nom_fan, pj_insc_est, pj_insc_mun, pj_mail, pj_telefone, pj_celular, pj_endereco, pj_num_casa, pj_complemento, pj_cep, pj_cidade, pj_bairro, pj_uf, pj_obs, pj_idf_ativo FROM pessoajuridica ORDER BY pj_raz_soc ASC";

            MySqlConnection connection = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                List<Cliente> pessoajuridica = new List<Cliente>();

                using (MySqlCommand command = new MySqlCommand(queryExibirPessoaJ, connection)) //  cria o comando, aonde recebe como parametro a query e o objeto de connexao)
                {
                    connection.Open(); // abre a conexao
                    leitor = command.ExecuteReader();

                    while (leitor.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Id = Int32.Parse(leitor["pj_id"].ToString());
                        cliente.razao_social = leitor["pj_raz_soc"].ToString();
                        cliente.cnpj = leitor["pj_cnpj"].ToString();
                        cliente.nome_fantasia = leitor["pj_nom_fan"].ToString();
                        cliente.insc_estadual = leitor["pj_insc_est"].ToString();
                        cliente.insc_municipal = leitor["pj_insc_mun"].ToString();
                        cliente.email = leitor["pj_mail"].ToString();
                        cliente.telefone = leitor["pj_telefone"].ToString();
                        cliente.celular = leitor["pj_celular"].ToString();
                        cliente.endereco = leitor["pj_endereco"].ToString();
                        cliente.numero_casa = leitor["pj_num_casa"].ToString();
                        cliente.complemento = leitor["pj_complemento"].ToString();
                        cliente.cep = leitor["pj_cep"].ToString();
                        cliente.cidade = leitor["pj_cidade"].ToString();
                        cliente.bairro = leitor["pj_bairro"].ToString();
                        cliente.estado = leitor["pj_uf"].ToString();
                        cliente.observacoes = leitor["pj_obs"].ToString();
                        cliente.idf_ativo = bool.Parse(leitor["pj_idf_ativo"].ToString());

                        pessoajuridica.Add(cliente);
                    }
                    return pessoajuridica;
                }
            } // fecha o try
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        //metodo responsavel pela geracao do relatorio de locacao pessoa fisica
        public List<Locacao> ExibiRelatorioLocacaoPf()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirLocacaoPf = "SELECT loc_id, loc_dta_loc, loc_dta_dev, loc_tipo_locacao, loc_form_pagamento, loc_valor_locacao, loc_status, ckn_id, pf_id FROM locacao WHERE pf_id = pf_id ORDER BY loc_dta_loc DESC";

            MySqlConnection connection = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                List<Locacao> locacaoPessoaFisica = new List<Locacao>();

                using (MySqlCommand command = new MySqlCommand(queryExibirLocacaoPf, connection)) //  cria o comando, aonde recebe como parametro a query e o objeto de connexao)
                {
                    connection.Open(); // abre a conexao
                    leitor = command.ExecuteReader();

                    while (leitor.Read())
                    {
                        Locacao locacaoPf = new Locacao();

                        locacaoPf.id = Int32.Parse(leitor["loc_id"].ToString());
                        locacaoPf.data_locacao = DateTime.Parse(leitor["loc_dta_loc"].ToString());
                        locacaoPf.data_devolucao = DateTime.Parse(leitor["loc_dta_dev"].ToString());
                        locacaoPf.tipo_locacao = leitor["loc_tipo_locacao"].ToString();
                        locacaoPf.forma_pagamento = leitor["loc_form_pagamento"].ToString();
                        locacaoPf.valor_locacao = leitor["loc_valor_locacao"].ToString();
                        locacaoPf.status = leitor["loc_status"].ToString();
                        locacaoPf.ckn_id = leitor["ckn_id"].ToString();
                        locacaoPf.pf_id = leitor["pf_id"].ToString();
                       
                        locacaoPessoaFisica.Add(locacaoPf);
                    }
                    return locacaoPessoaFisica;
                }
            } // fecha o try
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responsavel pela geracao do relatorio de devolucao pessoa juridica
        public List<Locacao> ExibiRelatorioLocacaoPj()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryExibirLocacaoPj = "SELECT loc_id, loc_dta_loc, loc_dta_dev, loc_tipo_locacao, loc_form_pagamento, loc_valor_locacao, loc_status, ckn_id, pj_id FROM locacao WHERE pj_id = pj_id ORDER BY loc_dta_loc DESC";

            MySqlConnection connection = new MySqlConnection(connectionString); // cria objeto de connexao que recebe como parametro a string de connexao

            try
            {
                List<Locacao> locacaoPessoaJuridica = new List<Locacao>();

                using (MySqlCommand command = new MySqlCommand(queryExibirLocacaoPj, connection)) //  cria o comando, aonde recebe como parametro a query e o objeto de connexao)
                {
                    connection.Open(); // abre a conexao
                    leitor = command.ExecuteReader();

                    while (leitor.Read())
                    {
                        Locacao locacaoPj = new Locacao();

                        locacaoPj.id = Int32.Parse(leitor["loc_id"].ToString());
                        locacaoPj.data_locacao = DateTime.Parse(leitor["loc_dta_loc"].ToString());
                        locacaoPj.data_devolucao = DateTime.Parse(leitor["loc_dta_dev"].ToString());
                        locacaoPj.tipo_locacao = leitor["loc_tipo_locacao"].ToString();
                        locacaoPj.forma_pagamento = leitor["loc_form_pagamento"].ToString();
                        locacaoPj.valor_locacao = leitor["loc_valor_locacao"].ToString();
                        locacaoPj.status = leitor["loc_status"].ToString();
                        locacaoPj.ckn_id = leitor["ckn_id"].ToString();
                        locacaoPj.pj_id = leitor["pj_id"].ToString();

                        locacaoPessoaJuridica.Add(locacaoPj);
                    }
                    return locacaoPessoaJuridica;
                }
            } // fecha o try
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responvavel por realizar a locacao
        public void RealizarLocacao(Locacao locacao)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryRealizarLocacao = "INSERT INTO LOCACAO(loc_dta_loc, loc_dta_dev, loc_tipo_locacao, loc_form_pagamento, loc_valor_locacao, loc_status, ckn_id , pj_id, pf_id)values(@loc_dta_loc, @loc_dta_dev, @loc_tipo_locacao, @loc_form_pagamento, @loc_valor_locacao, @loc_status, @ckn_id, @pj_id, @pf_id)";

            MySqlConnection connectionRealizarLocacao = new MySqlConnection(connectionString);

            try
            {
                connectionRealizarLocacao.Open(); // abre a conexao
                MySqlCommand commandLocacao = new MySqlCommand(queryRealizarLocacao, connectionRealizarLocacao);
                commandLocacao.Prepare();

                commandLocacao.Parameters.Add(new MySqlParameter("loc_dta_loc", locacao.data_locacao));
                commandLocacao.Parameters.Add(new MySqlParameter("loc_dta_dev", locacao.data_devolucao));
                commandLocacao.Parameters.Add(new MySqlParameter("loc_tipo_locacao", locacao.tipo_locacao));
                commandLocacao.Parameters.Add(new MySqlParameter("loc_form_pagamento", locacao.forma_pagamento));
                commandLocacao.Parameters.Add(new MySqlParameter("loc_valor_locacao", locacao.valor_locacao));
                commandLocacao.Parameters.Add(new MySqlParameter("loc_status", locacao.status));
                commandLocacao.Parameters.Add(new MySqlParameter("ckn_id", locacao.ckn_id));
                commandLocacao.Parameters.Add(new MySqlParameter("pj_id", locacao.pj_id));
                commandLocacao.Parameters.Add(new MySqlParameter("pf_id",locacao.pf_id));

                commandLocacao.ExecuteNonQuery();

                MessageBox.Show("Locacao realizada com sucesso: ");
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionRealizarLocacao.Close(); // fecha a conexao
            }
        } // fecha o metodo

        // metodo responsavel por exibir itens da locacao de pessoa fisica
        public DataTable ListarLocacaoPessoaFisica()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT loc_id, loc_dta_loc, loc_dta_dev, loc_tipo_locacao, loc_form_pagamento, loc_valor_locacao, loc_status, ckn_id, pf_id FROM locacao WHERE pf_id = pf_id ORDER BY loc_dta_loc ASC";
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responsavel por exibir itens da locacao de pessoa juridica
        public DataTable ListarLocacaoPessoaJuridica()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Locadoraveiculos"].ConnectionString; // string de connexao configurada no app.config

            string queryExibirTodos = "SELECT loc_id, loc_dta_loc, loc_dta_dev, loc_tipo_locacao, loc_form_pagamento, loc_valor_locacao, loc_status, ckn_id, pj_id FROM locacao WHERE pj_id = pj_id ORDER BY loc_dta_loc ASC";
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
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
                return data; // returno do datatable
            }
            finally
            {
                connectionExibirTodos.Close(); // fecha a conexao 
            }
        } // fecha o metodo

        // metodo responsavel pela atualizacao dos dados da locacao
        public void RealizarDevolucao(Locacao devolucao)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["locadoraveiculos"].ConnectionString; // string de conexao configurada no app.config
            string queryRealizarDevolucao = "UPDATE locacao set loc_status = @loc_status, loc_dta_dev = @loc_dta_dev, loc_valor_locacao = @loc_valor_locacao WHERE loc_id = @loc_id";

            MySqlConnection connectionRealizarDevolucao = new MySqlConnection(connectionString);

            try
            {
                connectionRealizarDevolucao.Open(); // abre a conexao
                MySqlCommand commandRealizarDevolucao = new MySqlCommand(queryRealizarDevolucao, connectionRealizarDevolucao);
                commandRealizarDevolucao.Prepare();

                commandRealizarDevolucao.Parameters.Add(new MySqlParameter("loc_id",devolucao.id));
                commandRealizarDevolucao.Parameters.Add(new MySqlParameter("loc_status", devolucao.status));
                commandRealizarDevolucao.Parameters.Add(new MySqlParameter("loc_dta_dev", devolucao.data_devolucao));
                commandRealizarDevolucao.Parameters.Add(new MySqlParameter("loc_valor_locacao", devolucao.valor_locacao));         

                commandRealizarDevolucao.ExecuteNonQuery();

                MessageBox.Show("Devolucao efetuada com sucesso: ");
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel se conectar a base de dados!", MessageBoxButtons.OK.ToString()); // exibe a mensagem quando ocorrer algum erro na operacao
            }
            finally
            {
                connectionRealizarDevolucao.Close(); // fecha a conexao
            }
        } // fecha o metodo
    } // final da classe Dao
} // final do namespace
