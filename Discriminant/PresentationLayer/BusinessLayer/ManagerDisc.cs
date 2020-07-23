using AutoMapper;
using BusinessLayer.ModelsDTO;
using DAL;
using DAL.Models;
using System;

namespace BusinessLayer
{
    public class ManagerDisc
    {
        public readonly DiscRepository _discRepository;
        public readonly Mapper _mapper;
        public ManagerDisc()
        {
            _discRepository = new DiscRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataForDiscrim, DataForDiscrimDTO>();
                cfg.CreateMap<DataForDiscrimDTO, DataForDiscrim>();
            });

            _mapper = new Mapper(config);
        }
        public DataForDiscrimDTO Calculate(DataForDiscrimDTO discDTO)
        {
            discDTO.Discrim = Math.Pow(discDTO.BParam, 2) - 4 * discDTO.AParam * discDTO.CParam;
            var discrim = discDTO.Discrim;
            if (discrim < 0)
            {
                discDTO.RootF = double.NaN;
                discDTO.RootS = double.NaN;
            }
            else if (discrim > 0)
            {
                discDTO.RootF = (-discDTO.BParam + Math.Sqrt(discDTO.Discrim)) / (2 * discDTO.AParam);
                discDTO.RootS = (-discDTO.BParam - Math.Sqrt(discDTO.Discrim)) / (2 * discDTO.AParam);
            }
            else if (discrim == 0)
            {
                discDTO.RootF = discDTO.RootS = (-discDTO.BParam / (2 * discDTO.AParam));
                discDTO.RootS = double.NaN;
            }
            var map = _mapper.Map<DataForDiscrim>(discDTO);
            _discRepository.SaveCalculate(map);
            return discDTO;
        }
    }
}
