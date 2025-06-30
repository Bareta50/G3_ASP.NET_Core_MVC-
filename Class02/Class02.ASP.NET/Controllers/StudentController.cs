using Microsoft.AspNetCore.Mvc;

namespace Class02.ASP.NET.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
