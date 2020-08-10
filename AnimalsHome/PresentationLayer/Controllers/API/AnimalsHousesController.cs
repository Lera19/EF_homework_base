using AutoMapper;
using BL;
using BL.Interface;
using BL.Model;
using PresentationLayer.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers.API
{
    public class AnimalsHousesController : Controller
    {
        public AnimalsHousesController() { }
        private readonly IAnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public AnimalsHousesController(IAnimalsManager animalsManager)
        {


            _animalManager = animalsManager;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();
            });
            _mapper = new Mapper(config);
        }

        public ActionResult Index()
        {
            return View();
        }

        public IEnumerable<AnimalViewModel> GetAllAnimals()
        {
            var animal = _animalManager.GetAllAnimals();
            var result = _mapper.Map<List<AnimalViewModel>>(animal);
            return result;
        }


        public string GetAllAnimalsJson()
        {
            var result = new GetAllAnimalsViewModel();
            var getAnimals = _animalManager.GetAllAnimals();
            result.Animals = _mapper.Map<List<AnimalViewModel>>(getAnimals);

            var json = new JsonConvertor();
            return json.Convert(result.Animals);
        }

        public IEnumerable<HomeViewModel> GetAllHouses()
        {
            var houses = _animalManager.GetAllHomes();
            var result = _mapper.Map<List<HomeViewModel>>(houses);
            return result;
        }


        public string GetAllHousesJson()
        {
            var result = new GetAllHomesViewModel();
            var getHome = _animalManager.GetAllHomes();
            result.Homes = _mapper.Map<List<HomeViewModel>>(getHome);

            var json = new JsonConvertor();
            return json.Convert(result.Homes);
        }
    }
}