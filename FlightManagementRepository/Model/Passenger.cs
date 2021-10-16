using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementRepository.Model
{
    public class Passenger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int PassengerId { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Passport { get; set; }

        [Required]
        public DateTime DateofBirth { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        public int FlightId { get; set; }

        public bool IsWheelChair { get; set; }

        public bool IsInfant { get; set; }

        [ForeignKey("FlightId")]
        public Flight flight { get; set; }

    }
}
