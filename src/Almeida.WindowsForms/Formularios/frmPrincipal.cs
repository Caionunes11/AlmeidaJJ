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
    public partial class frmPrincipal : Form
    {
        private readonly IPessoaServices _pessoaServices;
        public frmPrincipal(IPessoaServices pessoaServices)
        {
            _pessoaServices = pessoaServices;
            InitializeComponent();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            _pessoaServices.GetByAll();
        }
    }
}
