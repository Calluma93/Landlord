namespace Landlord.Models.Shared
{
    public class PageViewModel : LayoutViewModel
    {
        public ImageViewModel BannerImage { get; set; }

        public ImageViewModel MobileBannerImage { get; set; }

        public string Heading { get; set; }

        public string SubHeading { get; set; }

        public string Title { get; set; }

        public string MetaDescription { get; set; }
    }
}