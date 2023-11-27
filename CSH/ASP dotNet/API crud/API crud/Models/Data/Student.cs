using System;
using System.Collections.Generic;

namespace API_crud.Models.Data;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CurrentGradeId { get; set; }

    public virtual Grade CurrentGrade { get; set; } = null!;
}
