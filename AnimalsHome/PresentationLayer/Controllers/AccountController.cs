using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PresentationLayer.Models;
using System.Web.Security;
using PresentationLayer.Models.Account;
using DAL;
using DAL.Model;
using BL;
using System.Threading.Tasks;
using BL.Managers;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace PresentationLayer.Controllers
    {
    public class AccountController :Controller
    {///context add
        public AccountController() { }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
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
        public async Task<ActionResult> Register(RegistrationViewModel model)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            var employee = new Employee
            {
                Email = model.Email,
                Name = model.Name,
                Age = model.Age,
               // UserName = model.UserName,
                Phone= model.Phone
            };

            await userManager.CreateAsync(employee, model.Password);

            //var roleManager = HttpContext.GetOwinContext().Get<RoleManager<IdentityRole>>();
            //await roleManager.CreateAsync(new IdentityRole
            //{
            //    Name = "Admin"
            //});
            //var createdUser = await userManager.FindAsync(model.UserName, model.Password);
            //await userManager.AddToRoleAsync(createdUser.Id, "Admin");

            return RedirectToAction("LogIn");
        }

        //public ActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public string Register(RegistrationViewModel model)
        //{
        //    var json = new JsonConvertor();
        //    if (ModelState.IsValid)
        //    {
        //        Employee employee = null;
        //        using (var db = new AnimalsContext())
        //        {
        //            employee = db.Employees.FirstOrDefault(u => u.Email == model.Name);
        //        }
        //        if (employee == null)
        //        {
        //            // создаем нового пользователя 
        //            using (var db = new AnimalsContext())
        //            {
        //                db.Employees.Add(new Employee { Email = model.Email, Password = model.Password, Age = model.Age , Name=model.Name, Phone=model.Phone});
        //                db.SaveChanges();

        //                employee = db.Employees.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
        //            }
        //            // если пользователь удачно добавлен в бд 
        //            if (employee != null)
        //            {
        //                FormsAuthentication.SetAuthCookie(model.Name, true);
        //                return json.Convert(RedirectToAction("Index", "Home"));
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Пользователь с таким логином уже существует");
        //        }
        //    }

        //    return json.Convert(View(model));

        //}

        public string LogOut()
        {
            FormsAuthentication.SignOut();
            var json = new JsonConvertor();
            return json.Convert(RedirectToAction("Index", "Home"));
            
        }
        //public bool LogIn(LoginViewModel model)
        //{
        //    var ctx = HttpContext.Current.GetOwinContext();
        //    var userManager = ctx.GetUserManager<EmployeeManager>();
        //    var authManager = ctx.Authentication;

        //    if(!ModelState.IsValid)
        //    {
        //        return false;
        //    }

        //    var user = userManager.FindAsync(model.Email, model.Password);
        //    if(user==null)
        //    {
        //        return false;
        //    }
        //    var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
        //    authManager.SignIn(new Microsoft.Owin.Security.AuthenticationProperties { IsPersistent = false }, identity);

        //    return true;
        //}

        //[Authorize]
        //public bool LogOut()
        //{
        //    var ctx = HttpContext.Current.GetOwinContext();
        //    var authManager = ctx.Authentication;
        //    authManager.SignOut();

        //    return true;
        //}
    }
    }