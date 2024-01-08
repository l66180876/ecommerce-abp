using System.Collections.Generic;
using Ecommerce.Public.ProductCategories;
using Ecommerce.Public.Products;

namespace Ecommerce.Public.Web.Models
{
    public class HomeCacheItem
    {
        public List<ProductCategoryInListDto> Categories { set; get; }
        public List<ProductInListDto> TopSellerProducts { set; get; }
    }
}
