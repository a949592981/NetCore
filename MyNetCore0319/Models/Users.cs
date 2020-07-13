using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCore0319.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int IsDelete { get; set; }

        public List<Permissions> Permissions { get; set; }
    }
}
