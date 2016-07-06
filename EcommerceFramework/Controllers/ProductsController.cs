using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using EcommerceFramework.Models;

namespace EcommerceFramework.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index(string id)
        {
           
                var products = db.Products.Where(p => p.RootCategoryId == id).ToList();
                ViewBag.NestedCategories = db.Categories.Where(c => c.ParentCategoryId == id).ToList(); ;
                ViewBag.RootNode = id;

                return View(products);
           
        }


    }
}