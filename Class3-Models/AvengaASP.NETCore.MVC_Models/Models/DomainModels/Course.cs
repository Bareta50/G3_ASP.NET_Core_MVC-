namespace AvengaASP.NETCore.MVC_Models.Models.DomainModels
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int NumberOfClasses { get; set; }
        //public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
