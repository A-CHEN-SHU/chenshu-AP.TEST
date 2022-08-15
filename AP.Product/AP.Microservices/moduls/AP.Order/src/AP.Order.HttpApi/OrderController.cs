using AP.Order.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AP.Order
{
    public abstract class OrderController : AbpController
    {
        protected OrderController()
        {
            LocalizationResource = typeof(OrderResource);
        }
    }
}
