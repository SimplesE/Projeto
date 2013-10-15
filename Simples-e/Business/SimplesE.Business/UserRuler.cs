using SimplesE.Factory.Common.Provider;
using SimplesE.Model.Core;
using System;
using System.Collections.Generic;

namespace SimplesE.Business {

    public class UserRuler : IRuler<User> {

        public User Insert(User user) {

            var factory = FactoryProvider.GetDataFactory();
            var repository = factory.CreateUserRepository();

            return repository.Insert(user);
        }
        public IEnumerable<User> GetAll()
        {
            var factory = FactoryProvider.GetDataFactory();
            var repository = factory.CreateUserRepository();

            return repository.GetAll();
        }
    }
}
