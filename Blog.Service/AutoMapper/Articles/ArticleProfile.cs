﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Entity.Dtos.Articles;
using Blog.Entity.Entities;

namespace Blog.Service.AutoMapper.Articles
{
	public class ArticleProfile:Profile
	{
		public ArticleProfile()
		{
			CreateMap<ArticleDto, Article>().ReverseMap();
		}
	}
}
