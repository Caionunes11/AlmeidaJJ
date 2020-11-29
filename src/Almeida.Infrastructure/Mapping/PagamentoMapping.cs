using Almeida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Infrastructure.Mapping
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.StatusPagamentoId);
            builder.Property(x => x.TipoPagamentoId);
            builder.Property(x => x.PessoaAtividadeId);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.DataAlteracao);
            builder.Property(x => x.Ativo);
        }
    }
}
