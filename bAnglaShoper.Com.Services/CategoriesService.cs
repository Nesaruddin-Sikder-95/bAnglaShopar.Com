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
        //Single Category
        public Category GetCategory(int ID)
        {
            using (var context = new ProjectDBContext())
            {
                return context.Categories.Find(ID);

            }

        }
        //All Categories
        public List<Category> GetCategories()
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

        public void UpdateCategory(Category category)
        {
            using (var context = new ProjectDBContext())
            {
                //Update category
                context.Entry(category).State = System.Data.Entity.EntityState.Modified; 
                //Save Changes
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new ProjectDBContext())
            {
                //Update category
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);

                //Save Changes
                context.SaveChanges();
            }
        }
    }
}
