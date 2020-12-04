using Almeida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Almeida.Infrastructure.Mapping
{
    public class PresencaMapping : IEntityTypeConfiguration<Presenca>
    {
        public void Configure(EntityTypeBuilder<Presenca> builder)
        {
            builder.ToTable("Presenca");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.PessoaId);
            builder.Property(x => x.DataPresenca);
            builder.Property(x => x.CheckPresenca);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.DataAlteracao);
        }
    }


}
