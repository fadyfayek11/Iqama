using System;
using Iqama.Data.DataTransfer.Request;
using Iqama.Data.DataTransfer.Response;
using Iqama.Data.Models;
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
        public CompanyPriceContract AddPolicy(PolicyEntity policy)
        {
            try
            {
                _dbContext.TRX.Add(MapPolicyToTRX(policy));
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return new CompanyPriceContract();
        }

        private static TRX MapPolicyToTRX(PolicyEntity policy)
        {
            var trx = new TRX
            {
                ENumber = policy.eNumber,
                Email = policy.Email,
                City = policy.City,
                NationalityCode = policy.Nationality,
            };

            return trx;
        }
    }
}
