﻿using AutoMapper;
using rovin.Data;
using rovin.Models.Country;

namespace rovin.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountry>().ReverseMap();
            CreateMap<Country, GetCountry>().ReverseMap();
            CreateMap<Country, GetCountryDetails>().ReverseMap();
            CreateMap<Country,UpdateCountry>().ReverseMap();
            //CreateMap<Country, GetHotelscs>().ReverseMap();
            CreateMap<Hotel, GetHotelscs>().ReverseMap();
        }

    }
}
