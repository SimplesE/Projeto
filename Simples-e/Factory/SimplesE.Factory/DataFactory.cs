using SimplesE.Data.SqlClient;
using SimplesE.Factory.Common;

namespace SimplesE.Factory
{
    public class DataFactory : IDataFactory
    {
        public Data.Common.IUserRepository CreateUserRepository() {

            return new UserRepository();
        }
    }
}
