using System;

namespace Almeida.Application.ViewModels
{
    public class AtividadeViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime VigenciaInicio { get; set; }
        public DateTime ?VigenciaFim { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime ?DataAlteracao { get; set; }
        public bool Ativo { get; set; }

    }
}
