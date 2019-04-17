using System.Collections.Generic;

namespace Landlord.Models.Shared
{
    public class LayoutViewModel
    {
        public ImageViewModel LogoImage { get; set; }

        public ImageViewModel HamburgerImage { get; set; }

        public IEnumerable<MenuItemViewModel> MainMenu { get; set; }
    }
}