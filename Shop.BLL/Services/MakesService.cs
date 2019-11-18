using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.QueryableExtensions;
using DAL.Models;
using DAL.Repositories;
using Shop.BLL.DTO;
using Shop.BLL.Interfaces;

namespace Shop.BLL.Services
{
    public class MakesService : IMakes
    {
        MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Make, MakeDTO>();
            cfg.CreateMap<IEnumerable<Make>, IEnumerable<MakeDTO>>();
        });

        private MakesRepository repository;

        public MakesService(MakesRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<MakeDTO> GetMakes()
        {
            return repository.GetAll().ProjectTo<MakeDTO>(config).ToList();
        }
    }
}