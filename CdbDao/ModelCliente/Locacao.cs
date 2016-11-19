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
        public DateTime data_locacao { get; set; }
        public DateTime data_devolucao { get; set; }
        public string tipo_locacao { get; set; }
        public string forma_pagamento { get; set; }
        public string valor_locacao { get; set; }
        public string pf_id { get; set; }
        public string pj_id { get; set; }
        public string ckn_id { get; set; }
        public string car_id { get; set; }

    }
}
