using AP.Product.Localization;
using Volo.Abp.Application.Services;

namespace AP.Product
{
    public abstract class ProductAppService : ApplicationService
    {
        protected ProductAppService()
        {
            LocalizationResource = typeof(ProductResource);
            ObjectMapperContext = typeof(ProductApplicationModule);
        }
    }
}
