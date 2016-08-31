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
    public partial class AluguelAutomovel : Form
    {
        public AluguelAutomovel()
        {
            InitializeComponent();
        }

        private void BtnCancelaAluguelAutomovel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
