using Microsoft.AspNetCore.Mvc;
using Views.Database;
using Views.Models.DTOModels;

namespace Views.Controllers
{
    [Route("courses")]
    public class CourseControler : Controller
    {
        public IActionResult Index()
        {
            var courses = InMemoryDb.Courses;
            var coursesList = new List<CoursesWithStudentsDTO>();

            foreach (var course in courses)
            {
                var students = InMemoryDb.Students
                    .Where(student => student.ActiveCourse.Id == course.Id)
                    .Select(student => new StudentDTO
                    {
                      FullName = $"{student.FirstName}"+"{student.LastName}",

                    }).ToList();
                coursesList.Add(new CoursesWithStudentsDTO
                {
                    Id = course.Id,
                    Name = course.Name,
                    Students = students.ToList()
                });
            }
            return View(coursesList);
        }
    }
}
