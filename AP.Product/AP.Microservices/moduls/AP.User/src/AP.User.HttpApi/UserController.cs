using AP.User.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AP.User
{
    public abstract class UserController : AbpController
    {
        protected UserController()
        {
            LocalizationResource = typeof(UserResource);
        }
    }
}
