using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Domain.Entities
{
    public class Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataInicio { get; set; }
        public string Telefone { get; set; }
    }
}
