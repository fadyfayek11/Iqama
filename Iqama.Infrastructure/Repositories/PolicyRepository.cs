using System;
using Iqama.Data.Repositories;
using Iqama.Infrastructure.Config;

namespace Iqama.Infrastructure.Repositories
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly IqamaDbContext _dbContext;

        public PolicyRepository(IqamaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddPolicy()
        {
            try
            {
                _dbContext.TRX.Add(new Data.Models.TRX(){Id="14"});
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
