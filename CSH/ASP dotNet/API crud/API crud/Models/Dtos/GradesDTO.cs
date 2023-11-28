using API_crud.Models.Data;

namespace API_crud.Models.Dtos
{
    public class GradesDTO
    {
        public string? GradeName { get; set; }
    }

    public class GradesDTOavecStd
    {
        public int? GradeId { get; set; }
        public string? GradeName { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
