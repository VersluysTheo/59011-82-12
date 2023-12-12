using AutoMapper;
using GestionDonnee.Models.Data;
using GestionDonnee.Models.Dtos;
using GestionDonnee.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDonnee.Controllers
{
    public class ArticlesController : ControllerBase
    {
        private readonly ArticlesServices _service;
        private readonly IMapper _mapper;

        public ArticlesController(ArticlesDbContext context)
        {
            _service = new ArticlesServices(context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticlesProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            IEnumerable<Article> listeArticles = _service.GetAllArticles();
            return _mapper.Map<IEnumerable<Article>>(listeArticles);
        }
        public ActionResult<ArticlesDTO> GetArticleById(uint id)
        {
            var item = _service.GetArticleById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<ArticlesDTO>(item));
            }
            return NotFound();
        }
        public ActionResult<ArticlesDTO> CreateArticle(ArticlesDTO personneDTO)
        {
            Article personnePOCO = _mapper.Map<Article>(personneDTO);
            //on ajoute l’objet à la base de données
            _service.AddArticles(personnePOCO);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetArticleById), new { personneId = personnePOCO.IdArticles }, personnePOCO);

        }

        public ActionResult UpdateArticle(uint id, ArticlesDTO personneDTO)
        {
            var personneFromRepo = _service.GetArticleById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(personneDTO, personneFromRepo);
            _service.UpdateArticle(personneFromRepo);

            return NoContent();
        }

        public ActionResult DeleteArticle(uint id)
        {
            var personneModelFromRepo = _service.GetArticleById(id);
            if (personneModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(personneModelFromRepo);

            return NoContent();
        }
    }
}
