using Abp.Application.Services;
using Abp.Application.Services.Dto;
using first_abp_02.MultiTenancy.Dto;

namespace first_abp_02.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
