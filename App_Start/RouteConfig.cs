using System.Web.Mvc;
using System.Web.Routing;

namespace Landlord
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.LowercaseUrls = true;

            routes.AppendTrailingSlash = true;

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );
            
            routes.MapRoute(
                name: "Support",
                url: "support",
                defaults: new { controller = "Support", action = "Index" }
            );

            routes.MapRoute(
                 name: "WhereToBuy",
                 url: "where-to-buy",
                 defaults: new { controller = "WhereToBuy", action = "Index" }
            );

            routes.MapRoute(
               name: "Product",
               url: "product/{productName}",
               defaults: new { controller = "Product", action = "Index" }
            );
        }
    }
}
