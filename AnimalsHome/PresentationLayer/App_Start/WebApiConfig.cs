using System.Web.Http;

namespace PresentationLayer.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration cfg)
        {
            cfg.MapHttpAttributeRoutes();
            cfg.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                });
        }
    }
}