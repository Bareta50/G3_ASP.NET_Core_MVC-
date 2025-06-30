namespace Views.Models.DTOModels
{
    public class StudentWithCoursDTO
    {
        public StudentWithCoursDTO(int id, string firstName, string lastName, DateTime dateOfBirth,
            int courseId, string courseName)
        {
            Id = id;
            FullName = string.Format("{0} {1}", firstName, lastName);
            CourseId = courseId;
            CourseName = courseName;
            Age = DateTime.Now.Year - dateOfBirth.Year;
        }
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
    }
}
