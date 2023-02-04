using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult PrintInfo()
        {
            return View(); 
        }
        
        public IActionResult Index()
        {
            var adminName = _configuration.GetSection("AdminName");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}