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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //Abre cadastro geral
            Cadastro cadastro = new Cadastro();
            //cadastro.MdiParent = this; 
            //this.Hide();
            cadastro.StartPosition = FormStartPosition.CenterScreen;
            cadastro.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAluguel_Click(object sender, EventArgs e)
        {
            //Abre Aluguel geral
            Aluguel aluguel = new Aluguel();
            //cadastro.MdiParent = this; 
            //this.Hide();
            aluguel.StartPosition = FormStartPosition.CenterScreen;
            aluguel.Show();
        }
    }
}
