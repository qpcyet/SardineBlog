using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SardineBlog.Controllers
{
    public abstract class SardineBlogControllerBase: AbpController
    {
        protected SardineBlogControllerBase()
        {
            LocalizationSourceName = SardineBlogConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
