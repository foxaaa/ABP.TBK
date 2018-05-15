using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABP.TBK.Web.Views
{
    public abstract class TBKViewComponent : AbpViewComponent
    {
        protected TBKViewComponent()
        {
            LocalizationSourceName = TBKConsts.LocalizationSourceName;
        }
    }
}
