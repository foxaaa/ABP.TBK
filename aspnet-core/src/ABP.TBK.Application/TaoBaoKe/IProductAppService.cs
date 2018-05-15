using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP.TBK.TaoBaoKe.Dto;

namespace ABP.TBK.TaoBaoKe
{
    public interface IProductAppService : IApplicationService
    {
        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="getProductInput"></param>
        /// <returns></returns>
        Task<PagedResultDto<ProductListDto>> GetPagedProductAsync(GetProductInput getProductInput);

        Task<ProductListDto> GetProductByNameAsync(NullableIdDto input);

        Task SaveProductAsync(CreateOrUpdateProductInput input);

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        Task DeleteProdectAsync(EntityDto input);



    }
}
