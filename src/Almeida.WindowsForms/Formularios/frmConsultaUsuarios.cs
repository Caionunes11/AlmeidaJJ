using Almeida.Application.Interfaces;
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
    public partial class frmConsultaUsuarios : Form
    {
        private readonly IPessoaServices _pessoaServices;
        public frmConsultaUsuarios(IPessoaServices pessoaServices)
        {
            _pessoaServices = pessoaServices;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            
        }
    }
}
