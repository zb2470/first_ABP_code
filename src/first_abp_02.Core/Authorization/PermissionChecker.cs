using Abp.Authorization;
using first_abp_02.Authorization.Roles;
using first_abp_02.Authorization.Users;

namespace first_abp_02.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
