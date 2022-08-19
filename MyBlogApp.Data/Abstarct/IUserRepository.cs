using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogApp.Entities.Concrete;
using MyBlogApp.Shared.Data.Abstarct;

namespace MyBlogApp.Data.Abstarct
{
    public interface IUserRepository:IEntityRepository<User>
    {

    }
}
