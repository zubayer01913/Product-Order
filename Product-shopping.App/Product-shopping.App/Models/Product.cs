using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_shopping.App.Models
{
    public class Product
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}