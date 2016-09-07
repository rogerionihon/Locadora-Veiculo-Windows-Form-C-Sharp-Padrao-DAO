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
    public partial class LocalizarCliente : Form
    {
        public LocalizarCliente()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        DataGridView dgvCliente = new DataGridView();
        private void LocalizarCliente_Load(object sender, EventArgs e)
        {
            //table.Columns[0].HeaderText = "Codigo";
            table.Columns.Add("Codigo");
            table.Columns.Add("Razao social");
            table.Columns.Add("Nome Fantasia");
            table.Columns.Add("CNPJ");
            table.Columns.Add("Inscricao estadual");
            table.Columns.Add("Inscricao municipal");
            table.Columns.Add("Nome");
            table.Columns.Add("CPF");
            table.Columns.Add("CNH");
            table.Columns.Add("RNE");
            table.Columns.Add("Telefone");
            table.Columns.Add("Celular");
            table.Columns.Add("Sexo");
            table.Columns.Add("E-mail");
            table.Columns.Add("Estado civil");
            table.Columns.Add("Data de nascimento");
            table.Columns.Add("CEP");
            table.Columns.Add("Endereco");
            table.Columns.Add("Numero");
            table.Columns.Add("Bairro");
            table.Columns.Add("Cidade");
            table.Columns.Add("Estado");
            table.Columns.Add("Complemento");
            table.Columns.Add("Observacoes");
            
           
            dataGridView1.DataSource = table;
        }

        private void rbtPessoaj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaj.Checked == true)
            {


                
                carregaformpessoaj();

                
            }
        }
       
        private void rbtPessoaf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaf.Checked == true)
            {
                
                
                carreformpessoaf();

            }
        }

        private void carregaformpessoaj()
        {
                          
                table.Columns.Remove("Nome");
                table.Columns.Remove("CPF");
                table.Columns.Remove("CNH");
                table.Columns.Remove("RNE");

        }

        public void carreformpessoaf()
        {

            
            table.Columns.Remove("Razao social");
            table.Columns.Remove("Nome Fantasia");
            table.Columns.Remove("CNPJ");
            table.Columns.Remove("Inscricao estadual");
            table.Columns.Remove("Inscricao municipal");


        }


    }
}
