using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using first_abp_02.Authorization.Users;
using first_abp_02.Editions;

namespace first_abp_02.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}