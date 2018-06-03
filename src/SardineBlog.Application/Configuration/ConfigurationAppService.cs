using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SardineBlog.Configuration.Dto;

namespace SardineBlog.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SardineBlogAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
