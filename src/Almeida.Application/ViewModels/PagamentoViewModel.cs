using System;

namespace Almeida.Application.ViewModels
{
    public class PagamentoViewModel
    {
        public int Id { get; set; }
        public int StatusPagamentoId { get; set; }
        public int TipoPagamentoId { get; set; }
        public int PessoaAtividadeId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
