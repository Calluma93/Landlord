using Landlord.Helpers;
using Landlord.Models.WhereToBuy;
using Services.Abstract;
using Services.Models.PageContent;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Landlord.Controllers
{
    public class WhereToBuyController : BaseController
    {
        private readonly IRetailerService retailerService;

        public WhereToBuyController(IRetailerService retailerService, IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {
            this.retailerService = retailerService;
        }
        
        public ActionResult Index()
        {
            IEnumerable<RetailerViewModel> retailers =
                retailerService.GetRetailers().Select(
                    a => new RetailerViewModel()
                    {
                        WebsiteUrl = a.WebsiteUrl,
                        Image = ImageHelper.MapImageToViewModel(a.Image)
                    }
                )
            ;

            PageModel whereToBuyPage = pageContentService.WhereToBuyPage;

            WhereToBuyPageViewModel viewModel = new WhereToBuyPageViewModel()
            {
                BannerImage = ImageHelper.MapImageToViewModel(whereToBuyPage.BannerImage),
                MobileBannerImage = ImageHelper.MapImageToViewModel(whereToBuyPage.MobileBannerImage),
                Heading = whereToBuyPage.Heading,
                SubHeading = whereToBuyPage.SubHeading,
                Retailers = retailers,
                Title = whereToBuyPage.MetaData.Title,
                MetaDescription = whereToBuyPage.MetaData.MetaDescription
            };

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}