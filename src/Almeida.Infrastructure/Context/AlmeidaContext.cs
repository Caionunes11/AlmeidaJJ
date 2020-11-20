using Almeida.Domain.ValueObjects;

namespace Almeida.Infrastructure.Context
{
    public class AlmeidaContext
    {
        private readonly ConnectionStrings _connectionStrings;

        public AlmeidaContext(ConnectionStrings keys)
        {
            _connectionStrings = keys;
        }





    }
}
