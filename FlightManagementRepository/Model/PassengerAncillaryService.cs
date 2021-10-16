using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementRepository.Model
{
    public class PassengerAncillaryService
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SeatId { get; set; }

        [Required]
        public int PassengerId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey("PassengerId")]
        [Required]
        public ICollection<Passenger> passenger { get; set; }

        [ForeignKey("ServiceId")]
        [Required]
        public ICollection<AncillaryServices> ancillaryServices { get; set; }


    }
}
