using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdbDao.ModelCliente
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string confirmarSenha { get; set; }
        public DateTime dataCadastro { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string status { get; set; }
    } // fecha a classe
} // fecha o namespace

      