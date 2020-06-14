using System.Data.Entity;

namespace DataAccessLayerEF
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base("DefaultConnection")
        {}

        public DbSet<Students> Students { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<GraduateSupervisor> GraduateSupervisor { get; set; }
    }
}
