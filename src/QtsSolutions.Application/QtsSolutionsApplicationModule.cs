using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QtsSolutions.Authorization;

namespace QtsSolutions
{
    [DependsOn(
        typeof(QtsSolutionsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QtsSolutionsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QtsSolutionsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QtsSolutionsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
