using Landlord.Models.Shared;
using Services.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace Landlord.Helpers
{
    public static class ProductHelper
    {
        public static ProductViewModel MapProductToViewModel(ProductModel product)
        {
            return new ProductViewModel()
            {
                ProductBanner = ImageHelper.MapImageToViewModel(product.ProductBanner),
                HomePageImage = ImageHelper.MapImageToViewModel(product.HomePageImage),
                SupportPageImage = ImageHelper.MapImageToViewModel(product.SupportPageImage),
                MobileImage = ImageHelper.MapImageToViewModel(product.MobileImage),
                ProductName = product.Title,
                SubHeading = product.SubHeading,
                ProductBannerBlurb = product.ProductBannerBlurb,
                LinkUrl = LandlordUrlHelper.GetProductUrl(product.Name),
                ImageGallery = product.ImageGallery.Select(b => ImageHelper.MapImageToViewModel(b)),
                Content = ProductContentHelper.MapContentToViewModel(product.Content),
                DownloadLink = DownloadLinkHelper.MapDownloadLinkToViewModel(product.DownloadLink)
            };
        }

        public static IEnumerable<ProductViewModel> MapProductsToViewModels(IEnumerable<ProductModel> products)
        {
            return products.Select(a => MapProductToViewModel(a));
        }
    }
}