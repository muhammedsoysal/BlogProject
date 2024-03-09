﻿using System.Reflection;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Service.Extensions
{
	public static class ServiceLayerExtensions
	{

		public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
		{
			var assembly=Assembly.GetExecutingAssembly();

			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<IArticleService,ArticleService>();

			services.AddAutoMapper(assembly);

			return services;
		}
	}
}
