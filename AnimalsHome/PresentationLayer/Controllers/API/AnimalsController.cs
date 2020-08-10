using AutoMapper;
using BL;
using BL.Interface;
using BL.Model;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PresentationLayer.Controllers.API
{
    public class AnimalsController : ApiController
    {
        public AnimalsController() { }
        private readonly IAnimalsManager _animalManager;
        private readonly Mapper _mapper;
        public AnimalsController(IAnimalsManager animalsManager)
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