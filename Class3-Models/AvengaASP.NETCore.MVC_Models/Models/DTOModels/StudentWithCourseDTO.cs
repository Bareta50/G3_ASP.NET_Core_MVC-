namespace AvengaASP.NETCore.MVC_Models.Models.DTOModels
{
    public class StudentWithCourseDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string CourseNmae { get; set; }
        public int Age { get; set; }
    }
}
