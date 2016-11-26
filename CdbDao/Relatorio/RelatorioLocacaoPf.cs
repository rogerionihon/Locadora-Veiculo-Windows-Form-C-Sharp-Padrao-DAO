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
    public partial class RelatorioLocacaoPf : Form
    {
        Dao cdb = new Dao(); // criacao do objeto de conexao
        public RelatorioLocacaoPf()
        {
            InitializeComponent();
        }

        private void RelatorioLocacaoPf_Load(object sender, EventArgs e)
        {
            LocacaoBindingSource.DataSource = cdb.ExibiRelatorioLocacaoPf();
            this.reportViewer1.RefreshReport();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
