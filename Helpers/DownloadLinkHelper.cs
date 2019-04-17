using Landlord.Models.Support;
using Services.Models.Shared;

namespace Landlord.Helpers
{
    public static class DownloadLinkHelper
    {

        public static DownloadLinkViewModel MapDownloadLinkToViewModel(DownloadLinkModel downloadLink)
        {
            return new DownloadLinkViewModel(LandlordUrlHelper.GetDownloadUrl(downloadLink.RelativeLinkUrl), ImageHelper.MapImageToViewModel(downloadLink.Image));
        }
    }
}