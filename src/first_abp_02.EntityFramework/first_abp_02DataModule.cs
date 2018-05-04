using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using first_abp_02.EntityFramework;

namespace first_abp_02
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(first_abp_02CoreModule))]
    public class first_abp_02DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<first_abp_02DbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
