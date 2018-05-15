using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ABP.TBK.Web.Views
{
    public abstract class TBKRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TBKRazorPage()
        {
            LocalizationSourceName = TBKConsts.LocalizationSourceName;
        }
    }
}
