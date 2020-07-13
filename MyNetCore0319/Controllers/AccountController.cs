using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetCore0319.Models;
using MyNetCore0319.Services;

namespace MyNetCore0319.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getAllUser()
        {
            var items = _accountService.GetAllUsersAsync();
            return View(items);
        }
    }
}