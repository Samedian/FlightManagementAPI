using AutoMapper;
using FlightManagementEntity;
using FlightManagementRepository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementRepository.Convertor
{
    public class PassengerAncillaryServicesConvertor : Profile
    {
        public PassengerAncillaryServicesConvertor()
        {
            CreateMap<PassengerAncillaryService, PassengerAncillaryServiceEntity>().ReverseMap();

        }
    }
}
