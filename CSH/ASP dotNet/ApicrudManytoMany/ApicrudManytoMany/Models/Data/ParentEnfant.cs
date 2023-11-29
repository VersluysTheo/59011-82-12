using System;
using System.Collections.Generic;

namespace ApicrudManytoMany.Data.Models;

public partial class ParentEnfant
{
    public int IdParentEnfant { get; set; }

    public int? IdParent { get; set; }

    public int? IdEnfant { get; set; }

    public virtual Enfant? IdEnfantNavigation { get; set; }

    public virtual Parent? IdParentNavigation { get; set; }
}
