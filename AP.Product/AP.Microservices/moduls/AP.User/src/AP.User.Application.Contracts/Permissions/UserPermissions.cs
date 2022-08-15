using Volo.Abp.Reflection;

namespace AP.User.Permissions
{
    public class UserPermissions
    {
        public const string GroupName = "User";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UserPermissions));
        }
    }
}