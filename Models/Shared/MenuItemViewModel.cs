using System.Collections.Generic;

namespace Landlord.Models.Shared
{
    public class MenuItemViewModel
    {
        public MenuItemViewModel(string text, string url)
            : this(text, url, null)
        { }

        public MenuItemViewModel(string text, string url, IEnumerable<MenuItemViewModel> subMenu)
        {
            Text = text;
            Url = url;
            SubMenu = subMenu;
        }

        public string Text { get; private set; }

        public string Url { get; private set; }

        public IEnumerable<MenuItemViewModel> SubMenu { get; private set; }
    }
}