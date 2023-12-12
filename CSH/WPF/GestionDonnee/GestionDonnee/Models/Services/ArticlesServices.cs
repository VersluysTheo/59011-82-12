using GestionDonnee.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDonnee.Models.Services
{
    public class ArticlesServices
    {
        private readonly ArticlesDbContext _context;
        public ArticlesServices(ArticlesDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles.ToList();
        }
        public Article? GetArticleById(uint id)
        {
            return _context.Articles.FirstOrDefault(p => p.IdArticles == id);
        }
        public void AddArticles(Article article)
        {
            if (article == null) throw new ArgumentNullException(nameof(article));

            _context.Articles.Add(article);
            _context.SaveChanges();
        }
        public void DeleteArticle(Article article)
        {
            //si l'objet articlenne est null, on renvoi une exception
            if (article == null) throw new ArgumentNullException(nameof(article));

            // on met à jour le context
            _context.Articles.Remove(article);
            _context.SaveChanges();
        }
        public void UpdateArticle(Article article)
        {
            _context.Articles.Update(article);

            _context.SaveChanges();
        }
    }
}
