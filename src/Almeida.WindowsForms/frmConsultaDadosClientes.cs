using Almeida.Application.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Almeida.WindowsForms
{
    public partial class frmConsultaDadosClientes : Form
    {
        private readonly IPessoaServices _pessoaServices;
        public frmConsultaDadosClientes(IPessoaServices pessoaServices)
        {
            _pessoaServices = pessoaServices;
            InitializeComponent();
        }

        private void frmConsultaDadosClientes_Load(object sender, EventArgs e)
        {
            PessoaRepositorys pessoaRepository = new PessoaRepositorys();
            //dgvConsultaDadosCliente.DataSource = pessoaRepository.GetConsultaPessoaPagamento();
            //dgvConsultaDadosCliente.Columns[0].HeaderText = "Nome Completo";
            //dgvConsultaDadosCliente.Columns[0].Width = 50;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Registro alterado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {


            var busca = txtPesquisar.Text;

            if (String.IsNullOrEmpty(busca)) // verifica se o valor veio vazio, caso esteja vazio, tras todos os resultados
            {
                //tabelaReferenciaProdutosBindingSource.Filter = String.Empty; //seta para vazio o filtro
                //pessoaBindingSource.Filter = String.Empty;
                
            }
            else
            {
                if (int.TryParse(busca, out int result)) //caso o valor 'busca' não seja vazio, verifica se é um numero valido. 
                {
                    //pessoaBindingSource.Filter = "CPF like '%" + busca + "%' or Telefone like '%" + busca + "%'"; //busca em todos os campos pelo filtro informado (a variavel "busca" aqui é tipo Int)
                }
                else
                {
                    // pessoaBindingSource.Filter = "Nome like '%" + busca + "%'  or CPF like '%" + busca + "%'"; // caso a variavel seja do tipo String, busca só nos campos string.
                }

            }

        }

        private void dgvConsultaDadosCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                
            }
        }
    }

}
