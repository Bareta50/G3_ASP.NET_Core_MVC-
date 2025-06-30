using System.Diagnostics;
using Class02.ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "Hello world, This is Filip!";
        }
    }
}
