using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.TBK.Configuration;

namespace ABP.TBK.Web.Host.Startup
{
    [DependsOn(
       typeof(TBKWebCoreModule))]
    public class TBKWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TBKWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TBKWebHostModule).GetAssembly());
        }
    }
}
