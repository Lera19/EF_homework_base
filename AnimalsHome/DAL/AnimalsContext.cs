using DAL.Model;
using System.Data.Entity;

namespace DAL
{
    public class AnimalsContext : DbContext
    {

        public AnimalsContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new InitializerClass());
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}