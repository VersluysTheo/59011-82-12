﻿using Crud_Json.Json;
using Crud_Json.Models.DAO;
using Crud_Json.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Json.Service
{
    public class ProduitsServices
    {
        static public string Path { get; set; } = "../../../Models/Json/Produits.json";
        static public int NextId { get; set; }

        static public List<Produits> GetAllProduits()
        {
            StructureJson sj = DAOJson.LireFichier(Path);
            List<Produits> liste = Profiles.Profiles.FromObjectToProduits(sj.Liste);
            NextId = sj.NextId;

            return liste;
        }
        // methode qui met à jour le fichier avec les produits 
        static public void SaveProduits(List<Produits> liste)
        {
            StructureJson sj = new StructureJson();
            sj.Liste = Profiles.Profiles.FromProduitsToObject(liste);
            sj.NextId = NextId;
            DAOJson.EcrireFichier(sj, Path); //enregistrer fichier
        }

        static public Produits GetById(int idProduit)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produits> liste = GetAllProduits();
            // on recherche la position du produit dans la liste
            Produits p = liste.Find(r => r.IdProduit == idProduit);
            return p;
        }
        static public void AddProduit(Produits p)
        //Méthode qui permet d'entrer un enregistrement
        {
            List<Produits> liste = GetAllProduits();
            p.IdProduit = NextId++;
            // on ajoute l'enregistrement
            liste.Add(p);
            SaveProduits(liste);
        }
        static public void UpdateProduit(Produits p)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produits> liste = GetAllProduits();
            // on recherche la position du produit dans la liste
            int position = liste.FindIndex(r => r.IdProduit == p.IdProduit);
            // on met à jour le produit dans la liste
            liste[position].LibelleProduit = p.LibelleProduit;
            liste[position].NumeroProduit = p.NumeroProduit;
            liste[position].Description = p.Description;
            liste[position].Quantite = p.Quantite;
            liste[position].Prix = p.Prix;
            // on sauvegarde dans le fichier
            SaveProduits(liste);
        }
        static public void DeleteProduit(Produits p)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produits> liste = GetAllProduits();
            // on recherche la position du produit dans la liste
            liste.RemoveAll(x => x.IdProduit == p.IdProduit);
            // on sauvegarde dans le fichier
            SaveProduits(liste);
        }
    }
}
