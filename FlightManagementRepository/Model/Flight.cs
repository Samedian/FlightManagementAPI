using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementRepository.Model
{
    public class Flight
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int FlightId { get; set; }

        [MaxLength(50)]
        [Required]
        public string FlightCompanyName { get; set; }


        [MaxLength(50)]
        [Required]
        public string FlightCode { get; set; }

        [MaxLength(50)]
        [Required]
        public string Source { get; set; }

        [MaxLength(50)]
        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTime LandingTime { get; set; }

        [Required]
        public DateTime TakeOffTime { get; set; }

    }
}
