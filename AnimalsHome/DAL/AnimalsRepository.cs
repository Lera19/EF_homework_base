using DAL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DAL
{
    public class AnimalsRepository
    {
        public IList<Animal> GetAllAnimals()
        {
            using (var context = new AnimalsContext())
            {
                var result = context.Animals.Include(h => h.Homes).ToList();
                return result;
            }
        }
        public IList<Home> GetAllHomes()
        {
            using (var context = new AnimalsContext())
            {
                var result = context.Homes.Include(a => a.ListAnimal).ToList();
                return result;
            }
        }
    }
}
