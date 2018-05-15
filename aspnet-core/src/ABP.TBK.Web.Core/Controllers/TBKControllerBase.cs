using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABP.TBK.Controllers
{
    public abstract class TBKControllerBase: AbpController
    {
        protected TBKControllerBase()
        {
            LocalizationSourceName = TBKConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
