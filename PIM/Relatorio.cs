using CdbDao.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        //metodo que fecha o formulario
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        } // fecha o metodo

        // abre relatorio veiculo
        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            RelatorioVeiculo relatorio = new RelatorioVeiculo();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        } // fecha o metodo

        // abre relatorio clientes
        private void btnCliente_Click(object sender, EventArgs e)
        {
            RelatorioCliente relatorio = new RelatorioCliente();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        } // fecha o metodo
        
        //abre o relatorio Locacao
        private void btnLocacao_Click(object sender, EventArgs e)
        {
            RelatorioLocacao relatorio = new RelatorioLocacao();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
