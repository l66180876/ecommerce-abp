using System;
using Ecommerce.Public.Products;

namespace Ecommerce.Public.Web.Models
{
    public class CartItem
    {
        public ProductDto  Product { get; set; }
        public int Quantity { get; set; }
    }
}
