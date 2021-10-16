using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementRepository.Model
{
    public class AncillaryServices
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int? ServiceId { get; set; }

        [Column("ServiceName", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required]
        public string ServiceName { get; set; }
    }
}
