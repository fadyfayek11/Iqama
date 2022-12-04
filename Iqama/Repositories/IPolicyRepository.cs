using Iqama.Data.DataTransfer.Request;
using Iqama.Data.DataTransfer.Response;

namespace Iqama.Data.Repositories
{
    public interface IPolicyRepository
    {
        CompanyPriceContract AddPolicy(PolicyEntity policy);
    }
}
