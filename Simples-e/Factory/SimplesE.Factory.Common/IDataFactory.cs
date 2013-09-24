using SimplesE.Data.Common;

namespace SimplesE.Factory.Common {

    public interface IDataFactory {

        IUserRepository CreateUserRepository();
    }
}
