using Landlord.Models.Shared;

namespace Landlord.Models.Support
{
    public class DownloadLinkViewModel
    {
        public DownloadLinkViewModel(string downloadLinkUrl, ImageViewModel image)
        {
            DownloadLinkUrl = downloadLinkUrl;
            Image = image;
        }

        public string DownloadLinkUrl { get; private set; }

        public ImageViewModel Image { get; private set; }
    }
}