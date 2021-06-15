using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QtsSolutions.Controllers
{
    public abstract class QtsSolutionsControllerBase: AbpController
    {
        protected QtsSolutionsControllerBase()
        {
            LocalizationSourceName = QtsSolutionsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
