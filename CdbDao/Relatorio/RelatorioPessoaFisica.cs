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
    public partial class RelatorioPessoaFisica : Form
    {
        Dao cdb = new Dao(); // criacao do objeto de conexao
        public RelatorioPessoaFisica()
        {
            InitializeComponent();
        }

        // metodo que gera o relatorio
        private void RelatorioPessoaFisica_Load(object sender, EventArgs e)
        {
            ClienteBindingSource.DataSource = cdb.ExibiRelatorioClienteFisico();
            this.reportViewer1.RefreshReport();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
