﻿using Crud_Json.Json;
using Crud_Json.Models.DAO;
using Crud_Json.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Json.Models.Service
{
    public class CategoriesServices
    {
        static public string Path { get; set; } = "../../../Models/Json/Categories.json";

        static public List<Categories> GetAllCategories()
        {
            StructureJson sj = DAOJson.LireFichier(Path);
            List<Categories> liste = Profiles.Profiles.FromObjectToCategories(sj.Liste);

            return liste;
        }
        static public Categories GetById(int idCategorie)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Categories> liste = GetAllCategories();
            // on recherche la position du produit dans la liste
            Categories p = liste.Find(r => r.IdCategorie == idCategorie);
            return p;
        }
    }
}
