using System.Data.Common;
using Abp.Zero.EntityFramework;
using Meter.Authorization.Roles;
using Meter.MultiTenancy;
using Meter.Users;

namespace Meter.EntityFramework
{
    public class MeterDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MeterDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MeterDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MeterDbContext since ABP automatically handles it.
         */
        public MeterDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MeterDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MeterDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
