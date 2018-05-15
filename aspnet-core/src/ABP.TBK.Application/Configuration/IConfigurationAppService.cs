using System.Threading.Tasks;
using ABP.TBK.Configuration.Dto;

namespace ABP.TBK.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
