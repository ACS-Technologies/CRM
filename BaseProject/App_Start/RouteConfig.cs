using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Routing;

namespace BaseProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            HttpConfiguration config = new HttpConfiguration();
            var corsAttr = new EnableCorsAttribute("http://localhost:44381", "*", "*");
            config.EnableCors(corsAttr);
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Authentication", action = "SelectCompany", id = UrlParameter.Optional },
                namespaces: new string[] { "BaseProject.Controllers" }
            );
        }
    }
}
