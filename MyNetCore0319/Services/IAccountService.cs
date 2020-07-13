using MyNetCore0319.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCore0319.Services
{
    interface IAccountService
    {
        Task<Users[]> GetAllUsersAsync();
    }
}
