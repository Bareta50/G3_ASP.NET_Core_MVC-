using Microsoft.AspNetCore.Mvc;
using AvengaASP.NETCore.MVC_Models.Services;
namespace AvengaASP.NETCore.MVC_Models.Controllers
{
    //[Route("Students")]
   
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var studentService = _studentService.GetAllStudents();
            //return View(studentService);
            return Json(studentService);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
        }
    }
}
