using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementEntity
{
    public class FlightEntity
    {
        public int FlightId { get; set; }

        public string FlightCompanyName { get; set; }

        public string FlightCode { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public DateTime LandingTime { get; set; }

        public DateTime TakeOffTime { get; set; }

    }
}
