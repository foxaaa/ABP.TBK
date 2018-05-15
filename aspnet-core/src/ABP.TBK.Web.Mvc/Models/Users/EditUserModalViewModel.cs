using System.Collections.Generic;
using System.Linq;
using ABP.TBK.Roles.Dto;
using ABP.TBK.Users.Dto;

namespace ABP.TBK.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
