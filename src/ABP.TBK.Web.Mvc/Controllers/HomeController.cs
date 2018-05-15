using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABP.TBK.Controllers;

namespace ABP.TBK.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TBKControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
