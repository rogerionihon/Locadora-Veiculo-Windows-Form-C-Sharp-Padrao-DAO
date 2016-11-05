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
    public partial class LocalizarMenu : Form
    {
        
        public LocalizarMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            LocalizarCliente localizarcliente = new LocalizarCliente();
            localizarcliente.StartPosition = FormStartPosition.CenterScreen;
            localizarcliente.Show();                     
        }

        private void btnSairLocalizacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            LocalizarVeiculo localizarveiculo = new LocalizarVeiculo();
            localizarveiculo.StartPosition = FormStartPosition.CenterScreen;
            localizarveiculo.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            LocalizarFuncionario localizarFuncionario = new LocalizarFuncionario();
            localizarFuncionario.StartPosition = FormStartPosition.CenterScreen;
            localizarFuncionario.Show();
        }
    }
}
