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
    public partial class RelatorioLocacaoPj : Form
    {
        Dao cdb = new Dao(); // cria objeto de conexao
        public RelatorioLocacaoPj()
        {
            InitializeComponent();
        }

        private void RelatorioLocacaoPj_Load(object sender, EventArgs e)
        {
            LocacaoBindingSource.DataSource = cdb.ExibiRelatorioLocacaoPj();
            this.reportViewer1.RefreshReport();
        }// fecha o metodo
    } // fecha a classe
} // fecha o namespace
