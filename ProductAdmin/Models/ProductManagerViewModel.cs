using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAdmin.Models
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}