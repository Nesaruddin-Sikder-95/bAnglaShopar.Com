using bAnglaShoper.Com.DataBase;
using bAnglaShoper.ComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace bAnglaShoper.Com.Services
{
    public class ProductsService
    {
        //Single Product
        public Product GetProduct(int ID)
        {
            using (var context = new ProjectDBContext())
            {
                return context.Products.Find(ID);

            }

        }
        //All Products
        public List<Product> GetProducts()
        {
            //var context = new ProjectDBContext();
            //return context.Products.ToList();

            using (var context = new ProjectDBContext())
            {
                return context.Products.Include(x=> x.Category).ToList();
                
            }
           
        }
        public void SaveProduct(Product product)
        {
            using (var context = new ProjectDBContext())
            {
                // jehetu akoi category bar bar notun kore create hoy tai ata unchange kore dite hobe
                context.Entry(product.Category).State = System.Data.Entity.EntityState.Unchanged;

                //Add Product
                context.Products.Add(product);
                //Save Changes
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new ProjectDBContext())
            {
                //Update Product
                context.Entry(product).State = System.Data.Entity.EntityState.Modified; 
                //Save Changes
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int ID)
        {
            using (var context = new ProjectDBContext())
            {
                //Update product
                //context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                var product = context.Products.Find(ID);
                context.Products.Remove(product);

                //Save Changes
                context.SaveChanges();
            }
        }
    }
}
