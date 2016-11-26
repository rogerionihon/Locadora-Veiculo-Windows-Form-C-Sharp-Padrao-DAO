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
    public partial class RelatorioLocacao : Form
    {
        public RelatorioLocacao()
        {
            InitializeComponent();
        }

        private void btnLocSair_Click(object sender, EventArgs e)
        {
            this.Close();
        } // fecha o metodo

        // exibi formulario de relatorio pessoa fisica
        private void btnLocPesFis_Click(object sender, EventArgs e)
        {
            RelatorioLocacaoPf relatorioPf = new RelatorioLocacaoPf();
            relatorioPf.StartPosition = FormStartPosition.CenterScreen;
            relatorioPf.Show();
        } // fecha o metodo

        // exibi formulario de relatorio pessoa juridica
        private void btnLocPesJur_Click(object sender, EventArgs e)
        {
            RelatorioLocacaoPj relatorioPj = new RelatorioLocacaoPj();
            relatorioPj.StartPosition = FormStartPosition.CenterScreen;
            relatorioPj.Show();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
