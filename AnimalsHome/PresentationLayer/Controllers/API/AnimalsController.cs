using AutoMapper;
using BL;
using BL.Model;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers.API
{
    public class AnimalsController : ApiController
    {
        private readonly AnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public AnimalsController()
        {


            _animalManager = new AnimalsManager();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
            });
            _mapper = new Mapper(config);
        }
        // GET api/<controller>
        //public IEnumerable<AnimalViewModel> Get()
        //{
        //    var animal = _animalManager.GetAllAnimals();
        //    var result = _mapper.Map<List<AnimalViewModel>>(animal);
        //    return result;
        //}

        // GET api/<controller>/5
        public string Get()
        {
            var result = new GetAllAnimalsViewModel();
            var getAnimals = _animalManager.GetAllAnimals();
            result.Animals = _mapper.Map<List<AnimalViewModel>>(getAnimals);

            var json = new JsonConvertor();
            return json.Convert(result.Animals);
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