using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CdbDao.ModelCliente;
using CdbDao.ModelVeiculo;
using System.Windows.Forms;

namespace CdbDao.ConnectionDataBase
{
    public class CdbDao
    {
        //inserir Pessoa Fisica
        public void InserirPessoaFisica(Cliente cliente)
        {
            string connectionStringInserirPessoaF = @"server=localhost;database=pimfinal;userid=root;password=root";
            string queryInserirPessoaF = "INSERT INTO clientefisico (fid, fnome, fendereco, fcidade, festado, fcep, fcpf, fsexo, femail, fcnh, ftelefone, fcelular, fnumero_casa, fdata_nascimento, frne, fbairro, fobservacoes,  ) values (@fid, @fnome, @fendereco, @fcidade, @festado, @fcep, @fcpf, @fsexo, @femail, @fcnh, @ftelefone, @fcelular, @fnumero_casa, @fdata_nascimento, @frne, @fbairro, @fobservacoes)";

            MySqlConnection connectionInsertPessoaF = new MySqlConnection(connectionStringInserirPessoaF);
            try
            {

                connectionInsertPessoaF.Open();
                MySqlCommand commandInserir = new MySqlCommand(queryInserirPessoaF, connectionInsertPessoaF);
                commandInserir.Prepare();
                commandInserir.Parameters.Add(new MySqlParameter("fnome", cliente.nome));
                commandInserir.Parameters.Add(new MySqlParameter("fendereco", cliente.endereco));
                commandInserir.Parameters.Add(new MySqlParameter("fcidade", cliente.cidade));
                commandInserir.Parameters.Add(new MySqlParameter("festado", cliente.estado));
                commandInserir.Parameters.Add(new MySqlParameter("fcep", cliente.cep));
                commandInserir.Parameters.Add(new MySqlParameter("fcpf", cliente.cpf));
                commandInserir.Parameters.Add(new MySqlParameter("fsexo", cliente.cnh));
                commandInserir.Parameters.Add(new MySqlParameter("femail", cliente.email));
                commandInserir.Parameters.Add(new MySqlParameter("fcnh", cliente.cnh));
                commandInserir.Parameters.Add(new MySqlParameter("ftelefone", cliente.telefone));
                commandInserir.Parameters.Add(new MySqlParameter("fcelular", cliente.celular));
                commandInserir.Parameters.Add(new MySqlParameter("fnumero_casa", cliente.numero_casa));
                commandInserir.Parameters.Add(new MySqlParameter("fdata_nascimento", cliente.data_nascimento));
                commandInserir.Parameters.Add(new MySqlParameter("frne", cliente.rne));
                commandInserir.Parameters.Add(new MySqlParameter("fbairro", cliente.bairro));
                commandInserir.Parameters.Add(new MySqlParameter("fobservacoes", cliente.observacoes));
                commandInserir.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                connectionInsertPessoaF.Close();

            }

        }

        //Inserir pessoa juridica
        public void InserirPessoaJuridica(Cliente cliente)
        {
            string connectionStringInserirPessoaJ = "@server=localhost;database=pimfinal;userid=root;password;root";
            string queryInserirPessoaJ = "INSERT INTO clientejuridico (jid, jcnpj, jrazao_social, jnome_fantasia, jinsc_municipal, jinsc_estadual, jtelefone, jcelular, jcnh, jsexo, jemail, jendereco, jnumero_casa, jbairro, jcidade, jcep, jestado, jobservacoes ) values (@jid, @jcnpj, @jrazao_social, @jnome_fantasia, @jinsc_municipal, @jinsc_estadual, @jtelefone, @jcelular, @jcnh, @jsexo, @jemail, @jendereco, @jnumero_casa, @jbairro, @jcidade, @jcep, @jestado, @jobservacoes)";

            MySqlConnection connectionInsertPessoaJ = new MySqlConnection(connectionStringInserirPessoaJ);

            try
            {
                connectionInsertPessoaJ.Open();
                MySqlCommand commandInserir = new MySqlCommand(queryInserirPessoaJ, connectionInsertPessoaJ);
                commandInserir.Prepare();
                commandInserir.Parameters.Add(new MySqlParameter("jcnpj", cliente.cnpj));
                commandInserir.Parameters.Add(new MySqlParameter("jrazao_social", cliente.razao_social));
                commandInserir.Parameters.Add(new MySqlParameter("jnome_fantasia", cliente.nome_fantasia));
                commandInserir.Parameters.Add(new MySqlParameter("jinsc_municipal", cliente.insc_municipal));
                commandInserir.Parameters.Add(new MySqlParameter("jinsc_estadual", cliente.insc_estadual));
                commandInserir.Parameters.Add(new MySqlParameter("jtelefone", cliente.telefone));
                commandInserir.Parameters.Add(new MySqlParameter("jcelular", cliente.celular));
                commandInserir.Parameters.Add(new MySqlParameter("jcnh", cliente.cnh));
                commandInserir.Parameters.Add(new MySqlParameter("jsexo", cliente.sexo));
                commandInserir.Parameters.Add(new MySqlParameter("jemail", cliente.email));
                commandInserir.Parameters.Add(new MySqlParameter("jendereco", cliente.endereco));
                commandInserir.Parameters.Add(new MySqlParameter("jnumero_casa", cliente.numero_casa));
                commandInserir.Parameters.Add(new MySqlParameter("jbairro", cliente.bairro));
                commandInserir.Parameters.Add(new MySqlParameter("jcidade", cliente.cidade));
                commandInserir.Parameters.Add(new MySqlParameter("jcep", cliente.cep));
                commandInserir.Parameters.Add(new MySqlParameter("jestado", cliente.estado));
                commandInserir.Parameters.Add(new MySqlParameter("jobservacoes", cliente.observacoes));
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

        // INSERT VEICULO

        public void InsertVeiculo(Veiculo veiculo)
        {
            string connectionStringInserirVeiculo = "@server=localhost; database=pimfinal;userid=root;password=root";
            string InserirVeiculo = "INSERT INTO veiculo(vid, vplaca, vano_fabricacao, vano_modelo, vchassi, vrenavam, vmarca, vmodelo, vcor, vcombustivel, vportas, vquilometragem, vtipo, vcidade, vuf, vobservacao) values (@vid, @vplaca, @vano_fabricacao, @vano_modelo, @vchassi, @vrenavam, @vmarca, @vmodelo, @vcor, @vcombustivel, @vportas, @vquilometragem, @vtipo, @vcidade, @vuf, @vobservacao)";

            MySqlConnection connectionInsertVeiculo = new MySqlConnection(connectionStringInserirVeiculo);

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
