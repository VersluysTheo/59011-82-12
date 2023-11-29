using System;
using System.Collections.Generic;

namespace CleDouble.Models.Data;

public partial class Parent
{
    public int IdParent { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<Enfant> ListeEnfants { get; set; } = new List<Enfant>();
}
