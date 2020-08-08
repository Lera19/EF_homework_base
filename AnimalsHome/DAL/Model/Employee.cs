using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace DAL.Model
{
    public class Employee : IdentityUser
    {
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string LastName { get; set; }
    }
}
