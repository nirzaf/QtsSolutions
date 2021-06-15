using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QtsSolutions.EntityFrameworkCore;
using QtsSolutions.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace QtsSolutions.Web.Tests
{
    [DependsOn(
        typeof(QtsSolutionsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QtsSolutionsWebTestModule : AbpModule
    {
        public QtsSolutionsWebTestModule(QtsSolutionsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QtsSolutionsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QtsSolutionsWebMvcModule).Assembly);
        }
    }
}