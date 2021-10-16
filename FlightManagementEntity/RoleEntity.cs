using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlightManagementEntity
{
    public class RoleEntity
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

    }
}
