using bAnglaShopar.Com.Web.ModelView;
using bAnglaShoper.Com.Services;
using bAnglaShoper.ComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bAnglaShopar.Com.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();

        public ActionResult Index()
        {
            return View();
        }
        // Show product in table
        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();
            //get search value
            if(string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(p => p.Name != null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CategoriesService categoriesService = new CategoriesService();
            var categories = categoriesService.GetCategories();
            // we need only value not all page thats why use Partial keyword
            return PartialView(categories);
        }

        [HttpPost]
        public ActionResult Create(CategoryViewModel model)
        {
            CategoriesService categoriesService = new CategoriesService();

            var newProduct = new Product();
            newProduct.Name = model.Name;
            newProduct.Description = model.Description;
            newProduct.Price = model.Price;
            //newProduct.CategoryID = model.CategoryID;
            newProduct.Category = categoriesService.GetCategory(model.CategoryID);

            productsService.SaveProduct(newProduct);
            return RedirectToAction("ProductTable");
        }

        // For edit button
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = productsService.GetProduct(ID);
            // we need only value not all page thats why use Partial keyword
            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productsService.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }

        // For Delete button       

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productsService.DeleteProduct(ID);
            return RedirectToAction("ProductTable");
        }
    }
}