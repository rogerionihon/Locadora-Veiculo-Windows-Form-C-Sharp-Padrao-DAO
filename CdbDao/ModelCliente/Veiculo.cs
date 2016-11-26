using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdbDao.ModelCliente
{
    public class Veiculo
    {
        public int id { get; set; }
        public string placa { get; set; }
        public string ano_fabricacao { get; set; }
        public string ano_modelo { get; set; }
        public string chassi { get; set; }
        public string renavam { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tipo { get; set; }
        public string cor { get; set; }
        public string num_portas { get; set; }
        public string combustivel { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string km { get; set; }
        public string observacao { get; set; }
        public string idf_ativo { get; set; }
    } // fecha a classe
} // fecha o namespace
