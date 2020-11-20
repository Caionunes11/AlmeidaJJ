using System;
using System.Windows.Forms;

namespace Almeida.WindowsForms
{
    public partial class Form1 : Form
    {
        private frmConsultaDadosClientes frmConsultaDadosobj = new frmConsultaDadosClientes();
        private frmConsulta cadastro = new frmConsulta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            if (!this.cadastro.Visible)
            {
                cadastro.Show();
            }



        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (!this.frmConsultaDadosobj.Visible)
            {
                frmConsultaDadosobj.Show();
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            //TO DO Limpar as instancias da aplicação quando fechar
            this.Dispose(true);
            //base.Dispose(true);



        }
    }
}
