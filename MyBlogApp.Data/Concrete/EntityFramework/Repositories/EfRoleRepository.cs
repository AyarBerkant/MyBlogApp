using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlogApp.Data.Abstarct;
using MyBlogApp.Entities.Concrete;
using MyBlogApp.Shared.Data.Concrete.EntityFramework;

namespace MyBlogApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfRoleRepository : EFEntityRepositoryBase<Role>, IRoleRepository
    {
        public EfRoleRepository(DbContext context) : base(context)
        {
        }
    }
}
