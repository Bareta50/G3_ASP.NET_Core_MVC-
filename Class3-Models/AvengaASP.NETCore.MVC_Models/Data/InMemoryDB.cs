using AvengaASP.NETCore.MVC_Models.Models.DomainModels;

namespace AvengaASP.NETCore.MVC_Models.Data
{
    public static class InMemoryDB
    {
        public  static List<Student> Students { get; set; }
        public  static List<Course> Courses { get; set; }
        static InMemoryDB()
        {
            LoadCourses();
            LoadStudents();
        }
        private static void LoadStudents()
        {
            Students = new List<Student>
            {
                new()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth =  DateTime.Now.AddYears(-20).AddDays(20),
                    ActiveCourse = Courses[0],
                },
                new()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    DateOfBirth = DateTime.Now.AddYears(-22).AddDays(10),
                    ActiveCourse = Courses[1],
                },
                new()
                {
                    Id = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    DateOfBirth = DateTime.Now.AddYears(-19).AddDays(5),
                    ActiveCourse = Courses[2],
                },
                new()
                {
                    Id = 4,
                    FirstName = "Bob",
                    LastName = "Brown",
                    DateOfBirth = DateTime.Now.AddYears(-21).AddDays(15),
                    ActiveCourse = Courses[3]
                },
                new()
                {
                    Id = 5,
                    FirstName = "Charlie",
                    LastName = "Davis",
                    DateOfBirth = DateTime.Now.AddYears(-23).AddDays(30),
                    ActiveCourse = Courses[4]
                },
                new()
                {
                    Id = 6,
                    FirstName = "Eve",
                    LastName = "Wilson",
                    DateOfBirth = DateTime.Now.AddYears(-20).AddDays(25),
                    ActiveCourse = Courses[5]
                }
            };
        }
        private static void LoadCourses()
        {
            Courses = new List<Course>
            {
                new() { Id = 1, Title = "C#Basic", NumberOfClasses = 30 },
                new() { Id = 2, Title = "C#Advanced", NumberOfClasses = 25 },
                new() { Id = 3, Title = "Db Dev & Design", NumberOfClasses = 28 },
                new() { Id = 4, Title = "JavaScript", NumberOfClasses = 22 },
                new() { Id = 5, Title = "Python", NumberOfClasses = 18 },
                new() { Id = 6, Title = "ASP.NET", NumberOfClasses = 20 }
            };
        }
    }
}
