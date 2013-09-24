using SimplesE.Business;
using SimplesE.Model.Core;
using SimplesE.Model.Service;
using System;

namespace SimplesE.Service {

    public class CoreService : Contract.ICoreService {

        public ServiceResult<User> InsertUser(User user) {

            ServiceResult<User> result = new ServiceResult<User>();

            try {

                var userBusiness = new UserRuler();

                userBusiness.Insert(user);

                result.Completed = true;
            }
            catch (Exception ex) {

                result.Completed = false;
                result.Exception = ex;
            }

            return result;
        }
    }
}