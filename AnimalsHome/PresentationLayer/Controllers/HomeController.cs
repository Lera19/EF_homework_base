using AutoMapper;
using BL.Interface;
using BL.Model;
using PresentationLayer.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public HomeController() { }
        public HomeController(IAnimalsManager animalsManager)
        {


            _animalManager = animalsManager;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<AnimalModel, AnimalHomeViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();
                cfg.CreateMap<HomeModel, AnimalHomeViewModel>();
            });
            _mapper = new Mapper(config);
        }
        public ActionResult Index()
        {

            var result = new GetAllAnimalsViewModel();
            var getAll = _animalManager.GetAllAnimals();
            result.Animals = _mapper.Map<List<AnimalViewModel>>(getAll);

            return View(result);
        }

        public ActionResult HomesDataPartialView()
        {
            var result = new AnimalHomeCollectionViewModel();
            var getHome = _animalManager.GetAllHomes();
            result.ListAllModels = _mapper.Map<List<AnimalHomeViewModel>>(getHome);
            return PartialView(result);
        }

        public ActionResult AnimalsDataPartialView()
        {
            var result = new AnimalHomeCollectionViewModel();
            var getAnimal = _animalManager.GetAllAnimals();
            result.ListAllModels = _mapper.Map<List<AnimalHomeViewModel>>(getAnimal);
            return PartialView("HomesDataPartialView",result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}