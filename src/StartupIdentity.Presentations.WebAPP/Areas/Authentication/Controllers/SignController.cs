using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StartupIdentity.Presentations.WebAPP.Areas.Authentication.Controllers
{
    [Area("Authentication")]
    public class SignController : Controller
    {
        public IActionResult In()
        {
            return View();
        }

        public IActionResult Out()
        {
            return View();
        }
    }
}