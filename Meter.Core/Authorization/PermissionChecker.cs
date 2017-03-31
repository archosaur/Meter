using Abp.Authorization;
using Meter.Authorization.Roles;
using Meter.MultiTenancy;
using Meter.Users;

namespace Meter.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
