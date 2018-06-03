using Abp.Authorization;
using SardineBlog.Authorization.Roles;
using SardineBlog.Authorization.Users;

namespace SardineBlog.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
