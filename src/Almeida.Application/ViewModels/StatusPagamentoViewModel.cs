using System;

namespace Almeida.Application.ViewModels
{
    public class StatusPagamentoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
