using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementEntity
{
    public class SeatEntity
    {
        public int SeatId { get; set; }
        public int SeatNumber { get; set; }

        public int FlightId { get; set; }

        public int ServiceId { get; set; }

        public ICollection<FlightEntity> flight { get; set; }

        public ICollection<AncillaryServicesEntity> ancillaryServices { get; set; }

    }
}
