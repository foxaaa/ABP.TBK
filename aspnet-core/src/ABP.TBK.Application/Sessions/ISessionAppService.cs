using System.Threading.Tasks;
using Abp.Application.Services;
using ABP.TBK.Sessions.Dto;

namespace ABP.TBK.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
