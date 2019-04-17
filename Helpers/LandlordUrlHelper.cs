namespace Landlord.Helpers
{
    public static class LandlordUrlHelper
    {
        public static string GetImageUrl(string imageRelativeUrl)
        {
            return ConfigHelper.RootUrl + "Images/" + imageRelativeUrl;
        }

        public static string GetProductUrl(string name)
        {
            return ConfigHelper.RootUrl + "product/" + name + "/";
        }

        public static string GetDownloadUrl(string relativeUrl)
        {
            return ConfigHelper.RootUrl + "Content/" + relativeUrl;
        }
    }
}