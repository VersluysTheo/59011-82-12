﻿using System;
using System.Collections.Generic;

namespace GestionDonnee.Models.Data;

public partial class Article
{
    public int IdArticles { get; set; }

    public string? LibelleArticle { get; set; }

    public int? QuantiteStockee { get; set; }

    public int IdCategories { get; set; }


    public Article(int idArticles, string libelleArticle, int quantiteStockee)
    {
        IdArticles = idArticles;
        LibelleArticle = libelleArticle;
        QuantiteStockee = quantiteStockee;
    }
    public Article()
    {

    }
}
