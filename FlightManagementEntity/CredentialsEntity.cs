using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementEntity
{
    public class CredentialsEntity
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public int RoleId { get; set; }
        public RoleEntity role { get; set; }
    }
}
