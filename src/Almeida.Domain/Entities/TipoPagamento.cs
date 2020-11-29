using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Domain.Entities
{
   public class TipoPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public byte Ativo { get; set; }
    }
}
