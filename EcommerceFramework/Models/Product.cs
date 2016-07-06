using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EcommerceFramework.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public string RootCategoryId { get; set; }
        [Required]
        [ForeignKey("RootCategoryId")]
        public RootCategory RootCategory { get; set; }

        public IList<Category> Categories { get; set; }


        public Product()
        {
            Categories = new List<Category>();
        }

        public virtual string ImageUri { get; set; }
       
    }
}