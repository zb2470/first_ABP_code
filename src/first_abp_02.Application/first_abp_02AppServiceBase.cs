using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using first_abp_02.Authorization.Users;
using first_abp_02.MultiTenancy;
using first_abp_02.Users;
using Microsoft.AspNet.Identity;

namespace first_abp_02
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class first_abp_02AppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected first_abp_02AppServiceBase()
        {
            LocalizationSourceName = first_abp_02Consts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}