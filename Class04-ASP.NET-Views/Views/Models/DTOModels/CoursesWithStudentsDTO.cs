namespace Views.Models.DTOModels
{
    public class CoursesWithStudentsDTO
    {
        public CoursesWithStudentsDTO()
        {
            Students = new List<StudentDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<StudentDTO> Students { get; set; } 
    }
}
