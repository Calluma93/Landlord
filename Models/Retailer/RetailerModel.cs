using Services.Models.Shared;

namespace Services.Models.Retailer
{
    public class RetailerModel
    {
        public RetailerModel(string websiteUrl, ImageModel image)
        {
            WebsiteUrl = websiteUrl;
            Image = image;
        }

        public string WebsiteUrl { get; private set; }

        public ImageModel Image { get; private set; }
    }
}
