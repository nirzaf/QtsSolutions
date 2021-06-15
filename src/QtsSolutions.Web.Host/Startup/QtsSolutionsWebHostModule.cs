using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QtsSolutions.Configuration;

namespace QtsSolutions.Web.Host.Startup
{
    [DependsOn(
       typeof(QtsSolutionsWebCoreModule))]
    public class QtsSolutionsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QtsSolutionsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QtsSolutionsWebHostModule).GetAssembly());
        }
    }
}
