using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Domain.Entities
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int StatusPagamentoId { get; set; }
        public int TipoPagamentoId { get; set; }
        public int PessoaAtividadeId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public byte Ativo { get; set; }
    }
}
