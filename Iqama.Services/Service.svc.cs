using Iqama.Data.DataTransfer.Request;
using Iqama.Data.DataTransfer.Response;

namespace Iqama.Services
{
    
    public class Service1 : IService
    {
        public CompanyPriceContract GetPolicyPrice(PolicyEntity policyEntity)
        {
            return new CompanyPriceContract()
            {
                PolicyNumber = "65",
                Price = 55,
                Status = "success",
            };
        }

        public bool UpdatePolicyVISANumber(PolicyEntity policyEntity)
        {
            return true;
        }

        public bool CancelPolicy(PolicyEntity policyEntity)
        {
            return true;
        }

        public PolicyEntity GetBeneficariesDetails(PolicyEntity policyEntity)
        {
            return new PolicyEntity();
        }

        public bool ActivatePolicy(PolicyEntity policyEntity)
        {
            return true;
        }

        public ExtendVisa ExtendVisa(policyContract policyEntity)
        {
            return new ExtendVisa();
        }
    }
}
