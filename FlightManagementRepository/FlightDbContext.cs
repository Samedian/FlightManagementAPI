using FlightManagementRepository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementRepository
{
    public class FlightDbContext : DbContext
    {

        public FlightDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<AncillaryServices> ancillaryServices { get; set; }
        public DbSet<Credentials> credentials { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<FlightServices> flightServices { get; set; }
        public DbSet<Passenger> passengers { get; set; }
        public DbSet<PassengerAncillaryService> passengerAncillaryServices { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Seat> seats { get; set; }


    }
}
