using Microsoft.AspNetCore.Mvc;
using Views.Database;
using Views.Models.DTOModels;

namespace Views.Controllers
{
    [Route("students")]
    public class StudentContriller : Controller
    {
        public IActionResult Index()
        {
            return View(InMemoryDb.Students
                .Select(students => new StudentWithCoursDTO(
                    students.Id,
                    students.FirstName,
                    students.LastName,
                    students.DateOfBirth,
                    students.ActiveCourse.Id,
                    students.ActiveCourse.Name
                    )
                )
                );
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = InMemoryDb.Students.FirstOrDefault(student => student.Id == id);
            if (student == null)
            {
                return View();
            }

            var studentWithCourse = new StudentWithCoursDTO(
                student.Id,
                student.FirstName,
                student.LastName,
                student.DateOfBirth,
                student.ActiveCourse.Id,
                student.ActiveCourse.Name
            );
            return View(studentWithCourse);
        }
    }
}
