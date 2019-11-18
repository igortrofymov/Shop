using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DAL.Models;

namespace Shop.BLL.DTO
{
    class MapperDTO : Profile
    {
        public MapperDTO()
        {
            CreateMap<MakeDTO, Make>();
            CreateMap<Make, MakeDTO>();
        }
    }
}
