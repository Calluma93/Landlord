using Landlord.Helpers;
using Landlord.Models.Home;
using Services.Abstract;
using Services.Models.PageContent;
using System.Web.Mvc;

namespace Landlord.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {}
        
        public ActionResult Index()
        {
            PageModel homePageContent = pageContentService.HomePage;

            HomePageViewModel viewModel =
                new HomePageViewModel()
                {
                    BannerImage = ImageHelper.MapImageToViewModel(homePageContent.BannerImage),
                    MobileBannerImage = ImageHelper.MapImageToViewModel(homePageContent.MobileBannerImage),
                    Heading = homePageContent.Heading,
                    SubHeading = homePageContent.SubHeading,
                    Products = ProductHelper.MapProductsToViewModels(productsService.GetAllProducts()),
                    Title = homePageContent.MetaData.Title,
                    MetaDescription = homePageContent.MetaData.MetaDescription
                }
            ;

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}