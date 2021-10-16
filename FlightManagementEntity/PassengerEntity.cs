using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementEntity
{
    public class PassengerEntity
    {
        public int PassengerId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Passport { get; set; }

        public DateTime DateofBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int FlightId { get; set; }

        public bool IsWheelChair { get; set; }

        public bool IsInfant { get; set; }

        public FlightEntity flight { get; set; }

    }
}
