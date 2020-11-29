using System;

namespace Almeida.Application.ViewModels
{
    public class PessoaAtividadeViewModel
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int AtividadeId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public byte Ativo { get; set; }
    }
}
