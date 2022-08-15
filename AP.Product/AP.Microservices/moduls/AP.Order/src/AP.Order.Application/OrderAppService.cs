using AP.Order.Localization;
using Volo.Abp.Application.Services;

namespace AP.Order
{
    public abstract class OrderAppService : ApplicationService
    {
        protected OrderAppService()
        {
            LocalizationResource = typeof(OrderResource);
            ObjectMapperContext = typeof(OrderApplicationModule);
        }
    }
}
