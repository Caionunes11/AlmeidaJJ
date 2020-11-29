using Almeida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almeida.WindowsForms
{

    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoas = new Pessoa();
            pessoas.Nome = txbNome.Text;
            pessoas.Documento = txbCPF.Text;
            pessoas.Telefone = txbTelefone.Text;
           // pessoas.DataInicio = DateTime.Now;

            PessoaRepositorys pessoaRepository = new PessoaRepositorys();
            pessoaRepository.Save(pessoas);




        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Form1 formInicial = new Form1();
            //formInicial.Show();
            this.Hide();
        }
    }
}
