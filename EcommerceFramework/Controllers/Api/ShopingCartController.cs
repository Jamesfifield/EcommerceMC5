using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EcommerceFramework.Models;
using EcommerceFramework.ViewModels;

namespace EcommerceFramework.Controllers.Api
{
    public class ShopingCartController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public IHttpActionResult Quantity()
        {
            var quantity = db.ShoppingCartProducts.Count();
            return Json(quantity);
        }


        [HttpPost]
        public IHttpActionResult Add([FromBody] int id)
        {
            var item = db.ShoppingCartProducts.FirstOrDefault(s => s.ProductId == id);

            if (item != null)
            {
                item.Quantity += 1;
                
            }
            else
            {
                db.ShoppingCartProducts.Add(new ShoppingCartProduct {ProductId = id, Quantity = 1});
            }
            db.SaveChanges();
            return Ok();
        }
    }
}
