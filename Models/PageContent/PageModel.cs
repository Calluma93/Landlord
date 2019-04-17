using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class PageModel
    {
        public PageModel(ImageModel bannerImage, ImageModel mobileBannerImage, string heading, string subheading, MetaDataModel metaData)
        {
            BannerImage = bannerImage;
            MobileBannerImage = mobileBannerImage;
            Heading = heading;
            SubHeading = subheading;
            MetaData = metaData;
        }

        public ImageModel BannerImage { get; private set; }

        public ImageModel MobileBannerImage { get; private set; }

        public string Heading { get; private set; }

        public string SubHeading { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
