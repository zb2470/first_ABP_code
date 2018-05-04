using System.Threading.Tasks;
using Abp.Application.Services;
using first_abp_02.Configuration.Dto;

namespace first_abp_02.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}