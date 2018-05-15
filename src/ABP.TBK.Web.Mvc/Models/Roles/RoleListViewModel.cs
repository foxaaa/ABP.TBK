using System.Collections.Generic;
using ABP.TBK.Roles.Dto;

namespace ABP.TBK.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
