using System;
using System.Collections.Generic;

namespace crudapirelationnn.Models.Data;

public partial class ParentEnfant
{
    public int? IdParent { get; set; }

    public int? IdEnfant { get; set; }

    public int IdParentEnfant { get; set; }

    public virtual Enfant? Enfant { get; set; }

    public virtual Parent? Parent { get; set; }
}
