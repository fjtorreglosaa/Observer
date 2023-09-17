using Microsoft.Extensions.Configuration;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConfiguration _configuration;

        public UnitOfWork(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IUnitOfWorkAdapter Create(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString)) connectionString = _configuration.GetConnectionString("CommonDB"); 

            return new UnitOfWorkAdapter(connectionString);
        }
    }
}
