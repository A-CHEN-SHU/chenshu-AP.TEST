using AP.Payment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AP.Payment
{
    public abstract class PaymentController : AbpController
    {
        protected PaymentController()
        {
            LocalizationResource = typeof(PaymentResource);
        }
    }
}
