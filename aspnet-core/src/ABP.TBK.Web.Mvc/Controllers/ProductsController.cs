using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using ABP.TBK.Authorization;
using ABP.TBK.Controllers;
using ABP.TBK.TaoBaoKe;
using ABP.TBK.TaoBaoKe.Dto;
using ABP.TBK.Users;
using ABP.TBK.Web.Models.Users;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Antiforgery.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABP.TBK.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProductsController : TBKControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: /<controller>/
        public async Task<ActionResult> Index( GetProductInput input)
        { 

            var dots = await _productAppService.GetPagedProductAsync(input);
            return View(dots);
        }
    }
}
