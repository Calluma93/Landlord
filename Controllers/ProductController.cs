using Landlord.Helpers;
using Landlord.Models.Product;
using Services.Abstract;
using Services.Exceptions;
using Services.Models.Products;
using System.Web.Mvc;

namespace Landlord.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        { }
        
        public ActionResult Index(string productName)
        {
            ProductModel product;
            try
            {
                product = productsService.GetProduct(productName);
            }
            catch(ClientException)
            {
                return NotFoundResult();
            }

            ProductPageViewModel viewModel =
                new ProductPageViewModel()
                {
                    Product = ProductHelper.MapProductToViewModel(product),
                    Title = product.MetaData.Title,
                    MetaDescription = product.MetaData.MetaDescription
                }
            ;

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}