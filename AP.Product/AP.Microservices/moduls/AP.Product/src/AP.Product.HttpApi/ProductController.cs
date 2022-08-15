using AP.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AP.Product
{
    public abstract class ProductController : AbpController
    {
        protected ProductController()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}
