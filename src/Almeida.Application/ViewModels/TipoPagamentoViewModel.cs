using System;

namespace Almeida.Application.ViewModels
{
    public class TipoPagamentoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public byte Ativo { get; set; }
    }
}
