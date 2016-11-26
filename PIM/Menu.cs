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

        //abre cadastro geral
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.StartPosition = FormStartPosition.CenterScreen;
            cadastro.Show();
        } // fecha o metodo

        //metodo que fecha o formulario
        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        } // fecha o metodo

        //abre aluguel geral
        private void BtnAluguel_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.StartPosition = FormStartPosition.CenterScreen;
            aluguel.Show();
        } // fecha o metodo

        //abre localizacao geral
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocalizarMenu localizar = new LocalizarMenu();
            localizar.StartPosition = FormStartPosition.CenterScreen;
            localizar.Show();
        } // fecha o metodo

        //abre relatorio geral
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.StartPosition = FormStartPosition.CenterScreen;
            relatorio.Show();
        } // fecha metodo
    } // fecha a classe
} // fecha o namespace
