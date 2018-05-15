using Microsoft.AspNetCore.Antiforgery;
using ABP.TBK.Controllers;

namespace ABP.TBK.Web.Host.Controllers
{
    public class AntiForgeryController : TBKControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
