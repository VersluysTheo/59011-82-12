using System;
using System.Collections.Generic;

namespace ScaffoldCrud.Models.Data;

public partial class Personne
{
    public uint Id { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? CodePostal { get; set; }

    public string Adresse { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public Personne(uint id,string nom, string prenom, int codePostal,string adresse, string ville)
    {
        Id = id;
        Nom = nom;
        Prenom = prenom;
        CodePostal = codePostal;
        Adresse = adresse;
        Ville = ville;
    }

    public Personne()
    {
        
    }
}
