using Volo.Abp.Reflection;

namespace AP.Product.Permissions
{
    public class ProductPermissions
    {
        public const string GroupName = "Product";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductPermissions));
        }
    }
}