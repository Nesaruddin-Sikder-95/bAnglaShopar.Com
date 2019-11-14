using bAnglaShoper.Com.Services;
using bAnglaShoper.ComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bAnglaShopar.Com.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoriesService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categoryList = categoriesService.GetCategories();
            return View(categoryList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoriesService.SaveCategory(category);
            return RedirectToAction("Index");
        }

        // Edit Category
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoriesService.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoriesService.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        // Delete Category
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoriesService.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {           
            categoriesService.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}