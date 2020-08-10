using Autofac;
using Autofac.Integration.Mvc;
using BL;
using BL.Interface;
using BL.Managers;
using DAL;
using DAL.Interface;
using DAL.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Mvc;

namespace PresentationLayer.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer() 
        { 
            var builder = new ContainerBuilder(); 

            builder.RegisterControllers(typeof(MvcApplication).Assembly); 
            builder.RegisterType<AnimalsContext>().InstancePerRequest(); 
            builder.RegisterType<AnimalsManager>().As<IAnimalsManager>(); 
            builder.RegisterType<AnimalsRepository>().As<IAnimalsRepository>(); 

            builder.RegisterModule<AutoModule>(); 

            var ctx = new AnimalsContext();
            builder.Register<AnimalsContext>(x => ctx); 
            builder.Register<UserStore<Employee>>(x => new UserStore<Employee>(ctx)).AsImplementedInterfaces();
            builder.RegisterType<RoleStore<IdentityRole>>().As<IRoleStore<IdentityRole, string>>(); 
            builder.Register<IdentityFactoryOptions<DefaultRoleManager>>(c => new IdentityFactoryOptions<DefaultRoleManager>()); 
            builder.RegisterType<DefaultRoleManager>(); 
            var container = builder.Build(); 
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); }
    }
}