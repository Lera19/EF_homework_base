using AutoMapper;
using BL;
using BL.Interface;
using BL.Model;
using PresentationLayer.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace PresentationLayer.Controllers.API
{
    public class HousesController : ApiController
    {
        public HousesController() { }
        private readonly IAnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public HousesController(IAnimalsManager animalsManager)
        {


            _animalManager = animalsManager;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
            });
            _mapper = new Mapper(config);
        }

        public string Get()
        {
            var result = new GetAllHomesViewModel();
            var getHome = _animalManager.GetAllHomes();
            result.Homes = _mapper.Map<List<HomeViewModel>>(getHome);

            var json = new JsonConvertor();
            return json.Convert(result.Homes);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}