using Almeida.Domain.Entities;
using Almeida.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Infrastructure.Context
{
    public class AlmeidaContext : DbContext
    {
        private readonly ConnectionStrings _connectionStrings;

        public AlmeidaContext(ConnectionStrings keys)
        {
            _connectionStrings = keys;
        }

        public DbSet<Pessoas> Pessoas { get; set; }




    }
}
