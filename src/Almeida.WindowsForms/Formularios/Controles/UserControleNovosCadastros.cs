using Almeida.Application.ViewModels;
using System;
using System.Windows.Forms;

namespace Almeida.WindowsForms.Formularios.Controles
{
    public partial class UserControleNovosCadastros : UserControl
    {
        public UserControleNovosCadastros()
        {
           
            InitializeComponent();


        }

        private void UserControleNovosCadastros_Load(object sender, EventArgs e)
        {

        }

        private void salv_Click(object sender, EventArgs e)
        {
            PessoaViewModel pessoa = new PessoaViewModel();
            pessoa.Nome = textBox1.Text;
            pessoa.Documento = textBox2.Text;

        }
    }
}
