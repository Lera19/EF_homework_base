using BL;
using BL.Managers;
using DAL.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PresentationLayer.Models.Account;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PresentationLayer.Controllers.Account
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var ctx = HttpContext.GetOwinContext();
            var userManager = ctx.GetUserManager<EmployeeManager>();
            var auth = ctx.Authentication;
            var user = await userManager.FindAsync(model.Email, model.Password);

            var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            auth.SignIn(new Microsoft.Owin.Security.AuthenticationProperties
            {
                IsPersistent = false,
            }, identity);

            return View("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            var employee = new Employee
            {
                Email = model.Email,
                Age = model.Age,
                UserName = model.Name,
                Phone = model.Phone
            };

            await userManager.CreateAsync(employee, model.Password);

            return RedirectToAction("LogIn");
        }

        public ActionResult Register()
        {
            return View();
        }

        

        public string LogOut()
        {
            FormsAuthentication.SignOut();
            var json = new JsonConvertor();
            return json.Convert(RedirectToAction("Index", "Home"));

        }
       
    }
}