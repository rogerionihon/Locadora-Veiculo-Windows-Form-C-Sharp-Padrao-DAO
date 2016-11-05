using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdbDao.ModelCliente
{
    public class Locacao
    {
        public int id { get; set; }
        public string data_locacao { get; set; }
        public string data_devolucao { get; set; }
        public string tipo_locacao { get; set; }
        public string forma_pagamento { get; set; }
        public string valor_locacao { get; set; }

    }
}
