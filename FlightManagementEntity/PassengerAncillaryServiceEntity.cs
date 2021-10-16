using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementEntity
{
    public class PassengerAncillaryServiceEntity
    {
        public int SeatId { get; set; }

        public int PassengerId { get; set; }

        public int ServiceId { get; set; }

        public ICollection<PassengerEntity> passenger { get; set; }

        public ICollection<AncillaryServicesEntity> ancillaryServices { get; set; }


    }
}
