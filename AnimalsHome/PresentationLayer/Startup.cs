using BL.Managers;
using DAL;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace PresentationLayer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) 
        { 
            app.CreatePerOwinContext(() => new AnimalsContext()); 
            app.CreatePerOwinContext<EmployeeManager>(EmployeeManager.Create); 
            app.UseCookieAuthentication(new CookieAuthenticationOptions 
            { 
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie, 
                LoginPath = new PathString("/Account/Index"), 
            }); 
        }
    }
}