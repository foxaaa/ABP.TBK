using Abp.Authorization;
using ABP.TBK.Authorization.Roles;
using ABP.TBK.Authorization.Users;

namespace ABP.TBK.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
