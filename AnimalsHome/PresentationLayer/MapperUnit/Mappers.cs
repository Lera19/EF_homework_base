using AutoMapper;
using BL.Model;
using PresentationLayer.MapperUnit.Interface;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.MapperUnit
{
    public class Mappers :IMap
    {
        public T Map<T>(IEnumerable<AnimalModel> getAnimal)
        {
            throw new NotImplementedException();

        }

        public T Map<T>(IEnumerable<HomeModel> getHome)
        {
            throw new NotImplementedException();

        }

        public void MapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
                 {
                     cfg.CreateMap<AnimalModel, AnimalViewModel>();
                     cfg.CreateMap<AnimalModel, AnimalHomeViewModel>();
                     cfg.CreateMap<HomeModel, HomeViewModel>();
                     cfg.CreateMap<HomeModel, AnimalHomeViewModel>();

                     
            });

        }
    }
}
