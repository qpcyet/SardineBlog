using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SardineBlog.Configuration;

namespace SardineBlog.Web.Host.Startup
{
    [DependsOn(
       typeof(SardineBlogWebCoreModule))]
    public class SardineBlogWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SardineBlogWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SardineBlogWebHostModule).GetAssembly());
        }
    }
}
