using SimplesE.Model.Core;
using SimplesE.Model.Service;
using System.Net.Security;
using System.ServiceModel;

namespace SimplesE.Service.Contract {

    [ServiceContract(ProtectionLevel = ProtectionLevel.Sign)]
    public interface ICoreService {

        [OperationContract()]
        ServiceResult<User> InsertUser(User user);
    }
}
