/*using RuanMou.Projects.ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace YDT.EBusiness.Products
{
    /// <summary>
    /// 商品数据迁移
    /// </summary>
    public class ProductDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductDataSeederContributor(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productRepository.GetCountAsync() <= 0)
            {
                await _productRepository.InsertAsync(
                    new Product
                    {
                        ProductTitle = "iphone12",
                        ProductPrice = 12,
                        ProductVirtualprice = 12,
                        ProductSold = 1,
                        ProductStatus = "1",
                        ProductStock = 1,
                        ProductDescription = "手机非常好",
                        ProductSort = 1,
                        ProductUrl = "23232313"
                    },
                    autoSave: true
                );

                await _productRepository.InsertAsync(
                     new Product
                     {
                         ProductTitle = "iphone13",
                         ProductPrice = 24,
                         ProductVirtualprice = 24,
                         ProductSold = 1,
                         ProductStatus = "1",
                         ProductStock = 1,
                         ProductDescription = "手机非常好",
                         ProductSort = 1,
                         ProductUrl = "23232313"
                     },
                    autoSave: true
                );
            }
        }
    }
}
*/