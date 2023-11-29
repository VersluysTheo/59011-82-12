using System;
using System.Collections.Generic;

namespace crudapirelationnn.Models.Data;

public partial class Enfant
{
    public int IdEnfant { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<ParentEnfant> SonParent{ get; set; } = new List<ParentEnfant>();
}
