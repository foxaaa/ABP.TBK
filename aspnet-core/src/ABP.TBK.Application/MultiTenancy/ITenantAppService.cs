using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP.TBK.MultiTenancy.Dto;

namespace ABP.TBK.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
