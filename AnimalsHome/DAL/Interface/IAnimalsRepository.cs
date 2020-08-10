using DAL.Model;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IAnimalsRepository
    {
        IList<Animal> GetAllAnimals();
        IList<Home> GetAllHomes();

    }
}
