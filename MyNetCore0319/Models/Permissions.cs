using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCore0319.Models
{
    public class Permissions
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string PermissionName { get; set; }

        public string PermissionDescribe { get; set; }
    }
}
