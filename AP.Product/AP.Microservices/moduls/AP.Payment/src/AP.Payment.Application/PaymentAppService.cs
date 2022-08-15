using AP.Payment.Localization;
using Volo.Abp.Application.Services;

namespace AP.Payment
{
    public abstract class PaymentAppService : ApplicationService
    {
        protected PaymentAppService()
        {
            LocalizationResource = typeof(PaymentResource);
            ObjectMapperContext = typeof(PaymentApplicationModule);
        }
    }
}
