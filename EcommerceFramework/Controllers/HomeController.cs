using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceFramework.Models;
using EcommerceFramework.ViewModels;
using Microsoft.Ajax.Utilities;

namespace EcommerceFramework.Controllers
{
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Categories()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //var CategoryList = new KeyValuePair<Category, List<Category>>();

            var categories = db.Categories.ToList();

            var test = db.Categories.GroupBy(c=>c.ParentCategoryId).ToList();

            var Children = categories;
            var RootCategories = categories.Select(d => d.ParentCategoryId).Distinct();

          


            return PartialView("_Categories", test);
        }

        
    }

    
}