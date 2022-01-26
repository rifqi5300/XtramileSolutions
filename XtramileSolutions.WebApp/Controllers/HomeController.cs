using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using XtramileSolutions.WebApp.Models;

namespace XtramileSolutions.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            return View();
        }

        public IActionResult Weather()
        {
            return View();
        }
    }
}
