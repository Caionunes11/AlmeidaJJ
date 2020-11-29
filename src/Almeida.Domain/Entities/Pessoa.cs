﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public char? Sexo { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }

}