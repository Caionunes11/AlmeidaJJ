using Almeida.Application.Interfaces;
using Almeida.WindowsForms.Formularios.Controles;
using System.Windows.Forms;

namespace Almeida.WindowsForms.Formularios
{
    public partial class frmModelo : Form
    {
        private readonly IPessoaServices _pessoaServices;
        private readonly IAtividadeServices _atividadeSevices;
        //private readonly UserControleNovosCadastros _userControleNovosCadastros;
        public frmModelo(IPessoaServices pessoaServices, IAtividadeServices atividadeServices)
        {
            _pessoaServices = pessoaServices;
            _atividadeSevices = atividadeServices;
            InitializeComponent();
            //userControleNovosCadastros1.BringToFront();
        }
        private void button4_Click(object sender, System.EventArgs e)
        {
            //home
            sidePainel.Height = button4.Height;
            sidePainel.Top = button4.Top;

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            //novo cadastro
            sidePainel.Height = button1.Height;
            sidePainel.Top = button1.Top;
            frmCadastroNovoUsuario frmCadastroNovoUsuario = new frmCadastroNovoUsuario(_pessoaServices, _atividadeSevices);
            frmCadastroNovoUsuario.ShowDialog();
            //userControleNovosCadastros1.BringToFront();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            sidePainel.Height = button2.Height;
            sidePainel.Top = button2.Top;
            frmConsultaUsuarios frmConsultaUsuarios = new frmConsultaUsuarios(_pessoaServices);
            frmConsultaUsuarios.ShowDialog();
            //userControleNovosCadastros1.BringToFront();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            sidePainel.Height = button3.Height;
            sidePainel.Top = button3.Top;
        }
    }
}
