using System.Threading.Tasks;
using Abp.Application.Services;
using first_abp_02.Sessions.Dto;

namespace first_abp_02.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
