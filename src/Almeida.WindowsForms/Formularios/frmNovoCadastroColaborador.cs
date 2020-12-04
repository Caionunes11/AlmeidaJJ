using Almeida.Application.ViewModels;
using Almeida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almeida.WindowsForms.Formularios
{
    public partial class frmNovoCadastroColaborador : frmModelo
    {
        public frmNovoCadastroColaborador()
        {
            InitializeComponent();
        }

        private void frmNovoCadastroColaborador_Load(object sender, EventArgs e)
        {

        }
        private void btnSalvarNovoCadastro_Click(object sender, EventArgs e)
        {
            PessoaViewModel pessoa = new PessoaViewModel();
            pessoa.Nome = txtNomeCompleto.Text;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.Documento = txtDocumento.Text;
            DateTime dateTime = Convert.ToDateTime(txtDataNascimento.Text);
            string dataNascimento = String.Format("{0:yyyy/MM/dd HH:mm:ss tt}", dateTime);
            pessoa.DataNascimento = Convert.ToDateTime(dataNascimento);
            
        }
    }
}
