﻿using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;

namespace Blog.Service.Services.Concrete
{
   public class ArticleService : IArticleService
   {
       private readonly IUnitOfWork  _unitOfWork;
       private readonly IMapper _mapper;
       public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
       {
	       _unitOfWork = unitOfWork;
	       _mapper = mapper;
       }

       public async Task<List<ArticleDto>> GetAllArticleAsync()
       {
           var articles= await _unitOfWork.GetRepository<Article>().GetAllAsync();
           var map = _mapper.Map<List<ArticleDto>>(articles);
            return map;

        }
    }
}