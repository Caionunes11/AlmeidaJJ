using Almeida.Application.Interfaces;
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
    public partial class frmConsultaGeralUsuarios : frmModelo
    {
        private readonly IPessoaServices _pessoaServices;
        private readonly ILogger _logger;
        public frmConsultaGeralUsuarios(IPessoaServices pessoaServices)
        {
            
            InitializeComponent();
            _pessoaServices = pessoaServices;
        }

        private void frmConsultaGeralUsuarios_Load(object sender, EventArgs e)
        {
            _pessoaServices.GetByAll();
        }
    }
}
