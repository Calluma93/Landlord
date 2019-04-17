using Services.Models.Shared;
using Landlord.Models.Shared;

namespace Landlord.Helpers
{
    public static class ImageHelper
    {
        public static ImageViewModel MapImageToViewModel(ImageModel image)
        {
            return new ImageViewModel(image.Title, LandlordUrlHelper.GetImageUrl(image.ImageRelativeUrl));
        }
    }
}