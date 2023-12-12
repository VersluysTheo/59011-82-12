using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDonnee.Models.Dtos
{
    public class ArticlesDTO
    {
        public string? LibelleArticle { get; set; }

        public int? QuantiteStockee { get; set; }

        public ArticlesDTO()
        {
        }
    }

    public class ArticlesDTOin
    {
        public int IdArticles { get; set; }

        public string? LibelleArticle { get; set; }

        public int? QuantiteStockee { get; set; }
    }
}
