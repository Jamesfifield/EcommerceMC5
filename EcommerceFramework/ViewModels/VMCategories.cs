using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcommerceFramework.Models;

namespace EcommerceFramework.ViewModels
{
    public class VMCategories
    {
        public IEnumerable<string> RootCategories { get; set; }
        public List<Category> Children { get; set; }
    }
}