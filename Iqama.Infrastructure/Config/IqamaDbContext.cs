using Iqama.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Iqama.Infrastructure.Config
{
    public class IqamaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.10.200.115)(PORT=1521)))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=ORCLTOPS)));password=APIS;persist security info=True;user id=APIS;");
        }
        public virtual DbSet<TRX> TRX { get; set; }
        public virtual DbSet<Beneficiary> Beneficiary { get; set; }
        public virtual DbSet<BeneficiaryQuestionResponse> BeneficiaryQuestionResponse { get; set; }
        public virtual DbSet<FormQuestion> FormQuestion { get; set; }
        public virtual DbSet<Lookup> Lookup { get; set; }
        public virtual DbSet<LookupDetails> LookupDetails { get; set; }
    }
}
