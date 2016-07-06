using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceFramework.Models
{
    public class RootCategory
    {
        [Key]
        public string Name { get; set; }

        public IList<Product> Products { get; set; }
        public IList<Category> Categories { get; set; }

        public RootCategory()
        {
            Products = new List<Product>();
            Categories = new List<Category>();
        }
    }
}