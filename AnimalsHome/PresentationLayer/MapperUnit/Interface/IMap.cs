using BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.MapperUnit.Interface
{
    public interface IMap
    {
        void MapperConfig();
        T Map<T>(IEnumerable<AnimalModel> getAnimal);
        T Map<T>(IEnumerable<HomeModel> getHome);
    }
}
