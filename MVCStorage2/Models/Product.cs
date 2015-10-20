using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStorage2.Models {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Modified { get; set; }

        public virtual string Image { get {
            return String.IsNullOrEmpty(ImageUrl) ? "" : String.Format("<img src='{0}'>", ImageUrl);
        } }

        public Product() {
            Modified = DateTime.Now;
        }
    }
}