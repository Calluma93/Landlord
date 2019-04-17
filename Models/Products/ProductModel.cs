using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class ProductModel
    {
        public ProductModel(
            ImageModel productBanner, ImageModel homePageImage, ImageModel supportPageImage, ImageModel mobileImage, string name, string title,
            string subHeading, string productBannerBlurb, IEnumerable<ImageModel> imageGallery, IEnumerable<ContentModel> content,
            DownloadLinkModel downloadLink, MetaDataModel metaData
        )
        {
            ProductBanner = productBanner;
            HomePageImage = homePageImage;
            SupportPageImage = supportPageImage;
            MobileImage = mobileImage;
            Name = name;
            Title = title;
            SubHeading = subHeading;
            ProductBannerBlurb = productBannerBlurb;
            ImageGallery = imageGallery;
            Content = content;
            DownloadLink = downloadLink;
            MetaData = metaData;
        }

        public ImageModel ProductBanner { get; private set; }

        public ImageModel HomePageImage { get; private set; }

        public ImageModel SupportPageImage { get; private set; }

        public ImageModel MobileImage { get; private set; }

        public string Name { get; private set; }

        public string Title { get; private set; }

        public string SubHeading { get; private set; }

        public string ProductBannerBlurb { get; private set; }

        public IEnumerable<ImageModel> ImageGallery { get; private set; }

        public IEnumerable<ContentModel> Content { get; private set; }

        public DownloadLinkModel DownloadLink { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
