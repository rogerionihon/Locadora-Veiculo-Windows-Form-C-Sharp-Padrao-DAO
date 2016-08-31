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
    public partial class DevolucaoAutomovel : Form
    {
        public DevolucaoAutomovel()
        {
            InitializeComponent();
        }

        private void BtnCancelaDevolucaoAutomovel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
