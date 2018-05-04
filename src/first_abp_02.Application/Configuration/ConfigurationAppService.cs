using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using first_abp_02.Configuration.Dto;

namespace first_abp_02.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : first_abp_02AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
