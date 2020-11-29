using System.Configuration;

namespace Almeida.WindowsForms.Configuration
{
    public class AlmeidaConfiguration
    {
        public string AlmeidaConnectionStrings { get { return ConfigurationManager.ConnectionStrings["AlmeidaConnectionStrings"].ConnectionString; } }
    }
}
