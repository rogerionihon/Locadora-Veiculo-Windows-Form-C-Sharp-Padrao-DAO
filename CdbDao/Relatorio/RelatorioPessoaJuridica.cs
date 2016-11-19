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

namespace CdbDao.Relatorio
{
    public partial class RelatorioPessoaJuridica : Form
    {
        Dao cdb = new Dao();

        public RelatorioPessoaJuridica()
        {
            InitializeComponent();
        }

        private void RelatorioPessoaJuridica_Load(object sender, EventArgs e)
        {
            ClienteBindingSource.DataSource = cdb.ExibiRelatorioClienteJuridico();
            this.reportViewer1.RefreshReport();
        }
    }
}
