using DataAccessLayerEF;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class Manager
    {
        public IEnumerable<Students> DeleteStudentsById(int id)
        {
            using (var context = new StudentsContext())
            {
                var students = context.Students.Where(o => o.ID == id).FirstOrDefault();
                context.Students.Remove(students);
                context.SaveChanges();
                return context.Students.ToList();
            }
        }

        public IEnumerable<Students> GetInfoAboutStud()
        {
            using (var context = new StudentsContext())
            {
                return context.Students.ToList(); 
            }
        }

        public IEnumerable<Students> Insert()
        {
            var context = new StudentsContext();
            var students = new List<Students>()
            {
                new Students() {
                    ID= 5, 
                    FirstName="Julia", 
                    LastName="Koval", 
                    Email="dhjk@gamil.com", 
                    Phone="762859"
                },
                new Students() {}
            };
            var university = new University() { Name = "Politeh", Id=3};
            var graduateSupervisor = new GraduateSupervisor() { LName="kOVALCHYK", FName="Boris", Id=5};

            context.Students.AddRange(students);
            context.GraduateSupervisor.Add(graduateSupervisor);
            context.University.Add(university);

            context.SaveChanges();

            return context.Students.ToList();

        }
    }
}
