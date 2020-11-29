using Almeida.Domain.Entities;
using Almeida.Domain.ValueObjects;
using Almeida.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Almeida.Infrastructure.Context
{
    public class AlmeidaContext : DbContext
    {
        private readonly ConnectionStrings _connectionStrings;

        public AlmeidaContext(ConnectionStrings keys)
        {
            _connectionStrings = keys;
        }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaAtividade> PessoaAtividade { get; set; }
        public DbSet<Presenca> Presenca { get; set; }
        public DbSet<StatusPagamento> StatusPagamento { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtividadeMapping());
            modelBuilder.ApplyConfiguration(new PagamentoMapping());
            modelBuilder.ApplyConfiguration(new PessoaMapping());
            modelBuilder.ApplyConfiguration(new PessoaAtividadeMapping());
            modelBuilder.ApplyConfiguration(new PresencaMapping());
            modelBuilder.ApplyConfiguration(new StatusPagamentoMapping());
            modelBuilder.ApplyConfiguration(new TipoPagamentoMapping());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStrings.AlmeidaConnectionStrings);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
