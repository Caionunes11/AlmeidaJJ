using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almeida.WindowsForms
{
    public partial class frmConsultaDadosClientes : Form
    {
        
        public frmConsultaDadosClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaDadosClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoAlmeidaJJDataSet.Pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.bancoAlmeidaJJDataSet.Pessoa);
            // TODO: This line of code loads data into the 'bancoAlmeidaJJDataSet.Pessoa' table. You can move, or remove it, as needed.

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
                this.pessoaTableAdapter.Update(this.bancoAlmeidaJJDataSet);
                MessageBox.Show("Registro alterado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ ex );

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
            

        }
    }
}
