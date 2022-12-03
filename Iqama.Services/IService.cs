using Iqama.Data.DataTransfer.Request;
using Iqama.Data.DataTransfer.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Iqama.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        CompanyPriceContract GetPolicyPrice(PolicyEntity policyEntity);

        [OperationContract]
        bool UpdatePolicyVISANumber(PolicyEntity policyEntity);

        [OperationContract]
        bool CancelPolicy(PolicyEntity policyEntity);

        [OperationContract]
        PolicyEntity GetBeneficariesDetails(PolicyEntity policyEntity);

        [OperationContract]
        bool ActivatePolicy(PolicyEntity policyEntity);

        [OperationContract]
        ExtendVisa ExtendVisa(policyContract policyEntity);
    }
}
