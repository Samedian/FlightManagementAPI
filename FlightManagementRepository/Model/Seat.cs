using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementRepository.Model
{
    public class Seat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int SeatId { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public int FlightId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey("FlightId")]
        public ICollection<Flight> flight { get; set; }

        [ForeignKey("ServiceId")]
        public ICollection<AncillaryServices> ancillaryServices { get; set; }

    }
}
