using Abp.Authorization;
using QtsSolutions.Authorization.Roles;
using QtsSolutions.Authorization.Users;

namespace QtsSolutions.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
