﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using moviesWebSite.Dtos;
using moviesWebSite.Models;
namespace moviesWebSite.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());


            //Mapper.CreateMap<Customer, CustomerDto>();
           // Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}