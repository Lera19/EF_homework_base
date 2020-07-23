using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class DiscContext : DbContext
    {
        public DiscContext():base("DefaultConnection")
        {}

        public DbSet<DataForDiscrim> Discriminants { get; set; }
    }
}
