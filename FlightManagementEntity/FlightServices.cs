using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementRepository.Model
{
    public class FlightServices
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int FlightServiceId { get; set; }

        [Required]
        public int FlightId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey("FlightId")]
        public FlightEntity flight { get; set; }

        [ForeignKey("ServiceId")]
        public ICollection<AncillaryServices> ancillaryServices { get; set; }
    }
}
