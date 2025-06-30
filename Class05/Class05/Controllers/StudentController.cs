using Class05.Database;
using Class05.Models;
using Class05.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Class05.Controllers
{
    public class StudentController : Controller
    {
        [Route("students")]
        public IActionResult Index()
        {
            List<StudentViewModel> students = InMemoryDB.Students.Select(s => new StudentViewModel
            {
                Id = s.Id,
                FullName = s.GetFullName(),
                Age = DateTime.UtcNow.Year - s.DateOfBirth.Year,
                ActiveCourseName = s.ActiveCourse?.Name ?? "No active course"
            }).ToList();
            return View(students);
        }
        // /students/create
        public IActionResult Create()
        {
            CreateStudentViewModel createStudentViewModel = new();
            createStudentViewModel.Courses = InMemoryDB.Courses.Select(c => new CourseOptionViewModel
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
            return View(createStudentViewModel);
        }
    }
}
