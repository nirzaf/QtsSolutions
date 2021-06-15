using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QtsSolutions.Configuration.Dto;

namespace QtsSolutions.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QtsSolutionsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
