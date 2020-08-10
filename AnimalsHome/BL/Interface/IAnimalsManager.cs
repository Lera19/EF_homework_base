using BL.Model;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface IAnimalsManager
    {
        IList<AnimalModel> GetAllAnimals();
        IList<HomeModel> GetAllHomes();
    }
}
