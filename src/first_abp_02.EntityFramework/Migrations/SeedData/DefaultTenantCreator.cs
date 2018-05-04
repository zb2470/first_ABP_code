using System.Linq;
using first_abp_02.EntityFramework;
using first_abp_02.MultiTenancy;

namespace first_abp_02.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly first_abp_02DbContext _context;

        public DefaultTenantCreator(first_abp_02DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
