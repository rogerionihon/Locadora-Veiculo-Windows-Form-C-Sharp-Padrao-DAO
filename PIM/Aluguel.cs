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

        private void BtnSairAluguel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            //Abre o aluguel de carro
            AluguelAutomovel aluguelautomovel = new AluguelAutomovel();
            aluguelautomovel.StartPosition = FormStartPosition.CenterScreen;
            aluguelautomovel.Show();
        }

        private void btnDevolução_Click(object sender, EventArgs e)
        {
            //Abre devolução de carro
            DevolucaoAutomovel devolucaoautomovel = new DevolucaoAutomovel();
            devolucaoautomovel.StartPosition = FormStartPosition.CenterScreen;
            devolucaoautomovel.Show();
        }
    }
}
