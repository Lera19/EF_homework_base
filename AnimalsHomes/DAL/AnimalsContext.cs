using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
