namespace Services.Models.Shared
{
    public class DownloadLinkModel
    {
        public DownloadLinkModel(string relativeLinkUrl, ImageModel image)
        {
            RelativeLinkUrl = relativeLinkUrl;
            Image = image;
        }

        public string RelativeLinkUrl { get; private set; }

        public ImageModel Image { get; private set; }
    }
}
