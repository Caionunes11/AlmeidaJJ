using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Domain.Entities
{
    public class Presenca
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public DateTime DataPresenca { get; set; }
        public byte CheckPresenca { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        
    }
}
