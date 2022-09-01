using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBlogApp.Data.Abstarct;
using MyBlogApp.Data.Concrete;
using MyBlogApp.Data.Concrete.EntityFramework.Contexts;
using MyBlogApp.Services.Abstract;
using MyBlogApp.Services.Concrete;

namespace MyBlogApp.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection,string connectionString)
        {
            serviceCollection.AddDbContext<MyBlogAppContext>(options=>options.UseSqlServer(connectionString));
            serviceCollection.AddScoped<IUnitOfWork,UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}
