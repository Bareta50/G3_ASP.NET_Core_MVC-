using AvengaASP.NETCore.MVC_Models.Data;
using AvengaASP.NETCore.MVC_Models.Models.DomainModels;
using AvengaASP.NETCore.MVC_Models.Models.DTOModels;
using AvengaASP.NETCore.MVC_Models.Models.ViewModels;
using System.Linq;

namespace AvengaASP.NETCore.MVC_Models.Services
{
    public class StudentService
    {
        public List<StudentViewModels> GetAllStudents()
        {
            // 1. Get Students from InMemoryDB
            List<Student> students = InMemoryDB.Students;
            // 2. Validate Students
            if (students == null || !students.Any())
            {
                throw new InvalidOperationException("No students found in the database.");
            }
            // 3. Map Students to StudentViewModels
            var mappedStudents = students
                .Select(student => new StudentViewModels
                {
                    Id = student.Id,
                    FullName = $"{student.FirstName} {student.LastName}",
                    Course = student.ActiveCourse.Title,
                    
                })
                .ToList();
            return mappedStudents;
        }
        public StudentWithCourseDTO GetStudentWithActiveCourseById(int id)
        {
            //List<Student>
            var student = InMemoryDB.Students.FirstOrDefault(s => s.Id == id);
            if (student is null)
            {
                throw new KeyNotFoundException($"Student with ID {id} not found.");
            }
            var age = DateTime.Now - student.DateOfBirth;
            StudentWithCourseDTO studentDTO = new StudentWithCourseDTO
            {
                Id = student.Id,
                FullName = $"{student.FirstName} {student.LastName}",
                Age = DateTime.Now.Year - student.DateOfBirth.Year,
                CourseName = student.ActiveCourse.Title
            };

        }

        internal object GetStudentById(int id)
        {
            throw new NotImplementedException();
        }
    }
   
}
