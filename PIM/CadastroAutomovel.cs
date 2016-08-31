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
    public partial class CadastroAutomovel : Form
    {
        public CadastroAutomovel()
        {
            InitializeComponent();
        }

        private void BtnCancelaAutomovel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CadastroAutomovel_Load(object sender, EventArgs e)
        {

        }
    }
}
