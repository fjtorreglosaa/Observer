using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class WithdrawalRepository : IWithdrawalRepository
    {
        public Task<int> AddAsync(Withdrawal entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Withdrawal>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Withdrawal> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Withdrawal entity)
        {
            throw new NotImplementedException();
        }
    }
}
