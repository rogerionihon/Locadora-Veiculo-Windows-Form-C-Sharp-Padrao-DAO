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
    public partial class Aluguel : Form
    {
        public Aluguel()
        {
            InitializeComponent();
        }

        //fecha o formulario
        private void BtnSairAluguel_Click(object sender, EventArgs e)
        {
            this.Close();
        } // fecha o metodo

        //abre o aluguel de carro
        private void btnDev_Click(object sender, EventArgs e)
        {
            AluguelAutomovel aluguelautomovel = new AluguelAutomovel();
            aluguelautomovel.StartPosition = FormStartPosition.CenterScreen;
            aluguelautomovel.Show();
        } // fecha o metodo

        //Abre a devolucao de carro
        private void btnDevolução_Click(object sender, EventArgs e)
        {
            DevolucaoAutomovel devolucaoautomovel = new DevolucaoAutomovel();
            devolucaoautomovel.StartPosition = FormStartPosition.CenterScreen;
            devolucaoautomovel.Show();
        } // fecha o metodo
    } // fecha a classe
} // fecha o namespace
