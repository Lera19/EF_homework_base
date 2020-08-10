using DAL.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DAL
{
    public class AnimalsContext : IdentityDbContext<Employee>
    {

        public AnimalsContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new InitializerClass());
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}