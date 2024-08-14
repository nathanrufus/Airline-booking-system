// Models/Flight.cs
using System;
using System.Collections.Generic;

namespace AirlineBookingSystem.Models
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}







