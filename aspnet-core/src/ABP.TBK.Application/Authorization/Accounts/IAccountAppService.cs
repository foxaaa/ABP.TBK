using System.Threading.Tasks;
using Abp.Application.Services;
using ABP.TBK.Authorization.Accounts.Dto;

namespace ABP.TBK.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
