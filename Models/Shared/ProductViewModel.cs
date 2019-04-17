using Landlord.Models.Product;
using Landlord.Models.Support;
using System.Collections.Generic;

namespace Landlord.Models.Shared
{
    public class ProductViewModel
    {
        public ImageViewModel ProductBanner { get; set; }

        public ImageViewModel HomePageImage { get; set; }

        public ImageViewModel SupportPageImage { get; set; }

        public ImageViewModel MobileImage { get; set; }

        public string ProductName { get; set; }

        public string SubHeading { get; set; }

        public string ProductBannerBlurb { get; set; }

        public string LinkUrl { get; set; }

        public IEnumerable<ImageViewModel> ImageGallery { get; set; }

        public IEnumerable<ContentViewModel> Content { get; set; }

        public DownloadLinkViewModel DownloadLink { get; set; }
    }
}