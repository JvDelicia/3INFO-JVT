using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.Models {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public ProdCategory Category { get; set; }
        public int CategoryId { get; set; }
    }
}