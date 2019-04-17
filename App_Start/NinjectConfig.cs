using Ninject;

using Services.Abstract;
using Services.Concrete;

namespace Landlord
{
    public class NinjectConfig
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPageContentService>().To<PageContentService>().InSingletonScope();
            kernel.Bind<IProductsService>().To<ProductsService>().InSingletonScope();
            kernel.Bind<IRetailerService>().To<RetailerService>().InSingletonScope();
        }
    }
}