using SimplesE.Model.Core;
using System.Data.Entity;

namespace SimplesE.Data.SqlClient.Context {

    public class CoreContext : DbContext {

        public DbSet<User> Users { get; set; }
    }
}
