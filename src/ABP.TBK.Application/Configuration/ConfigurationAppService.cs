using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP.TBK.Configuration.Dto;

namespace ABP.TBK.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TBKAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
