using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DefaultRoleManager: RoleManager<IdentityRole>
    {
        public DefaultRoleManager(IRoleStore<IdentityRole, string> store) :base(store)
        { }
    }
}
