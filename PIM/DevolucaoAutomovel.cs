using CdbDao.ConnectionDataBase;
using CdbDao.ModelCliente;
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
        Dao Cdb = new Dao(); // criacao do objeto do tipo DAO

        Cliente novocliente = new Cliente(); // criacao do objeto do tipo Cliente

        Veiculo novoveiculo = new Veiculo(); // criacao do objeto do tipo veiculo

        DataTable dt = new DataTable(); // criacao do objeto do tipo datatable

        Locacao devolver = new Locacao();
        public DevolucaoAutomovel()
        {
            InitializeComponent();
        }

        private void BtnCancelaDevolucaoAutomovel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable ListarLocacao()
        {
            try
            {
                dt = Cdb.ListarLocacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar listar todos os veiculos: " + ex.Message); // exibe a mensagem caso a operacao nao seja realizada com sucesso
            }
            return dt; // retorno do datatable
        }

        private void CarregarGridLocaco()
        {
            gridView.DataSource = ListarLocacao(); // chama o metodo datatable para listar todos os clientes

            // edita o cabecalho do datagridwiew
            gridView.Columns[0].Visible = false;
            gridView.Columns[0].HeaderText = "Código";
            gridView.Columns[1].HeaderText = "Data Locação";
            gridView.Columns[2].HeaderText = "Data Devolução";
            gridView.Columns[3].HeaderText = "Tipo de Locação ";
            gridView.Columns[4].HeaderText = "Forma de Pagamento";
            gridView.Columns[5].HeaderText = "Valor da Locação";
            gridView.Columns[6].HeaderText = "Código do Checkin";
            gridView.Columns[7].HeaderText = "Código Pessoa Juridica";
            gridView.Columns[8].HeaderText = "Código Pessoa Fisica";
           

            //edita o tamanho das colunas do datagridview
            gridView.Columns[0].Width = 50;
            gridView.Columns[1].Width = 90;
            gridView.Columns[2].Width = 90;
            gridView.Columns[3].Width = 110;
            gridView.Columns[4].Width = 120;
            gridView.Columns[5].Width = 90;
            gridView.Columns[6].Width = 130;
            gridView.Columns[7].Width = 130;
            gridView.Columns[8].Width = 130;
        }

        private void DevolucaoAutomovel_Load(object sender, EventArgs e)
        {
            CarregarGridLocaco();
        }// fecha o metodo

    }
}
