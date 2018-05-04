using System.Data.Common;
using Abp.Zero.EntityFramework;
using first_abp_02.Authorization.Roles;
using first_abp_02.Authorization.Users;
using first_abp_02.MultiTenancy;

namespace first_abp_02.EntityFramework
{
    public class first_abp_02DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public first_abp_02DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in first_abp_02DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of first_abp_02DbContext since ABP automatically handles it.
         */
        public first_abp_02DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public first_abp_02DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public first_abp_02DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
