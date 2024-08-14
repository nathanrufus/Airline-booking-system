// Data/AirlineBookingContext.cs
using Microsoft.EntityFrameworkCore;
using AirlineBookingSystem.Models;

namespace AirlineBookingSystem.Data
{
    public class AirlineBookingContext : DbContext
    {
        public AirlineBookingContext(DbContextOptions<AirlineBookingContext> options)
            : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Luggage> Luggages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<SpecialNeed> SpecialNeeds { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
    }
}
