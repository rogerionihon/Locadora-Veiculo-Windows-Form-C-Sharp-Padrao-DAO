using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CdbDao.ConnectionDataBase;
using CdbDao.ModelCliente;

namespace CdbDao.Relatorio
{
    public partial class RelatorioVeiculo : Form
    {
        Dao cdb = new Dao();

        public RelatorioVeiculo()
        {
            InitializeComponent();
        }

        private void RelatorioVeiculo_Load(object sender, EventArgs e)
        {
            VeiculoBindingSource.DataSource = cdb.ExibiRelatorioVeiculo();
            this.reportViewer1.RefreshReport();
        }
    }
}
