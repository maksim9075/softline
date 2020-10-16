using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        CompanyDB db;
        public HomeController(CompanyDB context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.People.ToList());
        }
    }
}
