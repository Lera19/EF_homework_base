using DAL.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using DAL;

namespace BL.Managers
{
    public class EmployeeManager : UserManager<Employee>
    {
        public EmployeeManager(IUserStore<Employee> store) : base(store) { }
        public static EmployeeManager Create(IdentityFactoryOptions<EmployeeManager> options, IOwinContext context)
        {
            AnimalsContext db = context.Get<AnimalsContext>();
            EmployeeManager manager = new EmployeeManager(new UserStore<Employee>(db));

            return manager;
        }
    }
}