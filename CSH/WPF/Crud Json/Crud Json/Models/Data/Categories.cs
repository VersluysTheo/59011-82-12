using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Json.Models.Data
{
    public class Categories
    {
        public int IdCategorie { get; set; }
        public string LibelleCategorie { get; set; }

        public Categories(int idCategorie, string libelleCategorie)
        {
            IdCategorie = idCategorie;
            LibelleCategorie = libelleCategorie;
        }
    }
}
