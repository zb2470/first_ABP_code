using first_abp_02.EntityFramework;
using EntityFramework.DynamicFilters;

namespace first_abp_02.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly first_abp_02DbContext _context;

        public InitialHostDbBuilder(first_abp_02DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
