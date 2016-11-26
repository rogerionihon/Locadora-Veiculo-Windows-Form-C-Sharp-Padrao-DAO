using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdbDao.ModelCliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string data_nascimento { get; set; }
        public string cnpj { get; set; }
        public string insc_estadual { get; set; }
        public string insc_municipal { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string cpf { get; set; }
        public string cnh { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string observacoes { get; set; }
        public string numero_casa { get; set; }
        public string rne { get; set; }
        public string bairro { get; set; }
        public string Estado_civil { get; set; }
        public string complemento { get; set; }
        public Boolean idf_ativo { get; set; }
    } // fecha a classe
} // fecha o namespace
