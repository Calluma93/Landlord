namespace Services.Models.Shared
{
    public class ImageModel
    {
        public ImageModel(string title, string imageRelativeUrl)
        {
            Title = title;
            ImageRelativeUrl = imageRelativeUrl;
        }

        public string Title { get; private set; }

        public string ImageRelativeUrl { get; private set; }
    }
}
