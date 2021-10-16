using AutoMapper;
using FlightManagementEntity;
using FlightManagementRepository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementRepository.Convertor
{
    public class FlightConvertor : Profile
    {
        public FlightConvertor()
        {
            CreateMap<Flight, FlightEntity>().ReverseMap();

        }
    }
}
