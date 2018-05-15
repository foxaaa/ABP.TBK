using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ABP.TBK.TaoBaoKe.Dto;
 
using System.Linq.Dynamic.Core;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Abp.AutoMapper;
using Abp.UI;
using ABP.TBK.TaoBaoKe.Products;

namespace ABP.TBK.TaoBaoKe
{
    public class ProductAppService : TBKAppServiceBase, IProductAppService
    {
         
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        } 

        public async Task<PagedResultDto<ProductListDto>> GetPagedProductAsync(GetProductInput input)
        {
            var query =   _productRepository.GetAllIncluding();
             var count = await query.CountAsync();
            var products= await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = products.MapTo<List<ProductListDto>>(); 
            return new PagedResultDto<ProductListDto>(count, dtos);
        } 
        public async Task SaveProductAsync(CreateOrUpdateProductInput input)
        {
            if (input.ProductEditDto.Id.HasValue)
            {
                await UpdateProductAsync(input.ProductEditDto);
            }
            else
            {
                await CreateProductAsync(input.ProductEditDto);
            }
        }

        public async Task DeleteProdectAsync(EntityDto input)
        {
            var entity = await _productRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("不存在此条数据");
            }
            await  _productRepository.DeleteAsync(input.Id);
        }

        public async Task<ProductListDto> GetProductByNameAsync(NullableIdDto input)
        {
            var entity = await _productRepository.GetAsync(input.Id.Value);
            return entity.MapTo<ProductListDto>();
        }
         
        protected async Task CreateProductAsync(ProductEditDto input)
        {
            await _productRepository.InsertAsync(input.MapTo<Product>());
        } 
        protected async Task UpdateProductAsync(ProductEditDto input)
        {
            var entity = await _productRepository.GetAsync(input.Id.Value);

            await _productRepository.UpdateAsync(input.MapTo(entity));
        }
    }
}
