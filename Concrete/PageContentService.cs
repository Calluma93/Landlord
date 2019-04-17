using Services.Models.Shared;
using Services.Abstract;
using Services.Models.PageContent;

namespace Services.Concrete
{
    public class PageContentService : IPageContentService
    {
        private readonly LayoutModel layout =
            new LayoutModel(
                new ImageModel("Landlord Logo", "Shared/Logo-Landlord.png"),
                new ImageModel("Hamburger Menu Icon", "Shared/hamburger-menu.png")
            );

        private readonly PageModel homePage =
            new PageModel(
                new ImageModel("Home Page Banner", "Banners/header-home.jpg"),
                new ImageModel("Home Page Banner", "Mobile/mobile-home.jpg"),
                "Welcome to the home of Landlord FX, a bespoke pedal brand of high-strength, full-flavour effects pedals.",
                "Quench your tonal thirst with an FX order from the Landlord!",
                new MetaDataModel("Landlord FX: Finest compact guitar effects pedals | Landlord FX", "Landlord FX are a range of quality compact effects pedals. Born in the pub and raised on the stage.")
            );

        private readonly PageModel supportPage =
            new PageModel(
                new ImageModel("Support Page Banner", "Banners/header-support.jpg"),
                new ImageModel("Support Page Banner", "Mobile/mobile-support.jpg"),
                "SUPPORT",
                "Enhance your session with a little extra seasoning: download official Landlord FX manuals and software updates here.",
                new MetaDataModel("Landlord Product Manuals | Landlord FX", "Lost your Landlord FX manual? Fear not: we have you covered. Download PDF manuals here for every Landlord FX pedal.")
            );

        private readonly PageModel whereToBuyPage =
            new PageModel(
                new ImageModel("Where To Buy Banner", "Banners/header-buying.jpg"),
                new ImageModel("Where To Buy Banner", "Mobile/mobile-buying.jpg"),
                "WHERE TO BUY",
                "Landlord FX are available to taste and take home from these exclusive dealers",
                new MetaDataModel("Landlord FX Dealers | Landlord FX", "This list contains the full exclusive dealer list for Landlord FX. Click through to explore buying options.")
            );

        public LayoutModel Layout
        {
            get
            {
                return layout;
            }
        }

        public PageModel WhereToBuyPage
        {
            get
            {
                return whereToBuyPage;
            }
        }

        public PageModel HomePage
        {
            get
            {
                return homePage;
            }
        }

        public PageModel SupportPage
        {
            get
            {
                return supportPage;
            }
        }
    }
}
