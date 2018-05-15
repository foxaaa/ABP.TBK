using System.Collections.Generic;
using ABP.TBK.Roles.Dto;
using ABP.TBK.Users.Dto;

namespace ABP.TBK.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
