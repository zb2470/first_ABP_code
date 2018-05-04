using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using first_abp_02.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace first_abp_02.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<first_abp_02.EntityFramework.first_abp_02DbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "first_abp_02";
        }

        protected override void Seed(first_abp_02.EntityFramework.first_abp_02DbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
