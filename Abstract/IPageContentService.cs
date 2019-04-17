using Services.Models.PageContent;

namespace Services.Abstract
{
    public interface IPageContentService
    {
        LayoutModel Layout
        {
            get;
        }

        PageModel WhereToBuyPage
        {
            get;
        }

        PageModel HomePage
        {
            get;
        }

        PageModel SupportPage
        {
            get;
        }
    }
}
