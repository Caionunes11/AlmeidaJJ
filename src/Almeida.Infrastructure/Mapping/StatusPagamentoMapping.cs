using Almeida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Infrastructure.Mapping
{
    public class StatusPagamentoMapping : IEntityTypeConfiguration<StatusPagamento>
    {
        public void Configure(EntityTypeBuilder<StatusPagamento> builder)
        {
            builder.ToTable("StatusPagamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.DataAlteracao);
            builder.Property(x => x.Ativo);
        }
    }
    
}
