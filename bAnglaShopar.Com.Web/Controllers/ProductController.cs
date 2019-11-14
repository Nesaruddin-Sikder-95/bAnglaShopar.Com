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
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            // we need only value not all page thats why use Partial keyword
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
    }
}