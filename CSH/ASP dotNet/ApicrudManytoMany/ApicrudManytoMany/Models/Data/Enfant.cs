using System;
using System.Collections.Generic;

namespace ApicrudManytoMany.Data.Models;

public partial class Enfant
{
    public int IdEnfant { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<ParentEnfant> ParentEnfants { get; set; } = new List<ParentEnfant>();
}
