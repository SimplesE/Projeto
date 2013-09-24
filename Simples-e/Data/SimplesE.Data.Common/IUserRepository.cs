using SimplesE.Model.Core;
using System.Collections.Generic;

namespace SimplesE.Data.Common {

    public interface IUserRepository {

        User Insert(User user);

        User Update(User user);

        void Delete(User user);

        void Delete(int id);

        IEnumerable<User> GetAll();
    }
}
