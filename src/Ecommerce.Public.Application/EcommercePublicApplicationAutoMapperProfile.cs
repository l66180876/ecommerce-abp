using AutoMapper;
using Ecommerce.Manufacturers;
using Ecommerce.Orders;
using Ecommerce.ProductAttributes;
using Ecommerce.ProductCategories;
using Ecommerce.Products;
using Ecommerce.Public.Manufacturers;
using Ecommerce.Public.Orders;
using Ecommerce.Public.ProductAttributes;
using Ecommerce.Public.ProductCategories;
using Ecommerce.Public.Products;

namespace Ecommerce.Public;

public class EcommercePublicApplicationAutoMapperProfile : Profile
{
    public EcommercePublicApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();

        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();

        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();

        //Order
        CreateMap<Order, OrderDto>();
    }
}
