using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdbDao.ModelCliente
{
    public class CheckinCheckout
    {
        public int id { get; set; }
        public Boolean parabrisa_diant { get; set; }
        public Boolean parabrisa_tras { get; set; }
        public Boolean vidro_dianteiro { get; set; }
        public Boolean vidro_traseiro { get; set; }
        public Boolean vidro_diant_esq { get; set; }
        public Boolean vidro_diant_dir { get; set; }
        public Boolean vidro_tras_esq { get; set; }
        public Boolean vidro_tras_dir { get; set; }
        public Boolean port_diant_esq { get; set; }
        public Boolean port_diant_dir { get; set; }
        public Boolean port_tras_esq { get; set; }
        public Boolean port_tras_dir { get; set; }
        public Boolean parachoque_diant { get; set; }
        public Boolean parachoque_tras { get; set; }
        public Boolean roda_diant_esq { get; set; }
        public Boolean roda_diant_dir { get; set; }
        public Boolean roda_tras_esq { get; set; }
        public Boolean roda_tras_dir { get; set; }
        public Boolean pneu_diant_esq { get; set; }
        public Boolean pneu_diant_dir { get; set; }
        public Boolean pneu_tras_esq { get; set; }
        public Boolean pneu_tras_dir { get; set; }
        public string car_id { get; set; }
    }
}
