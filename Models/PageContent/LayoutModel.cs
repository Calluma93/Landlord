using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class LayoutModel
    {
        public LayoutModel(ImageModel logoImage, ImageModel hamburgerImage)
        {
            LogoImage = logoImage;
            HamburgerImage = hamburgerImage;
        }

        public ImageModel LogoImage { get; private set; }

        public ImageModel HamburgerImage { get; private set; }
    }
}
