using SimplesE.Factory.Common.Provider;
using SimplesE.Model.Core;

namespace SimplesE.Business {

    public class UserRuler {

        public User Insert(User user) {

            var factory = FactoryProvider.GetDataFactory();
            var repository = factory.CreateUserRepository();

            return repository.Insert(user);
        }
    }
}
