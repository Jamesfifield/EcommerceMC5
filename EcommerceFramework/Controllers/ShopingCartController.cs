using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceFramework.Models;

namespace EcommerceFramework.Controllers
{
    public class ShopingCartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShopingCart
        public ActionResult Index()
        {

            return View(db.ShoppingCartProducts.ToList());
        }

    }
}