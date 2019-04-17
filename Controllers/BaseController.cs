using Landlord.Helpers;
using Landlord.Models.Shared;
using Services.Abstract;
using Services.Models.PageContent;
using Services.Models.Products;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Landlord.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IPageContentService pageContentService;
        protected readonly IProductsService productsService;

        public BaseController(IPageContentService pageContentService, IProductsService productsService)
        {
            this.pageContentService = pageContentService;
            this.productsService = productsService;
        }

        public void SetLayout(LayoutViewModel layoutViewModel)
        {
            LayoutModel layout = pageContentService.Layout;

            IEnumerable<CategoryModel> categories = productsService.GetCategories();

            layoutViewModel.LogoImage = ImageHelper.MapImageToViewModel(layout.LogoImage);
            layoutViewModel.HamburgerImage = ImageHelper.MapImageToViewModel(layout.HamburgerImage);
            layoutViewModel.MainMenu =
                new MenuItemViewModel[]
                {
                    new MenuItemViewModel(
                        "find your pedal",
                        Url.Action("Index", "Home"),
                        categories.Select(a => new MenuItemViewModel(a.Name, "", a.Products.Select(b => new MenuItemViewModel(b.Title, LandlordUrlHelper.GetProductUrl(b.Name)))))
                        ),
                    new MenuItemViewModel("support", Url.Action("Index", "Support")),
                    new MenuItemViewModel("where to buy", Url.Action("Index", "WhereToBuy"))
                }
            ;
        }

        protected ActionResult NotFoundResult()
        {
            LayoutViewModel layoutModel = new LayoutViewModel();
            SetLayout(layoutModel);
            Response.StatusCode = 404;
            return View("NotFound", layoutModel);
        }
    }
}