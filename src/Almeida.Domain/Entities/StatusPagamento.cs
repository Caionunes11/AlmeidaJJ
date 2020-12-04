using System;

namespace Almeida.Domain.Entities
{
    public class StatusPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
