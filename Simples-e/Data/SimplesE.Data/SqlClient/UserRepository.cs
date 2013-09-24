using SimplesE.Data.Common;
using SimplesE.Model.Core;
using System;
using System.Collections.Generic;

namespace SimplesE.Data.SqlClient {

    public class UserRepository : IUserRepository {

        public User Insert(User user) {

            return user;
        }

        public User Update(User user) {

            return user;
        }

        public void Delete(User user) {
            
        }

        public void Delete(int id) {
            
        }

        public IEnumerable<User> GetAll() {

            return new List<User>(1);
        }
    }
}
