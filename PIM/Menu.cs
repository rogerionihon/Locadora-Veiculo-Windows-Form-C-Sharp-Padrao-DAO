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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        //Abre cadastro geral
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.StartPosition = FormStartPosition.CenterScreen;
            cadastro.Show();
        }

        //Encerra a aplicacao
        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja Sair do Sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Abre Aluguel geral
        private void BtnAluguel_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.StartPosition = FormStartPosition.CenterScreen;
            aluguel.Show();
        }

        //abre localizacao geral
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocalizarMenu localizar = new LocalizarMenu();
            localizar.StartPosition = FormStartPosition.CenterScreen;
            localizar.Show();
        }

        //abre relatorio geral
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        }
    }
}
