namespace Landlord.Models.Shared
{
    public class ImageViewModel
    {
        public ImageViewModel(string title, string imageUrl)
        {
            Title = title;
            ImageUrl = imageUrl;
        }

        public string Title { get; private set; }

        public string ImageUrl { get; private set; }
    }
}