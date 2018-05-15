using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.TBK.Authorization;

namespace ABP.TBK
{
    [DependsOn(
        typeof(TBKCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TBKApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TBKAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TBKApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
