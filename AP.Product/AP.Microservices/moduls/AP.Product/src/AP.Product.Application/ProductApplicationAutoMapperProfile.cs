using AP.Product.Products;
using AutoMapper;
using Volo.Abp.Application.Dtos;

namespace AP.Product
{
    public class ProductApplicationAutoMapperProfile : Profile
    {
        public ProductApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Products.Products, ProductDto>();
            CreateMap<PagedAndSortedResultRequestDto, Products.Products>();
            CreateMap<CreateProductDto, Products.Products>();
            CreateMap<UpdateProductDto, Products.Products>();
            CreateMap<ProductAttrQueryDto, Products.Products>();
            CreateMap<ProductImageDto, ProductImage>();
            CreateMap<ProductImage, ProductImageDto>();
            CreateMap<ProductImageCreateDto, ProductImage>();
        }
    }
}