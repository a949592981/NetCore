using Microsoft.EntityFrameworkCore;
using MyNetCore0319.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCore0319.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;

        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        Task<Users[]> IAccountService.GetAllUsersAsync()
        {
            var allUser = _context.Users.ToArrayAsync();
            return allUser;
        }
    }
}
