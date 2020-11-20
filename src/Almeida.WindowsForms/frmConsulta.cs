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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            pessoas.Nome = txbNome.Text;
            pessoas.Cpf = txbCPF.Text;
            pessoas.Telefone = txbTelefone.Text;
            pessoas.DataInicio = DateTime.Now;

            PessoaRepository pessoaRepository = new PessoaRepository();
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
