using Almeida.Application.Services;
using Almeida.WindowsForms.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using System;

namespace Almeida.WindowsForms
{

    class Program
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
            
            System.Windows.Forms.Application.Run(new Form1());

        }
    }
}
