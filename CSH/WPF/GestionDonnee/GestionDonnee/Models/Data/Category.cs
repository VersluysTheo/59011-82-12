using System;
using System.Collections.Generic;

namespace GestionDonnee.Models.Data;

public partial class Category
{
    public int IdCategories { get; set; }

    public string? LibelleCategorie { get; set; }

    public int IdTypesProduits { get; set; }
}
