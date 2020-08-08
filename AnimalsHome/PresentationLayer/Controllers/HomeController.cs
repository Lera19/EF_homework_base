using AutoMapper;
using BL;
using BL.Model;
using PresentationLayer.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly AnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public HomeController()
        {


            _animalManager = new AnimalsManager();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();
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

        public ActionResult HomesData()
        {
            var result = new GetAllHomesViewModel();
            var getHome = _animalManager.GetAllHomes();
            result.Homes = _mapper.Map<List<HomeViewModel>>(getHome);
            return PartialView(result);
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