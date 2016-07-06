using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcommerceFramework.Models;

namespace EcommerceFramework.ViewModels
{
    public class ShoppingCartProduct
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Quantity { get; set; }
    }
}