using bAnglaShopar.Com.Web.ModelView;
using bAnglaShoper.Com.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bAnglaShopar.Com.Web.Controllers
{
    public class HomeController : Controller
    {
        CategoriesService categoriesService = new CategoriesService();

        public ActionResult Index()
        {
            HomeModelView homeModel = new HomeModelView();
            homeModel.categoris = categoriesService.GetCategories();

            return View(homeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}