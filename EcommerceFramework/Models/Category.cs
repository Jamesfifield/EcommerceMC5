using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EcommerceFramework.Models
{


    public class Category
    {
        [Key]
        public string Name { get; set; }

        [Required]
        [ForeignKey("ParentCategoryId")]
        public RootCategory ParentCategory { get; set; }
        public string ParentCategoryId { get; set; }

        public IList<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}