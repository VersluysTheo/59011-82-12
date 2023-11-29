using ApicrudManytoMany.Data.Models;

namespace ApicrudManytoMany.Models.Dtos
{
    public class ParentsEnfantsDTO
    {
        public virtual Enfant? Enfant { get; set; }

        public virtual Parent? Parent { get; set; }
    }
    public class ParentDTOParent
    {
        public virtual ParentsDTO? Parent { get; set; }
    }

    public class EnfantDTOEnfant
    {
        public virtual EnfantsDTO? Enfant { get; set; }
    }
}
