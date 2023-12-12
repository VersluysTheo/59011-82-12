using AutoMapper;
using GestionDonnee.Models.Data;
using GestionDonnee.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDonnee.Models.Profiles
{
    public class ArticlesProfiles : Profile
    {
        public ArticlesProfiles()
        {
            CreateMap<Article, ArticlesDTO>();
            CreateMap<ArticlesDTO, Article>();
            CreateMap<Article, ArticlesDTOin>();
            CreateMap<ArticlesDTOin, Article>();
        }
    }
}
