using Almeida.Application.Interfaces;
using Almeida.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace Almeida.WindowsForms
{
    public partial class Form1 : Form
    {
        private readonly IPessoaServices _pessoaServices;
        // private frmConsultaDadosClientes frmConsultaDadosobj = new frmConsultaDadosClientes();
        private frmCadastroCliente cadastro = new frmCadastroCliente();
        public Form1()
        {

            InitializeComponent();
            _pessoaServices = IoCContainer.GetService<IPessoaServices>();


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            //if (!this.cadastro.Visible)
            //{
            //    cadastro.Show();
            //}

            var lista = _pessoaServices.GetByAll();

        }

        //private void btnConsulta_Click(object sender, EventArgs e)
        //{
        //    if (!this.frmConsultaDadosobj.Visible)
        //    {
        //        frmConsultaDadosobj.Show();
        //    }


        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            //TO DO Limpar as instancias da aplicação quando fechar
            this.Dispose(true);
            //base.Dispose(true);



        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
           var dados = _pessoaServices.GetByAll();
           // frmConsultaDadosClientes frmConsultaClientes = new frmConsultaDadosClientes();
           // frmConsultaClientes.ShowDialog();

        }
    }
}
