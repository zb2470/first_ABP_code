using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using first_abp_02.Roles.Dto;
using first_abp_02.Users.Dto;

namespace first_abp_02.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}