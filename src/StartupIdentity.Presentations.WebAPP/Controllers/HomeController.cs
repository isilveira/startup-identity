using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartupIdentity.Infrastructures.Data;
using StartupIdentity.Presentations.WebAPP.Models;

namespace StartupIdentity.Presentations.WebAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly StartupIdentityDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            StartupIdentityDbContext context,
            ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            ViewBag.Users = _context.Users.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
