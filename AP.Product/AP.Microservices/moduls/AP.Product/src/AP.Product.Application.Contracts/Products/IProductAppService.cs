using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AP.Product.Products
{
    /// <summary>
    /// 商品服务
    /// </summary>
    public interface IProductAppService : ICrudAppService<
                                            ProductDto, 
                                            Guid, 
                                            PagedAndSortedResultRequestDto, 
                                            CreateProductDto, 
                                            UpdateProductDto>
    {
        /*IEnumerable<ProductDto> GetProducts();
        ProductDto GetProductById(Guid id);
        void Create(CreateProductDto createProductDto);
        void Update(UpdateProductDto updateProductDto);
        void Delete(DeleteProductDto deleteProductDto);
        bool ProductExists(Guid id);*/

        public List<ProductDto> GetProductAndImages();

        public ProductDto GetProductByAttr(ProductAttrQueryDto createProductDto);

        public ProductTotaLDto GetProductTotals();
    }
}
