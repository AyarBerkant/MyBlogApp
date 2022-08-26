using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogApp.Entities.Concrete;
using MyBlogApp.Shared.Entities.Abstarct;
using MyBlogApp.Shared.Utilities.Results.ComplexTypes;

namespace MyBlogApp.Entities.Dtos
{
    public class ArticleDto:DtoGetBase
    {
        public Article Article { get; set; }
    }
}
