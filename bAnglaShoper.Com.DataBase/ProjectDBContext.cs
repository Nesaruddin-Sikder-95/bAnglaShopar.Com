using bAnglaShoper.ComEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bAnglaShoper.Com.DataBase
{
    public class ProjectDBContext : DbContext,IDisposable
    {
        public ProjectDBContext() : base ("ProjectConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
