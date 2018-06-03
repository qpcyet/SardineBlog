using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SardineBlog.Authorization;

namespace SardineBlog
{
    [DependsOn(
        typeof(SardineBlogCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SardineBlogApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SardineBlogAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SardineBlogApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
