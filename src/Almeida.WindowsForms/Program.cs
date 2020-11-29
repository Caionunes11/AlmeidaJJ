using Almeida.WindowsForms.Formularios;
using Almeida.WindowsForms.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almeida.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            IoCContainer.Register(services);

            System.Windows.Forms.Application.Run(new frmModelo());

        }
    }
}
