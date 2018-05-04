using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using first_abp_02.EntityFramework;

namespace first_abp_02.Migrator
{
    [DependsOn(typeof(first_abp_02DataModule))]
    public class first_abp_02MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<first_abp_02DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}