using System;
using System.Collections.Generic;

namespace crudapirelationnn.Models.Data;

public partial class Parent
{
    public int IdParent { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<ParentEnfant> SonEnfant { get; set; } = new List<ParentEnfant>();
}
