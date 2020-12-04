using System;

namespace Almeida.Domain.Entities
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime VigenciaInicio { get; set; }
        public DateTime VigenciaFim { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }

    }
}
