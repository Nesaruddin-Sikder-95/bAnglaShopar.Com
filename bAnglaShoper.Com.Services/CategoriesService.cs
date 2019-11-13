using bAnglaShoper.Com.DataBase;
using bAnglaShoper.ComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bAnglaShoper.Com.Services
{
    public class CategoriesService
    {
        public List<Category> GetCategory()
        {
            using (var context = new ProjectDBContext())
            {
                return context.Categories.ToList();
                
            }
           
        }
        public void SaveCategory(Category category)
        {
            using (var context = new ProjectDBContext())
            {
                //Add category
                context.Categories.Add(category);
                //Save Changes
                context.SaveChanges();
            }
        }
    }
}
