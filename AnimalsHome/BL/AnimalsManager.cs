using AutoMapper;
using BL.Interface;
using BL.Model;
using DAL.Interface;
using DAL.Model;
using System.Collections.Generic;

namespace BL
{
    public class AnimalsManager :IAnimalsManager
    {
        public readonly IAnimalsRepository _repository;

        public readonly Mapper _mapper;

        public AnimalsManager(IAnimalsRepository repository)
        {
            _repository = repository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Animal, AnimalModel>();
                cfg.CreateMap<Home, HomeModel>();
            });
            _mapper = new Mapper(config);
        }
        public IList<AnimalModel> GetAllAnimals()
        {
            var result = _mapper.Map<IList<AnimalModel>>(_repository.GetAllAnimals());
            return result;
        }

        public IList<HomeModel> GetAllHomes()
        {
            var result = _mapper.Map<IList<HomeModel>>(_repository.GetAllHomes());
            return result;
        }
    }
}