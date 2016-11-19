using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CdbDao.Relatorio;

namespace PIM
{
    public partial class RelatorioCliente : Form
    {
        public RelatorioCliente()
        {
            InitializeComponent();
        }

        //metodo que fecha o formulario
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        } // fecha o metodo

        // abre relatorio pessoa fisica
        private void btnPessoaF_Click(object sender, EventArgs e)
        {
            RelatorioPessoaFisica relatorio = new RelatorioPessoaFisica();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        } // fecha o metodo

        // abre relatorio pessoa juridica
        private void btnPessoaJ_Click(object sender, EventArgs e)
        {
            RelatorioPessoaJuridica relatorio = new RelatorioPessoaJuridica();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
