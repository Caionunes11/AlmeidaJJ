using Almeida.Application.Interfaces;
using Almeida.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almeida.WindowsForms.Formularios
{
    public partial class frmPrincipal : frmModelo
    {
       private readonly frmConsultaGeralUsuarios _frmConsultaGeralUsuarios;
        public frmPrincipal(frmConsultaGeralUsuarios frmConsultaGeralUsuarios)
        {
            
            InitializeComponent();
            _frmConsultaGeralUsuarios = frmConsultaGeralUsuarios;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovoCadastroColaborador frmNovoCadastro = new frmNovoCadastroColaborador();
            frmNovoCadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            _frmConsultaGeralUsuarios.Show();

        }
    }
}
