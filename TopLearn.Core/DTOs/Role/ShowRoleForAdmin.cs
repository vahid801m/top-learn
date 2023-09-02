using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.DTOs.Role
{
    public class ShowRoleForAdmin
    {
        public List<TopLearn.DataLayer.Entities.User.Role> Roles { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
    }
}
