using API_crud.Models.Data;

namespace API_crud.Models.Dtos
{
    public class StudentsDTO
    {
        public string Name { get; set; }
        public virtual Grade CurrentGrade { get; set; } = null!;
    }
}
