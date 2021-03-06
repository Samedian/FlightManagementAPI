using AutoMapper;
using FlightManagementEntity;
using FlightManagementRepository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementRepository.Convertor
{
    public class PassengerConvertor : Profile
    {
        public PassengerConvertor()
        {
            CreateMap<Passenger, PassengerEntity>().ReverseMap();

        }
    }
}
