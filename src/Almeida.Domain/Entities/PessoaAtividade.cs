using System;

namespace Almeida.Domain.Entities
{
    public class PessoaAtividade
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int AtividadeId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
