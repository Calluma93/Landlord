using System.Web.Mvc;
using Services.Abstract;
using Services.Models.PageContent;
using Landlord.Helpers;
using Landlord.Models.Support;

namespace Landlord.Controllers
{
    public class SupportController : BaseController
    {

        public SupportController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {}

        public ActionResult Index()
        {
            PageModel supportPageContent = pageContentService.SupportPage;

            SupportPageViewModel viewModel =
                new SupportPageViewModel()
                {
                    BannerImage = ImageHelper.MapImageToViewModel(supportPageContent.BannerImage),
                    MobileBannerImage = ImageHelper.MapImageToViewModel(supportPageContent.MobileBannerImage),
                    Heading = supportPageContent.Heading,
                    SubHeading = supportPageContent.SubHeading,
                    Products = ProductHelper.MapProductsToViewModels(productsService.GetAllProducts()),
                    Title = supportPageContent.MetaData.Title,
                    MetaDescription = supportPageContent.MetaData.MetaDescription
                }
            ;

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}