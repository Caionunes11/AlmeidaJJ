﻿using Almeida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Almeida.Infrastructure.Mapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome);
            builder.Property(x => x.Telefone);
            builder.Property(x => x.Documento);
            builder.Property(x => x.Email);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.Sexo);
            builder.Property(x => x.Endereco);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.DataAlteracao);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.Peso);
            builder.Property(x => x.Altura);
        }
    }
}
