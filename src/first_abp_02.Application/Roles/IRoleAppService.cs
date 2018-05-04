using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using first_abp_02.Roles.Dto;

namespace first_abp_02.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
