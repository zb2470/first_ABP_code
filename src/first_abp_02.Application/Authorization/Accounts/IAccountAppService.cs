using System.Threading.Tasks;
using Abp.Application.Services;
using first_abp_02.Authorization.Accounts.Dto;

namespace first_abp_02.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
