using Class02.ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.ASP.NET.Controllers
{
    public class CourseController : Controller
    {
        private List<Course> _courses = new List<Course>
        {
            new Course { Id = 1, Name = "CSharp Basics", NumberOfClasses = 10 },
            new Course { Id = 2, Name = "CSharp Advanced", NumberOfClasses = 8 },
            new Course { Id = 3, Name = "ASP.NET Core", NumberOfClasses = 15 },
            new Course { Id = 4, Name = "Database development & design", NumberOfClasses = 12 }
        };

        public JsonResult GetAllCourses()
        {
                       return Json(_courses);
        }
        public IActionResult GetCourseById(int Id)
        {
            return Json(_courses.FirstOrDefault(c => c.Id == Id)/*.Name*/);
        }

        public string GetCourse (int Id)
        {
            return _courses.FirstOrDefault(c => c.Id == Id)?.Name ?? "Course not found";
        }
        public IActionResult GetCourseNameByIdOrName(int id, string name)
        {
            var course = _courses.FirstOrDefault(course => course.Id == id || course.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (course != null)
            {
                return Json(course);
            }
            else
            {
                return NotFound("Course not found with the provided ID or Name.");
            }
        }

    }
}
