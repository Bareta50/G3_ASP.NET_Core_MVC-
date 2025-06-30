namespace AvengaASP.NETCore.MVC_Models.Models.DomainModels
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public Course ActiveCourse { get; set; }
    }
}
