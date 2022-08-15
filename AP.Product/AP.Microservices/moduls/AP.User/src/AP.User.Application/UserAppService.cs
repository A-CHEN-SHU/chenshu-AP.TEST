using AP.User.Localization;
using Volo.Abp.Application.Services;

namespace AP.User
{
    public abstract class UserAppService : ApplicationService
    {
        protected UserAppService()
        {
            LocalizationResource = typeof(UserResource);
            ObjectMapperContext = typeof(UserApplicationModule);
        }
    }
}
